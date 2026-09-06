using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;
using CarRentalManagementSystem.Models;

namespace CarRentalManagementSystem.Customer
{
    public partial class PaymentForm : Form
    {
        private int bookingID;
        private decimal amount;
        private string carName;
        private DateTime startDate;
        private DateTime endDate;

        // ============================================================
        // DEFAULT CONSTRUCTOR
        // ============================================================

        public PaymentForm()
        {
            InitializeComponent();
        }

        // ============================================================
        // PAYMENT CONSTRUCTOR
        // ============================================================

        public PaymentForm(
            int bookingID,
            decimal amount,
            string carName,
            DateTime startDate,
            DateTime endDate)
            : this()
        {
            this.bookingID = bookingID;
            this.amount = amount;
            this.carName = carName;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        // ============================================================
        // FORM LOAD
        // ============================================================

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            cmbPaymentMethod.SelectedIndex = 0;

            lblBookingID.Text =
                $"Booking ID: {bookingID}";

            lblCar.Text =
                $"Car: {carName}";

            lblDates.Text =
                $"Rental Dates: {startDate:dd/MM/yyyy} - {endDate:dd/MM/yyyy}";

            lblAmount.Text =
                $"Total: ৳{amount:N0}";

            btnBack.Click += btnBack_Click;
            btnCancel.Click += btnCancel_Click;
            btnPay.Click += btnPay_Click;
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

        // ============================================================
        // CANCEL
        // ============================================================

        private void btnCancel_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        // ============================================================
        // PAY NOW
        // ============================================================

        private void btnPay_Click(
            object sender,
            EventArgs e)
        {
            string paymentMethod =
                cmbPaymentMethod.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(paymentMethod))
            {
                MessageBox.Show(
                    "Please select a payment method.",
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (paymentMethod == "Credit Card" ||
                paymentMethod == "Debit Card")
            {
                if (string.IsNullOrWhiteSpace(txtCardNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtCardHolder.Text) ||
                    string.IsNullOrWhiteSpace(txtExpiry.Text) ||
                    string.IsNullOrWhiteSpace(txtCVV.Text))
                {
                    MessageBox.Show(
                        "Please complete the card payment information.",
                        "Payment Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                btnPay.Enabled = false;

                using SqlConnection connection =
                    new DatabaseHelper().GetConnection();

                connection.Open();

                using SqlTransaction transaction =
                    connection.BeginTransaction();

                try
                {
                    // Read the authoritative booking amount/status from the database.
                    string bookingCheckQuery = @"
                        SELECT TotalAmount, BookingStatus
                        FROM Bookings
                        WHERE BookingID = @BookingID";

                    decimal databaseAmount;
                    string bookingStatus;

                    using (SqlCommand command =
                           new SqlCommand(
                               bookingCheckQuery,
                               connection,
                               transaction))
                    {
                        command.Parameters.AddWithValue("@BookingID", bookingID);

                        using SqlDataReader reader = command.ExecuteReader();

                        if (!reader.Read())
                        {
                            reader.Close();
                            transaction.Rollback();
                            MessageBox.Show(
                                "The booking could not be found.",
                                "Payment Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            btnPay.Enabled = true;
                            return;
                        }

                        databaseAmount = Convert.ToDecimal(reader["TotalAmount"]);
                        bookingStatus = reader["BookingStatus"]?.ToString() ?? "";
                    }

                    if (!bookingStatus.Equals(
                            "Pending",
                            StringComparison.OrdinalIgnoreCase))
                    {
                        transaction.Rollback();
                        MessageBox.Show(
                            "Only pending bookings can be paid.",
                            "Payment Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        btnPay.Enabled = true;
                        return;
                    }

                    if (databaseAmount != amount)
                    {
                        transaction.Rollback();
                        MessageBox.Show(
                            "The booking amount has changed. Please return to My Bookings and try again.",
                            "Payment Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        btnPay.Enabled = true;
                        return;
                    }

                    string checkQuery = @"
                        SELECT COUNT(*)
                        FROM Payments
                        WHERE BookingID = @BookingID
                          AND PaymentStatus = 'Paid'";

                    using (SqlCommand checkCommand =
                           new SqlCommand(checkQuery, connection, transaction))
                    {
                        checkCommand.Parameters.AddWithValue("@BookingID", bookingID);

                        if (Convert.ToInt32(checkCommand.ExecuteScalar()) > 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show(
                                "This booking has already been paid.",
                                "Already Paid",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            SetPaymentCompleted();
                            return;
                        }
                    }

                    Payment payment = new Payment
                    {
                        BookingID = bookingID,
                        Amount = databaseAmount,
                        PaymentMethod = paymentMethod,
                        PaymentStatus = "Paid",
                        TransactionDate = DateTime.Now
                    };

                    string paymentQuery = @"
                        INSERT INTO Payments
                        (BookingID, Amount, PaymentMethod, PaymentStatus, TransactionDate)
                        OUTPUT INSERTED.PaymentID
                        VALUES
                        (@BookingID, @Amount, @PaymentMethod, @PaymentStatus, @TransactionDate)";

                    int paymentID;

                    using (SqlCommand paymentCommand =
                           new SqlCommand(paymentQuery, connection, transaction))
                    {
                        paymentCommand.Parameters.AddWithValue("@BookingID", payment.BookingID);
                        paymentCommand.Parameters.AddWithValue("@Amount", payment.Amount);
                        paymentCommand.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod);
                        paymentCommand.Parameters.AddWithValue("@PaymentStatus", payment.PaymentStatus);
                        paymentCommand.Parameters.AddWithValue("@TransactionDate", payment.TransactionDate);

                        paymentID = Convert.ToInt32(paymentCommand.ExecuteScalar());
                    }

                    // Payment does NOT confirm the booking. The owner must confirm it.
                    transaction.Commit();

                    SetPaymentCompleted();

                    MessageBox.Show(
                        $"Payment successful!\n\n" +
                        $"Payment ID: {paymentID}\n" +
                        $"Booking ID: {bookingID}\n" +
                        $"Car: {carName}\n" +
                        $"Amount: ৳{databaseAmount:N0}\n" +
                        $"Payment Method: {paymentMethod}\n" +
                        $"Payment Status: Paid\n" +
                        $"Booking Status: Pending (awaiting owner confirmation)",
                        "Payment Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch
                {
                    try { transaction.Rollback(); } catch { }
                    throw;
                }
            }
            catch (SqlException ex)
            {
                btnPay.Enabled = true;
                MessageBox.Show(
                    "Could not process the payment.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                btnPay.Enabled = true;
                MessageBox.Show(
                    "An unexpected error occurred.\n\n" + ex.Message,
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // PAYMENT COMPLETED UI
        // ============================================================

        private void SetPaymentCompleted()
        {
            btnPay.Text = "✓ Paid";
            btnPay.Enabled = false;

            cmbPaymentMethod.Enabled = false;

            txtCardNumber.Enabled = false;
            txtCardHolder.Enabled = false;
            txtExpiry.Enabled = false;
            txtCVV.Enabled = false;

            lblSubtitle.Text =
                "Payment completed successfully";
        }
    }
}