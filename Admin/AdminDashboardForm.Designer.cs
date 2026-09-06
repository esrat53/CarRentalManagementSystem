using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Admin
{
    partial class AdminDashboardForm
    {
        private IContainer components = null;

        private Panel sidebar;
        private Panel headerPanel;
        private Panel contentPanel;

        private Label lblLogo;
        private Label lblAdminPanel;
        private Label lblTitle;
        private Label lblWelcome;

        private Button btnUsers;
        private Button btnCars;
        private Button btnBookings;
        private Button btnLogout;

        private Panel cardUsers;
        private Panel cardCars;
        private Panel cardBookings;
        private Panel cardRevenue;

        private Label lblUsersTitle;
        private Label lblCarsTitle;
        private Label lblBookingsTitle;
        private Label lblRevenueTitle;

        private Label lblUsersValue;
        private Label lblCarsValue;
        private Label lblBookingsValue;
        private Label lblRevenueValue;

        private Label lblRecentBookings;

        private DataGridView dgvRecentBookings;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            sidebar = new Panel();
            lblLogo = new Label();
            lblAdminPanel = new Label();
            btnUsers = new Button();
            btnCars = new Button();
            btnBookings = new Button();
            btnLogout = new Button();
            headerPanel = new Panel();
            lblTitle = new Label();
            lblWelcome = new Label();
            contentPanel = new Panel();
            cardUsers = new Panel();
            lblUsersTitle = new Label();
            lblUsersValue = new Label();
            cardCars = new Panel();
            lblCarsTitle = new Label();
            lblCarsValue = new Label();
            cardBookings = new Panel();
            lblBookingsTitle = new Label();
            lblBookingsValue = new Label();
            cardRevenue = new Panel();
            lblRevenueTitle = new Label();
            lblRevenueValue = new Label();
            lblRecentBookings = new Label();
            dgvRecentBookings = new DataGridView();
            sidebar.SuspendLayout();
            headerPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            cardUsers.SuspendLayout();
            cardCars.SuspendLayout();
            cardBookings.SuspendLayout();
            cardRevenue.SuspendLayout();
            ((ISupportInitialize)dgvRecentBookings).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(24, 34, 54);
            sidebar.Controls.Add(lblLogo);
            sidebar.Controls.Add(lblAdminPanel);
            sidebar.Controls.Add(btnUsers);
            sidebar.Controls.Add(btnCars);
            sidebar.Controls.Add(btnBookings);
            sidebar.Controls.Add(btnLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(230, 700);
            sidebar.TabIndex = 2;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(25, 30);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(198, 41);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "CAR RENTAL";
            // 
            // lblAdminPanel
            // 
            lblAdminPanel.AutoSize = true;
            lblAdminPanel.Font = new Font("Segoe UI", 9F);
            lblAdminPanel.ForeColor = Color.FromArgb(170, 180, 195);
            lblAdminPanel.Location = new Point(27, 65);
            lblAdminPanel.Name = "lblAdminPanel";
            lblAdminPanel.Size = new Size(105, 20);
            lblAdminPanel.TabIndex = 1;
            lblAdminPanel.Text = "ADMIN PANEL";
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(43, 52, 70);
            btnUsers.FlatAppearance.BorderColor = Color.White;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 10.5F);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(15, 125);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(12, 0, 0, 0);
            btnUsers.Size = new Size(200, 48);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "Manage Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnCars
            // 
            btnCars.BackColor = Color.FromArgb(43, 52, 70);
            btnCars.FlatAppearance.BorderColor = Color.White;
            btnCars.FlatStyle = FlatStyle.Flat;
            btnCars.Font = new Font("Segoe UI", 10.5F);
            btnCars.ForeColor = Color.White;
            btnCars.Location = new Point(15, 185);
            btnCars.Name = "btnCars";
            btnCars.Padding = new Padding(12, 0, 0, 0);
            btnCars.Size = new Size(200, 48);
            btnCars.TabIndex = 3;
            btnCars.Text = "Manage Cars";
            btnCars.TextAlign = ContentAlignment.MiddleLeft;
            btnCars.UseVisualStyleBackColor = false;
            btnCars.Click += btnCars_Click;
            // 
            // btnBookings
            // 
            btnBookings.BackColor = Color.FromArgb(43, 52, 70);
            btnBookings.FlatAppearance.BorderColor = Color.White;
            btnBookings.FlatStyle = FlatStyle.Flat;
            btnBookings.Font = new Font("Segoe UI", 10.5F);
            btnBookings.ForeColor = Color.White;
            btnBookings.Location = new Point(15, 245);
            btnBookings.Name = "btnBookings";
            btnBookings.Padding = new Padding(12, 0, 0, 0);
            btnBookings.Size = new Size(200, 48);
            btnBookings.TabIndex = 4;
            btnBookings.Text = "All Bookings";
            btnBookings.TextAlign = ContentAlignment.MiddleLeft;
            btnBookings.UseVisualStyleBackColor = false;
            btnBookings.Click += btnBookings_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(43, 52, 70);
            btnLogout.FlatAppearance.BorderColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.5F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(15, 600);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(12, 0, 0, 0);
            btnLogout.Size = new Size(200, 48);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(24, 34, 54);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblWelcome);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(230, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(870, 85);
            headerPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(235, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(309, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Admin Dashboard";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10F);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(235, 54);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(120, 23);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome back";
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(245, 247, 250);
            contentPanel.Controls.Add(cardUsers);
            contentPanel.Controls.Add(cardCars);
            contentPanel.Controls.Add(cardBookings);
            contentPanel.Controls.Add(cardRevenue);
            contentPanel.Controls.Add(lblRecentBookings);
            contentPanel.Controls.Add(dgvRecentBookings);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(230, 85);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(30);
            contentPanel.Size = new Size(870, 615);
            contentPanel.TabIndex = 0;
            // 
            // cardUsers
            // 
            cardUsers.BackColor = Color.White;
            cardUsers.Controls.Add(lblUsersTitle);
            cardUsers.Controls.Add(lblUsersValue);
            cardUsers.Location = new Point(30, 25);
            cardUsers.Name = "cardUsers";
            cardUsers.Size = new Size(190, 110);
            cardUsers.TabIndex = 0;
            // 
            // lblUsersTitle
            // 
            lblUsersTitle.AutoSize = true;
            lblUsersTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsersTitle.ForeColor = Color.Gray;
            lblUsersTitle.Location = new Point(20, 20);
            lblUsersTitle.Name = "lblUsersTitle";
            lblUsersTitle.Size = new Size(103, 20);
            lblUsersTitle.TabIndex = 0;
            lblUsersTitle.Text = "TOTAL USERS";
            // 
            // lblUsersValue
            // 
            lblUsersValue.AutoSize = true;
            lblUsersValue.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblUsersValue.ForeColor = Color.FromArgb(35, 45, 60);
            lblUsersValue.Location = new Point(20, 48);
            lblUsersValue.Name = "lblUsersValue";
            lblUsersValue.Size = new Size(40, 47);
            lblUsersValue.TabIndex = 1;
            lblUsersValue.Text = "0";
            // 
            // cardCars
            // 
            cardCars.BackColor = Color.White;
            cardCars.Controls.Add(lblCarsTitle);
            cardCars.Controls.Add(lblCarsValue);
            cardCars.Location = new Point(235, 25);
            cardCars.Name = "cardCars";
            cardCars.Size = new Size(190, 110);
            cardCars.TabIndex = 1;
            // 
            // lblCarsTitle
            // 
            lblCarsTitle.AutoSize = true;
            lblCarsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCarsTitle.ForeColor = Color.Gray;
            lblCarsTitle.Location = new Point(20, 20);
            lblCarsTitle.Name = "lblCarsTitle";
            lblCarsTitle.Size = new Size(96, 20);
            lblCarsTitle.TabIndex = 0;
            lblCarsTitle.Text = "TOTAL CARS";
            // 
            // lblCarsValue
            // 
            lblCarsValue.AutoSize = true;
            lblCarsValue.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblCarsValue.ForeColor = Color.FromArgb(35, 45, 60);
            lblCarsValue.Location = new Point(20, 48);
            lblCarsValue.Name = "lblCarsValue";
            lblCarsValue.Size = new Size(40, 47);
            lblCarsValue.TabIndex = 1;
            lblCarsValue.Text = "0";
            // 
            // cardBookings
            // 
            cardBookings.BackColor = Color.White;
            cardBookings.Controls.Add(lblBookingsTitle);
            cardBookings.Controls.Add(lblBookingsValue);
            cardBookings.Location = new Point(440, 25);
            cardBookings.Name = "cardBookings";
            cardBookings.Size = new Size(190, 110);
            cardBookings.TabIndex = 2;
            // 
            // lblBookingsTitle
            // 
            lblBookingsTitle.AutoSize = true;
            lblBookingsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBookingsTitle.ForeColor = Color.Gray;
            lblBookingsTitle.Location = new Point(20, 20);
            lblBookingsTitle.Name = "lblBookingsTitle";
            lblBookingsTitle.Size = new Size(136, 20);
            lblBookingsTitle.TabIndex = 0;
            lblBookingsTitle.Text = "TOTAL BOOKINGS";
            // 
            // lblBookingsValue
            // 
            lblBookingsValue.AutoSize = true;
            lblBookingsValue.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblBookingsValue.ForeColor = Color.FromArgb(35, 45, 60);
            lblBookingsValue.Location = new Point(20, 48);
            lblBookingsValue.Name = "lblBookingsValue";
            lblBookingsValue.Size = new Size(40, 47);
            lblBookingsValue.TabIndex = 1;
            lblBookingsValue.Text = "0";
            // 
            // cardRevenue
            // 
            cardRevenue.BackColor = Color.White;
            cardRevenue.Controls.Add(lblRevenueTitle);
            cardRevenue.Controls.Add(lblRevenueValue);
            cardRevenue.Location = new Point(645, 25);
            cardRevenue.Name = "cardRevenue";
            cardRevenue.Size = new Size(190, 110);
            cardRevenue.TabIndex = 3;
            // 
            // lblRevenueTitle
            // 
            lblRevenueTitle.AutoSize = true;
            lblRevenueTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRevenueTitle.ForeColor = Color.Gray;
            lblRevenueTitle.Location = new Point(20, 20);
            lblRevenueTitle.Name = "lblRevenueTitle";
            lblRevenueTitle.Size = new Size(125, 20);
            lblRevenueTitle.TabIndex = 0;
            lblRevenueTitle.Text = "TOTAL REVENUE";
            // 
            // lblRevenueValue
            // 
            lblRevenueValue.AutoSize = true;
            lblRevenueValue.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblRevenueValue.ForeColor = Color.FromArgb(35, 45, 60);
            lblRevenueValue.Location = new Point(20, 48);
            lblRevenueValue.Name = "lblRevenueValue";
            lblRevenueValue.Size = new Size(68, 47);
            lblRevenueValue.TabIndex = 1;
            lblRevenueValue.Text = "৳0";
            // 
            // lblRecentBookings
            // 
            lblRecentBookings.AutoSize = true;
            lblRecentBookings.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblRecentBookings.ForeColor = Color.FromArgb(35, 45, 60);
            lblRecentBookings.Location = new Point(30, 160);
            lblRecentBookings.Name = "lblRecentBookings";
            lblRecentBookings.Size = new Size(210, 35);
            lblRecentBookings.TabIndex = 4;
            lblRecentBookings.Text = "Recent Bookings";
            // 
            // dgvRecentBookings
            // 
            dgvRecentBookings.AllowUserToAddRows = false;
            dgvRecentBookings.AllowUserToDeleteRows = false;
            dgvRecentBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentBookings.BackgroundColor = Color.White;
            dgvRecentBookings.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 52, 70);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecentBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecentBookings.ColumnHeadersHeight = 40;
            dgvRecentBookings.EnableHeadersVisualStyles = false;
            dgvRecentBookings.Location = new Point(30, 200);
            dgvRecentBookings.MultiSelect = false;
            dgvRecentBookings.Name = "dgvRecentBookings";
            dgvRecentBookings.ReadOnly = true;
            dgvRecentBookings.RowHeadersVisible = false;
            dgvRecentBookings.RowHeadersWidth = 51;
            dgvRecentBookings.RowTemplate.Height = 35;
            dgvRecentBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentBookings.Size = new Size(805, 360);
            dgvRecentBookings.TabIndex = 5;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1100, 700);
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            Controls.Add(sidebar);
            Font = new Font("Segoe UI", 10F);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            cardUsers.ResumeLayout(false);
            cardUsers.PerformLayout();
            cardCars.ResumeLayout(false);
            cardCars.PerformLayout();
            cardBookings.ResumeLayout(false);
            cardBookings.PerformLayout();
            cardRevenue.ResumeLayout(false);
            cardRevenue.PerformLayout();
            ((ISupportInitialize)dgvRecentBookings).EndInit();
            ResumeLayout(false);
        }
    }
}