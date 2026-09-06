namespace CarRentalManagementSystem.Owner
{
    partial class OwnerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel contentPanel;

        private System.Windows.Forms.Panel totalCarsCard;
        private System.Windows.Forms.Label lblTotalCarsTitle;
        private System.Windows.Forms.Label lblTotalCars;

        private System.Windows.Forms.Panel availableCarsCard;
        private System.Windows.Forms.Label lblAvailableCarsTitle;
        private System.Windows.Forms.Label lblAvailableCars;

        private System.Windows.Forms.Panel rentedCarsCard;
        private System.Windows.Forms.Label lblRentedCarsTitle;
        private System.Windows.Forms.Label lblRentedCars;

        private System.Windows.Forms.Panel earningsCard;
        private System.Windows.Forms.Label lblEarningsTitle;
        private System.Windows.Forms.Label lblTotalEarnings;

        private System.Windows.Forms.Panel pendingCard;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Label lblPendingBookings;

        private System.Windows.Forms.Panel carsPanel;
        private System.Windows.Forms.Label lblCarsPanelTitle;
        private System.Windows.Forms.Label lblCarsPanelDescription;
        private System.Windows.Forms.Button btnMyCars;

        private System.Windows.Forms.Panel bookingsPanel;
        private System.Windows.Forms.Label lblBookingsPanelTitle;
        private System.Windows.Forms.Label lblBookingsPanelDescription;
        private System.Windows.Forms.Button btnOwnerBookings;

        private System.Windows.Forms.Label lblRecentTitle;
        private System.Windows.Forms.DataGridView dgvRecentBookings;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            headerPanel = new Panel();
            lblPageTitle = new Label();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            btnLogout = new Button();
            contentPanel = new Panel();
            totalCarsCard = new Panel();
            lblTotalCarsTitle = new Label();
            lblTotalCars = new Label();
            availableCarsCard = new Panel();
            lblAvailableCarsTitle = new Label();
            lblAvailableCars = new Label();
            rentedCarsCard = new Panel();
            lblRentedCarsTitle = new Label();
            lblRentedCars = new Label();
            earningsCard = new Panel();
            lblEarningsTitle = new Label();
            lblTotalEarnings = new Label();
            pendingCard = new Panel();
            lblPendingTitle = new Label();
            lblPendingBookings = new Label();
            carsPanel = new Panel();
            lblCarsPanelTitle = new Label();
            lblCarsPanelDescription = new Label();
            btnMyCars = new Button();
            bookingsPanel = new Panel();
            lblBookingsPanelTitle = new Label();
            lblBookingsPanelDescription = new Label();
            btnOwnerBookings = new Button();
            lblRecentTitle = new Label();
            dgvRecentBookings = new DataGridView();
            headerPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            totalCarsCard.SuspendLayout();
            availableCarsCard.SuspendLayout();
            rentedCarsCard.SuspendLayout();
            earningsCard.SuspendLayout();
            pendingCard.SuspendLayout();
            carsPanel.SuspendLayout();
            bookingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentBookings).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(24, 34, 54);
            headerPanel.Controls.Add(lblPageTitle);
            headerPanel.Controls.Add(lblWelcome);
            headerPanel.Controls.Add(lblSubtitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 4, 3, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1143, 86);
            headerPanel.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(410, 5);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(308, 46);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Owner Dashboard";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(37, 99, 235);
            lblWelcome.Location = new Point(12, 23);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(153, 23);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, Owner!";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(419, 51);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(288, 20);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Manage your vehicles and rental bookings";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(239, 68, 68);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(12, 728);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(126, 40);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(246, 248, 251);
            contentPanel.Controls.Add(totalCarsCard);
            contentPanel.Controls.Add(availableCarsCard);
            contentPanel.Controls.Add(rentedCarsCard);
            contentPanel.Controls.Add(btnLogout);
            contentPanel.Controls.Add(earningsCard);
            contentPanel.Controls.Add(pendingCard);
            contentPanel.Controls.Add(carsPanel);
            contentPanel.Controls.Add(bookingsPanel);
            contentPanel.Controls.Add(lblRecentTitle);
            contentPanel.Controls.Add(dgvRecentBookings);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 86);
            contentPanel.Margin = new Padding(3, 4, 3, 4);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1143, 781);
            contentPanel.TabIndex = 1;
            // 
            // totalCarsCard
            // 
            totalCarsCard.BackColor = Color.White;
            totalCarsCard.Controls.Add(lblTotalCarsTitle);
            totalCarsCard.Controls.Add(lblTotalCars);
            totalCarsCard.Location = new Point(40, 33);
            totalCarsCard.Margin = new Padding(3, 4, 3, 4);
            totalCarsCard.Name = "totalCarsCard";
            totalCarsCard.Size = new Size(194, 147);
            totalCarsCard.TabIndex = 0;
            // 
            // lblTotalCarsTitle
            // 
            lblTotalCarsTitle.AutoSize = true;
            lblTotalCarsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTotalCarsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblTotalCarsTitle.Location = new Point(21, 20);
            lblTotalCarsTitle.Name = "lblTotalCarsTitle";
            lblTotalCarsTitle.Size = new Size(96, 20);
            lblTotalCarsTitle.TabIndex = 0;
            lblTotalCarsTitle.Text = "TOTAL CARS";
            // 
            // lblTotalCars
            // 
            lblTotalCars.AutoSize = true;
            lblTotalCars.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalCars.ForeColor = Color.FromArgb(31, 41, 55);
            lblTotalCars.Location = new Point(21, 57);
            lblTotalCars.Name = "lblTotalCars";
            lblTotalCars.Size = new Size(43, 50);
            lblTotalCars.TabIndex = 1;
            lblTotalCars.Text = "0";
            // 
            // availableCarsCard
            // 
            availableCarsCard.BackColor = Color.White;
            availableCarsCard.Controls.Add(lblAvailableCarsTitle);
            availableCarsCard.Controls.Add(lblAvailableCars);
            availableCarsCard.Location = new Point(251, 33);
            availableCarsCard.Margin = new Padding(3, 4, 3, 4);
            availableCarsCard.Name = "availableCarsCard";
            availableCarsCard.Size = new Size(194, 147);
            availableCarsCard.TabIndex = 1;
            // 
            // lblAvailableCarsTitle
            // 
            lblAvailableCarsTitle.AutoSize = true;
            lblAvailableCarsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblAvailableCarsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblAvailableCarsTitle.Location = new Point(21, 20);
            lblAvailableCarsTitle.Name = "lblAvailableCarsTitle";
            lblAvailableCarsTitle.Size = new Size(89, 20);
            lblAvailableCarsTitle.TabIndex = 0;
            lblAvailableCarsTitle.Text = "AVAILABLE";
            // 
            // lblAvailableCars
            // 
            lblAvailableCars.AutoSize = true;
            lblAvailableCars.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblAvailableCars.ForeColor = Color.FromArgb(31, 41, 55);
            lblAvailableCars.Location = new Point(21, 57);
            lblAvailableCars.Name = "lblAvailableCars";
            lblAvailableCars.Size = new Size(43, 50);
            lblAvailableCars.TabIndex = 1;
            lblAvailableCars.Text = "0";
            // 
            // rentedCarsCard
            // 
            rentedCarsCard.BackColor = Color.White;
            rentedCarsCard.Controls.Add(lblRentedCarsTitle);
            rentedCarsCard.Controls.Add(lblRentedCars);
            rentedCarsCard.Location = new Point(463, 33);
            rentedCarsCard.Margin = new Padding(3, 4, 3, 4);
            rentedCarsCard.Name = "rentedCarsCard";
            rentedCarsCard.Size = new Size(194, 147);
            rentedCarsCard.TabIndex = 2;
            // 
            // lblRentedCarsTitle
            // 
            lblRentedCarsTitle.AutoSize = true;
            lblRentedCarsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblRentedCarsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblRentedCarsTitle.Location = new Point(21, 20);
            lblRentedCarsTitle.Name = "lblRentedCarsTitle";
            lblRentedCarsTitle.Size = new Size(156, 20);
            lblRentedCarsTitle.TabIndex = 0;
            lblRentedCarsTitle.Text = "CURRENTLY RENTED";
            // 
            // lblRentedCars
            // 
            lblRentedCars.AutoSize = true;
            lblRentedCars.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblRentedCars.ForeColor = Color.FromArgb(31, 41, 55);
            lblRentedCars.Location = new Point(21, 57);
            lblRentedCars.Name = "lblRentedCars";
            lblRentedCars.Size = new Size(43, 50);
            lblRentedCars.TabIndex = 1;
            lblRentedCars.Text = "0";
            // 
            // earningsCard
            // 
            earningsCard.BackColor = Color.White;
            earningsCard.Controls.Add(lblEarningsTitle);
            earningsCard.Controls.Add(lblTotalEarnings);
            earningsCard.Location = new Point(674, 33);
            earningsCard.Margin = new Padding(3, 4, 3, 4);
            earningsCard.Name = "earningsCard";
            earningsCard.Size = new Size(194, 147);
            earningsCard.TabIndex = 3;
            // 
            // lblEarningsTitle
            // 
            lblEarningsTitle.AutoSize = true;
            lblEarningsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEarningsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblEarningsTitle.Location = new Point(21, 20);
            lblEarningsTitle.Name = "lblEarningsTitle";
            lblEarningsTitle.Size = new Size(135, 20);
            lblEarningsTitle.TabIndex = 0;
            lblEarningsTitle.Text = "TOTAL EARNINGS";
            // 
            // lblTotalEarnings
            // 
            lblTotalEarnings.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalEarnings.ForeColor = Color.FromArgb(22, 163, 74);
            lblTotalEarnings.Location = new Point(21, 57);
            lblTotalEarnings.Name = "lblTotalEarnings";
            lblTotalEarnings.Size = new Size(166, 53);
            lblTotalEarnings.TabIndex = 1;
            lblTotalEarnings.Text = "৳0";
            lblTotalEarnings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pendingCard
            // 
            pendingCard.BackColor = Color.White;
            pendingCard.Controls.Add(lblPendingTitle);
            pendingCard.Controls.Add(lblPendingBookings);
            pendingCard.Location = new Point(886, 33);
            pendingCard.Margin = new Padding(3, 4, 3, 4);
            pendingCard.Name = "pendingCard";
            pendingCard.Size = new Size(194, 147);
            pendingCard.TabIndex = 4;
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.AutoSize = true;
            lblPendingTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPendingTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblPendingTitle.Location = new Point(21, 20);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(77, 20);
            lblPendingTitle.TabIndex = 0;
            lblPendingTitle.Text = "PENDING";
            // 
            // lblPendingBookings
            // 
            lblPendingBookings.AutoSize = true;
            lblPendingBookings.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPendingBookings.ForeColor = Color.FromArgb(31, 41, 55);
            lblPendingBookings.Location = new Point(21, 57);
            lblPendingBookings.Name = "lblPendingBookings";
            lblPendingBookings.Size = new Size(43, 50);
            lblPendingBookings.TabIndex = 1;
            lblPendingBookings.Text = "0";
            // 
            // carsPanel
            // 
            carsPanel.BackColor = Color.White;
            carsPanel.Controls.Add(lblCarsPanelTitle);
            carsPanel.Controls.Add(lblCarsPanelDescription);
            carsPanel.Controls.Add(btnMyCars);
            carsPanel.Location = new Point(40, 207);
            carsPanel.Margin = new Padding(3, 4, 3, 4);
            carsPanel.Name = "carsPanel";
            carsPanel.Size = new Size(509, 111);
            carsPanel.TabIndex = 5;
            // 
            // lblCarsPanelTitle
            // 
            lblCarsPanelTitle.AutoSize = true;
            lblCarsPanelTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCarsPanelTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblCarsPanelTitle.Location = new Point(23, 21);
            lblCarsPanelTitle.Name = "lblCarsPanelTitle";
            lblCarsPanelTitle.Size = new Size(97, 30);
            lblCarsPanelTitle.TabIndex = 0;
            lblCarsPanelTitle.Text = "My Cars";
            // 
            // lblCarsPanelDescription
            // 
            lblCarsPanelDescription.AutoSize = true;
            lblCarsPanelDescription.Font = new Font("Segoe UI", 9F);
            lblCarsPanelDescription.ForeColor = Color.FromArgb(107, 114, 128);
            lblCarsPanelDescription.Location = new Point(23, 64);
            lblCarsPanelDescription.Name = "lblCarsPanelDescription";
            lblCarsPanelDescription.Size = new Size(249, 20);
            lblCarsPanelDescription.TabIndex = 1;
            lblCarsPanelDescription.Text = "Add, edit and manage your vehicles.";
            // 
            // btnMyCars
            // 
            btnMyCars.BackColor = Color.FromArgb(37, 99, 235);
            btnMyCars.Cursor = Cursors.Hand;
            btnMyCars.FlatAppearance.BorderSize = 0;
            btnMyCars.FlatStyle = FlatStyle.Flat;
            btnMyCars.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMyCars.ForeColor = Color.White;
            btnMyCars.Location = new Point(343, 40);
            btnMyCars.Margin = new Padding(3, 4, 3, 4);
            btnMyCars.Name = "btnMyCars";
            btnMyCars.Size = new Size(143, 56);
            btnMyCars.TabIndex = 2;
            btnMyCars.Text = "Manage Cars";
            btnMyCars.UseVisualStyleBackColor = false;
            btnMyCars.Click += btnMyCars_Click;
            // 
            // bookingsPanel
            // 
            bookingsPanel.BackColor = Color.White;
            bookingsPanel.Controls.Add(lblBookingsPanelTitle);
            bookingsPanel.Controls.Add(lblBookingsPanelDescription);
            bookingsPanel.Controls.Add(btnOwnerBookings);
            bookingsPanel.Location = new Point(571, 207);
            bookingsPanel.Margin = new Padding(3, 4, 3, 4);
            bookingsPanel.Name = "bookingsPanel";
            bookingsPanel.Size = new Size(509, 111);
            bookingsPanel.TabIndex = 6;
            // 
            // lblBookingsPanelTitle
            // 
            lblBookingsPanelTitle.AutoSize = true;
            lblBookingsPanelTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBookingsPanelTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblBookingsPanelTitle.Location = new Point(23, 21);
            lblBookingsPanelTitle.Name = "lblBookingsPanelTitle";
            lblBookingsPanelTitle.Size = new Size(147, 30);
            lblBookingsPanelTitle.TabIndex = 0;
            lblBookingsPanelTitle.Text = "My Bookings";
            // 
            // lblBookingsPanelDescription
            // 
            lblBookingsPanelDescription.AutoSize = true;
            lblBookingsPanelDescription.Font = new Font("Segoe UI", 9F);
            lblBookingsPanelDescription.ForeColor = Color.FromArgb(107, 114, 128);
            lblBookingsPanelDescription.Location = new Point(23, 64);
            lblBookingsPanelDescription.Name = "lblBookingsPanelDescription";
            lblBookingsPanelDescription.Size = new Size(251, 20);
            lblBookingsPanelDescription.TabIndex = 1;
            lblBookingsPanelDescription.Text = "View customers and rental bookings.";
            // 
            // btnOwnerBookings
            // 
            btnOwnerBookings.BackColor = Color.FromArgb(16, 185, 129);
            btnOwnerBookings.Cursor = Cursors.Hand;
            btnOwnerBookings.FlatAppearance.BorderSize = 0;
            btnOwnerBookings.FlatStyle = FlatStyle.Flat;
            btnOwnerBookings.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOwnerBookings.ForeColor = Color.White;
            btnOwnerBookings.Location = new Point(343, 40);
            btnOwnerBookings.Margin = new Padding(3, 4, 3, 4);
            btnOwnerBookings.Name = "btnOwnerBookings";
            btnOwnerBookings.Size = new Size(143, 56);
            btnOwnerBookings.TabIndex = 2;
            btnOwnerBookings.Text = "View Bookings";
            btnOwnerBookings.UseVisualStyleBackColor = false;
            btnOwnerBookings.Click += btnOwnerBookings_Click;
            // 
            // lblRecentTitle
            // 
            lblRecentTitle.AutoSize = true;
            lblRecentTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblRecentTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblRecentTitle.Location = new Point(473, 336);
            lblRecentTitle.Name = "lblRecentTitle";
            lblRecentTitle.Size = new Size(184, 30);
            lblRecentTitle.TabIndex = 7;
            lblRecentTitle.Text = "Recent Bookings";
            // 
            // dgvRecentBookings
            // 
            dgvRecentBookings.AllowUserToAddRows = false;
            dgvRecentBookings.AllowUserToDeleteRows = false;
            dgvRecentBookings.AllowUserToResizeRows = false;
            dgvRecentBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentBookings.BackgroundColor = Color.White;
            dgvRecentBookings.BorderStyle = BorderStyle.None;
            dgvRecentBookings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRecentBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecentBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecentBookings.ColumnHeadersHeight = 38;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRecentBookings.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRecentBookings.EnableHeadersVisualStyles = false;
            dgvRecentBookings.GridColor = Color.FromArgb(230, 233, 238);
            dgvRecentBookings.Location = new Point(40, 370);
            dgvRecentBookings.Margin = new Padding(3, 4, 3, 4);
            dgvRecentBookings.MultiSelect = false;
            dgvRecentBookings.Name = "dgvRecentBookings";
            dgvRecentBookings.ReadOnly = true;
            dgvRecentBookings.RowHeadersVisible = false;
            dgvRecentBookings.RowHeadersWidth = 51;
            dgvRecentBookings.RowTemplate.Height = 38;
            dgvRecentBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentBookings.Size = new Size(1040, 324);
            dgvRecentBookings.TabIndex = 8;
            // 
            // OwnerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 248, 251);
            ClientSize = new Size(1143, 867);
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "OwnerDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Owner Dashboard - Car Rental Management System";
            Load += OwnerDashboardForm_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            totalCarsCard.ResumeLayout(false);
            totalCarsCard.PerformLayout();
            availableCarsCard.ResumeLayout(false);
            availableCarsCard.PerformLayout();
            rentedCarsCard.ResumeLayout(false);
            rentedCarsCard.PerformLayout();
            earningsCard.ResumeLayout(false);
            earningsCard.PerformLayout();
            pendingCard.ResumeLayout(false);
            pendingCard.PerformLayout();
            carsPanel.ResumeLayout(false);
            carsPanel.PerformLayout();
            bookingsPanel.ResumeLayout(false);
            bookingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentBookings).EndInit();
            ResumeLayout(false);
        }
    }
}