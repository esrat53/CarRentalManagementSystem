using System;
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;

namespace CarRentalManagementSystem.Owner
{
    public partial class OwnerDashboardForm : Form
    {
        private readonly int userID;
        private readonly string fullName;

        public OwnerDashboardForm(int userID, string fullName)
        {
            InitializeComponent();

            this.userID = userID;
            this.fullName = fullName;

            lblWelcome.Text = $"Welcome, {fullName}!";
        }

        private void OwnerDashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardStatistics();
            LoadRecentBookings();
        }

        private void LoadDashboardStatistics()
        {
            try
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();

                using (SqlConnection connection =
                       databaseHelper.GetConnection())
                {
                    connection.Open();

                    // Total cars
                    string totalCarsQuery = @"
                        SELECT COUNT(*)
                        FROM Vehicles
                        WHERE OwnerID = @OwnerID";

                    using (SqlCommand command =
                           new SqlCommand(totalCarsQuery, connection))
                    {
                        command.Parameters.AddWithValue("@OwnerID", userID);

                        int totalCars =
                            Convert.ToInt32(command.ExecuteScalar());

                        lblTotalCars.Text = totalCars.ToString();
                    }

                    // Available cars
                    string availableCarsQuery = @"
                        SELECT COUNT(*)
                        FROM Vehicles
                        WHERE OwnerID = @OwnerID
                          AND AvailabilityStatus = 'Available'";

                    using (SqlCommand command =
                           new SqlCommand(availableCarsQuery, connection))
                    {
                        command.Parameters.AddWithValue("@OwnerID", userID);

                        int availableCars =
                            Convert.ToInt32(command.ExecuteScalar());

                        lblAvailableCars.Text =
                            availableCars.ToString();
                    }

                    // Currently rented cars
                    string rentedCarsQuery = @"
                        SELECT COUNT(DISTINCT b.VehicleID)
                        FROM Bookings b
                        INNER JOIN Vehicles v
                            ON b.VehicleID = v.VehicleID
                        WHERE v.OwnerID = @OwnerID
                          AND b.BookingStatus = 'Confirmed'
                          AND b.StartDate <= CAST(GETDATE() AS DATE)
                          AND b.EndDate > CAST(GETDATE() AS DATE)";

                    using (SqlCommand command =
                           new SqlCommand(rentedCarsQuery, connection))
                    {
                        command.Parameters.AddWithValue("@OwnerID", userID);

                        int rentedCars =
                            Convert.ToInt32(command.ExecuteScalar());

                        lblRentedCars.Text =
                            rentedCars.ToString();
                    }

                    // Total earnings
                    string earningsQuery = @"
                        SELECT ISNULL(SUM(p.Amount), 0)
                        FROM Payments p
                        INNER JOIN Bookings b
                            ON p.BookingID = b.BookingID
                        INNER JOIN Vehicles v
                            ON b.VehicleID = v.VehicleID
                        WHERE v.OwnerID = @OwnerID
                          AND p.PaymentStatus = 'Paid'
                          AND b.BookingStatus = 'Confirmed'";

                    using (SqlCommand command =
                           new SqlCommand(earningsQuery, connection))
                    {
                        command.Parameters.AddWithValue("@OwnerID", userID);

                        decimal earnings =
                            Convert.ToDecimal(command.ExecuteScalar());

                        lblTotalEarnings.Text =
                            $"৳{earnings:N0}";
                    }

                    // Pending bookings
                    string pendingQuery = @"
                        SELECT COUNT(*)
                        FROM Bookings b
                        INNER JOIN Vehicles v
                            ON b.VehicleID = v.VehicleID
                        WHERE v.OwnerID = @OwnerID
                          AND b.BookingStatus = 'Pending'";

                    using (SqlCommand command =
                           new SqlCommand(pendingQuery, connection))
                    {
                        command.Parameters.AddWithValue("@OwnerID", userID);

                        int pending =
                            Convert.ToInt32(command.ExecuteScalar());

                        lblPendingBookings.Text =
                            pending.ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error while loading dashboard:\n" +
                    ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unexpected error occurred:\n" +
                    ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadRecentBookings()
        {
            try
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();

                using (SqlConnection connection =
                       databaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT TOP 5
                            b.BookingID AS [Booking ID],
                            u.FullName AS [Customer],
                            v.Brand + ' ' + v.Model AS [Car],
                            b.StartDate AS [Start Date],
                            b.EndDate AS [End Date],
                            b.TotalAmount AS [Amount],
                            b.BookingStatus AS [Status]
                        FROM Bookings b
                        INNER JOIN Vehicles v
                            ON b.VehicleID = v.VehicleID
                        INNER JOIN Users u
                            ON b.CustomerID = u.UserID
                        WHERE v.OwnerID = @OwnerID
                          AND b.BookingStatus <> 'Cancelled'
                        ORDER BY b.BookingID DESC";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@OwnerID",
                            userID);

                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            dgvRecentBookings.DataSource = table;

                            if (dgvRecentBookings.Columns.Count > 0)
                            {
                                dgvRecentBookings.Columns["Start Date"]
                                    .DefaultCellStyle.Format = "dd/MM/yyyy";

                                dgvRecentBookings.Columns["End Date"]
                                    .DefaultCellStyle.Format = "dd/MM/yyyy";

                                dgvRecentBookings.Columns["Amount"]
                                    .DefaultCellStyle.Format = "৳#,##0";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load recent bookings:\n" +
                    ex.Message,
                    "Bookings Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnMyCars_Click(object sender, EventArgs e)
        {
            MyCarsForm myCarsForm =
                new MyCarsForm(userID);

            myCarsForm.ShowDialog();

            LoadDashboardStatistics();
            LoadRecentBookings();
        }

        private void btnOwnerBookings_Click(object sender, EventArgs e)
        {
            OwnerBookingsForm bookingsForm =
                new OwnerBookingsForm(userID);

            bookingsForm.ShowDialog();

            LoadDashboardStatistics();
            LoadRecentBookings();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}