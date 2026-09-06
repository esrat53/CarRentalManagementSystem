namespace CarRentalManagementSystem.Admin
{
    partial class ManageAllCarsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel contentPanel;

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            headerPanel = new Panel();
            btnClose = new Button();
            lblTitle = new Label();
            lblSubtitle = new Label();
            contentPanel = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnRefresh = new Button();
            dgvCars = new DataGridView();
            cmbType = new ComboBox();
            lblType = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            headerPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(24, 34, 54);
            headerPanel.Controls.Add(btnClose);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblSubtitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 4, 3, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1257, 124);
            headerPanel.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(23, 37);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(103, 51);
            btnClose.TabIndex = 0;
            btnClose.Text = "←  Back";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(417, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(362, 60);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Manage All Cars";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(400, 69);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(392, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "View and manage every vehicle in the system";
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(245, 247, 250);
            contentPanel.Controls.Add(btnDelete);
            contentPanel.Controls.Add(btnEdit);
            contentPanel.Controls.Add(btnRefresh);
            contentPanel.Controls.Add(dgvCars);
            contentPanel.Controls.Add(cmbType);
            contentPanel.Controls.Add(lblType);
            contentPanel.Controls.Add(txtSearch);
            contentPanel.Controls.Add(lblSearch);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 124);
            contentPanel.Margin = new Padding(3, 4, 3, 4);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(34, 40, 34, 40);
            contentPanel.Size = new Size(1257, 809);
            contentPanel.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 57, 43);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(869, 60);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 53);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "🗑  Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(41, 128, 185);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(743, 60);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(114, 53);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "✎  Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(43, 52, 70);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(606, 60);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(126, 53);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "↻  Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
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
            dgvCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCars.ColumnHeadersHeight = 42;
            dgvCars.EnableHeadersVisualStyles = false;
            dgvCars.GridColor = Color.FromArgb(225, 228, 233);
            dgvCars.Location = new Point(34, 140);
            dgvCars.Margin = new Padding(3, 4, 3, 4);
            dgvCars.MultiSelect = false;
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.RowHeadersVisible = false;
            dgvCars.RowHeadersWidth = 51;
            dgvCars.RowTemplate.Height = 38;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.Size = new Size(1143, 600);
            dgvCars.TabIndex = 6;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new Font("Segoe UI", 10F);
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "All", "Sedan", "SUV", "Luxury", "Van" });
            cmbType.Location = new Point(400, 67);
            cmbType.Margin = new Padding(3, 4, 3, 4);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(182, 31);
            cmbType.TabIndex = 2;
            cmbType.SelectedIndexChanged += FilterCars;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblType.ForeColor = Color.FromArgb(40, 50, 65);
            lblType.Location = new Point(400, 33);
            lblType.Name = "lblType";
            lblType.Size = new Size(109, 23);
            lblType.TabIndex = 7;
            lblType.Text = "Vehicle Type";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(34, 67);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Brand, model or owner...";
            txtSearch.Size = new Size(342, 32);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += FilterCars;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(40, 50, 65);
            lblSearch.Location = new Point(34, 33);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(63, 23);
            lblSearch.TabIndex = 8;
            lblSearch.Text = "Search";
            // 
            // ManageAllCarsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1257, 933);
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1140, 851);
            Name = "ManageAllCarsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage All Cars";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
        }
    }
}