using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Identity;
using CarRentalManagementSystem.Database;
using CarRentalManagementSystem.Customer;
using CarRentalManagementSystem.Owner;
using CarRentalManagementSystem.Admin;

namespace CarRentalManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter your username and password.",
                    "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();

                using (SqlConnection connection = databaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT UserID, Username, PasswordHash, FullName, Role
                        FROM Users
                        WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Invalid username or password.",
                                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            string storedHash = reader["PasswordHash"].ToString();

                            PasswordHasher<string> passwordHasher =
                                new PasswordHasher<string>();

                            PasswordVerificationResult result =
                                passwordHasher.VerifyHashedPassword(
                                    null, storedHash, txtPassword.Text);

                            if (result == PasswordVerificationResult.Failed)
                            {
                                MessageBox.Show("Invalid username or password.",
                                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            int userID = Convert.ToInt32(reader["UserID"]);
                            string fullName = reader["FullName"].ToString();
                            string role = reader["Role"].ToString();

                            if (role == "Customer")
                            {
                                CustomerDashboardForm customerDashboard =
                                    new CustomerDashboardForm(userID, fullName);
                                Hide();
                                customerDashboard.ShowDialog();
                                Show();
                            }
                            else if (role == "Owner")
                            {
                                OwnerDashboardForm ownerDashboard =
                                    new OwnerDashboardForm(userID, fullName);
                                Hide();
                                ownerDashboard.ShowDialog();
                                Show();
                            }
                            else if (role == "Admin")
                            {
                                AdminDashboardForm adminDashboard =
                                    new AdminDashboardForm(userID, fullName);
                                Hide();
                                adminDashboard.ShowDialog();
                                Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid user role.",
                                    "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }
    }
}