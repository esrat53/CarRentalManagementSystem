namespace CarRentalManagementSystem.Customer
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel bookingInfoPanel;
        private System.Windows.Forms.Label lblBookingTitle;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Label lblAmount;

        private System.Windows.Forms.Panel paymentPanel;
        private System.Windows.Forms.Label lblPaymentTitle;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;

        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;

        private System.Windows.Forms.Label lblCardHolder;
        private System.Windows.Forms.TextBox txtCardHolder;

        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.TextBox txtExpiry;

        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.TextBox txtCVV;

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCancel;

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
            bookingInfoPanel = new Panel();
            lblBookingTitle = new Label();
            lblBookingID = new Label();
            lblCar = new Label();
            lblDates = new Label();
            lblAmount = new Label();
            paymentPanel = new Panel();
            lblPaymentTitle = new Label();
            lblPaymentMethod = new Label();
            cmbPaymentMethod = new ComboBox();
            lblCardNumber = new Label();
            txtCardNumber = new TextBox();
            lblCardHolder = new Label();
            txtCardHolder = new TextBox();
            lblExpiry = new Label();
            txtExpiry = new TextBox();
            lblCVV = new Label();
            txtCVV = new TextBox();
            btnPay = new Button();
            btnCancel = new Button();
            headerPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            bookingInfoPanel.SuspendLayout();
            paymentPanel.SuspendLayout();
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
            headerPanel.Size = new Size(1143, 97);
            headerPanel.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(29, 33);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 47);
            btnBack.TabIndex = 0;
            btnBack.Text = "← Back";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(425, 9);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(174, 50);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Payment";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(203, 213, 225);
            lblSubtitle.Location = new Point(395, 59);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(239, 21);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Complete your payment securely";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.ButtonFace;
            mainPanel.Controls.Add(bookingInfoPanel);
            mainPanel.Controls.Add(paymentPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 97);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(40, 47, 40, 47);
            mainPanel.Size = new Size(1143, 810);
            mainPanel.TabIndex = 0;
            // 
            // bookingInfoPanel
            // 
            bookingInfoPanel.BackColor = Color.White;
            bookingInfoPanel.BorderStyle = BorderStyle.FixedSingle;
            bookingInfoPanel.Controls.Add(lblBookingTitle);
            bookingInfoPanel.Controls.Add(lblBookingID);
            bookingInfoPanel.Controls.Add(lblCar);
            bookingInfoPanel.Controls.Add(lblDates);
            bookingInfoPanel.Controls.Add(lblAmount);
            bookingInfoPanel.Location = new Point(40, 8);
            bookingInfoPanel.Margin = new Padding(3, 4, 3, 4);
            bookingInfoPanel.Name = "bookingInfoPanel";
            bookingInfoPanel.Size = new Size(1005, 215);
            bookingInfoPanel.TabIndex = 0;
            // 
            // lblBookingTitle
            // 
            lblBookingTitle.AutoSize = true;
            lblBookingTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBookingTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblBookingTitle.Location = new Point(29, 27);
            lblBookingTitle.Name = "lblBookingTitle";
            lblBookingTitle.Size = new Size(225, 32);
            lblBookingTitle.TabIndex = 0;
            lblBookingTitle.Text = "Booking Summary";
            // 
            // lblBookingID
            // 
            lblBookingID.AutoSize = true;
            lblBookingID.Font = new Font("Segoe UI", 10F);
            lblBookingID.ForeColor = Color.FromArgb(75, 85, 99);
            lblBookingID.Location = new Point(29, 80);
            lblBookingID.Name = "lblBookingID";
            lblBookingID.Size = new Size(110, 23);
            lblBookingID.TabIndex = 1;
            lblBookingID.Text = "Booking ID: -";
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Font = new Font("Segoe UI", 10F);
            lblCar.ForeColor = Color.FromArgb(75, 85, 99);
            lblCar.Location = new Point(29, 120);
            lblCar.Name = "lblCar";
            lblCar.Size = new Size(52, 23);
            lblCar.TabIndex = 2;
            lblCar.Text = "Car: -";
            // 
            // lblDates
            // 
            lblDates.AutoSize = true;
            lblDates.Font = new Font("Segoe UI", 10F);
            lblDates.ForeColor = Color.FromArgb(75, 85, 99);
            lblDates.Location = new Point(29, 160);
            lblDates.Name = "lblDates";
            lblDates.Size = new Size(122, 23);
            lblDates.TabIndex = 3;
            lblDates.Text = "Rental Dates: -";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(37, 99, 235);
            lblAmount.Location = new Point(686, 87);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(107, 30);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Total: ৳0";
            // 
            // paymentPanel
            // 
            paymentPanel.BackColor = Color.White;
            paymentPanel.BorderStyle = BorderStyle.FixedSingle;
            paymentPanel.Controls.Add(lblPaymentTitle);
            paymentPanel.Controls.Add(lblPaymentMethod);
            paymentPanel.Controls.Add(cmbPaymentMethod);
            paymentPanel.Controls.Add(lblCardNumber);
            paymentPanel.Controls.Add(txtCardNumber);
            paymentPanel.Controls.Add(lblCardHolder);
            paymentPanel.Controls.Add(txtCardHolder);
            paymentPanel.Controls.Add(lblExpiry);
            paymentPanel.Controls.Add(txtExpiry);
            paymentPanel.Controls.Add(lblCVV);
            paymentPanel.Controls.Add(txtCVV);
            paymentPanel.Controls.Add(btnPay);
            paymentPanel.Controls.Add(btnCancel);
            paymentPanel.Location = new Point(40, 241);
            paymentPanel.Margin = new Padding(3, 4, 3, 4);
            paymentPanel.Name = "paymentPanel";
            paymentPanel.Size = new Size(1005, 486);
            paymentPanel.TabIndex = 1;
            // 
            // lblPaymentTitle
            // 
            lblPaymentTitle.AutoSize = true;
            lblPaymentTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPaymentTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblPaymentTitle.Location = new Point(29, 27);
            lblPaymentTitle.Name = "lblPaymentTitle";
            lblPaymentTitle.Size = new Size(198, 32);
            lblPaymentTitle.TabIndex = 0;
            lblPaymentTitle.Text = "Payment Details";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI", 9.5F);
            lblPaymentMethod.Location = new Point(29, 87);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(128, 21);
            lblPaymentMethod.TabIndex = 1;
            lblPaymentMethod.Text = "Payment Method";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.Font = new Font("Segoe UI", 10F);
            cmbPaymentMethod.Items.AddRange(new object[] { "Credit Card", "Debit Card", "Mobile Banking" });
            cmbPaymentMethod.Location = new Point(29, 120);
            cmbPaymentMethod.Margin = new Padding(3, 4, 3, 4);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(285, 31);
            cmbPaymentMethod.TabIndex = 2;
            // 
            // lblCardNumber
            // 
            lblCardNumber.AutoSize = true;
            lblCardNumber.Font = new Font("Segoe UI", 9.5F);
            lblCardNumber.Location = new Point(354, 87);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(175, 21);
            lblCardNumber.TabIndex = 3;
            lblCardNumber.Text = "Card / Account Number";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Font = new Font("Segoe UI", 10F);
            txtCardNumber.Location = new Point(354, 120);
            txtCardNumber.Margin = new Padding(3, 4, 3, 4);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(297, 30);
            txtCardNumber.TabIndex = 4;
            // 
            // lblCardHolder
            // 
            lblCardHolder.AutoSize = true;
            lblCardHolder.Font = new Font("Segoe UI", 9.5F);
            lblCardHolder.Location = new Point(29, 193);
            lblCardHolder.Name = "lblCardHolder";
            lblCardHolder.Size = new Size(140, 21);
            lblCardHolder.TabIndex = 5;
            lblCardHolder.Text = "Card Holder Name";
            // 
            // txtCardHolder
            // 
            txtCardHolder.Font = new Font("Segoe UI", 10F);
            txtCardHolder.Location = new Point(29, 227);
            txtCardHolder.Margin = new Padding(3, 4, 3, 4);
            txtCardHolder.Name = "txtCardHolder";
            txtCardHolder.Size = new Size(342, 30);
            txtCardHolder.TabIndex = 6;
            // 
            // lblExpiry
            // 
            lblExpiry.AutoSize = true;
            lblExpiry.Font = new Font("Segoe UI", 9.5F);
            lblExpiry.Location = new Point(400, 193);
            lblExpiry.Name = "lblExpiry";
            lblExpiry.Size = new Size(52, 21);
            lblExpiry.TabIndex = 7;
            lblExpiry.Text = "Expiry";
            // 
            // txtExpiry
            // 
            txtExpiry.Font = new Font("Segoe UI", 10F);
            txtExpiry.Location = new Point(400, 227);
            txtExpiry.Margin = new Padding(3, 4, 3, 4);
            txtExpiry.Name = "txtExpiry";
            txtExpiry.Size = new Size(114, 30);
            txtExpiry.TabIndex = 8;
            // 
            // lblCVV
            // 
            lblCVV.AutoSize = true;
            lblCVV.Font = new Font("Segoe UI", 9.5F);
            lblCVV.Location = new Point(549, 193);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(40, 21);
            lblCVV.TabIndex = 9;
            lblCVV.Text = "CVV";
            // 
            // txtCVV
            // 
            txtCVV.Font = new Font("Segoe UI", 10F);
            txtCVV.Location = new Point(549, 227);
            txtCVV.Margin = new Padding(3, 4, 3, 4);
            txtCVV.Name = "txtCVV";
            txtCVV.PasswordChar = '*';
            txtCVV.Size = new Size(102, 30);
            txtCVV.TabIndex = 10;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(37, 99, 235);
            btnPay.Cursor = Cursors.Hand;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(253, 367);
            btnPay.Margin = new Padding(3, 4, 3, 4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(160, 60);
            btnPay.TabIndex = 11;
            btnPay.Text = "Pay Now";
            btnPay.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(229, 231, 235);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(31, 41, 55);
            btnCancel.Location = new Point(442, 367);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 60);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 907);
            Controls.Add(mainPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            bookingInfoPanel.ResumeLayout(false);
            bookingInfoPanel.PerformLayout();
            paymentPanel.ResumeLayout(false);
            paymentPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}