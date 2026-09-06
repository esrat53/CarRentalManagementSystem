using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;

namespace CarRentalManagementSystem.Owner
{
    public partial class OwnerBookingsForm : Form
    {
        private readonly int ownerID;

        private readonly DatabaseHelper databaseHelper =
            new DatabaseHelper();

        public OwnerBookingsForm(int ownerID)
        {
            InitializeComponent();

            this.ownerID = ownerID;

            // Select "All Status" initially
            if (cmbStatus.Items.Count > 0)
            {
                cmbStatus.SelectedIndex = 0;
            }

            // Load bookings when the form opens
            LoadBookings();
        }

        // ============================================================
        // LOAD BOOKINGS
        // ============================================================

        private void LoadBookings()
        {
            try
            {
                using (SqlConnection connection =
                       databaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            b.BookingID,
                            v.Brand + ' ' + v.Model AS Car,
                            u.FullName AS Customer,
                            b.StartDate,
                            b.EndDate,
                            b.TotalAmount,
                            b.BookingStatus,
                            ISNULL(p.PaymentStatus, 'Not Paid') AS PaymentStatus
                        FROM Bookings b
                        INNER JOIN Vehicles v
                            ON b.VehicleID = v.VehicleID
                        INNER JOIN Users u
                            ON b.CustomerID = u.UserID
                        OUTER APPLY (
                            SELECT TOP 1 PaymentStatus
                            FROM Payments p
                            WHERE p.BookingID = b.BookingID
                            ORDER BY p.PaymentID DESC
                        ) p
                        WHERE v.OwnerID = @OwnerID
                        ORDER BY b.BookingID DESC";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@OwnerID",
                            ownerID);

                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(command))
                        {
                            DataTable table =
                                new DataTable();

                            adapter.Fill(table);

                            dgvBookings.DataSource = table;

                            FormatGrid();

                            lblResults.Text =
                                $"{table.Rows.Count} booking(s)";
                        }
                    }
                }

                ApplySearchAndFilter();
                UpdateActionButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load bookings.\n\n" +
                    ex.Message,
                    "Owner Bookings",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // FORMAT GRID
        // ============================================================

        private void FormatGrid()
        {
            if (dgvBookings.Columns.Count == 0)
            {
                return;
            }

            dgvBookings.Columns["BookingID"].HeaderText =
                "Booking ID";

            dgvBookings.Columns["Car"].HeaderText =
                "Car";

            dgvBookings.Columns["Customer"].HeaderText =
                "Customer";

            dgvBookings.Columns["StartDate"].HeaderText =
                "Start Date";

            dgvBookings.Columns["EndDate"].HeaderText =
                "End Date";

            dgvBookings.Columns["TotalAmount"].HeaderText =
                "Total Amount";

            dgvBookings.Columns["BookingStatus"].HeaderText =
                "Booking Status";

            dgvBookings.Columns["PaymentStatus"].HeaderText =
                "Payment";

            dgvBookings.Columns["StartDate"]
                .DefaultCellStyle.Format =
                "dd MMM yyyy";

            dgvBookings.Columns["EndDate"]
                .DefaultCellStyle.Format =
                "dd MMM yyyy";

            dgvBookings.Columns["TotalAmount"]
                .DefaultCellStyle.Format =
                "৳#,##0";

            dgvBookings.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvBookings.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvBookings.MultiSelect = false;

            dgvBookings.ReadOnly = true;
        }

        // ============================================================
        // UPDATE ACTION BUTTONS
        // ============================================================

        private void UpdateActionButtons()
        {
            btnConfirmBooking.Enabled = false;
            btnCancelBooking.Enabled = false;
            btnViewDetails.Enabled = false;

            if (dgvBookings.CurrentRow == null)
            {
                return;
            }

            try
            {
                string bookingStatus =
                    dgvBookings.CurrentRow
                        .Cells["BookingStatus"]
                        .Value?.ToString() ?? "";

                string paymentStatus =
                    dgvBookings.CurrentRow
                        .Cells["PaymentStatus"]
                        .Value?.ToString() ?? "";

                // View Details is always available
                btnViewDetails.Enabled = true;

                // Owner can cancel only unpaid pending bookings.
                if (bookingStatus.Equals(
                        "Pending",
                        StringComparison.OrdinalIgnoreCase) &&
                    paymentStatus.Equals(
                        "Not Paid",
                        StringComparison.OrdinalIgnoreCase))
                {
                    btnCancelBooking.Enabled = true;
                }

                // Owner can confirm ONLY:
                // Pending + Paid
                if (bookingStatus.Equals(
                        "Pending",
                        StringComparison.OrdinalIgnoreCase) &&
                    paymentStatus.Equals(
                        "Paid",
                        StringComparison.OrdinalIgnoreCase))
                {
                    btnConfirmBooking.Enabled = true;
                }
            }
            catch
            {
                btnConfirmBooking.Enabled = false;
                btnCancelBooking.Enabled = false;
                btnViewDetails.Enabled = false;
            }
        }

        // ============================================================
        // GRID SELECTION
        // ============================================================

        private void dgvBookings_SelectionChanged(
            object sender,
            EventArgs e)
        {
            UpdateActionButtons();
        }

        // ============================================================
        // SEARCH AND FILTER
        // ============================================================

        private void ApplySearchAndFilter()
        {
            if (dgvBookings.DataSource == null)
            {
                return;
            }

            DataTable originalTable =
                dgvBookings.DataSource as DataTable;

            if (originalTable == null)
            {
                return;
            }

            string searchText =
                txtSearch.Text.Trim();

            string selectedStatus =
                cmbStatus.SelectedItem?.ToString()
                ?? "All Status";

            DataView view =
                new DataView(originalTable);

            string filter = "";

            // Search by car or customer
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string safeSearch =
                    searchText.Replace("'", "''");

                filter =
                    $"(Car LIKE '%{safeSearch}%' " +
                    $"OR Customer LIKE '%{safeSearch}%')";
            }

            // Status filter
            if (selectedStatus != "All Status")
            {
                string safeStatus =
                    selectedStatus.Replace("'", "''");

                if (!string.IsNullOrWhiteSpace(filter))
                {
                    filter += " AND ";
                }

                filter +=
                    $"BookingStatus = '{safeStatus}'";
            }

            view.RowFilter = filter;

            dgvBookings.DataSource = view;

            lblResults.Text =
                $"{view.Count} booking(s)";

            UpdateActionButtons();
        }

        // ============================================================
        // SEARCH BUTTON
        // ============================================================

        private void btnSearch_Click(
            object sender,
            EventArgs e)
        {
            ApplySearchAndFilter();
        }

        // ============================================================
        // STATUS FILTER
        // ============================================================

        private void cmbStatus_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            ApplySearchAndFilter();
        }

        // ============================================================
        // REFRESH
        // ============================================================

        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            txtSearch.Clear();

            if (cmbStatus.Items.Count > 0)
            {
                cmbStatus.SelectedIndex = 0;
            }

            LoadBookings();
        }

        // ============================================================
        // CONFIRM BOOKING
        // ============================================================

        private void btnConfirmBooking_Click(
            object sender,
            EventArgs e)
        {
            if (dgvBookings.CurrentRow == null)
            {
                return;
            }

            int bookingID =
                Convert.ToInt32(
                    dgvBookings.CurrentRow
                        .Cells["BookingID"]
                        .Value);

            string bookingStatus =
                dgvBookings.CurrentRow
                    .Cells["BookingStatus"]
                    .Value?.ToString() ?? "";

            string paymentStatus =
                dgvBookings.CurrentRow
                    .Cells["PaymentStatus"]
                    .Value?.ToString() ?? "";

            // Safety check
            if (!bookingStatus.Equals(
                    "Pending",
                    StringComparison.OrdinalIgnoreCase) ||
                !paymentStatus.Equals(
                    "Paid",
                    StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Only paid pending bookings can be confirmed.",
                    "Confirm Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to confirm this booking?",
                "Confirm Booking",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection connection =
                       databaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        UPDATE b
                        SET b.BookingStatus = 'Confirmed'
                        FROM Bookings b
                        INNER JOIN Vehicles v
                            ON b.VehicleID = v.VehicleID
                        WHERE b.BookingID = @BookingID
                          AND v.OwnerID = @OwnerID
                          AND b.BookingStatus = 'Pending'
                          AND EXISTS (
                              SELECT 1
                              FROM Payments p
                              WHERE p.BookingID = b.BookingID
                                AND p.PaymentStatus = 'Paid'
                          )
                          AND NOT EXISTS (
                              SELECT 1
                              FROM Bookings other
                              WHERE other.VehicleID = b.VehicleID
                                AND other.BookingID <> b.BookingID
                                AND other.BookingStatus = 'Confirmed'
                                AND other.StartDate < b.EndDate
                                AND other.EndDate > b.StartDate
                          )";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@BookingID",
                            bookingID);

                        command.Parameters.AddWithValue(
                            "@OwnerID",
                            ownerID);

                        int rowsAffected =
                            command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Booking confirmed successfully.",
                                "Booking Confirmed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            LoadBookings();
                        }
                        else
                        {
                            MessageBox.Show(
                                "The booking could not be confirmed.",
                                "Confirm Booking",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not confirm the booking.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unexpected error occurred.\n\n" +
                    ex.Message,
                    "Confirm Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // CANCEL BOOKING
        // ============================================================

        private void btnCancelBooking_Click(
            object sender,
            EventArgs e)
        {
            if (dgvBookings.CurrentRow == null)
            {
                return;
            }

            int bookingID =
                Convert.ToInt32(
                    dgvBookings.CurrentRow
                        .Cells["BookingID"]
                        .Value);

            string bookingStatus =
                dgvBookings.CurrentRow
                    .Cells["BookingStatus"]
                    .Value?.ToString() ?? "";

            string paymentStatus =
                dgvBookings.CurrentRow
                    .Cells["PaymentStatus"]
                    .Value?.ToString() ?? "";

            if (!bookingStatus.Equals(
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

            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel this booking?",
                "Cancel Booking",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection connection =
                       databaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        UPDATE b
                        SET b.BookingStatus = 'Cancelled'
                        FROM Bookings b
                        INNER JOIN Vehicles v
                            ON b.VehicleID = v.VehicleID
                        WHERE b.BookingID = @BookingID
                          AND v.OwnerID = @OwnerID
                          AND b.BookingStatus = 'Pending'
                          AND NOT EXISTS (
                              SELECT 1
                              FROM Payments p
                              WHERE p.BookingID = b.BookingID
                                AND p.PaymentStatus = 'Paid'
                          )";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@BookingID",
                            bookingID);

                        command.Parameters.AddWithValue(
                            "@OwnerID",
                            ownerID);

                        int rowsAffected =
                            command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Booking cancelled successfully.",
                                "Booking Cancelled",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            LoadBookings();
                        }
                        else
                        {
                            MessageBox.Show(
                                "The booking could not be cancelled.",
                                "Cancel Booking",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not cancel the booking.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unexpected error occurred.\n\n" +
                    ex.Message,
                    "Cancel Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // VIEW DETAILS
        // ============================================================

        private void btnViewDetails_Click(
            object sender,
            EventArgs e)
        {
            if (dgvBookings.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a booking first.",
                    "View Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow row =
                dgvBookings.CurrentRow;

            string bookingID =
                row.Cells["BookingID"].Value?.ToString() ?? "";

            string car =
                row.Cells["Car"].Value?.ToString() ?? "";

            string customer =
                row.Cells["Customer"].Value?.ToString() ?? "";

            string startDate =
                Convert.ToDateTime(
                    row.Cells["StartDate"].Value)
                .ToString("dd MMM yyyy");

            string endDate =
                Convert.ToDateTime(
                    row.Cells["EndDate"].Value)
                .ToString("dd MMM yyyy");

            string amount =
                Convert.ToDecimal(
                    row.Cells["TotalAmount"].Value)
                .ToString("৳#,##0");

            string bookingStatus =
                row.Cells["BookingStatus"]
                   .Value?.ToString() ?? "";

            string paymentStatus =
                row.Cells["PaymentStatus"]
                   .Value?.ToString() ?? "";

            string details =
                $"Booking ID: {bookingID}\n\n" +
                $"Customer: {customer}\n" +
                $"Car: {car}\n\n" +
                $"Start Date: {startDate}\n" +
                $"End Date: {endDate}\n\n" +
                $"Total Amount: {amount}\n" +
                $"Booking Status: {bookingStatus}\n" +
                $"Payment Status: {paymentStatus}";

            MessageBox.Show(
                details,
                "Booking Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ============================================================
        // BACK
        // ============================================================

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}