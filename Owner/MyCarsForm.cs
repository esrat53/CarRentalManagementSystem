using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using CarRentalManagementSystem.Database;

namespace CarRentalManagementSystem.Owner
{
    public partial class MyCarsForm : Form
    {
        private int ownerID;
        private DatabaseHelper db = new DatabaseHelper();

        public MyCarsForm(int ownerID)
        {
            InitializeComponent();

            this.ownerID = ownerID;
        }

        private void MyCarsForm_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void LoadCars()
        {
            try
            {
                using (SqlConnection con = db.GetConnection())
                {
                    con.Open();

                    string query = @"
                        SELECT 
                            VehicleID,
                            Brand,
                            Model,
                            VehicleType,
                            Year,
                            Seats,
                            Location,
                            PricePerDay,
                            AvailabilityStatus
                        FROM Vehicles
                        WHERE OwnerID = @OwnerID
                        ORDER BY VehicleID DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@OwnerID", ownerID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            dgvCars.DataSource = table;

                            if (dgvCars.Columns.Count > 0)
                            {
                                dgvCars.Columns["VehicleID"].HeaderText = "ID";
                                dgvCars.Columns["Brand"].HeaderText = "Brand";
                                dgvCars.Columns["Model"].HeaderText = "Model";
                                dgvCars.Columns["VehicleType"].HeaderText = "Type";
                                dgvCars.Columns["Year"].HeaderText = "Year";
                                dgvCars.Columns["Seats"].HeaderText = "Seats";
                                dgvCars.Columns["Location"].HeaderText = "Location";
                                dgvCars.Columns["PricePerDay"].HeaderText = "Price / Day";
                                dgvCars.Columns["AvailabilityStatus"].HeaderText = "Status";
                            }

                            lblResults.Text = table.Rows.Count + " vehicle(s)";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load cars.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddEditCarForm form = new AddEditCarForm(ownerID);

            form.ShowDialog();

            LoadCars();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Make sure a car is selected
            if (dgvCars.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a car first.",
                    "Edit Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                // Get VehicleID from the selected row
                int vehicleID = Convert.ToInt32(
                    dgvCars.CurrentRow.Cells["VehicleID"].Value
                );

                // IMPORTANT:
                // Use the constructor that receives BOTH ownerID and vehicleID.
                AddEditCarForm form =
                    new AddEditCarForm(ownerID, vehicleID);

                form.ShowDialog();

                // Reload after editing
                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not edit the selected car.\n\n" + ex.Message,
                    "Edit Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCars.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a car first.",
                    "Remove Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int vehicleID = Convert.ToInt32(
                dgvCars.CurrentRow.Cells["VehicleID"].Value
            );

            string brand =
                dgvCars.CurrentRow.Cells["Brand"].Value?.ToString() ?? "";

            string model =
                dgvCars.CurrentRow.Cells["Model"].Value?.ToString() ?? "";

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to remove {brand} {model}?",
                "Remove Car",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection con = db.GetConnection())
                {
                    con.Open();

                    // Check whether this car has bookings
                    string checkQuery = @"
                        SELECT COUNT(*)
                        FROM Bookings
                        WHERE VehicleID = @VehicleID";

                    using (SqlCommand checkCmd =
                        new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue(
                            "@VehicleID", vehicleID);

                        int bookingCount =
                            Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (bookingCount > 0)
                        {
                            MessageBox.Show(
                                "This car has booking records and cannot be deleted.\n\n" +
                                "You can edit the car and change its status to Inactive instead.",
                                "Cannot Remove Car",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }

                    string deleteQuery = @"
                        DELETE FROM Vehicles
                        WHERE VehicleID = @VehicleID
                        AND OwnerID = @OwnerID";

                    using (SqlCommand deleteCmd =
                        new SqlCommand(deleteQuery, con))
                    {
                        deleteCmd.Parameters.AddWithValue(
                            "@VehicleID", vehicleID);

                        deleteCmd.Parameters.AddWithValue(
                            "@OwnerID", ownerID);

                        deleteCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Car removed successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not remove the car.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            btnRemove_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;

            if (cmbVehicleType.Items.Count > 0)
                cmbVehicleType.SelectedIndex = 0;

            LoadCars();
        }

    }
}