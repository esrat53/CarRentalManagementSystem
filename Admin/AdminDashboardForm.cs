using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;

namespace CarRentalManagementSystem.Admin
{
    public partial class AdminDashboardForm : Form
    {
        private readonly int userID;
        private readonly string fullName;

        public AdminDashboardForm(int userID, string fullName)
        {
            this.userID = userID;
            this.fullName = fullName;

            InitializeComponent();

            lblWelcome.Text = $"Welcome back, {fullName}";

            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using SqlConnection connection = db.GetConnection();
                connection.Open();

                // ==============================
                // DASHBOARD STATISTICS
                // ==============================

                string statsQuery = @"
                    SELECT
                        (SELECT COUNT(*) FROM Users) AS TotalUsers,

                        (SELECT COUNT(*) FROM Vehicles) AS TotalCars,

                        (SELECT COUNT(*) FROM Bookings) AS TotalBookings,

                        ISNULL(
                            (
                                SELECT SUM(p.Amount)
                                FROM Payments p
                                INNER JOIN Bookings b
                                    ON p.BookingID = b.BookingID
                                WHERE p.PaymentStatus = 'Paid'
                                  AND b.BookingStatus = 'Confirmed'
                            ),
                            0
                        ) AS TotalRevenue";

                using (SqlCommand command = new SqlCommand(statsQuery, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblUsersValue.Text =
                            reader["TotalUsers"].ToString();

                        lblCarsValue.Text =
                            reader["TotalCars"].ToString();

                        lblBookingsValue.Text =
                            reader["TotalBookings"].ToString();

                        decimal revenue =
                            Convert.ToDecimal(reader["TotalRevenue"]);

                        lblRevenueValue.Text =
                            "৳" + revenue.ToString("N0");
                    }
                }

                // ==============================
                // RECENT BOOKINGS
                // ==============================

                string bookingQuery = @"
                    SELECT TOP 10
                        b.BookingID AS [Booking ID],

                        u.FullName AS [Customer],

                        v.Brand + ' ' + v.Model AS [Car],

                        b.StartDate AS [Start Date],

                        b.EndDate AS [End Date],

                        b.TotalAmount AS [Amount],

                        b.BookingStatus AS [Status]

                    FROM Bookings b

                    INNER JOIN Users u
                        ON b.CustomerID = u.UserID

                    INNER JOIN Vehicles v
                        ON b.VehicleID = v.VehicleID

                    ORDER BY b.CreatedAt DESC";

                using SqlDataAdapter adapter =
                    new SqlDataAdapter(bookingQuery, connection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvRecentBookings.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load dashboard data.\n\n" +
                    ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // MANAGE USERS BUTTON
        // ==========================================

        private void btnUsers_Click(object sender, EventArgs e)
        {
            using ManageUsersForm form = new ManageUsersForm();

            form.ShowDialog();

            LoadDashboardData();
        }

        // ==========================================
        // MANAGE CARS BUTTON
        // ==========================================

        private void btnCars_Click(object sender, EventArgs e)
        {
            using ManageAllCarsForm form =
                new ManageAllCarsForm();

            form.ShowDialog();

            LoadDashboardData();
        }

        // ==========================================
        // ALL BOOKINGS BUTTON
        // ==========================================

        private void btnBookings_Click(object sender, EventArgs e)
        {
            using ManageAllBookingsForm form =
                new ManageAllBookingsForm();

            form.ShowDialog();

            LoadDashboardData();
        }

        // ==========================================
        // LOGOUT BUTTON
        // ==========================================

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}