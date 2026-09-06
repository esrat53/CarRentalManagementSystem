namespace CarRentalManagementSystem.Customer
{
    partial class CustomerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel contentPanel;

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblSystemName;

        private System.Windows.Forms.Label lblProfileIcon;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblProfileRole;
        private System.Windows.Forms.Panel profileSeparator;

        private System.Windows.Forms.Label lblChangePasswordIcon;
        private System.Windows.Forms.Label lblChangePassword;

        private System.Windows.Forms.Label lblDeleteAccountIcon;
        private System.Windows.Forms.Label lblDeleteAccount;

        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel cardBrowseCars;
        private System.Windows.Forms.Panel cardBookings;

        private System.Windows.Forms.Label lblBrowseIcon;
        private System.Windows.Forms.Label lblBrowseTitle;
        private System.Windows.Forms.Label lblBrowseDescription;

        private System.Windows.Forms.Label lblBookingIcon;
        private System.Windows.Forms.Label lblBookingTitle;
        private System.Windows.Forms.Label lblBookingDescription;

        private System.Windows.Forms.Button btnBrowseCars;
        private System.Windows.Forms.Button btnMyBookings;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            sidebarPanel = new Panel();
            lblLogo = new Label();
            lblSystemName = new Label();
            lblProfileIcon = new Label();
            lblProfileName = new Label();
            lblProfileRole = new Label();
            profileSeparator = new Panel();
            lblChangePasswordIcon = new Label();
            lblChangePassword = new Label();
            lblDeleteAccountIcon = new Label();
            lblDeleteAccount = new Label();
            btnLogout = new Button();
            headerPanel = new Panel();
            lblPageTitle = new Label();
            lblCustomer = new Label();
            contentPanel = new Panel();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            cardBrowseCars = new Panel();
            lblBrowseIcon = new Label();
            lblBrowseTitle = new Label();
            lblBrowseDescription = new Label();
            btnBrowseCars = new Button();
            cardBookings = new Panel();
            lblBookingIcon = new Label();
            lblBookingTitle = new Label();
            lblBookingDescription = new Label();
            btnMyBookings = new Button();
            sidebarPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            cardBrowseCars.SuspendLayout();
            cardBookings.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(28, 35, 49);
            sidebarPanel.Controls.Add(lblLogo);
            sidebarPanel.Controls.Add(lblSystemName);
            sidebarPanel.Controls.Add(lblProfileIcon);
            sidebarPanel.Controls.Add(lblProfileName);
            sidebarPanel.Controls.Add(lblProfileRole);
            sidebarPanel.Controls.Add(profileSeparator);
            sidebarPanel.Controls.Add(lblChangePasswordIcon);
            sidebarPanel.Controls.Add(lblChangePassword);
            sidebarPanel.Controls.Add(lblDeleteAccountIcon);
            sidebarPanel.Controls.Add(lblDeleteAccount);
            sidebarPanel.Controls.Add(btnLogout);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(335, 867);
            sidebarPanel.TabIndex = 2;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI Emoji", 30F);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(101, 9);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(98, 67);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "🚗";
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSystemName.ForeColor = Color.White;
            lblSystemName.Location = new Point(62, 88);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(178, 37);
            lblSystemName.TabIndex = 1;
            lblSystemName.Text = "CAR RENTAL";
            // 
            // lblProfileIcon
            // 
            lblProfileIcon.BackColor = Color.FromArgb(226, 232, 240);
            lblProfileIcon.Font = new Font("Segoe UI Emoji", 48F);
            lblProfileIcon.ForeColor = Color.FromArgb(71, 85, 105);
            lblProfileIcon.Location = new Point(83, 139);
            lblProfileIcon.Name = "lblProfileIcon";
            lblProfileIcon.Size = new Size(130, 130);
            lblProfileIcon.TabIndex = 2;
            lblProfileIcon.Text = "👤";
            lblProfileIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProfileName
            // 
            lblProfileName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblProfileName.ForeColor = Color.White;
            lblProfileName.Location = new Point(-9, 282);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.Size = new Size(293, 34);
            lblProfileName.TabIndex = 3;
            lblProfileName.Text = "Customer Name";
            lblProfileName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProfileRole
            // 
            lblProfileRole.Font = new Font("Segoe UI", 11F);
            lblProfileRole.ForeColor = Color.FromArgb(226, 232, 240);
            lblProfileRole.Location = new Point(0, 327);
            lblProfileRole.Name = "lblProfileRole";
            lblProfileRole.Size = new Size(293, 29);
            lblProfileRole.TabIndex = 4;
            lblProfileRole.Text = "Customer";
            lblProfileRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // profileSeparator
            // 
            profileSeparator.BackColor = Color.FromArgb(148, 163, 184);
            profileSeparator.Location = new Point(38, 376);
            profileSeparator.Name = "profileSeparator";
            profileSeparator.Size = new Size(287, 1);
            profileSeparator.TabIndex = 5;
            // 
            // lblChangePasswordIcon
            // 
            lblChangePasswordIcon.AutoSize = true;
            lblChangePasswordIcon.Font = new Font("Segoe UI Symbol", 19F);
            lblChangePasswordIcon.ForeColor = Color.White;
            lblChangePasswordIcon.Location = new Point(22, 430);
            lblChangePasswordIcon.Name = "lblChangePasswordIcon";
            lblChangePasswordIcon.Size = new Size(52, 45);
            lblChangePasswordIcon.TabIndex = 6;
            lblChangePasswordIcon.Text = "🔐";
            // 
            // lblChangePassword
            // 
            lblChangePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblChangePassword.ForeColor = Color.White;
            lblChangePassword.Location = new Point(80, 435);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(230, 40);
            lblChangePassword.TabIndex = 7;
            lblChangePassword.Text = "Change Password";
            lblChangePassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDeleteAccountIcon
            // 
            lblDeleteAccountIcon.AutoSize = true;
            lblDeleteAccountIcon.Font = new Font("Segoe UI Symbol", 20F);
            lblDeleteAccountIcon.ForeColor = Color.White;
            lblDeleteAccountIcon.Location = new Point(22, 493);
            lblDeleteAccountIcon.Name = "lblDeleteAccountIcon";
            lblDeleteAccountIcon.Size = new Size(44, 46);
            lblDeleteAccountIcon.TabIndex = 8;
            lblDeleteAccountIcon.Text = "🗑";
            // 
            // lblDeleteAccount
            // 
            lblDeleteAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDeleteAccount.ForeColor = Color.White;
            lblDeleteAccount.Location = new Point(80, 499);
            lblDeleteAccount.Name = "lblDeleteAccount";
            lblDeleteAccount.Size = new Size(230, 40);
            lblDeleteAccount.TabIndex = 9;
            lblDeleteAccount.Text = "Delete Account";
            lblDeleteAccount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(43, 52, 70);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(38, 728);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(18, 0, 0, 0);
            btnLogout.Size = new Size(164, 46);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "⇥   Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(24, 32, 48);
            headerPanel.Controls.Add(lblPageTitle);
            headerPanel.Controls.Add(lblCustomer);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(335, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1036, 103);
            headerPanel.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(265, 9);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(460, 60);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Customer Dashboard";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCustomer.ForeColor = Color.White;
            lblCustomer.Location = new Point(15, 26);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(87, 23);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Customer";
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(245, 247, 250);
            contentPanel.Controls.Add(lblWelcome);
            contentPanel.Controls.Add(lblSubtitle);
            contentPanel.Controls.Add(cardBrowseCars);
            contentPanel.Controls.Add(cardBookings);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(335, 103);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1036, 764);
            contentPanel.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(41, 128, 185);
            lblWelcome.Location = new Point(298, 23);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(132, 35);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome!";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(105, 112, 125);
            lblSubtitle.Location = new Point(148, 94);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(319, 23);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Manage your car rentals from one place.";
            // 
            // cardBrowseCars
            // 
            cardBrowseCars.BackColor = Color.White;
            cardBrowseCars.Controls.Add(lblBrowseIcon);
            cardBrowseCars.Controls.Add(lblBrowseTitle);
            cardBrowseCars.Controls.Add(lblBrowseDescription);
            cardBrowseCars.Controls.Add(btnBrowseCars);
            cardBrowseCars.Location = new Point(117, 151);
            cardBrowseCars.Name = "cardBrowseCars";
            cardBrowseCars.Size = new Size(330, 293);
            cardBrowseCars.TabIndex = 3;
            // 
            // lblBrowseIcon
            // 
            lblBrowseIcon.AutoSize = true;
            lblBrowseIcon.Font = new Font("Segoe UI Emoji", 30F);
            lblBrowseIcon.Location = new Point(29, 27);
            lblBrowseIcon.Name = "lblBrowseIcon";
            lblBrowseIcon.Size = new Size(98, 67);
            lblBrowseIcon.TabIndex = 0;
            lblBrowseIcon.Text = "🚘";
            // 
            // lblBrowseTitle
            // 
            lblBrowseTitle.AutoSize = true;
            lblBrowseTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblBrowseTitle.ForeColor = Color.FromArgb(30, 35, 45);
            lblBrowseTitle.Location = new Point(34, 100);
            lblBrowseTitle.Name = "lblBrowseTitle";
            lblBrowseTitle.Size = new Size(185, 40);
            lblBrowseTitle.TabIndex = 1;
            lblBrowseTitle.Text = "Browse Cars";
            // 
            // lblBrowseDescription
            // 
            lblBrowseDescription.AutoSize = true;
            lblBrowseDescription.Font = new Font("Segoe UI", 10F);
            lblBrowseDescription.ForeColor = Color.FromArgb(105, 112, 125);
            lblBrowseDescription.Location = new Point(34, 149);
            lblBrowseDescription.MaximumSize = new Size(377, 0);
            lblBrowseDescription.Name = "lblBrowseDescription";
            lblBrowseDescription.Size = new Size(241, 23);
            lblBrowseDescription.TabIndex = 2;
            lblBrowseDescription.Text = "Find available cars and choose";
            // 
            // btnBrowseCars
            // 
            btnBrowseCars.BackColor = Color.FromArgb(41, 128, 185);
            btnBrowseCars.FlatAppearance.BorderSize = 0;
            btnBrowseCars.FlatStyle = FlatStyle.Flat;
            btnBrowseCars.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBrowseCars.ForeColor = Color.White;
            btnBrowseCars.Location = new Point(34, 196);
            btnBrowseCars.Name = "btnBrowseCars";
            btnBrowseCars.Size = new Size(183, 56);
            btnBrowseCars.TabIndex = 1;
            btnBrowseCars.Text = "Browse Cars →";
            btnBrowseCars.UseVisualStyleBackColor = false;
            btnBrowseCars.Click += btnBrowseCars_Click;
            // 
            // cardBookings
            // 
            cardBookings.BackColor = Color.White;
            cardBookings.Controls.Add(lblBookingIcon);
            cardBookings.Controls.Add(lblBookingTitle);
            cardBookings.Controls.Add(lblBookingDescription);
            cardBookings.Controls.Add(btnMyBookings);
            cardBookings.Location = new Point(581, 151);
            cardBookings.Name = "cardBookings";
            cardBookings.Size = new Size(317, 293);
            cardBookings.TabIndex = 4;
            // 
            // lblBookingIcon
            // 
            lblBookingIcon.AutoSize = true;
            lblBookingIcon.Font = new Font("Segoe UI Emoji", 30F);
            lblBookingIcon.Location = new Point(29, 27);
            lblBookingIcon.Name = "lblBookingIcon";
            lblBookingIcon.Size = new Size(98, 67);
            lblBookingIcon.TabIndex = 0;
            lblBookingIcon.Text = "📋";
            // 
            // lblBookingTitle
            // 
            lblBookingTitle.AutoSize = true;
            lblBookingTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblBookingTitle.ForeColor = Color.FromArgb(30, 35, 45);
            lblBookingTitle.Location = new Point(34, 100);
            lblBookingTitle.Name = "lblBookingTitle";
            lblBookingTitle.Size = new Size(197, 40);
            lblBookingTitle.TabIndex = 1;
            lblBookingTitle.Text = "My Bookings";
            // 
            // lblBookingDescription
            // 
            lblBookingDescription.AutoSize = true;
            lblBookingDescription.Font = new Font("Segoe UI", 10F);
            lblBookingDescription.ForeColor = Color.FromArgb(105, 112, 125);
            lblBookingDescription.Location = new Point(34, 149);
            lblBookingDescription.MaximumSize = new Size(377, 0);
            lblBookingDescription.Name = "lblBookingDescription";
            lblBookingDescription.Size = new Size(246, 23);
            lblBookingDescription.TabIndex = 2;
            lblBookingDescription.Text = "View and manage your current";
            // 
            // btnMyBookings
            // 
            btnMyBookings.BackColor = Color.FromArgb(41, 128, 185);
            btnMyBookings.FlatAppearance.BorderSize = 0;
            btnMyBookings.FlatStyle = FlatStyle.Flat;
            btnMyBookings.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMyBookings.ForeColor = Color.White;
            btnMyBookings.Location = new Point(34, 196);
            btnMyBookings.Name = "btnMyBookings";
            btnMyBookings.Size = new Size(183, 56);
            btnMyBookings.TabIndex = 2;
            btnMyBookings.Text = "My Bookings →";
            btnMyBookings.UseVisualStyleBackColor = false;
            btnMyBookings.Click += btnMyBookings_Click_1;
            // 
            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1371, 867);
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            Controls.Add(sidebarPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CustomerDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Dashboard - Car Rental Management System";
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            cardBrowseCars.ResumeLayout(false);
            cardBrowseCars.PerformLayout();
            cardBookings.ResumeLayout(false);
            cardBookings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}