namespace CarRentalManagementSystem.Owner
{
    partial class MyCarsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnRemoveCar;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.DataGridView dgvCars;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            headerPanel = new Panel();
            btnBack = new Button();
            lblPageTitle = new Label();
            lblSubtitle = new Label();
            contentPanel = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            cmbStatus = new ComboBox();
            cmbVehicleType = new ComboBox();
            btnReset = new Button();
            btnAddCar = new Button();
            btnEditCar = new Button();
            btnRemoveCar = new Button();
            lblResults = new Label();
            dgvCars = new DataGridView();
            headerPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(24, 34, 54);
            headerPanel.Controls.Add(btnBack);
            headerPanel.Controls.Add(lblPageTitle);
            headerPanel.Controls.Add(lblSubtitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 4, 3, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1103, 113);
            headerPanel.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 13);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 47);
            btnBack.TabIndex = 0;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(448, 7);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(141, 45);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "My Cars";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(423, 52);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(204, 20);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Manage the vehicles you own";
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(246, 248, 251);
            contentPanel.Controls.Add(lblSearch);
            contentPanel.Controls.Add(txtSearch);
            contentPanel.Controls.Add(btnSearch);
            contentPanel.Controls.Add(cmbStatus);
            contentPanel.Controls.Add(cmbVehicleType);
            contentPanel.Controls.Add(btnReset);
            contentPanel.Controls.Add(btnAddCar);
            contentPanel.Controls.Add(btnEditCar);
            contentPanel.Controls.Add(btnRemoveCar);
            contentPanel.Controls.Add(lblResults);
            contentPanel.Controls.Add(dgvCars);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 113);
            contentPanel.Margin = new Padding(3, 4, 3, 4);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(34, 40, 34, 40);
            contentPanel.Size = new Size(1103, 714);
            contentPanel.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(55, 65, 81);
            lblSearch.Location = new Point(34, 33);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(55, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(34, 67);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(377, 30);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(37, 99, 235);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(423, 64);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(114, 45);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.Items.AddRange(new object[] { "All Status", "Available", "Maintenance", "Inactive" });
            cmbStatus.Location = new Point(560, 67);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(165, 29);
            cmbStatus.TabIndex = 3;
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicleType.Font = new Font("Segoe UI", 9.5F);
            cmbVehicleType.Items.AddRange(new object[] { "All Types", "Sedan", "SUV", "Van", "Luxury" });
            cmbVehicleType.Location = new Point(743, 67);
            cmbVehicleType.Margin = new Padding(3, 4, 3, 4);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(159, 29);
            cmbVehicleType.TabIndex = 4;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReset.ForeColor = Color.FromArgb(75, 85, 99);
            btnReset.Location = new Point(920, 64);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(114, 45);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnAddCar
            // 
            btnAddCar.BackColor = Color.FromArgb(16, 185, 129);
            btnAddCar.FlatAppearance.BorderSize = 0;
            btnAddCar.FlatStyle = FlatStyle.Flat;
            btnAddCar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddCar.ForeColor = Color.White;
            btnAddCar.Location = new Point(34, 140);
            btnAddCar.Margin = new Padding(3, 4, 3, 4);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(149, 53);
            btnAddCar.TabIndex = 6;
            btnAddCar.Text = "+ Add New Car";
            btnAddCar.UseVisualStyleBackColor = false;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // btnEditCar
            // 
            btnEditCar.BackColor = Color.FromArgb(37, 99, 235);
            btnEditCar.FlatAppearance.BorderSize = 0;
            btnEditCar.FlatStyle = FlatStyle.Flat;
            btnEditCar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditCar.ForeColor = Color.White;
            btnEditCar.Location = new Point(194, 140);
            btnEditCar.Margin = new Padding(3, 4, 3, 4);
            btnEditCar.Name = "btnEditCar";
            btnEditCar.Size = new Size(120, 53);
            btnEditCar.TabIndex = 7;
            btnEditCar.Text = "Edit";
            btnEditCar.UseVisualStyleBackColor = false;
            btnEditCar.Click += btnEditCar_Click;
            // 
            // btnRemoveCar
            // 
            btnRemoveCar.BackColor = Color.FromArgb(239, 68, 68);
            btnRemoveCar.FlatAppearance.BorderSize = 0;
            btnRemoveCar.FlatStyle = FlatStyle.Flat;
            btnRemoveCar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemoveCar.ForeColor = Color.White;
            btnRemoveCar.Location = new Point(326, 140);
            btnRemoveCar.Margin = new Padding(3, 4, 3, 4);
            btnRemoveCar.Name = "btnRemoveCar";
            btnRemoveCar.Size = new Size(120, 53);
            btnRemoveCar.TabIndex = 8;
            btnRemoveCar.Text = "Remove";
            btnRemoveCar.UseVisualStyleBackColor = false;
            btnRemoveCar.Click += btnRemoveCar_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblResults.ForeColor = Color.FromArgb(107, 114, 128);
            lblResults.Location = new Point(869, 157);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(89, 20);
            lblResults.TabIndex = 9;
            lblResults.Text = "0 vehicle(s)";
            // 
            // dgvCars
            // 
            dgvCars.AllowUserToAddRows = false;
            dgvCars.AllowUserToDeleteRows = false;
            dgvCars.AllowUserToResizeRows = false;
            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCars.BackgroundColor = Color.White;
            dgvCars.BorderStyle = BorderStyle.None;
            dgvCars.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCars.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCars.ColumnHeadersHeight = 40;
            dgvCars.EnableHeadersVisualStyles = false;
            dgvCars.GridColor = Color.FromArgb(230, 233, 238);
            dgvCars.Location = new Point(34, 213);
            dgvCars.Margin = new Padding(3, 4, 3, 4);
            dgvCars.MultiSelect = false;
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.RowHeadersVisible = false;
            dgvCars.RowHeadersWidth = 51;
            dgvCars.RowTemplate.Height = 40;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.Size = new Size(1000, 471);
            dgvCars.TabIndex = 10;
            // 
            // MyCarsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 248, 251);
            ClientSize = new Size(1103, 827);
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MyCarsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Cars - Car Rental Management System";
            Load += MyCarsForm_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
        }
    }
}