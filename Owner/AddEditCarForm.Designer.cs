using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Owner
{
    partial class AddEditCarForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblPageTitle;
        private Label lblSubtitle;

        private Label lblBrand;
        private TextBox txtBrand;

        private Label lblModel;
        private TextBox txtModel;

        private Label lblYear;
        private NumericUpDown nudYear;

        private Label lblVehicleType;
        private ComboBox cmbVehicleType;

        private Label lblSeats;
        private NumericUpDown nudSeats;

        private Label lblPrice;
        private TextBox txtPrice;

        private Label lblLocation;
        private TextBox txtLocation;

        private Label lblStatus;
        private ComboBox cmbStatus;

        private Label lblDescription;
        private TextBox txtDescription;

        private Label lblTransmission;
        private ComboBox cmbTransmission;

        private Label lblDriveType;
        private ComboBox cmbDriveType;

        private Label lblCargoVolume;
        private TextBox txtCargoVolume;

        private Panel imagePanel;
        private PictureBox picCar;
        private Button btnChooseImage;

        private Button btnBack;
        private Button btnSave;
        private Button btnCancel;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblPageTitle = new Label();
            lblSubtitle = new Label();
            lblBrand = new Label();
            txtBrand = new TextBox();
            lblModel = new Label();
            txtModel = new TextBox();
            lblYear = new Label();
            nudYear = new NumericUpDown();
            lblVehicleType = new Label();
            cmbVehicleType = new ComboBox();
            lblSeats = new Label();
            nudSeats = new NumericUpDown();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblTransmission = new Label();
            cmbTransmission = new ComboBox();
            lblDriveType = new Label();
            cmbDriveType = new ComboBox();
            lblCargoVolume = new Label();
            txtCargoVolume = new TextBox();
            imagePanel = new Panel();
            picCar = new PictureBox();
            btnChooseImage = new Button();
            btnBack = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSeats).BeginInit();
            imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            SuspendLayout();
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(25, 35, 50);
            lblPageTitle.Location = new Point(411, 9);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(286, 57);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Add New Car";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10.5F);
            lblSubtitle.ForeColor = Color.FromArgb(105, 112, 125);
            lblSubtitle.Location = new Point(419, 66);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(261, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Add a new vehicle to your fleet.";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(45, 55, 70);
            lblBrand.Location = new Point(370, 145);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(66, 21);
            lblBrand.TabIndex = 4;
            lblBrand.Text = "Brand *";
            // 
            // txtBrand
            // 
            txtBrand.Font = new Font("Segoe UI", 10.5F);
            txtBrand.Location = new Point(370, 172);
            txtBrand.Name = "txtBrand";
            txtBrand.PlaceholderText = "e.g. Toyota";
            txtBrand.Size = new Size(310, 31);
            txtBrand.TabIndex = 5;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblModel.ForeColor = Color.FromArgb(45, 55, 70);
            lblModel.Location = new Point(710, 145);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(70, 21);
            lblModel.TabIndex = 6;
            lblModel.Text = "Model *";
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Segoe UI", 10.5F);
            txtModel.Location = new Point(710, 172);
            txtModel.Name = "txtModel";
            txtModel.PlaceholderText = "e.g. Corolla";
            txtModel.Size = new Size(340, 31);
            txtModel.TabIndex = 7;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblYear.ForeColor = Color.FromArgb(45, 55, 70);
            lblYear.Location = new Point(370, 220);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(54, 21);
            lblYear.TabIndex = 8;
            lblYear.Text = "Year *";
            // 
            // nudYear
            // 
            nudYear.Font = new Font("Segoe UI", 10.5F);
            nudYear.Location = new Point(370, 247);
            nudYear.Maximum = new decimal(new int[] { 2035, 0, 0, 0 });
            nudYear.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(310, 31);
            nudYear.TabIndex = 9;
            nudYear.Value = new decimal(new int[] { 2022, 0, 0, 0 });
            // 
            // lblVehicleType
            // 
            lblVehicleType.AutoSize = true;
            lblVehicleType.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblVehicleType.ForeColor = Color.FromArgb(45, 55, 70);
            lblVehicleType.Location = new Point(710, 220);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(117, 21);
            lblVehicleType.TabIndex = 10;
            lblVehicleType.Text = "Vehicle Type *";
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicleType.Font = new Font("Segoe UI", 10.5F);
            cmbVehicleType.Items.AddRange(new object[] { "Sedan", "SUV", "Van", "Luxury" });
            cmbVehicleType.Location = new Point(710, 247);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(340, 31);
            cmbVehicleType.TabIndex = 11;
            cmbVehicleType.SelectedIndexChanged += cmbVehicleType_SelectedIndexChanged;
            // 
            // lblSeats
            // 
            lblSeats.AutoSize = true;
            lblSeats.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSeats.ForeColor = Color.FromArgb(45, 55, 70);
            lblSeats.Location = new Point(370, 295);
            lblSeats.Name = "lblSeats";
            lblSeats.Size = new Size(148, 21);
            lblSeats.TabIndex = 12;
            lblSeats.Text = "Number of Seats *";
            // 
            // nudSeats
            // 
            nudSeats.Font = new Font("Segoe UI", 10.5F);
            nudSeats.Location = new Point(370, 322);
            nudSeats.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudSeats.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudSeats.Name = "nudSeats";
            nudSeats.Size = new Size(310, 31);
            nudSeats.TabIndex = 13;
            nudSeats.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(45, 55, 70);
            lblPrice.Location = new Point(710, 295);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(155, 21);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "Price Per Day (৳) *";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10.5F);
            txtPrice.Location = new Point(710, 322);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "e.g. 2500";
            txtPrice.Size = new Size(340, 31);
            txtPrice.TabIndex = 15;
            // 
            // lblTransmission
            // 
            lblTransmission.AutoSize = true;
            lblTransmission.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTransmission.ForeColor = Color.FromArgb(45, 55, 70);
            lblTransmission.Location = new Point(370, 370);
            lblTransmission.Name = "lblTransmission";
            lblTransmission.Size = new Size(135, 21);
            lblTransmission.TabIndex = 16;
            lblTransmission.Text = "Transmission Type *";
            // 
            // cmbTransmission
            // 
            cmbTransmission.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTransmission.Font = new Font("Segoe UI", 10.5F);
            cmbTransmission.Items.AddRange(new object[] { "Automatic", "Manual" });
            cmbTransmission.Location = new Point(370, 397);
            cmbTransmission.Name = "cmbTransmission";
            cmbTransmission.Size = new Size(310, 31);
            cmbTransmission.TabIndex = 17;
            cmbTransmission.Visible = false;
            // 
            // lblDriveType
            // 
            lblDriveType.AutoSize = true;
            lblDriveType.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDriveType.ForeColor = Color.FromArgb(45, 55, 70);
            lblDriveType.Location = new Point(370, 370);
            lblDriveType.Name = "lblDriveType";
            lblDriveType.Size = new Size(90, 21);
            lblDriveType.TabIndex = 18;
            lblDriveType.Text = "Drive Type *";
            lblDriveType.Visible = false;
            // 
            // cmbDriveType
            // 
            cmbDriveType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDriveType.Font = new Font("Segoe UI", 10.5F);
            cmbDriveType.Items.AddRange(new object[] { "FWD", "RWD", "AWD", "4WD" });
            cmbDriveType.Location = new Point(370, 397);
            cmbDriveType.Name = "cmbDriveType";
            cmbDriveType.Size = new Size(310, 31);
            cmbDriveType.TabIndex = 19;
            cmbDriveType.Visible = false;
            // 
            // lblCargoVolume
            // 
            lblCargoVolume.AutoSize = true;
            lblCargoVolume.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCargoVolume.ForeColor = Color.FromArgb(45, 55, 70);
            lblCargoVolume.Location = new Point(370, 370);
            lblCargoVolume.Name = "lblCargoVolume";
            lblCargoVolume.Size = new Size(145, 21);
            lblCargoVolume.TabIndex = 20;
            lblCargoVolume.Text = "Cargo Volume (m³) *";
            lblCargoVolume.Visible = false;
            // 
            // txtCargoVolume
            // 
            txtCargoVolume.Font = new Font("Segoe UI", 10.5F);
            txtCargoVolume.Location = new Point(370, 397);
            txtCargoVolume.Name = "txtCargoVolume";
            txtCargoVolume.PlaceholderText = "e.g. 6.5";
            txtCargoVolume.Size = new Size(310, 31);
            txtCargoVolume.TabIndex = 21;
            txtCargoVolume.Visible = false;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLocation.ForeColor = Color.FromArgb(45, 55, 70);
            lblLocation.Location = new Point(370, 445);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(87, 21);
            lblLocation.TabIndex = 16;
            lblLocation.Text = "Location *";
            // 
            // txtLocation
            // 
            txtLocation.Font = new Font("Segoe UI", 10.5F);
            txtLocation.Location = new Point(370, 472);
            txtLocation.Name = "txtLocation";
            txtLocation.PlaceholderText = "e.g. Dhaka";
            txtLocation.Size = new Size(310, 31);
            txtLocation.TabIndex = 17;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(45, 55, 70);
            lblStatus.Location = new Point(710, 445);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(160, 21);
            lblStatus.TabIndex = 18;
            lblStatus.Text = "Availability Status *";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 10.5F);
            cmbStatus.Items.AddRange(new object[] { "Available", "Unavailable", "Inactive" });
            cmbStatus.Location = new Point(710, 472);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(340, 31);
            cmbStatus.TabIndex = 19;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(45, 55, 70);
            lblDescription.Location = new Point(370, 520);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(98, 21);
            lblDescription.TabIndex = 20;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(370, 547);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Enter additional information about the vehicle...";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(680, 60);
            txtDescription.TabIndex = 21;
            // 
            // imagePanel
            // 
            imagePanel.BackColor = Color.White;
            imagePanel.BorderStyle = BorderStyle.FixedSingle;
            imagePanel.Controls.Add(picCar);
            imagePanel.Controls.Add(btnChooseImage);
            imagePanel.Location = new Point(35, 145);
            imagePanel.Name = "imagePanel";
            imagePanel.Size = new Size(300, 440);
            imagePanel.TabIndex = 3;
            // 
            // picCar
            // 
            picCar.BackColor = Color.FromArgb(242, 244, 247);
            picCar.BorderStyle = BorderStyle.FixedSingle;
            picCar.Location = new Point(25, 25);
            picCar.Name = "picCar";
            picCar.Size = new Size(248, 250);
            picCar.SizeMode = PictureBoxSizeMode.Zoom;
            picCar.TabIndex = 0;
            picCar.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.BackColor = Color.FromArgb(37, 99, 235);
            btnChooseImage.FlatAppearance.BorderSize = 0;
            btnChooseImage.FlatStyle = FlatStyle.Flat;
            btnChooseImage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnChooseImage.ForeColor = Color.White;
            btnChooseImage.Location = new Point(25, 295);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(248, 50);
            btnChooseImage.TabIndex = 1;
            btnChooseImage.Text = "Choose Car Image";
            btnChooseImage.UseVisualStyleBackColor = false;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(37, 99, 235);
            btnBack.Location = new Point(35, 38);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 40);
            btnBack.TabIndex = 2;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(16, 185, 129);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(915, 625);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 45);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save Car";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(210, 214, 220);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(70, 78, 90);
            btnCancel.Location = new Point(775, 625);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 45);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddEditCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1100, 700);
            Controls.Add(lblPageTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(btnBack);
            Controls.Add(imagePanel);
            Controls.Add(lblBrand);
            Controls.Add(txtBrand);
            Controls.Add(lblModel);
            Controls.Add(txtModel);
            Controls.Add(lblYear);
            Controls.Add(nudYear);
            Controls.Add(lblVehicleType);
            Controls.Add(cmbVehicleType);
            Controls.Add(lblSeats);
            Controls.Add(nudSeats);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblLocation);
            Controls.Add(txtLocation);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblTransmission);
            Controls.Add(cmbTransmission);
            Controls.Add(lblDriveType);
            Controls.Add(cmbDriveType);
            Controls.Add(lblCargoVolume);
            Controls.Add(txtCargoVolume);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEditCarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit Car - Car Rental Management System";
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSeats).EndInit();
            imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}