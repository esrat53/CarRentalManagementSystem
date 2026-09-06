using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;
using CarRentalManagementSystem.Models;

namespace CarRentalManagementSystem.Admin
{
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Do not load database data while Visual Studio Designer is open
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                using SqlConnection connection =
                    new DatabaseHelper().GetConnection();

                connection.Open();

                string query = @"
                    SELECT
                        UserID AS [ID],
                        Username,
                        FullName AS [Full Name],
                        Email,
                        Role,
                        CreatedAt AS [Created]
                    FROM Users
                    ORDER BY UserID DESC";

                using SqlDataAdapter adapter =
                    new SqlDataAdapter(query, connection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvUsers.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load users.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // SEARCH / ROLE FILTER
        // ==========================================

        private void FilterUsers(object sender, EventArgs e)
        {
            if (dgvUsers.DataSource is not DataTable table)
                return;

            string search =
                txtSearch.Text.Trim().Replace("'", "''");

            string selectedRole =
                cmbRoleFilter.SelectedItem?.ToString() ?? "All";

            string filter = "";

            if (search.Length > 0)
            {
                filter =
                    $"Username LIKE '%{search}%' " +
                    $"OR [Full Name] LIKE '%{search}%' " +
                    $"OR Email LIKE '%{search}%'";
            }

            if (selectedRole != "All")
            {
                if (filter.Length > 0)
                    filter += " AND ";

                filter += $"Role = '{selectedRole}'";
            }

            table.DefaultView.RowFilter = filter;
        }

        // ==========================================
        // REFRESH
        // ==========================================

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        // ==========================================
        // ADD USER
        // ==========================================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using UserEditorForm editor =
                new UserEditorForm();

            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        // ==========================================
        // EDIT USER
        // ==========================================

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a user first.",
                    "Select User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int userID =
                Convert.ToInt32(
                    dgvUsers.SelectedRows[0]
                        .Cells["ID"]
                        .Value);

            using UserEditorForm editor =
                new UserEditorForm(userID);

            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        // ==========================================
        // DELETE USER
        // ==========================================

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a user first.",
                    "Select User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int userID =
                Convert.ToInt32(
                    dgvUsers.SelectedRows[0]
                        .Cells["ID"]
                        .Value);

            string username =
                Convert.ToString(
                    dgvUsers.SelectedRows[0]
                        .Cells["Username"]
                        .Value);

            DialogResult result = MessageBox.Show(
                $"Delete user '{username}'?\n\n" +
                "This action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using SqlConnection connection =
                    new DatabaseHelper().GetConnection();

                connection.Open();

                // Check whether the user is connected
                // to bookings or vehicles.
                string checkQuery = @"
                    SELECT
                        (SELECT COUNT(*)
                         FROM Bookings
                         WHERE CustomerID = @UserID)
                        +
                        (SELECT COUNT(*)
                         FROM Vehicles
                         WHERE OwnerID = @UserID)";

                using SqlCommand check =
                    new SqlCommand(checkQuery, connection);

                check.Parameters.AddWithValue(
                    "@UserID",
                    userID);

                int relatedRecords =
                    Convert.ToInt32(
                        check.ExecuteScalar());

                if (relatedRecords > 0)
                {
                    MessageBox.Show(
                        "This user cannot be deleted because " +
                        "they are connected to existing bookings " +
                        "or vehicles.",
                        "Cannot Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                using SqlCommand delete =
                    new SqlCommand(
                        "DELETE FROM Users WHERE UserID = @UserID",
                        connection);

                delete.Parameters.AddWithValue(
                    "@UserID",
                    userID);

                delete.ExecuteNonQuery();

                MessageBox.Show(
                    "User deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not delete user.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // USER EDITOR FORM
        // ==========================================

        private class UserEditorForm : Form
        {
            private readonly int userID;
            private readonly bool editMode;

            private TextBox txtUsername;
            private TextBox txtFullName;
            private TextBox txtEmail;
            private TextBox txtPassword;
            private ComboBox cmbRole;

            public UserEditorForm(int userID = 0)
            {
                this.userID = userID;
                editMode = userID > 0;

                BuildEditorUI();

                if (editMode)
                {
                    LoadUser();
                }
            }

            private void BuildEditorUI()
            {
                Text =
                    editMode
                        ? "Edit User"
                        : "Add User";

                StartPosition =
                    FormStartPosition.CenterParent;

                ClientSize =
                    new Size(450, 470);

                BackColor =
                    Color.White;

                Font =
                    new Font("Segoe UI", 10F);

                Label title = new Label
                {
                    Text =
                        editMode
                            ? "Edit User"
                            : "Add New User",

                    Font =
                        new Font(
                            "Segoe UI",
                            18F,
                            FontStyle.Bold),

                    Location =
                        new Point(30, 25),

                    AutoSize = true
                };

                txtUsername =
                    AddTextBox(
                        "Username",
                        30,
                        80);

                txtFullName =
                    AddTextBox(
                        "Full Name",
                        30,
                        145);

                txtEmail =
                    AddTextBox(
                        "Email",
                        30,
                        210);

                txtPassword =
                    AddTextBox(
                        "Password",
                        30,
                        275);

                txtPassword.UseSystemPasswordChar =
                    true;

                Controls.Add(new Label
                {
                    Text = "Role",

                    Location =
                        new Point(30, 340),

                    AutoSize = true
                });

                cmbRole = new ComboBox
                {
                    Location =
                        new Point(30, 365),

                    Size =
                        new Size(390, 32),

                    DropDownStyle =
                        ComboBoxStyle.DropDownList
                };

                cmbRole.Items.AddRange(
                    new object[]
                    {
                        "Customer",
                        "Owner",
                        "Admin"
                    });

                cmbRole.SelectedIndex = 0;

                Button save = new Button
                {
                    Text = "Save",

                    Location =
                        new Point(220, 415),

                    Size =
                        new Size(95, 35),

                    BackColor =
                        Color.FromArgb(41, 128, 185),

                    ForeColor =
                        Color.White,

                    FlatStyle =
                        FlatStyle.Flat
                };

                Button cancel = new Button
                {
                    Text = "Cancel",

                    Location =
                        new Point(325, 415),

                    Size =
                        new Size(95, 35)
                };

                save.Click += SaveUser;

                cancel.Click += (s, e) =>
                {
                    DialogResult =
                        DialogResult.Cancel;

                    Close();
                };

                Controls.Add(title);
                Controls.Add(cmbRole);
                Controls.Add(save);
                Controls.Add(cancel);
            }

            private TextBox AddTextBox(
                string labelText,
                int x,
                int y)
            {
                Controls.Add(new Label
                {
                    Text = labelText,

                    Location =
                        new Point(x, y),

                    AutoSize = true
                });

                TextBox box = new TextBox
                {
                    Location =
                        new Point(x, y + 23),

                    Size =
                        new Size(390, 30)
                };

                Controls.Add(box);

                return box;
            }

            // ==========================================
            // LOAD USER FOR EDIT
            // ==========================================

            private void LoadUser()
            {
                try
                {
                    using SqlConnection connection =
                        new DatabaseHelper().GetConnection();

                    connection.Open();

                    using SqlCommand command =
                        new SqlCommand(
                            @"SELECT
                                Username,
                                FullName,
                                Email,
                                Role
                              FROM Users
                              WHERE UserID = @UserID",
                            connection);

                    command.Parameters.AddWithValue(
                        "@UserID",
                        userID);

                    using SqlDataReader reader =
                        command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtUsername.Text =
                            reader["Username"].ToString();

                        txtFullName.Text =
                            reader["FullName"].ToString();

                        txtEmail.Text =
                            reader["Email"].ToString();

                        cmbRole.Text =
                            reader["Role"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Could not load user.\n\n" +
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            // ==========================================
            // SAVE USER
            // ==========================================

            private void SaveUser(
                object sender,
                EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(
                        txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(
                        txtFullName.Text) ||
                    string.IsNullOrWhiteSpace(
                        txtEmail.Text))
                {
                    MessageBox.Show(
                        "Please fill in all required fields.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!editMode &&
                    string.IsNullOrWhiteSpace(
                        txtPassword.Text))
                {
                    MessageBox.Show(
                        "Password is required for a new user.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string username = txtUsername.Text.Trim();
                string fullName = txtFullName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string role = cmbRole.Text.Trim();

                User user = role switch
                {
                    "Customer" => new CarRentalManagementSystem.Models.Customer(),
                    "Owner" => new CarRentalManagementSystem.Models.Owner(),
                    "Admin" => new CarRentalManagementSystem.Models.Admin(),
                    _ => throw new InvalidOperationException("Please select a valid user role.")
                };

                user.UserID = userID;
                user.Username = username;
                user.FullName = fullName;
                user.Email = email;
                user.Role = role;

                try
                {
                    using SqlConnection connection =
                        new DatabaseHelper().GetConnection();

                    connection.Open();

                    if (editMode)
                    {
                        string query;

                        if (string.IsNullOrWhiteSpace(
                                txtPassword.Text))
                        {
                            query = @"
                                UPDATE Users
                                SET
                                    Username = @Username,
                                    FullName = @FullName,
                                    Email = @Email,
                                    Role = @Role
                                WHERE UserID = @UserID";
                        }
                        else
                        {
                            query = @"
                                UPDATE Users
                                SET
                                    Username = @Username,
                                    FullName = @FullName,
                                    Email = @Email,
                                    PasswordHash = @PasswordHash,
                                    Role = @Role
                                WHERE UserID = @UserID";
                        }

                        using SqlCommand command =
                            new SqlCommand(
                                query,
                                connection);

                        AddCommonParameters(command, user);

                        if (!string.IsNullOrWhiteSpace(
                                txtPassword.Text))
                        {
                            string hash =
                                new PasswordHasher<string>()
                                    .HashPassword(
                                        null,
                                        txtPassword.Text);

                            command.Parameters.AddWithValue(
                                "@PasswordHash",
                                hash);
                        }

                        command.Parameters.AddWithValue(
                            "@UserID",
                            userID);

                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        string hash =
                            new PasswordHasher<string>()
                                .HashPassword(
                                    null,
                                    txtPassword.Text);

                        string query = @"
                            INSERT INTO Users
                            (
                                Username,
                                PasswordHash,
                                Email,
                                FullName,
                                Role,
                                CreatedAt
                            )
                            VALUES
                            (
                                @Username,
                                @PasswordHash,
                                @Email,
                                @FullName,
                                @Role,
                                GETDATE()
                            )";

                        using SqlCommand command =
                            new SqlCommand(
                                query,
                                connection);

                        AddCommonParameters(command, user);

                        command.Parameters.AddWithValue(
                            "@PasswordHash",
                            hash);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "User saved successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult =
                        DialogResult.OK;

                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Could not save user.\n\n" +
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            private void AddCommonParameters(
                SqlCommand command,
                User user)
            {
                command.Parameters.AddWithValue(
                    "@Username",
                    user.Username);

                command.Parameters.AddWithValue(
                    "@FullName",
                    user.FullName);

                command.Parameters.AddWithValue(
                    "@Email",
                    user.Email);

                command.Parameters.AddWithValue(
                    "@Role",
                    user.Role);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}