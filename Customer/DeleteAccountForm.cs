using System;
using System.Windows.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;

namespace CarRentalManagementSystem.Customer
{
    public partial class DeleteAccountForm : Form
    {
        private readonly int userID;

        public bool AccountDeleted { get; private set; }

        public DeleteAccountForm(int userID)
        {
            InitializeComponent();

            this.userID = userID;
            AccountDeleted = false;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(
                    "Please enter your current password.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            DialogResult confirmation = MessageBox.Show(
                "Are you sure you want to permanently delete your account?\n\n" +
                "This action cannot be undone.",
                "Confirm Account Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            try
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();

                using (SqlConnection connection = databaseHelper.GetConnection())
                {
                    connection.Open();

                    using (SqlTransaction transaction =
                        connection.BeginTransaction())
                    {
                        try
                        {
                            // -------------------------------------------------
                            // 1. Get current password
                            // -------------------------------------------------

                            string passwordQuery = @"
                                SELECT PasswordHash
                                FROM Users
                                WHERE UserID = @UserID
                                  AND Role = 'Customer'";

                            string storedHash = null;

                            using (SqlCommand command =
                                new SqlCommand(
                                    passwordQuery,
                                    connection,
                                    transaction))
                            {
                                command.Parameters.AddWithValue(
                                    "@UserID",
                                    userID);

                                object result = command.ExecuteScalar();

                                if (result == null)
                                {
                                    transaction.Rollback();

                                    MessageBox.Show(
                                        "Your account could not be found.",
                                        "Delete Account",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);

                                    return;
                                }

                                storedHash = result.ToString();
                            }

                            // -------------------------------------------------
                            // 2. Verify current password
                            // -------------------------------------------------

                            PasswordHasher<string> passwordHasher =
                                new PasswordHasher<string>();

                            PasswordVerificationResult verificationResult =
                                passwordHasher.VerifyHashedPassword(
                                    null,
                                    storedHash,
                                    txtPassword.Text);

                            if (verificationResult ==
                                PasswordVerificationResult.Failed)
                            {
                                transaction.Rollback();

                                MessageBox.Show(
                                    "The password you entered is incorrect.",
                                    "Delete Account",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                txtPassword.Clear();
                                txtPassword.Focus();

                                return;
                            }

                            // -------------------------------------------------
                            // 3. Check whether customer has ANY booking
                            // -------------------------------------------------

                            string bookingQuery = @"
                                SELECT COUNT(*)
                                FROM Bookings
                                WHERE CustomerID = @UserID";

                            int bookingCount = 0;

                            using (SqlCommand command =
                                new SqlCommand(
                                    bookingQuery,
                                    connection,
                                    transaction))
                            {
                                command.Parameters.AddWithValue(
                                    "@UserID",
                                    userID);

                                bookingCount =
                                    Convert.ToInt32(
                                        command.ExecuteScalar());
                            }

                            // -------------------------------------------------
                            // 4. Block deletion if ANY booking exists
                            // -------------------------------------------------

                            if (bookingCount > 0)
                            {
                                transaction.Rollback();

                                MessageBox.Show(
                                    "Your account cannot be deleted because " +
                                    "you have booking history in the system.\n\n" +
                                    "This includes current, completed, cancelled, " +
                                    "or paid bookings.\n\n" +
                                    "Your rental history must be preserved.",
                                    "Account Deletion Not Allowed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                return;
                            }

                            // -------------------------------------------------
                            // 5. Permanently delete customer account
                            // -------------------------------------------------

                            string deleteQuery = @"
                                DELETE FROM Users
                                WHERE UserID = @UserID
                                  AND Role = 'Customer'";

                            using (SqlCommand command =
                                new SqlCommand(
                                    deleteQuery,
                                    connection,
                                    transaction))
                            {
                                command.Parameters.AddWithValue(
                                    "@UserID",
                                    userID);

                                int rowsAffected =
                                    command.ExecuteNonQuery();

                                if (rowsAffected != 1)
                                {
                                    transaction.Rollback();

                                    MessageBox.Show(
                                        "The account could not be deleted.",
                                        "Delete Account",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);

                                    return;
                                }
                            }

                            // -------------------------------------------------
                            // 6. Commit permanent deletion
                            // -------------------------------------------------

                            transaction.Commit();

                            AccountDeleted = true;

                            MessageBox.Show(
                                "Your account has been permanently deleted.",
                                "Account Deleted",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            Close();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unexpected error occurred: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}