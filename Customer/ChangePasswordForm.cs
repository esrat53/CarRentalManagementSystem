using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Identity;
using CarRentalManagementSystem.Database;

namespace CarRentalManagementSystem.Customer
{
    public partial class ChangePasswordForm : Form
    {
        private int userID;

        public ChangePasswordForm(int userID)
        {
            InitializeComponent();

            this.userID = userID;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text) ||
                string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show(
                    "Please fill in all password fields.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (txtNewPassword.Text.Length < 6)
            {
                MessageBox.Show(
                    "New password must be at least 6 characters long.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show(
                    "New password and confirmation password do not match.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (txtCurrentPassword.Text == txtNewPassword.Text)
            {
                MessageBox.Show(
                    "New password must be different from your current password.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();

                using (SqlConnection connection = databaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT PasswordHash
                        FROM Users
                        WHERE UserID = @UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);

                        object result = command.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show(
                                "User account could not be found.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            return;
                        }

                        string storedHash = result.ToString();

                        PasswordHasher<string> passwordHasher =
                            new PasswordHasher<string>();

                        PasswordVerificationResult verificationResult =
                            passwordHasher.VerifyHashedPassword(
                                null,
                                storedHash,
                                txtCurrentPassword.Text);

                        if (verificationResult ==
                            PasswordVerificationResult.Failed)
                        {
                            MessageBox.Show(
                                "Current password is incorrect.",
                                "Change Password",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }

                        string newPasswordHash =
                            passwordHasher.HashPassword(
                                null,
                                txtNewPassword.Text);

                        string updateQuery = @"
                            UPDATE Users
                            SET PasswordHash = @PasswordHash
                            WHERE UserID = @UserID";

                        using (SqlCommand updateCommand =
                            new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue(
                                "@PasswordHash",
                                newPasswordHash);

                            updateCommand.Parameters.AddWithValue(
                                "@UserID",
                                userID);

                            int rowsAffected =
                                updateCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show(
                                    "Password changed successfully.",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                txtCurrentPassword.Clear();
                                txtNewPassword.Clear();
                                txtConfirmPassword.Clear();

                                Close();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Password could not be changed.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
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