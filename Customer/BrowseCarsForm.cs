using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;
using CarRentalManagementSystem.Models;

namespace CarRentalManagementSystem.Customer
{
    public partial class BrowseCarsForm : Form
    {
        private int userID;

        private List<Vehicle> allVehicles =
            new List<Vehicle>();

        private List<Vehicle> filteredVehicles =
            new List<Vehicle>();

        public BrowseCarsForm(int userID)
        {
            InitializeComponent();

            this.userID = userID;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadCars();
        }

        private void LoadCars()
        {
            try
            {
                allVehicles = GetAvailableVehicles();

                // Show ALL available cars when the form opens.
                filteredVehicles =
                    new List<Vehicle>(allVehicles);

                DisplayCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load cars from the database.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private List<Vehicle> GetAvailableVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            using SqlConnection connection = new DatabaseHelper().GetConnection();
            connection.Open();

            string query = @"
                SELECT VehicleID, OwnerID, Brand, Model, Year, VehicleType, Seats,
                       PricePerDay, AvailabilityStatus, Description, ImagePath, Location,
                       TransmissionType, DriveType, CargoVolume
                FROM Vehicles
                WHERE AvailabilityStatus = 'Available'
                ORDER BY VehicleID";

            using SqlCommand command = new SqlCommand(query, connection);
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string vehicleType = reader["VehicleType"]?.ToString() ?? "";
                Vehicle vehicle = vehicleType.Trim() switch
                {
                    "Sedan" => new Sedan(),
                    "SUV" => new SUV(),
                    "Van" => new Van(),
                    "Luxury" => new Luxury(),
                    _ => throw new InvalidOperationException("Unknown vehicle type: " + vehicleType)
                };

                vehicle.VehicleID = Convert.ToInt32(reader["VehicleID"]);
                vehicle.OwnerID = Convert.ToInt32(reader["OwnerID"]);
                vehicle.Brand = reader["Brand"]?.ToString() ?? "";
                vehicle.Model = reader["Model"]?.ToString() ?? "";
                vehicle.Year = Convert.ToInt32(reader["Year"]);
                vehicle.VehicleType = vehicleType;
                vehicle.Seats = Convert.ToInt32(reader["Seats"]);
                vehicle.PricePerDay = Convert.ToDecimal(reader["PricePerDay"]);
                vehicle.AvailabilityStatus = reader["AvailabilityStatus"]?.ToString() ?? "";
                vehicle.Description = reader["Description"]?.ToString() ?? "";
                vehicle.ImagePath = reader["ImagePath"]?.ToString() ?? "";
                vehicle.Location = reader["Location"]?.ToString() ?? "";

                if (vehicle is Sedan sedan)
                    sedan.TransmissionType = reader["TransmissionType"]?.ToString() ?? "";
                else if (vehicle is SUV suv)
                    suv.DriveType = reader["DriveType"]?.ToString() ?? "";
                else if (vehicle is Van van && reader["CargoVolume"] != DBNull.Value)
                    van.CargoVolume = Convert.ToDecimal(reader["CargoVolume"]);

                vehicles.Add(vehicle);
            }

            return vehicles;
        }

        private void DisplayCars()
        {
            carsFlowPanel.Controls.Clear();

            if (filteredVehicles.Count == 0)
            {
                lblResults.Text = "0 cars found";

                Label noCars = new Label();

                noCars.Text =
                    "No cars match your selected filters.";

                noCars.Font =
                    new Font("Segoe UI", 12F);

                noCars.ForeColor =
                    Color.FromArgb(107, 114, 128);

                noCars.AutoSize = true;

                noCars.Margin =
                    new Padding(20, 30, 20, 20);

                carsFlowPanel.Controls.Add(noCars);

                return;
            }

            lblResults.Text =
                $"{filteredVehicles.Count} car(s) available";

            foreach (Vehicle vehicle in filteredVehicles)
            {
                Panel carCard =
                    CreateCarCard(vehicle);

                carsFlowPanel.Controls.Add(carCard);
            }

            carsFlowPanel.AutoScrollPosition =
                new Point(0, 0);
        }

        private Panel CreateCarCard(Vehicle vehicle)
        {
            Panel card = new Panel();

            card.BackColor = Color.White;

            card.BorderStyle =
                BorderStyle.FixedSingle;

            card.Width =
                carsFlowPanel.ClientSize.Width
                - SystemInformation.VerticalScrollBarWidth
                - 45;

            if (card.Width < 850)
            {
                card.Width = 850;
            }

            card.Height = 160;

            card.Margin =
                new Padding(5, 5, 5, 10);

            // IMAGE

            PictureBox picture =
                new PictureBox();

            picture.Location =
                new Point(12, 12);

            picture.Size =
                new Size(190, 134);

            picture.BackColor =
                Color.FromArgb(245, 247, 250);

            picture.SizeMode =
                PictureBoxSizeMode.Zoom;

            LoadCarImage(
                picture,
                vehicle.ImagePath);

            // CAR NAME

            Label name =
                new Label();

            name.AutoSize = false;

            name.Location =
                new Point(225, 17);

            name.Size =
                new Size(430, 30);

            name.Font =
                new Font(
                    "Segoe UI",
                    14F,
                    FontStyle.Bold);

            name.ForeColor =
                Color.FromArgb(31, 41, 55);

            name.Text =
                $"{vehicle.Brand} {vehicle.Model}";

            // TYPE / SEATS / YEAR

            Label information =
                new Label();

            information.AutoSize = false;

            information.Location =
                new Point(225, 53);

            information.Size =
                new Size(500, 25);

            information.Font =
                new Font(
                    "Segoe UI",
                    9.5F);

            information.ForeColor =
                Color.FromArgb(107, 114, 128);

            information.Text =
                $"{vehicle.VehicleType}  •  " +
                $"{vehicle.Seats} Seats  •  " +
                $"{vehicle.Year}";

            // LOCATION

            Label location =
                new Label();

            location.AutoSize = false;

            location.Location =
                new Point(225, 82);

            location.Size =
                new Size(400, 25);

            location.Font =
                new Font(
                    "Segoe UI",
                    9.5F);

            location.ForeColor =
                Color.FromArgb(75, 85, 99);

            location.Text =
                $"Location: {vehicle.Location}";

            // PRICE

            Label price =
                new Label();

            price.AutoSize = false;

            price.Location =
                new Point(225, 130);

            price.Size =
                new Size(250, 30);

            price.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            price.ForeColor =
                Color.FromArgb(37, 99, 235);

            price.Text =
                $"৳{vehicle.PricePerDay:N0} / day";


            
            // AVAILABILITY
            // ========================================================
            Label availability = new Label();

            availability.AutoSize = false;

            availability.Location =
                new Point(225, 107);

            availability.Size =
                new Size(200, 25);

            availability.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            availability.ForeColor =
                Color.FromArgb(22, 163, 74);

            availability.Text =
                "● Available";


            // VIEW DETAILS

            Button details =
                new Button();

            details.BackColor =
                Color.FromArgb(37, 99, 235);

            details.FlatAppearance.BorderSize =
                0;

            details.FlatStyle =
                FlatStyle.Flat;

            details.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            details.ForeColor =
                Color.White;

            details.Size =
                new Size(135, 40);

            details.Location =
                new Point(
                    card.Width - 160,
                    105);

            details.Text =
                "View Details";

            details.Cursor =
                Cursors.Hand;

            details.Tag =
                vehicle;

            details.Click +=
                ViewDetails_Click;

            // ADD CONTROLS

            card.Controls.Add(picture);
            card.Controls.Add(name);
            card.Controls.Add(information);
            card.Controls.Add(location);
            card.Controls.Add(availability);
            card.Controls.Add(price);
            card.Controls.Add(details);

            return card;
        }

        private void LoadCarImage(
            PictureBox pictureBox,
            string imagePath)
        {
            try
            {
                pictureBox.Image = null;

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
                        pictureBox.Image =
                            new Bitmap(originalImage);
                    }
                }
            }
            catch
            {
                pictureBox.Image = null;
            }
        }

        // SEARCH

        private void btnSearch_Click(
            object sender,
            EventArgs e)
        {
            ApplySearchAndFilters();
        }

        private void txtSearch_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplySearchAndFilters();

                e.SuppressKeyPress = true;
            }
        }

        // APPLY FILTERS

        private void btnApplyFilters_Click(
            object sender,
            EventArgs e)
        {
            ApplySearchAndFilters();
        }

        private void ApplySearchAndFilters()
        {
            IEnumerable<Vehicle> results =
                allVehicles;

            // Search by car name

            string searchText =
                txtSearch.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                results =
                    results.Where(v =>
                        v.Brand.Contains(
                            searchText,
                            StringComparison.OrdinalIgnoreCase)
                        ||
                        v.Model.Contains(
                            searchText,
                            StringComparison.OrdinalIgnoreCase));
            }

            // Brand

            string selectedBrand =
                cmbBrand.SelectedItem?.ToString()
                ?? "All Brands";

            if (selectedBrand != "All Brands")
            {
                results =
                    results.Where(v =>
                        v.Brand.Equals(
                            selectedBrand,
                            StringComparison.OrdinalIgnoreCase));
            }

            // Vehicle Type

            string selectedType =
                cmbVehicleType.SelectedItem?.ToString()
                ?? "All Types";

            if (selectedType != "All Types")
            {
                results =
                    results.Where(v =>
                        v.VehicleType.Equals(
                            selectedType,
                            StringComparison.OrdinalIgnoreCase));
            }

            // Seats

            string selectedSeats =
                cmbSeats.SelectedItem?.ToString()
                ?? "All Seats";

            if (selectedSeats != "All Seats")
            {
                int seats =
                    ExtractNumber(selectedSeats);

                results =
                    results.Where(v =>
                        v.Seats == seats);
            }

            // Maximum Price

            string selectedPrice =
                cmbMaxPrice.SelectedItem?.ToString()
                ?? "Any Price";

            decimal? maximumPrice =
                GetMaximumPrice(selectedPrice);

            if (maximumPrice.HasValue)
            {
                results =
                    results.Where(v =>
                        v.PricePerDay <=
                        maximumPrice.Value);
            }

            // Location

            string selectedLocation =
                cmbLocation.SelectedItem?.ToString()
                ?? "All Locations";

            if (selectedLocation != "All Locations")
            {
                results =
                    results.Where(v =>
                        v.Location.Equals(
                            selectedLocation,
                            StringComparison.OrdinalIgnoreCase));
            }

            filteredVehicles =
                results.ToList();

            DisplayCars();
        }

        // SEAT NUMBER

        private int ExtractNumber(string text)
        {
            string number = "";

            foreach (char character in text)
            {
                if (char.IsDigit(character))
                {
                    number += character;
                }
            }

            if (int.TryParse(
                number,
                out int result))
            {
                return result;
            }

            return 0;
        }

        // PRICE

        private decimal? GetMaximumPrice(
            string option)
        {
            switch (option)
            {
                case "Under ৳3,000":
                    return 3000;

                case "Under ৳5,000":
                    return 5000;

                case "Under ৳7,000":
                    return 7000;

                case "Under ৳10,000":
                    return 10000;

                case "Under ৳15,000":
                    return 15000;

                default:
                    return null;
            }
        }

        // RESET FILTERS

        private void btnResetFilters_Click(
            object sender,
            EventArgs e)
        {
            txtSearch.Clear();

            cmbBrand.SelectedIndex = 0;

            cmbVehicleType.SelectedIndex = 0;

            cmbSeats.SelectedIndex = 0;

            cmbMaxPrice.SelectedIndex = 0;

            cmbLocation.SelectedIndex = 0;

            filteredVehicles =
                new List<Vehicle>(
                    allVehicles);

            DisplayCars();
        }

        // VIEW DETAILS

        private void ViewDetails_Click(
            object sender,
            EventArgs e)
        {
            Button button =
                sender as Button;

            if (button == null)
            {
                return;
            }

            Vehicle vehicle =
                button.Tag as Vehicle;

            if (vehicle == null)
            {
                return;
            }

            CarDetailsForm detailsForm =
                new CarDetailsForm(
                    vehicle,
                    userID);

            detailsForm.ShowDialog();
        }

        // BACK

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}