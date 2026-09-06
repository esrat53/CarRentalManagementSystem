using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;

namespace CarRentalManagementSystem.Admin
{
    public partial class ManageAllBookingsForm : Form
    {
        public ManageAllBookingsForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Do not access the database while Visual Studio Designer is open.
            if (DesignMode ||
                LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }

            LoadBookings();
        }

        // =========================================================
        // LOAD ALL BOOKINGS
        // =========================================================

        private void LoadBookings()
        {
            try
            {
                using SqlConnection connection =
                    new DatabaseHelper().GetConnection();

                connection.Open();

                string query = @"
                    SELECT
                        b.BookingID AS [ID],
                        u.FullName AS [Customer],
                        v.Brand + ' ' + v.Model AS [Car],
                        b.StartDate AS [Start Date],
                        b.EndDate AS [End Date],
                        b.TotalAmount AS [Amount],
                        b.BookingStatus AS [Status],
                        ISNULL(p.PaymentStatus, 'Not Paid') AS [Payment]

                    FROM Bookings b

                    INNER JOIN Users u
                        ON b.CustomerID = u.UserID

                    INNER JOIN Vehicles v
                        ON b.VehicleID = v.VehicleID

                    OUTER APPLY (
                        SELECT TOP 1 PaymentStatus
                        FROM Payments p
                        WHERE p.BookingID = b.BookingID
                        ORDER BY p.PaymentID DESC
                    ) p

                    ORDER BY b.CreatedAt DESC";

                using SqlDataAdapter adapter =
                    new SqlDataAdapter(query, connection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvBookings.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load bookings.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // SEARCH / FILTER
        // =========================================================

        private void FilterBookings(object sender, EventArgs e)
        {
            if (dgvBookings.DataSource is not DataTable table)
                return;

            string search =
                txtSearch.Text.Trim().Replace("'", "''");

            string selectedStatus =
                cmbStatus.SelectedItem?.ToString() ?? "All";

            string filter = "";

            if (search.Length > 0)
            {
                filter =
                    $"Customer LIKE '%{search}%' " +
                    $"OR Car LIKE '%{search}%'";
            }

            if (selectedStatus != "All")
            {
                if (filter.Length > 0)
                    filter += " AND ";

                filter += $"Status = '{selectedStatus}'";
            }

            table.DefaultView.RowFilter = filter;
        }

        // =========================================================
        // REFRESH
        // =========================================================

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBookings();

            MessageBox.Show(
                "Booking list has been refreshed.",
                "Refresh",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================================================
        // CONFIRM BOOKING
        // =========================================================

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a booking first.",
                    "Select Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DataGridViewRow row =
                dgvBookings.SelectedRows[0];

            int bookingID =
                Convert.ToInt32(row.Cells["ID"].Value);

            string currentStatus =
                row.Cells["Status"].Value?.ToString() ?? "";

            string paymentStatus =
                row.Cells["Payment"].Value?.ToString() ?? "Not Paid";

            // Already confirmed
            if (currentStatus.Equals(
                "Confirmed",
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    $"Booking #{bookingID} is already confirmed.",
                    "Already Confirmed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // Cannot confirm cancelled booking
            if (currentStatus.Equals(
                "Cancelled",
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    $"Booking #{bookingID} has already been cancelled.\n\n" +
                    "A cancelled booking cannot be confirmed again.",
                    "Cannot Confirm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Only paid pending bookings should be confirmed.
            if (!currentStatus.Equals(
                "Pending",
                StringComparison.OrdinalIgnoreCase) ||
                !paymentStatus.Equals(
                    "Paid",
                    StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    $"Booking #{bookingID} cannot be confirmed. It must be Pending and Paid.",
                    "Cannot Confirm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                $"Confirm booking #{bookingID}?",
                "Confirm Booking",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UpdateBookingStatus(
                    bookingID,
                    "Pending",
                    "Confirmed");
            }
        }

        // =========================================================
        // CANCEL BOOKING
        // =========================================================

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a booking first.",
                    "Select Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DataGridViewRow row =
                dgvBookings.SelectedRows[0];

            int bookingID =
                Convert.ToInt32(row.Cells["ID"].Value);

            string currentStatus =
                row.Cells["Status"].Value?.ToString() ?? "";

            string paymentStatus =
                row.Cells["Payment"].Value?.ToString() ?? "Not Paid";

            // Already cancelled
            if (currentStatus.Equals(
                "Cancelled",
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    $"Booking #{bookingID} is already cancelled.",
                    "Already Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (!currentStatus.Equals(
                    "Pending",
                    StringComparison.OrdinalIgnoreCase) ||
                !paymentStatus.Equals(
                    "Not Paid",
                    StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Only unpaid pending bookings can be cancelled. Paid bookings require a refund process.",
                    "Cancel Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Confirm before cancelling
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to cancel booking #{bookingID}?\n\n" +
                $"Current status: {currentStatus}",
                "Cancel Booking",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                UpdateBookingStatus(
                    bookingID,
                    currentStatus,
                    "Cancelled");
            }
        }

        // =========================================================
        // UPDATE BOOKING STATUS
        // =========================================================

        private void UpdateBookingStatus(
            int bookingID,
            string expectedCurrentStatus,
            string newStatus)
        {
            try
            {
                using SqlConnection connection =
                    new DatabaseHelper().GetConnection();

                connection.Open();

                string query = @"
                    UPDATE b
                    SET b.BookingStatus = @NewStatus
                    FROM Bookings b
                    WHERE b.BookingID = @BookingID
                      AND b.BookingStatus = @CurrentStatus
                      AND (
                          (@NewStatus = 'Confirmed' AND EXISTS (
                              SELECT 1
                              FROM Payments p
                              WHERE p.BookingID = b.BookingID
                                AND p.PaymentStatus = 'Paid'
                          ))
                          OR
                          (@NewStatus = 'Cancelled' AND NOT EXISTS (
                              SELECT 1
                              FROM Payments p
                              WHERE p.BookingID = b.BookingID
                                AND p.PaymentStatus = 'Paid'
                          ))
                          OR
                          (@NewStatus NOT IN ('Confirmed', 'Cancelled'))
                      )";

                using SqlCommand command =
                    new SqlCommand(query, connection);

                command.Parameters.AddWithValue(
                    "@NewStatus",
                    newStatus);

                command.Parameters.AddWithValue(
                    "@BookingID",
                    bookingID);

                command.Parameters.AddWithValue(
                    "@CurrentStatus",
                    expectedCurrentStatus);

                int rowsAffected =
                    command.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    MessageBox.Show(
                        "The booking status may have changed already.\n\n" +
                        "Please refresh the booking list and try again.",
                        "Booking Changed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    LoadBookings();
                    return;
                }

                LoadBookings();

                MessageBox.Show(
                    $"Booking #{bookingID} is now {newStatus}.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not update booking.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // CLOSE / BACK
        // =========================================================

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}