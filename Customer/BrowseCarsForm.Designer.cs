using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customer
{
    partial class BrowseCarsForm
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private Panel headerPanel;
        private Button btnBack;
        private Label lblPageTitle;
        private Label lblSubtitle;
        private Label lblCustomer;

        // Filter panel
        private Panel filterPanel;
        private Label lblFilterTitle;

        private Label lblBrand;
        private ComboBox cmbBrand;

        private Label lblVehicleType;
        private ComboBox cmbVehicleType;

        private Label lblSeats;
        private ComboBox cmbSeats;

        private Label lblMaxPrice;
        private ComboBox cmbMaxPrice;

        private Label lblLocation;
        private ComboBox cmbLocation;

        private Button btnApplyFilters;
        private Button btnResetFilters;

        // Search
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;

        // Results
        private Label lblResults;

        // Cars
        private Panel carsContainer;
        private FlowLayoutPanel carsFlowPanel;


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
            headerPanel = new Panel();
            btnBack = new Button();
            lblPageTitle = new Label();
            lblSubtitle = new Label();
            lblCustomer = new Label();
            filterPanel = new Panel();
            lblFilterTitle = new Label();
            lblBrand = new Label();
            cmbBrand = new ComboBox();
            lblVehicleType = new Label();
            cmbVehicleType = new ComboBox();
            lblSeats = new Label();
            cmbSeats = new ComboBox();
            lblMaxPrice = new Label();
            cmbMaxPrice = new ComboBox();
            lblLocation = new Label();
            cmbLocation = new ComboBox();
            btnApplyFilters = new Button();
            btnResetFilters = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblResults = new Label();
            carsContainer = new Panel();
            carsFlowPanel = new FlowLayoutPanel();
            headerPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            carsContainer.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(24, 34, 54);
            headerPanel.Controls.Add(lblPageTitle);
            headerPanel.Controls.Add(btnBack);
            headerPanel.Controls.Add(lblSubtitle);
            headerPanel.Controls.Add(lblCustomer);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 4, 3, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(23, 0, 23, 0);
            headerPanel.Size = new Size(1567, 91);
            headerPanel.TabIndex = 12;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(24, 32, 48);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1, 0);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(109, 51);
            btnBack.TabIndex = 0;
            btnBack.Text = "←  Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(644, 0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(214, 46);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Browse Cars";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(644, 51);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(260, 21);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Find the perfect car for your journey";
            // 
            // lblCustomer
            // 
            lblCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCustomer.ForeColor = Color.FromArgb(75, 85, 99);
            lblCustomer.Location = new Point(2664, 41);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(87, 23);
            lblCustomer.TabIndex = 3;
            lblCustomer.Text = "Customer";
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.WhiteSmoke;
            filterPanel.BorderStyle = BorderStyle.FixedSingle;
            filterPanel.Controls.Add(lblFilterTitle);
            filterPanel.Controls.Add(lblBrand);
            filterPanel.Controls.Add(cmbBrand);
            filterPanel.Controls.Add(lblVehicleType);
            filterPanel.Controls.Add(cmbVehicleType);
            filterPanel.Controls.Add(lblSeats);
            filterPanel.Controls.Add(cmbSeats);
            filterPanel.Controls.Add(lblMaxPrice);
            filterPanel.Controls.Add(cmbMaxPrice);
            filterPanel.Controls.Add(lblLocation);
            filterPanel.Controls.Add(cmbLocation);
            filterPanel.Controls.Add(btnApplyFilters);
            filterPanel.Controls.Add(btnResetFilters);
            filterPanel.Location = new Point(28, 99);
            filterPanel.Margin = new Padding(3, 4, 3, 4);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(320, 890);
            filterPanel.TabIndex = 11;
            // 
            // lblFilterTitle
            // 
            lblFilterTitle.AutoSize = true;
            lblFilterTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblFilterTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblFilterTitle.Location = new Point(25, 24);
            lblFilterTitle.Name = "lblFilterTitle";
            lblFilterTitle.Size = new Size(133, 35);
            lblFilterTitle.TabIndex = 0;
            lblFilterTitle.Text = "Filter Cars";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(55, 65, 81);
            lblBrand.Location = new Point(25, 89);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(55, 21);
            lblBrand.TabIndex = 1;
            lblBrand.Text = "Brand";
            // 
            // cmbBrand
            // 
            cmbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrand.Font = new Font("Segoe UI", 10F);
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Items.AddRange(new object[] { "All Brands", "Toyota", "BMW", "Tata", "Honda", "Nissan", "Mitsubishi", "Hyundai", "Ford", "Mercedes-Benz" });
            cmbBrand.Location = new Point(25, 121);
            cmbBrand.Margin = new Padding(3, 4, 3, 4);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(265, 31);
            cmbBrand.TabIndex = 1;
            // 
            // lblVehicleType
            // 
            lblVehicleType.AutoSize = true;
            lblVehicleType.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblVehicleType.ForeColor = Color.FromArgb(55, 65, 81);
            lblVehicleType.Location = new Point(25, 185);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(106, 21);
            lblVehicleType.TabIndex = 2;
            lblVehicleType.Text = "Vehicle Type";
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicleType.Font = new Font("Segoe UI", 10F);
            cmbVehicleType.FormattingEnabled = true;
            cmbVehicleType.Items.AddRange(new object[] { "All Types", "Sedan", "SUV", "Van" });
            cmbVehicleType.Location = new Point(25, 217);
            cmbVehicleType.Margin = new Padding(3, 4, 3, 4);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(265, 31);
            cmbVehicleType.TabIndex = 2;
            // 
            // lblSeats
            // 
            lblSeats.AutoSize = true;
            lblSeats.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSeats.ForeColor = Color.FromArgb(55, 65, 81);
            lblSeats.Location = new Point(25, 281);
            lblSeats.Name = "lblSeats";
            lblSeats.Size = new Size(50, 21);
            lblSeats.TabIndex = 3;
            lblSeats.Text = "Seats";
            // 
            // cmbSeats
            // 
            cmbSeats.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeats.Font = new Font("Segoe UI", 10F);
            cmbSeats.FormattingEnabled = true;
            cmbSeats.Items.AddRange(new object[] { "All Seats", "2 Seats", "4 Seats", "5 Seats", "6 Seats", "7 Seats", "8 Seats" });
            cmbSeats.Location = new Point(25, 313);
            cmbSeats.Margin = new Padding(3, 4, 3, 4);
            cmbSeats.Name = "cmbSeats";
            cmbSeats.Size = new Size(265, 31);
            cmbSeats.TabIndex = 3;
            // 
            // lblMaxPrice
            // 
            lblMaxPrice.AutoSize = true;
            lblMaxPrice.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblMaxPrice.ForeColor = Color.FromArgb(55, 65, 81);
            lblMaxPrice.Location = new Point(25, 377);
            lblMaxPrice.Name = "lblMaxPrice";
            lblMaxPrice.Size = new Size(175, 21);
            lblMaxPrice.TabIndex = 4;
            lblMaxPrice.Text = "Maximum Price / Day";
            // 
            // cmbMaxPrice
            // 
            cmbMaxPrice.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaxPrice.Font = new Font("Segoe UI", 10F);
            cmbMaxPrice.FormattingEnabled = true;
            cmbMaxPrice.Items.AddRange(new object[] { "Any Price", "Under ৳3,000", "Under ৳5,000", "Under ৳7,000", "Under ৳10,000", "Under ৳15,000" });
            cmbMaxPrice.Location = new Point(25, 409);
            cmbMaxPrice.Margin = new Padding(3, 4, 3, 4);
            cmbMaxPrice.Name = "cmbMaxPrice";
            cmbMaxPrice.Size = new Size(265, 31);
            cmbMaxPrice.TabIndex = 4;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLocation.ForeColor = Color.FromArgb(55, 65, 81);
            lblLocation.Location = new Point(25, 473);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(76, 21);
            lblLocation.TabIndex = 5;
            lblLocation.Text = "Location";
            // 
            // cmbLocation
            // 
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocation.Font = new Font("Segoe UI", 10F);
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Items.AddRange(new object[] { "All Locations", "Dhaka", "Chittagong", "Sylhet", "Rajshahi", "Khulna", "Rangpur", "Barisal", "Mymensingh" });
            cmbLocation.Location = new Point(25, 505);
            cmbLocation.Margin = new Padding(3, 4, 3, 4);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(265, 31);
            cmbLocation.TabIndex = 5;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.BackColor = Color.FromArgb(37, 99, 235);
            btnApplyFilters.Cursor = Cursors.Hand;
            btnApplyFilters.FlatAppearance.BorderSize = 0;
            btnApplyFilters.FlatStyle = FlatStyle.Flat;
            btnApplyFilters.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnApplyFilters.ForeColor = Color.White;
            btnApplyFilters.Location = new Point(25, 593);
            btnApplyFilters.Margin = new Padding(3, 4, 3, 4);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(265, 56);
            btnApplyFilters.TabIndex = 6;
            btnApplyFilters.Text = "Apply Filters";
            btnApplyFilters.UseVisualStyleBackColor = false;
            btnApplyFilters.Click += btnApplyFilters_Click;
            // 
            // btnResetFilters
            // 
            btnResetFilters.BackColor = Color.White;
            btnResetFilters.Cursor = Cursors.Hand;
            btnResetFilters.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnResetFilters.FlatStyle = FlatStyle.Flat;
            btnResetFilters.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnResetFilters.ForeColor = Color.FromArgb(55, 65, 81);
            btnResetFilters.Location = new Point(25, 663);
            btnResetFilters.Margin = new Padding(3, 4, 3, 4);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(265, 56);
            btnResetFilters.TabIndex = 7;
            btnResetFilters.Text = "Reset Filters";
            btnResetFilters.UseVisualStyleBackColor = false;
            btnResetFilters.Click += btnResetFilters_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(55, 65, 81);
            lblSearch.Location = new Point(377, 99);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(166, 23);
            lblSearch.TabIndex = 10;
            lblSearch.Text = "Search by car name";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(377, 129);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(662, 32);
            txtSearch.TabIndex = 8;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(37, 99, 235);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1055, 118);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(137, 41);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResults.ForeColor = Color.FromArgb(75, 85, 99);
            lblResults.Location = new Point(387, 189);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(123, 23);
            lblResults.TabIndex = 1;
            lblResults.Text = "Available Cars";
            // 
            // carsContainer
            // 
            carsContainer.BackColor = Color.White;
            carsContainer.BorderStyle = BorderStyle.FixedSingle;
            carsContainer.Controls.Add(carsFlowPanel);
            carsContainer.Location = new Point(377, 236);
            carsContainer.Margin = new Padding(3, 4, 3, 4);
            carsContainer.Name = "carsContainer";
            carsContainer.Padding = new Padding(9, 11, 9, 11);
            carsContainer.Size = new Size(1155, 606);
            carsContainer.TabIndex = 0;
            // 
            // carsFlowPanel
            // 
            carsFlowPanel.AutoScroll = true;
            carsFlowPanel.BackColor = Color.FromArgb(248, 250, 252);
            carsFlowPanel.Dock = DockStyle.Fill;
            carsFlowPanel.FlowDirection = FlowDirection.TopDown;
            carsFlowPanel.Location = new Point(9, 11);
            carsFlowPanel.Margin = new Padding(3, 4, 3, 4);
            carsFlowPanel.Name = "carsFlowPanel";
            carsFlowPanel.Padding = new Padding(14, 16, 14, 16);
            carsFlowPanel.Size = new Size(1135, 582);
            carsFlowPanel.TabIndex = 0;
            carsFlowPanel.WrapContents = false;
            // 
            // BrowseCarsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1567, 900);
            Controls.Add(carsContainer);
            Controls.Add(lblResults);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(filterPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "BrowseCarsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Browse Cars";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            carsContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}