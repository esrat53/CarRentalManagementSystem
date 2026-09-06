namespace CarRentalManagementSystem.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Panel pnlLogin;

        private System.Windows.Forms.Label lblBrandIcon;
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private System.Windows.Forms.Label lblBrandDescription;
        private System.Windows.Forms.Label lblBrandFooter;

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblFooter;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            pnlBrand = new Panel();
            lblBrandFooter = new Label();
            lblBrandDescription = new Label();
            lblBrandSubtitle = new Label();
            lblBrandTitle = new Label();
            lblBrandIcon = new Label();
            pnlLogin = new Panel();
            lblFooter = new Label();
            btnSignUp = new Button();
            lblNoAccount = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblSubtitle = new Label();
            lblWelcome = new Label();
            pnlBrand.SuspendLayout();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBrand
            // 
            pnlBrand.BackColor = Color.FromArgb(18, 32, 47);
            pnlBrand.Controls.Add(lblBrandFooter);
            pnlBrand.Controls.Add(lblBrandDescription);
            pnlBrand.Controls.Add(lblBrandSubtitle);
            pnlBrand.Controls.Add(lblBrandTitle);
            pnlBrand.Controls.Add(lblBrandIcon);
            pnlBrand.Dock = DockStyle.Left;
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(430, 680);
            pnlBrand.TabIndex = 0;
            // 
            // lblBrandFooter
            // 
            lblBrandFooter.Font = new Font("Segoe UI", 8.5F);
            lblBrandFooter.ForeColor = Color.FromArgb(145, 160, 175);
            lblBrandFooter.Location = new Point(58, 615);
            lblBrandFooter.Name = "lblBrandFooter";
            lblBrandFooter.Size = new Size(315, 25);
            lblBrandFooter.TabIndex = 4;
            lblBrandFooter.Text = "CAR RENTAL MANAGEMENT SYSTEM © 2026";
            // 
            // lblBrandDescription
            // 
            lblBrandDescription.Font = new Font("Segoe UI", 10.5F);
            lblBrandDescription.ForeColor = Color.FromArgb(205, 215, 225);
            lblBrandDescription.Location = new Point(58, 370);
            lblBrandDescription.Name = "lblBrandDescription";
            lblBrandDescription.Size = new Size(315, 105);
            lblBrandDescription.TabIndex = 3;
            lblBrandDescription.Text = "Find the perfect car for your journey.\r\n\r\nSimple booking. Reliable vehicles.\r\nA smarter way to rent.";
            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBrandSubtitle.ForeColor = Color.FromArgb(70, 170, 255);
            lblBrandSubtitle.Location = new Point(58, 320);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new Size(300, 30);
            lblBrandSubtitle.TabIndex = 2;
            lblBrandSubtitle.Text = "YOUR JOURNEY STARTS HERE";
            // 
            // lblBrandTitle
            // 
            lblBrandTitle.Font = new Font("Segoe UI", 27F, FontStyle.Bold);
            lblBrandTitle.ForeColor = Color.White;
            lblBrandTitle.Location = new Point(55, 205);
            lblBrandTitle.Name = "lblBrandTitle";
            lblBrandTitle.Size = new Size(320, 105);
            lblBrandTitle.TabIndex = 1;
            lblBrandTitle.Text = "CAR RENTAL\r\nMANAGEMENT";
            lblBrandTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBrandIcon
            // 
            lblBrandIcon.Font = new Font("Segoe UI Emoji", 46F);
            lblBrandIcon.ForeColor = Color.White;
            lblBrandIcon.Location = new Point(55, 105);
            lblBrandIcon.Name = "lblBrandIcon";
            lblBrandIcon.Size = new Size(100, 90);
            lblBrandIcon.TabIndex = 0;
            lblBrandIcon.Text = "🚗";
            lblBrandIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(lblFooter);
            pnlLogin.Controls.Add(btnSignUp);
            pnlLogin.Controls.Add(lblNoAccount);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(lblUsername);
            pnlLogin.Controls.Add(lblSubtitle);
            pnlLogin.Controls.Add(lblWelcome);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(430, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(570, 680);
            pnlLogin.TabIndex = 1;
            // 
            // lblFooter
            // 
            lblFooter.Font = new Font("Segoe UI", 8.5F);
            lblFooter.ForeColor = Color.FromArgb(150, 155, 160);
            lblFooter.Location = new Point(78, 585);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(410, 25);
            lblFooter.TabIndex = 9;
            lblFooter.Text = "Secure access • Car Rental Management System";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.White;
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.FlatAppearance.BorderColor = Color.FromArgb(35, 125, 205);
            btnSignUp.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 245, 255);
            btnSignUp.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 248, 255);
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSignUp.ForeColor = Color.FromArgb(35, 125, 205);
            btnSignUp.Location = new Point(300, 481);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(105, 38);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.Font = new Font("Segoe UI", 9.5F);
            lblNoAccount.ForeColor = Color.FromArgb(110, 120, 130);
            lblNoAccount.Location = new Point(125, 490);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(171, 21);
            lblNoAccount.TabIndex = 7;
            lblNoAccount.Text = "Don't have an account?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(35, 125, 205);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 100, 170);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 140, 225);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(78, 405);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(410, 52);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(248, 250, 252);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.FromArgb(35, 45, 55);
            txtPassword.Location = new Point(78, 338);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(410, 32);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(55, 65, 75);
            lblPassword.Location = new Point(78, 310);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(85, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(248, 250, 252);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.ForeColor = Color.FromArgb(35, 45, 55);
            txtUsername.Location = new Point(78, 253);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(410, 32);
            txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(55, 65, 75);
            lblUsername.Location = new Point(78, 225);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(89, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10.5F);
            lblSubtitle.ForeColor = Color.FromArgb(110, 120, 130);
            lblSubtitle.Location = new Point(78, 147);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(420, 35);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Sign in to continue to your account.";
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 27F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(25, 39, 52);
            lblWelcome.Location = new Point(78, 70);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(420, 55);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Back";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 680);
            Controls.Add(pnlLogin);
            Controls.Add(pnlBrand);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Rental Management System - Login";
            pnlBrand.ResumeLayout(false);
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}