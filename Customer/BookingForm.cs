using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;
using CarRentalManagementSystem.Models;

namespace CarRentalManagementSystem.Customer
{
    public partial class BookingForm : Form
    {
        private Vehicle selectedVehicle;
        private int userID;

        // ============================================================
        // DEFAULT CONSTRUCTOR
        // ============================================================

        public BookingForm()
        {
            InitializeComponent();
        }

        // ============================================================
        // BOOKING CONSTRUCTOR
        // ============================================================

        public BookingForm(Vehicle vehicle, int userID)
            : this()
        {
            selectedVehicle = vehicle;
            this.userID = userID;
        }

        // ============================================================
        // FORM LOAD
        // ============================================================

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            dtpStartDate.ValueChanged += DateChanged;
            dtpReturnDate.ValueChanged += DateChanged;

            btnBack.Click += btnBack_Click;
            btnCancel.Click += btnCancel_Click;
            btnConfirmBooking.Click += btnConfirmBooking_Click;

            dtpStartDate.MinDate = DateTime.Today;
            dtpReturnDate.MinDate = DateTime.Today;

            dtpStartDate.Value = DateTime.Today;
            dtpReturnDate.Value = DateTime.Today.AddDays(1);

            if (selectedVehicle != null)
            {
                DisplayVehicle();
            }

            CalculateBooking();
        }

        // ============================================================
        // DISPLAY VEHICLE
        // ============================================================

        private void DisplayVehicle()
        {
            lblCarName.Text =
                $"{selectedVehicle.Brand} {selectedVehicle.Model}";

            lblCarType.Text =
                $"Type: {selectedVehicle.VehicleType}";

            lblCarSeats.Text =
                $"Seats: {selectedVehicle.Seats}";

            lblCarLocation.Text =
                $"Location: {selectedVehicle.Location}";

            lblPricePerDay.Text =
                $"৳{selectedVehicle.PricePerDay:N0} / day";

            LoadCarImage(selectedVehicle.ImagePath);
        }

        // ============================================================
        // LOAD CAR IMAGE
        // ============================================================

        private void LoadCarImage(string imagePath)
        {
            try
            {
                picCar.Image = null;

                if (string.IsNullOrWhiteSpace(imagePath))
                {
                    return;
                }

                string cleanPath =
                    imagePath
                    .Replace(
                        "/",
                        Path.DirectorySeparatorChar.ToString())
                    .Replace(
                        "\\",
                        Path.DirectorySeparatorChar.ToString());

                string fullPath =
                    Path.Combine(
                        Application.StartupPath,
                        cleanPath);

                if (!File.Exists(fullPath))
                {
                    return;
                }

                using (FileStream stream =
                       new FileStream(
                           fullPath,
                           FileMode.Open,
                           FileAccess.Read))
                {
                    using (Image originalImage =
                           Image.FromStream(stream))
                    {
                        picCar.Image =
                            new Bitmap(originalImage);
                    }
                }

                picCar.SizeMode =
                    PictureBoxSizeMode.Zoom;
            }
            catch
            {
                picCar.Image = null;
            }
        }

        // ============================================================
        // DATE CHANGE
        // ============================================================

        private void DateChanged(
            object sender,
            EventArgs e)
        {
            CalculateBooking();
        }

        // ============================================================
        // CALCULATE BOOKING
        // ============================================================

        private void CalculateBooking()
        {
            if (selectedVehicle == null)
            {
                return;
            }

            DateTime startDate = dtpStartDate.Value.Date;
            DateTime returnDate = dtpReturnDate.Value.Date;

            if (returnDate <= startDate)
            {
                lblDays.Text = "Invalid rental dates";
                lblTotal.Text = "৳0";

                lblAvailability.Text = "● Invalid rental dates";
                lblAvailability.ForeColor =
                    Color.FromArgb(220, 38, 38);

                btnConfirmBooking.Enabled = false;

                return;
            }

            int numberOfDays =
                (returnDate - startDate).Days;

            decimal totalAmount =
                numberOfDays * selectedVehicle.PricePerDay;

            lblDays.Text =
                $"{numberOfDays} day(s)";

            lblTotal.Text =
                $"৳{totalAmount:N0}";

            try
            {
                if (IsVehicleAvailable(startDate, returnDate))
                {
                    lblAvailability.Text =
                        "● Car Available for these dates";

                    lblAvailability.ForeColor =
                        Color.FromArgb(22, 163, 74);

                    btnConfirmBooking.Enabled = true;
                }
                else
                {
                    lblAvailability.Text =
                        "● Car Not Available for these dates";

                    lblAvailability.ForeColor =
                        Color.FromArgb(220, 38, 38);

                    btnConfirmBooking.Enabled = false;
                }
            }
            catch
            {
                lblAvailability.Text =
                    "● Could not check availability";

                lblAvailability.ForeColor =
                    Color.FromArgb(220, 38, 38);

                btnConfirmBooking.Enabled = false;
            }
        }

        // ============================================================
        // BACK BUTTON
        // ============================================================

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        // ============================================================
        // CANCEL BUTTON
        // ============================================================

        private void btnCancel_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        // ============================================================
        // CHECK VEHICLE AVAILABILITY
        // ============================================================

        private bool IsVehicleAvailable(
            DateTime startDate,
            DateTime endDate)
        {
            DatabaseHelper databaseHelper =
                new DatabaseHelper();

            using (SqlConnection connection =
                   databaseHelper.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT COUNT(*)
                    FROM Bookings
                    WHERE VehicleID = @VehicleID
                      AND BookingStatus IN ('Pending', 'Confirmed')
                      AND StartDate < @EndDate
                      AND EndDate > @StartDate";

                using (SqlCommand command =
                       new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@VehicleID",
                        selectedVehicle.VehicleID);

                    command.Parameters.AddWithValue(
                        "@StartDate",
                        startDate);

                    command.Parameters.AddWithValue(
                        "@EndDate",
                        endDate);

                    int existingBookings =
                        Convert.ToInt32(
                            command.ExecuteScalar());

                    return existingBookings == 0;
                }
            }
        }

        // ============================================================
        // CONFIRM BOOKING
        // ============================================================

        private void btnConfirmBooking_Click(
   object sender,
   EventArgs e)
        {
            if (selectedVehicle == null)
            {
                MessageBox.Show(
                    "No vehicle has been selected.",
                    "Booking Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DateTime startDate =
                dtpStartDate.Value.Date;

            DateTime returnDate =
                dtpReturnDate.Value.Date;

            // ============================================================
            // VALIDATE DATES
            // ============================================================

            if (returnDate <= startDate)
            {
                MessageBox.Show(
                    "Please select a return date after the start date.",
                    "Invalid Dates",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int numberOfDays =
                (returnDate - startDate).Days;

            decimal totalAmount =
                numberOfDays *
                selectedVehicle.PricePerDay;

            Booking booking = new Booking
            {
                CustomerID = userID,
                VehicleID = selectedVehicle.VehicleID,
                StartDate = startDate,
                EndDate = returnDate,
                TotalAmount = totalAmount,
                BookingStatus = "Pending"
            };

            try
            {
                // ============================================================
                // CHECK VEHICLE AVAILABILITY
                // ============================================================

                if (!IsVehicleAvailable(
                    startDate,
                    returnDate))
                {
                    MessageBox.Show(
                        "Sorry, this car is already booked for the selected dates.\n\n" +
                        "Please choose different dates or another car.",
                        "Car Not Available",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // ============================================================
                // INSERT BOOKING
                // ============================================================

                DatabaseHelper databaseHelper =
                    new DatabaseHelper();

                using (SqlConnection connection =
                       databaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
                INSERT INTO Bookings
                (
                    CustomerID,
                    VehicleID,
                    StartDate,
                    EndDate,
                    TotalAmount,
                    BookingStatus
                )
                OUTPUT INSERTED.BookingID
                VALUES
                (
                    @CustomerID,
                    @VehicleID,
                    @StartDate,
                    @EndDate,
                    @TotalAmount,
                    @BookingStatus
                )";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", booking.CustomerID);
                        command.Parameters.AddWithValue("@VehicleID", booking.VehicleID);
                        command.Parameters.AddWithValue("@StartDate", booking.StartDate);
                        command.Parameters.AddWithValue("@EndDate", booking.EndDate);
                        command.Parameters.AddWithValue("@TotalAmount", booking.TotalAmount);
                        command.Parameters.AddWithValue("@BookingStatus", booking.BookingStatus);

                        int bookingID =
                            Convert.ToInt32(
                                command.ExecuteScalar());

                        // ====================================================
                        // OPEN PAYMENT FORM
                        // ====================================================

                        PaymentForm paymentForm =
                            new PaymentForm(
                                bookingID,
                                totalAmount,
                                $"{selectedVehicle.Brand} {selectedVehicle.Model}",
                                startDate,
                                returnDate);

                        this.Hide();

                        paymentForm.ShowDialog();

                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not save the booking to the database.\n\n" +
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
                    "Booking Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        
    }
}