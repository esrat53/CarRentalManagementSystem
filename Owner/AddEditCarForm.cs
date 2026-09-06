using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;
using CarRentalManagementSystem.Models;

namespace CarRentalManagementSystem.Owner
{
    public partial class AddEditCarForm : Form
    {
        private readonly int ownerID;
        private readonly int? vehicleID;

        private string selectedImagePath = "";
        private Vehicle? loadedVehicle;

        // ============================================================
        // ADD NEW CAR CONSTRUCTOR
        // ============================================================
        public AddEditCarForm(int ownerID)
        {
            InitializeComponent();

            this.ownerID = ownerID;
            this.vehicleID = null;

            // ADD MODE
            lblPageTitle.Text = "Add New Car";
            lblSubtitle.Text = "Add a new vehicle to your fleet.";

            SetDefaultValues();
            UpdateSubtypeControls();
        }

        // ============================================================
        // EDIT CAR CONSTRUCTOR
        // ============================================================
        public AddEditCarForm(int ownerID, int vehicleID)
        {
            InitializeComponent();

            this.ownerID = ownerID;
            this.vehicleID = vehicleID;

            // EDIT MODE
            lblPageTitle.Text = "Edit Car";
            lblSubtitle.Text = "Update your vehicle information.";

            // Load the selected car immediately
            LoadVehicle();
            UpdateSubtypeControls();
        }

        // ============================================================
        // DEFAULT VALUES FOR ADD MODE
        // ============================================================
        private void SetDefaultValues()
        {
            if (cmbVehicleType.Items.Count > 0)
            {
                cmbVehicleType.SelectedIndex = 0;
            }

            if (cmbStatus.Items.Count > 0)
            {
                cmbStatus.SelectedIndex = 0;
            }

            // Make sure year is valid for the NumericUpDown
            int currentYear = DateTime.Today.Year;

            if (currentYear >= nudYear.Minimum &&
                currentYear <= nudYear.Maximum)
            {
                nudYear.Value = currentYear;
            }

            if (5 >= nudSeats.Minimum &&
                5 <= nudSeats.Maximum)
            {
                nudSeats.Value = 5;
            }
        }

        // ============================================================
        // FORM LOAD
        // ============================================================
        private void AddEditCarForm_Load(
            object sender,
            EventArgs e)
        {
            /*
             * The constructor already handles Add/Edit mode.
             *
             * This method is intentionally kept because the Designer
             * may already contain a Load event connected to it.
             *
             * We do not load the vehicle here again because the
             * constructor already loaded it.
             */
        }

        // ============================================================
        // LOAD VEHICLE FOR EDITING
        // ============================================================
        private void LoadVehicle()
        {
            try
            {
                using SqlConnection connection =
                    new DatabaseHelper().GetConnection();

                connection.Open();

                string query = @"
                    SELECT
                        Brand, Model, Year, VehicleType, Seats,
                        PricePerDay, AvailabilityStatus, Description,
                        ImagePath, Location, TransmissionType, DriveType, CargoVolume
                    FROM Vehicles
                    WHERE VehicleID = @VehicleID
                      AND OwnerID = @OwnerID";

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@VehicleID", vehicleID!.Value);
                command.Parameters.AddWithValue("@OwnerID", ownerID);

                using SqlDataReader reader = command.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show(
                        "Vehicle not found.", "Edit Car",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                    return;
                }

                string vehicleType = reader["VehicleType"]?.ToString() ?? "";
                Vehicle vehicle = CreateVehicleByType(vehicleType);

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

                loadedVehicle = vehicle;

                txtBrand.Text = vehicle.Brand;
                txtModel.Text = vehicle.Model;
                if (vehicle.Year >= nudYear.Minimum && vehicle.Year <= nudYear.Maximum)
                    nudYear.Value = vehicle.Year;

                int typeIndex = cmbVehicleType.Items.IndexOf(vehicle.VehicleType);
                if (typeIndex >= 0) cmbVehicleType.SelectedIndex = typeIndex;

                if (vehicle is Sedan loadedSedan)
                    cmbTransmission.Text = loadedSedan.TransmissionType;
                else if (vehicle is SUV loadedSuv)
                    cmbDriveType.Text = loadedSuv.DriveType;
                else if (vehicle is Van loadedVan)
                    txtCargoVolume.Text = loadedVan.CargoVolume > 0 ? loadedVan.CargoVolume.ToString("0.##") : "";

                UpdateSubtypeControls();

                if (vehicle.Seats >= nudSeats.Minimum && vehicle.Seats <= nudSeats.Maximum)
                    nudSeats.Value = vehicle.Seats;

                txtPrice.Text = vehicle.PricePerDay.ToString("0.##");

                int statusIndex = cmbStatus.Items.IndexOf(vehicle.AvailabilityStatus);
                if (statusIndex >= 0) cmbStatus.SelectedIndex = statusIndex;

                txtLocation.Text = vehicle.Location;
                txtDescription.Text = vehicle.Description;
                selectedImagePath = vehicle.ImagePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load vehicle:\n\n" + ex.Message,
                    "Edit Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadImagePreview(selectedImagePath);
        }

        private Vehicle CreateVehicleByType(string vehicleType)
        {
            return vehicleType.Trim() switch
            {
                "Sedan" => new Sedan(),
                "SUV" => new SUV(),
                "Van" => new Van(),
                "Luxury" => new Luxury(),
                _ => throw new InvalidOperationException("Unknown vehicle type: " + vehicleType)
            };
        }

        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSubtypeControls();
        }

        private void UpdateSubtypeControls()
        {
            string type = cmbVehicleType.Text.Trim();

            lblTransmission.Visible = type == "Sedan";
            cmbTransmission.Visible = type == "Sedan";

            lblDriveType.Visible = type == "SUV";
            cmbDriveType.Visible = type == "SUV";

            lblCargoVolume.Visible = type == "Van";
            txtCargoVolume.Visible = type == "Van";
        }

        // ============================================================
        // CHOOSE IMAGE
        // ============================================================
        private void btnChooseImage_Click(
            object sender,
            EventArgs e)
        {
            using (OpenFileDialog dialog =
                   new OpenFileDialog())
            {
                dialog.Title = "Select Car Image";

                dialog.Filter =
                    "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                dialog.Multiselect = false;

                if (dialog.ShowDialog() ==
                    DialogResult.OK)
                {
                    selectedImagePath =
                        dialog.FileName;

                    LoadImagePreview(
                        selectedImagePath);
                }
            }
        }

        // ============================================================
        // LOAD IMAGE PREVIEW
        // ============================================================
        private void LoadImagePreview(
            string imagePath)
        {
            try
            {
                // Dispose previous image
                if (picCar.Image != null)
                {
                    picCar.Image.Dispose();
                    picCar.Image = null;
                }

                if (string.IsNullOrWhiteSpace(imagePath))
                {
                    return;
                }

                string fullPath =
                    imagePath;

                // If database contains:
                // Images/ToyotaPremio.jpg
                //
                // convert it to:
                // bin\Debug\net10.0-windows\Images\ToyotaPremio.jpg
                if (!Path.IsPathRooted(fullPath))
                {
                    fullPath =
                        Path.Combine(
                            AppContext.BaseDirectory,
                            imagePath.Replace(
                                "/",
                                Path.DirectorySeparatorChar.ToString()));
                }

                if (!File.Exists(fullPath))
                {
                    return;
                }

                // Load a COPY of the image so the file
                // does not remain locked.
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
        // PREPARE IMAGE PATH
        // ============================================================
        private string PrepareImagePath()
        {
            if (string.IsNullOrWhiteSpace(
                selectedImagePath))
            {
                return "";
            }

            string imagesFolder =
                Path.Combine(
                    AppContext.BaseDirectory,
                    "Images");

            Directory.CreateDirectory(
                imagesFolder);

            string fileName =
                Path.GetFileName(
                    selectedImagePath);

            string destination =
                Path.Combine(
                    imagesFolder,
                    fileName);

            string sourceFullPath =
                Path.GetFullPath(
                    selectedImagePath);

            string destinationFullPath =
                Path.GetFullPath(
                    destination);

            if (!sourceFullPath.Equals(
                destinationFullPath,
                StringComparison.OrdinalIgnoreCase))
            {
                File.Copy(
                    sourceFullPath,
                    destinationFullPath,
                    true);
            }

            return "Images/" + fileName;
        }

        // ============================================================
        // VALIDATE FORM
        // ============================================================
        private bool ValidateForm()
        {
            // BRAND
            if (string.IsNullOrWhiteSpace(
                txtBrand.Text))
            {
                MessageBox.Show(
                    "Please enter the car brand.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBrand.Focus();

                return false;
            }

            // MODEL
            if (string.IsNullOrWhiteSpace(
                txtModel.Text))
            {
                MessageBox.Show(
                    "Please enter the car model.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtModel.Focus();

                return false;
            }

            // PRICE
            if (string.IsNullOrWhiteSpace(
                txtPrice.Text))
            {
                MessageBox.Show(
                    "Please enter the price per day.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrice.Focus();

                return false;
            }

            if (!decimal.TryParse(
                txtPrice.Text.Trim(),
                out decimal price)
                || price <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid price.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrice.Focus();

                return false;
            }

            // SUBTYPE-SPECIFIC FIELDS
            if (cmbVehicleType.Text == "Sedan" && string.IsNullOrWhiteSpace(cmbTransmission.Text))
            {
                MessageBox.Show("Please select the transmission type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTransmission.Focus();
                return false;
            }

            if (cmbVehicleType.Text == "SUV" && string.IsNullOrWhiteSpace(cmbDriveType.Text))
            {
                MessageBox.Show("Please select the drive type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDriveType.Focus();
                return false;
            }

            if (cmbVehicleType.Text == "Van")
            {
                if (string.IsNullOrWhiteSpace(txtCargoVolume.Text) ||
                    !decimal.TryParse(txtCargoVolume.Text.Trim(), out decimal cargoVolume) || cargoVolume <= 0)
                {
                    MessageBox.Show("Please enter a valid cargo volume.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCargoVolume.Focus();
                    return false;
                }
            }

            // LOCATION
            if (string.IsNullOrWhiteSpace(
                txtLocation.Text))
            {
                MessageBox.Show(
                    "Please enter the car location.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtLocation.Focus();

                return false;
            }

            return true;
        }

        // ============================================================
        // SAVE CAR
        // ============================================================
        private void btnSave_Click(
            object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                string imagePath = PrepareImagePath();
                Vehicle vehicle = CreateVehicleFromForm(imagePath);

                using SqlConnection connection =
                    new DatabaseHelper().GetConnection();
                connection.Open();

                if (vehicleID.HasValue)
                {
                    string updateQuery = @"
                        UPDATE Vehicles
                        SET Brand=@Brand, Model=@Model, Year=@Year,
                            VehicleType=@VehicleType, Seats=@Seats,
                            PricePerDay=@PricePerDay, AvailabilityStatus=@AvailabilityStatus,
                            Description=@Description, ImagePath=@ImagePath, Location=@Location,
                            TransmissionType=@TransmissionType, DriveType=@DriveType, CargoVolume=@CargoVolume
                        WHERE VehicleID=@VehicleID AND OwnerID=@OwnerID";

                    using SqlCommand command = new SqlCommand(updateQuery, connection);
                    AddVehicleParameters(command, vehicle);
                    command.Parameters.AddWithValue("@VehicleID", vehicleID.Value);
                    command.Parameters.AddWithValue("@OwnerID", ownerID);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Car updated successfully.", "Car Updated",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Car could not be updated.", "Update Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    string insertQuery = @"
                        INSERT INTO Vehicles
                        (OwnerID, Brand, Model, Year, VehicleType, Seats, PricePerDay,
                         AvailabilityStatus, Description, ImagePath, Location,
                         TransmissionType, DriveType, CargoVolume)
                        VALUES
                        (@OwnerID, @Brand, @Model, @Year, @VehicleType, @Seats, @PricePerDay,
                         @AvailabilityStatus, @Description, @ImagePath, @Location,
                         @TransmissionType, @DriveType, @CargoVolume)";

                    using SqlCommand command = new SqlCommand(insertQuery, connection);
                    AddVehicleParameters(command, vehicle);
                    command.Parameters.AddWithValue("@OwnerID", ownerID);
                    command.ExecuteNonQuery();

                    MessageBox.Show("New car added successfully.", "Car Added",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error:\n\n" + ex.Message, "Save Car",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the car:\n\n" + ex.Message, "Save Car",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Vehicle CreateVehicleFromForm(string imagePath)
        {
            string brand = txtBrand.Text.Trim();
            string model = txtModel.Text.Trim();
            int year = (int)nudYear.Value;
            string vehicleType = cmbVehicleType.Text.Trim();
            int seats = (int)nudSeats.Value;
            decimal pricePerDay = decimal.Parse(txtPrice.Text.Trim());
            string availabilityStatus = cmbStatus.Text.Trim();
            string description = txtDescription.Text.Trim();
            string location = txtLocation.Text.Trim();

            Vehicle vehicle = CreateVehicleByType(vehicleType);

            vehicle.VehicleID = vehicleID ?? 0;
            vehicle.OwnerID = ownerID;
            vehicle.Brand = brand;
            vehicle.Model = model;
            vehicle.Year = year;
            vehicle.VehicleType = vehicleType;
            vehicle.Seats = seats;
            vehicle.PricePerDay = pricePerDay;
            vehicle.AvailabilityStatus = availabilityStatus;
            vehicle.Description = description;
            vehicle.ImagePath = imagePath;
            vehicle.Location = location;

            // Store the subtype-specific values entered by the owner.
            if (vehicle is Sedan sedan)
                sedan.TransmissionType = cmbTransmission.Text.Trim();
            else if (vehicle is SUV suv)
                suv.DriveType = cmbDriveType.Text.Trim();
            else if (vehicle is Van van)
                van.CargoVolume = decimal.Parse(txtCargoVolume.Text.Trim());

            return vehicle;
        }

        private void AddVehicleParameters(SqlCommand command, Vehicle vehicle)
        {
            command.Parameters.AddWithValue("@Brand", vehicle.Brand);
            command.Parameters.AddWithValue("@Model", vehicle.Model);
            command.Parameters.AddWithValue("@Year", vehicle.Year);
            command.Parameters.AddWithValue("@VehicleType", vehicle.VehicleType);
            command.Parameters.AddWithValue("@Seats", vehicle.Seats);
            command.Parameters.AddWithValue("@PricePerDay", vehicle.PricePerDay);
            command.Parameters.AddWithValue("@AvailabilityStatus", vehicle.AvailabilityStatus);
            command.Parameters.AddWithValue("@Description", vehicle.Description);
            command.Parameters.AddWithValue("@ImagePath", vehicle.ImagePath);
            command.Parameters.AddWithValue("@Location", vehicle.Location);
            command.Parameters.AddWithValue("@TransmissionType",
                vehicle is Sedan sedan ? sedan.TransmissionType : (object)DBNull.Value);
            command.Parameters.AddWithValue("@DriveType",
                vehicle is SUV suv ? suv.DriveType : (object)DBNull.Value);
            command.Parameters.AddWithValue("@CargoVolume",
                vehicle is Van van ? van.CargoVolume : (object)DBNull.Value);
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
        // DISPOSE IMAGE WHEN FORM CLOSES
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