namespace CarRentalManagementSystem.Forms
{
    partial class SignUpForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlBrand;
        private Panel pnlRegister;

        private Label lblBrandIcon;
        private Label lblBrandTitle;
        private Label lblBrandSubtitle;
        private Label lblBrandDescription;
        private Label lblBrandFooter;

        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblFullName;
        private Label lblUsername;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblRole;

        private TextBox txtFullName;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;

        private ComboBox cmbRole;

        private Button btnSignUp;
        private Button btnBack;

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
            pnlBrand = new Panel();
            lblBrandIcon = new Label();
            lblBrandTitle = new Label();
            lblBrandSubtitle = new Label();
            lblBrandDescription = new Label();
            lblBrandFooter = new Label();

            pnlRegister = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();

            lblFullName = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            lblRole = new Label();

            txtFullName = new TextBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();

            cmbRole = new ComboBox();

            btnSignUp = new Button();
            btnBack = new Button();

            pnlBrand.SuspendLayout();
            pnlRegister.SuspendLayout();
            SuspendLayout();

            // 
            // pnlBrand
            // 
            pnlBrand.BackColor = Color.FromArgb(28, 35, 49);
            pnlBrand.Controls.Add(lblBrandIcon);
            pnlBrand.Controls.Add(lblBrandTitle);
            pnlBrand.Controls.Add(lblBrandSubtitle);
            pnlBrand.Controls.Add(lblBrandDescription);
            pnlBrand.Controls.Add(lblBrandFooter);
            pnlBrand.Dock = DockStyle.Left;
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(390, 680);
            pnlBrand.TabIndex = 0;

            // 
            // lblBrandIcon
            // 
            lblBrandIcon.Font = new Font("Segoe UI Emoji", 42F);
            lblBrandIcon.ForeColor = Color.White;
            lblBrandIcon.Location = new Point(125, 65);
            lblBrandIcon.Name = "lblBrandIcon";
            lblBrandIcon.Size = new Size(140, 80);
            lblBrandIcon.TabIndex = 0;
            lblBrandIcon.Text = "🚗";
            lblBrandIcon.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // lblBrandTitle
            // 
            lblBrandTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblBrandTitle.ForeColor = Color.White;
            lblBrandTitle.Location = new Point(45, 145);
            lblBrandTitle.Name = "lblBrandTitle";
            lblBrandTitle.Size = new Size(300, 55);
            lblBrandTitle.TabIndex = 1;
            lblBrandTitle.Text = "CAR RENTAL";
            lblBrandTitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBrandSubtitle.ForeColor = Color.FromArgb(96, 165, 250);
            lblBrandSubtitle.Location = new Point(45, 225);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new Size(300, 35);
            lblBrandSubtitle.TabIndex = 2;
            lblBrandSubtitle.Text = "Rent • Drive • Enjoy";
            lblBrandSubtitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // lblBrandDescription
            // 
            lblBrandDescription.Font = new Font("Segoe UI", 10.5F);
            lblBrandDescription.ForeColor = Color.FromArgb(203, 213, 225);
            lblBrandDescription.Location = new Point(48, 290);
            lblBrandDescription.Name = "lblBrandDescription";
            lblBrandDescription.Size = new Size(294, 120);
            lblBrandDescription.TabIndex = 3;
            lblBrandDescription.Text =
                "Create your account and discover\r\n" +
                "a simple way to manage your car\r\n" +
                "rentals, bookings and payments.";

            // 
            // lblBrandFooter
            // 
            lblBrandFooter.Font = new Font("Segoe UI", 9F);
            lblBrandFooter.ForeColor = Color.FromArgb(148, 163, 184);
            lblBrandFooter.Location = new Point(45, 590);
            lblBrandFooter.Name = "lblBrandFooter";
            lblBrandFooter.Size = new Size(300, 45);
            lblBrandFooter.TabIndex = 4;
            lblBrandFooter.Text = "Your journey starts here.";
            lblBrandFooter.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // pnlRegister
            // 
            pnlRegister.BackColor = Color.White;
            pnlRegister.Controls.Add(lblTitle);
            pnlRegister.Controls.Add(lblSubtitle);

            pnlRegister.Controls.Add(lblFullName);
            pnlRegister.Controls.Add(txtFullName);

            pnlRegister.Controls.Add(lblUsername);
            pnlRegister.Controls.Add(txtUsername);

            pnlRegister.Controls.Add(lblEmail);
            pnlRegister.Controls.Add(txtEmail);

            pnlRegister.Controls.Add(lblPassword);
            pnlRegister.Controls.Add(txtPassword);

            pnlRegister.Controls.Add(lblConfirmPassword);
            pnlRegister.Controls.Add(txtConfirmPassword);

            pnlRegister.Controls.Add(lblRole);
            pnlRegister.Controls.Add(cmbRole);

            pnlRegister.Controls.Add(btnSignUp);
            pnlRegister.Controls.Add(btnBack);

            pnlRegister.Dock = DockStyle.Fill;
            pnlRegister.Location = new Point(390, 0);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(610, 680);
            pnlRegister.TabIndex = 1;

            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(75, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(460, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Account";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(75, 88);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(460, 30);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Register for the Car Rental Management System";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(30, 41, 59);
            lblFullName.Location = new Point(95, 132);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(84, 21);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";

            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 10.5F);
            txtFullName.Location = new Point(95, 157);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(420, 31);
            txtFullName.TabIndex = 3;

            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(30, 41, 59);
            lblUsername.Location = new Point(95, 198);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(82, 21);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";

            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10.5F);
            txtUsername.Location = new Point(95, 223);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(420, 31);
            txtUsername.TabIndex = 5;

            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(30, 41, 59);
            lblEmail.Location = new Point(95, 264);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";

            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.5F);
            txtEmail.Location = new Point(95, 289);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(420, 31);
            txtEmail.TabIndex = 7;

            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(30, 41, 59);
            lblPassword.Location = new Point(95, 330);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";

            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10.5F);
            txtPassword.Location = new Point(95, 355);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(420, 31);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;

            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(30, 41, 59);
            lblConfirmPassword.Location = new Point(95, 396);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(157, 21);
            lblConfirmPassword.TabIndex = 10;
            lblConfirmPassword.Text = "Confirm Password";

            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 10.5F);
            txtConfirmPassword.Location = new Point(95, 421);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(420, 31);
            txtConfirmPassword.TabIndex = 11;
            txtConfirmPassword.UseSystemPasswordChar = true;

            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRole.ForeColor = Color.FromArgb(30, 41, 59);
            lblRole.Location = new Point(95, 462);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(97, 21);
            lblRole.TabIndex = 12;
            lblRole.Text = "Account Type";

            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 10.5F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[]
            {
                "Customer",
                "Owner"
            });
            cmbRole.Location = new Point(95, 487);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(200, 31);
            cmbRole.TabIndex = 13;

            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(37, 99, 235);
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(315, 482);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(200, 42);
            btnSignUp.TabIndex = 14;
            btnSignUp.Text = "Create Account";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;

            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(241, 245, 249);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(30, 41, 59);
            btnBack.Location = new Point(95, 545);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(420, 42);
            btnBack.TabIndex = 15;
            btnBack.Text = "←  Back to Login";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;

            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 680);
            Controls.Add(pnlRegister);
            Controls.Add(pnlBrand);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Account - Car Rental Management System";

            pnlBrand.ResumeLayout(false);
            pnlRegister.ResumeLayout(false);
            pnlRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}