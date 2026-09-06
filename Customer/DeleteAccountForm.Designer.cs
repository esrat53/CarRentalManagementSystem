namespace CarRentalManagementSystem.Customer
{
    partial class DeleteAccountForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblMessage;
        private Label lblPassword;

        private TextBox txtPassword;

        private Button btnDeleteAccount;
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
            lblMessage = new Label();
            lblPassword = new Label();

            txtPassword = new TextBox();

            btnDeleteAccount = new Button();
            btnCancel = new Button();

            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 35, 45);
            lblTitle.Location = new Point(112, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(207, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🗑 Delete Account";

            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 9F);
            lblMessage.ForeColor = Color.FromArgb(100, 105, 115);
            lblMessage.Location = new Point(40, 75);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(350, 55);
            lblMessage.TabIndex = 1;
            lblMessage.Text =
                "Enter your current password to continue.\r\n" +
                "Your rental history will be preserved.";

            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(50, 55, 65);
            lblPassword.Location = new Point(40, 145);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(126, 21);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Current Password";

            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(40, 172);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(350, 30);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;

            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = Color.FromArgb(220, 53, 69);
            btnDeleteAccount.FlatAppearance.BorderSize = 0;
            btnDeleteAccount.FlatStyle = FlatStyle.Flat;
            btnDeleteAccount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDeleteAccount.ForeColor = Color.White;
            btnDeleteAccount.Location = new Point(40, 235);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(190, 45);
            btnDeleteAccount.TabIndex = 4;
            btnDeleteAccount.Text = "Delete Account";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            btnDeleteAccount.Click += btnDeleteAccount_Click;

            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(226, 232, 240);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(30, 35, 45);
            btnCancel.Location = new Point(255, 235);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(135, 45);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;

            // 
            // DeleteAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(430, 320);
            Controls.Add(btnCancel);
            Controls.Add(btnDeleteAccount);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblMessage);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteAccountForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Delete Account";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}