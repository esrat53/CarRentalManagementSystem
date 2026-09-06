using CarRentalManagementSystem.Database;
using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Identity;
using CarRentalManagementSystem.Models;

namespace CarRentalManagementSystem.Forms
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
                cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Validate password length
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show(
                    "Password must be at least 6 characters long.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Validate password confirmation
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Validate email
            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show(
                    "Please enter a valid email address.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString() ?? "";

            User user = role switch
            {
                "Customer" => new CarRentalManagementSystem.Models.Customer(),
                "Owner" => new CarRentalManagementSystem.Models.Owner(),
                _ => throw new InvalidOperationException("Please select a valid user role.")
            };

            user.FullName = fullName;
            user.Username = username;
            user.Email = email;
            user.Role = role;

            // Create password hasher
            PasswordHasher<string> passwordHasher =
                new PasswordHasher<string>();

            // Generate secure password hash
            string passwordHash =
                passwordHasher.HashPassword(
                    null,
                    password);

            try
            {
                DatabaseHelper databaseHelper =
                    new DatabaseHelper();

                using (SqlConnection connection =
                    databaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO Users
                        (Username, PasswordHash, Email, FullName, Role)
                        VALUES
                        (@Username, @PasswordHash, @Email, @FullName, @Role)";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Username",
                            user.Username);

                        command.Parameters.AddWithValue(
                            "@PasswordHash",
                            passwordHash);

                        command.Parameters.AddWithValue(
                            "@Email",
                            user.Email);

                        command.Parameters.AddWithValue(
                            "@FullName",
                            user.FullName);

                        command.Parameters.AddWithValue(
                            "@Role",
                            user.Role);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Account created successfully!",
                    "Registration Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Clear form
                txtFullName.Clear();
                txtUsername.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                cmbRole.SelectedIndex = -1;

                txtFullName.Focus();
            }
            catch (SqlException ex)
            {
                // Duplicate username
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show(
                        "This username already exists. Please choose another username.",
                        "Registration Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(
                        "Database error: " + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}