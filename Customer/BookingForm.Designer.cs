using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customer
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private Panel headerPanel;
        private Button btnBack;
        private Label lblPageTitle;
        private Label lblSubtitle;

        // Main container
        private Panel mainPanel;

        // Car information
        private Panel carInfoPanel;
        private PictureBox picCar;
        private Label lblCarName;
        private Label lblCarType;
        private Label lblCarSeats;
        private Label lblCarLocation;
        private Label lblPricePerDay;

        // Booking section
        private Panel bookingPanel;
        private Label lblBookingTitle;

        private Label lblStartDate;
        private DateTimePicker dtpStartDate;

        private Label lblReturnDate;
        private DateTimePicker dtpReturnDate;

        private Label lblDaysTitle;
        private Label lblDays;

        private Label lblTotalTitle;
        private Label lblTotal;

        // Buttons
        private Button btnConfirmBooking;
        private Button btnCancel;


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
            mainPanel = new Panel();
            carInfoPanel = new Panel();
            picCar = new PictureBox();
            lblCarName = new Label();
            lblCarType = new Label();
            lblCarSeats = new Label();
            lblCarLocation = new Label();
            lblPricePerDay = new Label();
            bookingPanel = new Panel();
            lblAvailability = new Label();
            lblBookingTitle = new Label();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblReturnDate = new Label();
            dtpReturnDate = new DateTimePicker();
            lblDaysTitle = new Label();
            lblDays = new Label();
            lblTotalTitle = new Label();
            lblTotal = new Label();
            btnConfirmBooking = new Button();
            btnCancel = new Button();
            headerPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            carInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            bookingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(24, 33, 48);
            headerPanel.Controls.Add(btnBack);
            headerPanel.Controls.Add(lblPageTitle);
            headerPanel.Controls.Add(lblSubtitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 4, 3, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1143, 99);
            headerPanel.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(0, 0);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(109, 51);
            btnBack.TabIndex = 0;
            btnBack.Text = "←  Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(444, 9);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(192, 46);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Book a Car";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(364, 55);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(368, 21);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Choose your rental dates and confirm your booking";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(245, 247, 250);
            mainPanel.Controls.Add(carInfoPanel);
            mainPanel.Controls.Add(bookingPanel);
            mainPanel.Location = new Point(29, 140);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1086, 727);
            mainPanel.TabIndex = 0;
            // 
            // carInfoPanel
            // 
            carInfoPanel.BackColor = Color.White;
            carInfoPanel.BorderStyle = BorderStyle.FixedSingle;
            carInfoPanel.Controls.Add(picCar);
            carInfoPanel.Controls.Add(lblCarName);
            carInfoPanel.Controls.Add(lblCarType);
            carInfoPanel.Controls.Add(lblCarSeats);
            carInfoPanel.Controls.Add(lblCarLocation);
            carInfoPanel.Controls.Add(lblPricePerDay);
            carInfoPanel.Location = new Point(0, 0);
            carInfoPanel.Margin = new Padding(3, 4, 3, 4);
            carInfoPanel.Name = "carInfoPanel";
            carInfoPanel.Size = new Size(520, 493);
            carInfoPanel.TabIndex = 0;
            // 
            // picCar
            // 
            picCar.BackColor = Color.FromArgb(245, 247, 250);
            picCar.Location = new Point(23, 27);
            picCar.Margin = new Padding(3, 4, 3, 4);
            picCar.Name = "picCar";
            picCar.Size = new Size(474, 253);
            picCar.SizeMode = PictureBoxSizeMode.Zoom;
            picCar.TabIndex = 0;
            picCar.TabStop = false;
            // 
            // lblCarName
            // 
            lblCarName.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblCarName.ForeColor = Color.FromArgb(31, 41, 55);
            lblCarName.Location = new Point(23, 300);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(474, 47);
            lblCarName.TabIndex = 1;
            lblCarName.Text = "Toyota Corolla";
            // 
            // lblCarType
            // 
            lblCarType.Font = new Font("Segoe UI", 10F);
            lblCarType.ForeColor = Color.FromArgb(107, 114, 128);
            lblCarType.Location = new Point(23, 353);
            lblCarType.Name = "lblCarType";
            lblCarType.Size = new Size(229, 33);
            lblCarType.TabIndex = 2;
            lblCarType.Text = "Type: Sedan";
            // 
            // lblCarSeats
            // 
            lblCarSeats.Font = new Font("Segoe UI", 10F);
            lblCarSeats.ForeColor = Color.FromArgb(107, 114, 128);
            lblCarSeats.Location = new Point(257, 353);
            lblCarSeats.Name = "lblCarSeats";
            lblCarSeats.Size = new Size(229, 33);
            lblCarSeats.TabIndex = 3;
            lblCarSeats.Text = "Seats: 5";
            // 
            // lblCarLocation
            // 
            lblCarLocation.Font = new Font("Segoe UI", 10F);
            lblCarLocation.ForeColor = Color.FromArgb(107, 114, 128);
            lblCarLocation.Location = new Point(23, 393);
            lblCarLocation.Name = "lblCarLocation";
            lblCarLocation.Size = new Size(286, 33);
            lblCarLocation.TabIndex = 4;
            lblCarLocation.Text = "Location: Dhaka";
            // 
            // lblPricePerDay
            // 
            lblPricePerDay.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPricePerDay.ForeColor = Color.FromArgb(37, 99, 235);
            lblPricePerDay.Location = new Point(23, 433);
            lblPricePerDay.Name = "lblPricePerDay";
            lblPricePerDay.Size = new Size(343, 40);
            lblPricePerDay.TabIndex = 5;
            lblPricePerDay.Text = "৳2,500 / day";
            // 
            // bookingPanel
            // 
            bookingPanel.BackColor = Color.White;
            bookingPanel.BorderStyle = BorderStyle.FixedSingle;
            bookingPanel.Controls.Add(lblAvailability);
            bookingPanel.Controls.Add(lblBookingTitle);
            bookingPanel.Controls.Add(lblStartDate);
            bookingPanel.Controls.Add(dtpStartDate);
            bookingPanel.Controls.Add(lblReturnDate);
            bookingPanel.Controls.Add(dtpReturnDate);
            bookingPanel.Controls.Add(lblDaysTitle);
            bookingPanel.Controls.Add(lblDays);
            bookingPanel.Controls.Add(lblTotalTitle);
            bookingPanel.Controls.Add(lblTotal);
            bookingPanel.Controls.Add(btnConfirmBooking);
            bookingPanel.Controls.Add(btnCancel);
            bookingPanel.Location = new Point(549, 0);
            bookingPanel.Margin = new Padding(3, 4, 3, 4);
            bookingPanel.Name = "bookingPanel";
            bookingPanel.Size = new Size(537, 726);
            bookingPanel.TabIndex = 1;
            // 
            // lblAvailability
            // 
            lblAvailability.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailability.Location = new Point(34, 317);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(400, 30);
            lblAvailability.TabIndex = 11;
            lblAvailability.Text = "Checking availability...";
            // 
            // lblBookingTitle
            // 
            lblBookingTitle.AutoSize = true;
            lblBookingTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBookingTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblBookingTitle.Location = new Point(34, 33);
            lblBookingTitle.Name = "lblBookingTitle";
            lblBookingTitle.Size = new Size(195, 37);
            lblBookingTitle.TabIndex = 0;
            lblBookingTitle.Text = "Rental Details";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStartDate.ForeColor = Color.FromArgb(55, 65, 81);
            lblStartDate.Location = new Point(34, 109);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(149, 23);
            lblStartDate.TabIndex = 1;
            lblStartDate.Text = "Rental Start Date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 10F);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(34, 144);
            dtpStartDate.Margin = new Padding(3, 4, 3, 4);
            dtpStartDate.MinDate = new DateTime(2026, 9, 4, 0, 0, 0, 0);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(457, 30);
            dtpStartDate.TabIndex = 2;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblReturnDate.ForeColor = Color.FromArgb(55, 65, 81);
            lblReturnDate.Location = new Point(34, 213);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(163, 23);
            lblReturnDate.TabIndex = 3;
            lblReturnDate.Text = "Rental Return Date";
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Font = new Font("Segoe UI", 10F);
            dtpReturnDate.Format = DateTimePickerFormat.Short;
            dtpReturnDate.Location = new Point(34, 248);
            dtpReturnDate.Margin = new Padding(3, 4, 3, 4);
            dtpReturnDate.MinDate = new DateTime(2026, 9, 4, 0, 0, 0, 0);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(457, 30);
            dtpReturnDate.TabIndex = 4;
            // 
            // lblDaysTitle
            // 
            lblDaysTitle.AutoSize = true;
            lblDaysTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDaysTitle.ForeColor = Color.FromArgb(55, 65, 81);
            lblDaysTitle.Location = new Point(34, 374);
            lblDaysTitle.Name = "lblDaysTitle";
            lblDaysTitle.Size = new Size(137, 23);
            lblDaysTitle.TabIndex = 5;
            lblDaysTitle.Text = "Rental Duration";
            // 
            // lblDays
            // 
            lblDays.Font = new Font("Segoe UI", 11F);
            lblDays.ForeColor = Color.FromArgb(75, 85, 99);
            lblDays.Location = new Point(34, 407);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(457, 40);
            lblDays.TabIndex = 6;
            lblDays.Text = "1 day";
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalTitle.ForeColor = Color.FromArgb(55, 65, 81);
            lblTotalTitle.Location = new Point(34, 460);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(119, 23);
            lblTotalTitle.TabIndex = 7;
            lblTotalTitle.Text = "Total Amount";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(37, 99, 235);
            lblTotal.Location = new Point(34, 499);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(457, 60);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "৳2,500";
            // 
            // btnConfirmBooking
            // 
            btnConfirmBooking.BackColor = Color.FromArgb(37, 99, 235);
            btnConfirmBooking.Cursor = Cursors.Hand;
            btnConfirmBooking.FlatAppearance.BorderSize = 0;
            btnConfirmBooking.FlatStyle = FlatStyle.Flat;
            btnConfirmBooking.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirmBooking.ForeColor = Color.White;
            btnConfirmBooking.Location = new Point(34, 590);
            btnConfirmBooking.Margin = new Padding(3, 4, 3, 4);
            btnConfirmBooking.Name = "btnConfirmBooking";
            btnConfirmBooking.Size = new Size(217, 60);
            btnConfirmBooking.TabIndex = 9;
            btnConfirmBooking.Text = "Confirm Booking";
            btnConfirmBooking.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(55, 65, 81);
            btnCancel.Location = new Point(274, 590);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(217, 60);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1143, 933);
            Controls.Add(mainPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "BookingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book a Car";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            carInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            bookingPanel.ResumeLayout(false);
            bookingPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Label lblAvailability;
    }
}