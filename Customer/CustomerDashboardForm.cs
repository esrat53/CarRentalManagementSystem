using System;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customer
{
    public partial class CustomerDashboardForm : Form
    {
        private int userID;
        private string fullName;

        public CustomerDashboardForm(int userID, string fullName)
        {
            InitializeComponent();

            this.userID = userID;
            this.fullName = fullName;

            lblProfileName.Text = fullName;
            lblWelcome.Text = "Welcome, " + fullName + "!";

            lblChangePassword.Cursor = Cursors.Hand;
            lblChangePassword.Click += lblChangePassword_Click;

            lblDeleteAccount.Cursor = Cursors.Hand;
            lblDeleteAccount.Click += lblDeleteAccount_Click;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowseCars_Click(object sender, EventArgs e)
        {
            BrowseCarsForm browseCarsForm =
                new BrowseCarsForm(userID);

            browseCarsForm.ShowDialog();
        }

        private void btnMyBookings_Click(object sender, EventArgs e)
        {
            MyBookingsForm myBookingsForm =
                new MyBookingsForm(userID);

            myBookingsForm.ShowDialog();
        }

        private void btnMyBookings_Click_1(object sender, EventArgs e)
        {
            MyBookingsForm myBookingsForm =
                new MyBookingsForm(userID);

            myBookingsForm.ShowDialog();
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm =
                new ChangePasswordForm(userID);

            changePasswordForm.ShowDialog(this);
        }

        private void lblDeleteAccount_Click(object sender, EventArgs e)
        {
            DeleteAccountForm deleteAccountForm =
                new DeleteAccountForm(userID);

            deleteAccountForm.ShowDialog(this);

            if (deleteAccountForm.AccountDeleted)
            {
                // Account has been deleted/deactivated.
                // Close the dashboard and return to LoginForm.
                this.Close();
            }
        }
    }
}