using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;

namespace CarRentalManagementSystem.Admin
{
    public partial class ManageAllCarsForm : Form
    {
        public ManageAllCarsForm()
        {
            InitializeComponent();
            LoadCars();
        }

        private void LoadCars()
        {
            try
            {
                using SqlConnection connection = new DatabaseHelper().GetConnection();
                connection.Open();

                string query = @"
                    SELECT v.VehicleID AS [ID], v.Brand, v.Model, v.Year,
                           v.VehicleType AS [Type], v.Seats,
                           v.PricePerDay AS [Price/Day],
                           v.AvailabilityStatus AS [Status],
                           u.FullName AS [Owner], v.Location
                    FROM Vehicles v
                    LEFT JOIN Users u ON v.OwnerID = u.UserID
                    ORDER BY v.VehicleID DESC";

                using SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCars.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load cars.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterCars(object sender, EventArgs e)
        {
            if (dgvCars.DataSource is not DataTable table)
                return;

            string search = txtSearch.Text.Trim().Replace("'", "''");
            string selectedType = cmbType.SelectedItem?.ToString() ?? "All";
            string filter = "";

            if (search.Length > 0)
                filter = $"Brand LIKE '%{search}%' OR Model LIKE '%{search}%' OR Owner LIKE '%{search}%'";

            if (selectedType != "All")
            {
                if (filter.Length > 0)
                    filter += " AND ";

                filter += $"Type = '{selectedType}'";
            }

            table.DefaultView.RowFilter = filter;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a car first.");
                return;
            }

            int vehicleID = Convert.ToInt32(dgvCars.SelectedRows[0].Cells["ID"].Value);

            try
            {
                using SqlConnection connection = new DatabaseHelper().GetConnection();
                connection.Open();

                using SqlCommand command = new SqlCommand(
                    "SELECT OwnerID FROM Vehicles WHERE VehicleID = @VehicleID",
                    connection);

                command.Parameters.AddWithValue("@VehicleID", vehicleID);

                object result = command.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Vehicle not found.");
                    return;
                }

                int ownerID = Convert.ToInt32(result);

                using CarRentalManagementSystem.Owner.AddEditCarForm form =
                    new CarRentalManagementSystem.Owner.AddEditCarForm(ownerID, vehicleID);

                form.ShowDialog();
                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not edit car.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a car first.");
                return;
            }

            int vehicleID = Convert.ToInt32(dgvCars.SelectedRows[0].Cells["ID"].Value);

            if (MessageBox.Show(
                "Delete this car?\n\nIt cannot be deleted if it has bookings.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                using SqlConnection connection = new DatabaseHelper().GetConnection();
                connection.Open();

                using SqlCommand check = new SqlCommand(
                    "SELECT COUNT(*) FROM Bookings WHERE VehicleID = @VehicleID",
                    connection);

                check.Parameters.AddWithValue("@VehicleID", vehicleID);

                if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                {
                    MessageBox.Show(
                        "This car cannot be deleted because it has existing bookings.",
                        "Cannot Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                using SqlCommand delete = new SqlCommand(
                    "DELETE FROM Vehicles WHERE VehicleID = @VehicleID",
                    connection);

                delete.Parameters.AddWithValue("@VehicleID", vehicleID);
                delete.ExecuteNonQuery();

                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete car.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
