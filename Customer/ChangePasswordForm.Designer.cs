namespace CarRentalManagementSystem.Customer
{
    partial class ChangePasswordForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblCurrentPassword;
        private Label lblNewPassword;
        private Label lblConfirmPassword;

        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;

        private Button btnChangePassword;
        private Button btnCancel;

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
            lblTitle = new Label();

            lblCurrentPassword = new Label();
            lblNewPassword = new Label();
            lblConfirmPassword = new Label();

            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();

            btnChangePassword = new Button();
            btnCancel = new Button();

            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 35, 45);
            lblTitle.Location = new Point(105, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🔐 Change Password";

            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCurrentPassword.ForeColor = Color.FromArgb(50, 55, 65);
            lblCurrentPassword.Location = new Point(45, 88);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(137, 21);
            lblCurrentPassword.TabIndex = 1;
            lblCurrentPassword.Text = "Current Password";

            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Segoe UI", 10F);
            txtCurrentPassword.Location = new Point(45, 113);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(340, 30);
            txtCurrentPassword.TabIndex = 2;
            txtCurrentPassword.UseSystemPasswordChar = true;

            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNewPassword.ForeColor = Color.FromArgb(50, 55, 65);
            lblNewPassword.Location = new Point(45, 157);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(112, 21);
            lblNewPassword.TabIndex = 3;
            lblNewPassword.Text = "New Password";

            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 10F);
            txtNewPassword.Location = new Point(45, 182);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(340, 30);
            txtNewPassword.TabIndex = 4;
            txtNewPassword.UseSystemPasswordChar = true;

            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(50, 55, 65);
            lblConfirmPassword.Location = new Point(45, 226);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(174, 21);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Confirm New Password";

            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.Location = new Point(45, 251);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(340, 30);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.UseSystemPasswordChar = true;

            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(41, 128, 185);
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(45, 310);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(190, 45);
            btnChangePassword.TabIndex = 7;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;

            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(226, 232, 240);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(30, 35, 45);
            btnCancel.Location = new Point(250, 310);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(135, 45);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;

            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(430, 390);
            Controls.Add(btnCancel);
            Controls.Add(btnChangePassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(lblCurrentPassword);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Password";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}