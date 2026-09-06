using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;

namespace CarRentalManagementSystem.Customer
{
    public partial class MyBookingsForm : Form
    {
        private readonly int customerID;

        public MyBookingsForm(int customerID)
        {
            InitializeComponent();

            this.customerID = customerID;

            this.Load += MyBookingsForm_Load;
            this.dgvBookings.SelectionChanged += dgvBookings_SelectionChanged;
        }

        // ============================================================
        // FORM LOAD
        // ============================================================

        private void MyBookingsForm_Load(object sender, EventArgs e)
        {
            LoadBookings();
            UpdateActionButtons();
        }

        // ============================================================
        // LOAD BOOKINGS
        // ============================================================

        private void LoadBookings()
        {
            try
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();

                using (SqlConnection connection =
                       databaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            b.BookingID AS [Booking ID],
                            v.Brand + ' ' + v.Model AS [Car],
                            v.VehicleType AS [Type],
                            b.StartDate AS [Start Date],
                            b.EndDate AS [End Date],
                            b.TotalAmount AS [Total Amount],
                            b.BookingStatus AS [Booking Status],
                            ISNULL(p.PaymentStatus, 'Not Paid') AS [Payment Status]
                        FROM Bookings b
                        INNER JOIN Vehicles v
                            ON b.VehicleID = v.VehicleID
                        OUTER APPLY (
                            SELECT TOP 1 PaymentStatus
                            FROM Payments p
                            WHERE p.BookingID = b.BookingID
                            ORDER BY p.PaymentID DESC
                        ) p
                        WHERE b.CustomerID = @CustomerID
                        ORDER BY b.BookingID DESC";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@CustomerID",
                            customerID);

                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            dgvBookings.DataSource = table;

                            lblResults.Text =
                                $"My Bookings  •  {table.Rows.Count} booking(s)";
                        }
                    }
                }

                FormatGrid();
                UpdateActionButtons();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not load your bookings.\n\n" +
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
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // GRID FORMATTING
        // ============================================================

        private void FormatGrid()
        {
            if (dgvBookings.Columns.Count == 0)
                return;

            dgvBookings.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvBookings.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvBookings.MultiSelect = false;

            dgvBookings.ReadOnly = true;

            dgvBookings.AllowUserToAddRows = false;

            dgvBookings.RowHeadersVisible = false;

            if (dgvBookings.Columns.Contains("Booking ID"))
                dgvBookings.Columns["Booking ID"].FillWeight = 60;

            if (dgvBookings.Columns.Contains("Car"))
                dgvBookings.Columns["Car"].FillWeight = 130;

            if (dgvBookings.Columns.Contains("Type"))
                dgvBookings.Columns["Type"].FillWeight = 80;

            if (dgvBookings.Columns.Contains("Start Date"))
                dgvBookings.Columns["Start Date"].FillWeight = 90;

            if (dgvBookings.Columns.Contains("End Date"))
                dgvBookings.Columns["End Date"].FillWeight = 90;

            if (dgvBookings.Columns.Contains("Total Amount"))
                dgvBookings.Columns["Total Amount"].FillWeight = 90;

            if (dgvBookings.Columns.Contains("Booking Status"))
                dgvBookings.Columns["Booking Status"].FillWeight = 100;

            if (dgvBookings.Columns.Contains("Payment Status"))
                dgvBookings.Columns["Payment Status"].FillWeight = 100;

            // Format dates
            if (dgvBookings.Columns.Contains("Start Date"))
            {
                dgvBookings.Columns["Start Date"].DefaultCellStyle.Format =
                    "dd/MM/yyyy";
            }

            if (dgvBookings.Columns.Contains("End Date"))
            {
                dgvBookings.Columns["End Date"].DefaultCellStyle.Format =
                    "dd/MM/yyyy";
            }

            // Format amount
            if (dgvBookings.Columns.Contains("Total Amount"))
            {
                dgvBookings.Columns["Total Amount"]
                    .DefaultCellStyle.Format = "৳#,##0";
            }
        }

        // ============================================================
        // SELECTION CHANGED
        // ============================================================

        private void dgvBookings_SelectionChanged(
            object sender,
            EventArgs e)
        {
            UpdateActionButtons();
        }

        // ============================================================
        // UPDATE ACTION BUTTONS
        // ============================================================

        private void UpdateActionButtons()
        {
            btnCancelBooking.Enabled = false;
            btnPayNow.Enabled = false;

            if (dgvBookings.CurrentRow == null)
                return;

            try
            {
                string bookingStatus =
                    dgvBookings.CurrentRow.Cells["Booking Status"]
                    .Value?.ToString() ?? "";

                string paymentStatus =
                    dgvBookings.CurrentRow.Cells["Payment Status"]
                    .Value?.ToString() ?? "";

                // Cancellation is allowed only before payment.
                if (bookingStatus.Equals(
                        "Pending",
                        StringComparison.OrdinalIgnoreCase) &&
                    paymentStatus.Equals(
                        "Not Paid",
                        StringComparison.OrdinalIgnoreCase))
                {
                    btnCancelBooking.Enabled = true;
                }

                // Pay Now is available only when:
                // Booking = Pending
                // Payment = Not Paid
                if (bookingStatus.Equals(
                        "Pending",
                        StringComparison.OrdinalIgnoreCase) &&
                    paymentStatus.Equals(
                        "Not Paid",
                        StringComparison.OrdinalIgnoreCase))
                {
                    btnPayNow.Enabled = true;
                }
            }
            catch
            {
                btnCancelBooking.Enabled = false;
                btnPayNow.Enabled = false;
            }
        }

        // ============================================================
        // PAY NOW
        // ============================================================

        private void btnPayNow_Click(
            object sender,
            EventArgs e)
        {
            if (dgvBookings.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a booking first.",
                    "Pay Now",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                DataGridViewRow row =
                    dgvBookings.CurrentRow;

                int bookingID =
                    Convert.ToInt32(
                        row.Cells["Booking ID"].Value);

                string carName =
                    row.Cells["Car"].Value?.ToString() ?? "";

                DateTime startDate =
                    Convert.ToDateTime(
                        row.Cells["Start Date"].Value);

                DateTime endDate =
                    Convert.ToDateTime(
                        row.Cells["End Date"].Value);

                decimal amount =
                    Convert.ToDecimal(
                        row.Cells["Total Amount"].Value);

                string bookingStatus =
                    row.Cells["Booking Status"]
                       .Value?.ToString() ?? "";

                string paymentStatus =
                    row.Cells["Payment Status"]
                       .Value?.ToString() ?? "";

                // Safety check
                if (!bookingStatus.Equals(
                        "Pending",
                        StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Only pending bookings can be paid.",
                        "Payment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                if (!paymentStatus.Equals(
                        "Not Paid",
                        StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "This booking has already been paid.",
                        "Payment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadBookings();
                    return;
                }

                // Open PaymentForm
                using (PaymentForm paymentForm =
                       new PaymentForm(
                           bookingID,
                           amount,
                           carName,
                           startDate,
                           endDate))
                {
                    paymentForm.ShowDialog(this);
                }

                // Refresh after PaymentForm closes
                LoadBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open the payment screen.\n\n" +
                    ex.Message,
                    "Payment Error",
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
                MessageBox.Show(
                    "Please select a booking first.",
                    "Cancel Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                int bookingID =
                    Convert.ToInt32(
                        dgvBookings.CurrentRow
                            .Cells["Booking ID"].Value);

                string bookingStatus =
                    dgvBookings.CurrentRow
                        .Cells["Booking Status"]
                        .Value?.ToString() ?? "";

                string paymentStatus =
                    dgvBookings.CurrentRow
                        .Cells["Payment Status"]
                        .Value?.ToString() ?? "";

                if (!bookingStatus.Equals(
                        "Pending",
                        StringComparison.OrdinalIgnoreCase) ||
                    !paymentStatus.Equals(
                        "Not Paid",
                        StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Only unpaid pending bookings can be cancelled. Paid bookings require a refund process and cannot be cancelled here.",
                        "Cancel Booking",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to cancel this booking?",
                    "Confirm Cancellation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                DatabaseHelper databaseHelper =
                    new DatabaseHelper();

                using (SqlConnection connection =
                       databaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        UPDATE Bookings
                        SET BookingStatus = 'Cancelled'
                        WHERE BookingID = @BookingID
                          AND CustomerID = @CustomerID
                          AND BookingStatus = 'Pending'";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@BookingID",
                            bookingID);

                        command.Parameters.AddWithValue(
                            "@CustomerID",
                            customerID);

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
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}