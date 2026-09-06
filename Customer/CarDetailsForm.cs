using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CarRentalManagementSystem.Models;

namespace CarRentalManagementSystem.Customer
{
    public partial class CarDetailsForm : Form
    {
        private readonly Vehicle vehicle;
        private readonly int userID;

        public CarDetailsForm(
            Vehicle selectedVehicle,
            int userID)
        {
            InitializeComponent();

            vehicle = selectedVehicle;
            this.userID = userID;

            LoadVehicleDetails();
        }

        // ============================================================
        // LOAD VEHICLE INFORMATION
        // ============================================================

        private void LoadVehicleDetails()
        {
            if (vehicle == null)
                return;

            lblCarName.Text =
                $"{vehicle.Brand} {vehicle.Model}";

            lblCarType.Text =
                vehicle.VehicleType;

            lblYear.Text =
                $"Year: {vehicle.Year}";

            lblPrice.Text =
                $"৳{vehicle.PricePerDay:N0} / day";

            lblStatus.Text =
                $"● {vehicle.AvailabilityStatus}";

            if (string.IsNullOrWhiteSpace(
                vehicle.Description))
            {
                lblDescription.Text =
                    "No description available.";
            }
            else
            {
                lblDescription.Text =
                    vehicle.Description;
            }

            LoadCarImage(vehicle.ImagePath);

            btnBookNow.Enabled =
                vehicle.AvailabilityStatus.Equals(
                    "Available",
                    StringComparison.OrdinalIgnoreCase);
        }

        // ============================================================
        // LOAD CAR IMAGE
        // ============================================================

        private void LoadCarImage(string imagePath)
        {
            try
            {
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
        // CLOSE BUTTON
        // ============================================================

        private void btnClose_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        // ============================================================
        // BACK BUTTON
        // ============================================================

        private void lblBack_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        // ============================================================
        // BOOK NOW
        // ============================================================

        private void btnBookNow_Click(
            object sender,
            EventArgs e)
        {
            if (vehicle == null)
            {
                MessageBox.Show(
                    "No vehicle has been selected.",
                    "Booking Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            BookingForm bookingForm =
                new BookingForm(
                    vehicle,
                    userID);

            bookingForm.ShowDialog();
        }

        // ============================================================
        // FORM CLOSED
        // ============================================================

        protected override void OnFormClosed(
            FormClosedEventArgs e)
        {
            if (picCar.Image != null)
            {
                picCar.Image.Dispose();
                picCar.Image = null;
            }

            base.OnFormClosed(e);
        }
    }
}