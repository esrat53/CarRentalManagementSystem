namespace CarRentalManagementSystem.Customer
{
    partial class MyBookingsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel contentPanel;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblResults;

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Button btnPayNow;

        private System.Windows.Forms.DataGridView dgvBookings;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            headerPanel = new Panel();
            btnBack = new Button();
            lblTitle = new Label();
            lblSubtitle = new Label();
            contentPanel = new Panel();
            lblResults = new Label();
            dgvBookings = new DataGridView();
            btnCancelBooking = new Button();
            btnPayNow = new Button();
            headerPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(20, 35, 65);
            headerPanel.Controls.Add(btnBack);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblSubtitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 4, 3, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1400, 125);
            headerPanel.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(42, 65, 105);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(3, 4);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 63);
            btnBack.TabIndex = 0;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(165, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1046, 60);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "My Bookings";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10.5F);
            lblSubtitle.ForeColor = Color.FromArgb(190, 205, 225);
            lblSubtitle.Location = new Point(206, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(954, 40);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "View and manage your car rental bookings";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(245, 247, 250);
            contentPanel.Controls.Add(lblResults);
            contentPanel.Controls.Add(dgvBookings);
            contentPanel.Controls.Add(btnCancelBooking);
            contentPanel.Controls.Add(btnPayNow);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 125);
            contentPanel.Margin = new Padding(3, 4, 3, 4);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(39, 33, 39, 33);
            contentPanel.Size = new Size(1400, 775);
            contentPanel.TabIndex = 0;
            contentPanel.Paint += contentPanel_Paint;
            // 
            // lblResults
            // 
            lblResults.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblResults.ForeColor = Color.FromArgb(45, 55, 72);
            lblResults.Location = new Point(33, 13);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(1307, 47);
            lblResults.TabIndex = 0;
            lblResults.Text = "My Bookings";
            lblResults.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.AllowUserToResizeRows = false;
            dgvBookings.BackgroundColor = Color.White;
            dgvBookings.BorderStyle = BorderStyle.None;
            dgvBookings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBookings.ColumnHeadersHeight = 42;
            dgvBookings.EnableHeadersVisualStyles = false;
            dgvBookings.GridColor = Color.FromArgb(225, 230, 238);
            dgvBookings.Location = new Point(39, 64);
            dgvBookings.Margin = new Padding(3, 4, 3, 4);
            dgvBookings.MultiSelect = false;
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.RowTemplate.Height = 42;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(1307, 544);
            dgvBookings.TabIndex = 1;
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.BackColor = Color.FromArgb(220, 53, 69);
            btnCancelBooking.FlatAppearance.BorderSize = 0;
            btnCancelBooking.FlatStyle = FlatStyle.Flat;
            btnCancelBooking.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCancelBooking.ForeColor = Color.White;
            btnCancelBooking.Location = new Point(33, 632);
            btnCancelBooking.Margin = new Padding(3, 4, 3, 4);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new Size(217, 64);
            btnCancelBooking.TabIndex = 2;
            btnCancelBooking.Text = "✕  Cancel Booking";
            btnCancelBooking.UseVisualStyleBackColor = false;
            btnCancelBooking.Click += btnCancelBooking_Click;
            // 
            // btnPayNow
            // 
            btnPayNow.BackColor = Color.FromArgb(0, 123, 255);
            btnPayNow.Enabled = false;
            btnPayNow.FlatAppearance.BorderSize = 0;
            btnPayNow.FlatStyle = FlatStyle.Flat;
            btnPayNow.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnPayNow.ForeColor = Color.White;
            btnPayNow.Location = new Point(281, 632);
            btnPayNow.Margin = new Padding(3, 4, 3, 4);
            btnPayNow.Name = "btnPayNow";
            btnPayNow.Size = new Size(217, 64);
            btnPayNow.TabIndex = 3;
            btnPayNow.Text = "💳  Pay Now";
            btnPayNow.UseVisualStyleBackColor = false;
            btnPayNow.Click += btnPayNow_Click;
            // 
            // MyBookingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1400, 900);
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1000, 600);
            Name = "MyBookingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Bookings";
            headerPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ResumeLayout(false);
        }
    }
}