namespace CarRentalManagementSystem.Customer
{
    partial class CarDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblPageTitle;

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.PictureBox picCar;

        private System.Windows.Forms.Panel detailsPanel;

        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.Label lblDescriptionTitle;
        private System.Windows.Forms.Label lblDescription;

        private System.Windows.Forms.Button btnBookNow;
        private System.Windows.Forms.Button btnClose;

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
            lblBack = new Label();
            lblPageTitle = new Label();
            imagePanel = new Panel();
            picCar = new PictureBox();
            detailsPanel = new Panel();
            lblCarName = new Label();
            lblCarType = new Label();
            lblYear = new Label();
            lblPrice = new Label();
            lblStatus = new Label();
            lblDescriptionTitle = new Label();
            lblDescription = new Label();
            btnBookNow = new Button();
            btnClose = new Button();
            headerPanel.SuspendLayout();
            imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            detailsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(24, 32, 48);
            headerPanel.Controls.Add(lblBack);
            headerPanel.Controls.Add(lblPageTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 4, 3, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1143, 100);
            headerPanel.TabIndex = 2;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Cursor = Cursors.Hand;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.ForeColor = Color.White;
            lblBack.Location = new Point(29, 35);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(72, 25);
            lblBack.TabIndex = 0;
            lblBack.Text = "← Back";
            lblBack.Click += lblBack_Click;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(514, 29);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(166, 41);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Car Details";
            // 
            // imagePanel
            // 
            imagePanel.BackColor = Color.FromArgb(245, 247, 250);
            imagePanel.Controls.Add(picCar);
            imagePanel.Location = new Point(46, 147);
            imagePanel.Margin = new Padding(3, 4, 3, 4);
            imagePanel.Name = "imagePanel";
            imagePanel.Size = new Size(491, 480);
            imagePanel.TabIndex = 1;
            // 
            // picCar
            // 
            picCar.BackColor = Color.White;
            picCar.Dock = DockStyle.Fill;
            picCar.Location = new Point(0, 0);
            picCar.Margin = new Padding(3, 4, 3, 4);
            picCar.Name = "picCar";
            picCar.Size = new Size(491, 480);
            picCar.SizeMode = PictureBoxSizeMode.Zoom;
            picCar.TabIndex = 0;
            picCar.TabStop = false;
            // 
            // detailsPanel
            // 
            detailsPanel.BackColor = Color.White;
            detailsPanel.Controls.Add(lblCarName);
            detailsPanel.Controls.Add(lblCarType);
            detailsPanel.Controls.Add(lblYear);
            detailsPanel.Controls.Add(lblPrice);
            detailsPanel.Controls.Add(lblStatus);
            detailsPanel.Controls.Add(lblDescriptionTitle);
            detailsPanel.Controls.Add(lblDescription);
            detailsPanel.Controls.Add(btnBookNow);
            detailsPanel.Controls.Add(btnClose);
            detailsPanel.Location = new Point(577, 140);
            detailsPanel.Margin = new Padding(3, 4, 3, 4);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(520, 640);
            detailsPanel.TabIndex = 0;
            // 
            // lblCarName
            // 
            lblCarName.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold);
            lblCarName.ForeColor = Color.FromArgb(24, 32, 48);
            lblCarName.Location = new Point(14, 7);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(503, 67);
            lblCarName.TabIndex = 0;
            lblCarName.Text = "Toyota Corolla";
            // 
            // lblCarType
            // 
            lblCarType.AutoSize = true;
            lblCarType.Font = new Font("Segoe UI", 12F);
            lblCarType.ForeColor = Color.FromArgb(100, 108, 120);
            lblCarType.Location = new Point(5, 80);
            lblCarType.Name = "lblCarType";
            lblCarType.Size = new Size(66, 28);
            lblCarType.TabIndex = 1;
            lblCarType.Text = "Sedan";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 11F);
            lblYear.ForeColor = Color.FromArgb(70, 78, 90);
            lblYear.Location = new Point(5, 127);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(97, 25);
            lblYear.TabIndex = 2;
            lblYear.Text = "Year: 2024";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(0, 120, 215);
            lblPrice.Location = new Point(5, 173);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(200, 41);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "৳2,500 / day";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(40, 150, 90);
            lblStatus.Location = new Point(5, 233);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(107, 25);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "● Available";
            // 
            // lblDescriptionTitle
            // 
            lblDescriptionTitle.AutoSize = true;
            lblDescriptionTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDescriptionTitle.ForeColor = Color.FromArgb(24, 32, 48);
            lblDescriptionTitle.Location = new Point(5, 293);
            lblDescriptionTitle.Name = "lblDescriptionTitle";
            lblDescriptionTitle.Size = new Size(115, 28);
            lblDescriptionTitle.TabIndex = 5;
            lblDescriptionTitle.Text = "Description";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 10.5F);
            lblDescription.ForeColor = Color.FromArgb(90, 98, 110);
            lblDescription.Location = new Point(5, 333);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(480, 113);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Comfortable and reliable vehicle.";
            // 
            // btnBookNow
            // 
            btnBookNow.BackColor = Color.FromArgb(0, 120, 215);
            btnBookNow.FlatAppearance.BorderSize = 0;
            btnBookNow.FlatStyle = FlatStyle.Flat;
            btnBookNow.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnBookNow.ForeColor = Color.White;
            btnBookNow.Location = new Point(5, 500);
            btnBookNow.Margin = new Padding(3, 4, 3, 4);
            btnBookNow.Name = "btnBookNow";
            btnBookNow.Size = new Size(217, 60);
            btnBookNow.TabIndex = 7;
            btnBookNow.Text = "Book Now";
            btnBookNow.UseVisualStyleBackColor = false;
            btnBookNow.Click += btnBookNow_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(235, 238, 242);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(50, 58, 70);
            btnClose.Location = new Point(240, 500);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(171, 60);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // CarDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 867);
            Controls.Add(detailsPanel);
            Controls.Add(imagePanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CarDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Details";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}