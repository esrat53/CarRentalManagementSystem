using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Admin
{
    partial class ManageUsersForm
    {
        private IContainer components = null;

        private Panel header;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblSearch;
        private Label lblRole;
        private TextBox txtSearch;
        private ComboBox cmbRoleFilter;

        private Button btnRefresh;
        private Button btnClose;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;

        private DataGridView dgvUsers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            header = new Panel();
            btnClose = new Button();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblSearch = new Label();
            lblRole = new Label();
            txtSearch = new TextBox();
            cmbRoleFilter = new ComboBox();
            dgvUsers = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            header.SuspendLayout();
            ((ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(24, 34, 54);
            header.Controls.Add(btnClose);
            header.Controls.Add(lblTitle);
            header.Controls.Add(lblSubtitle);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1050, 90);
            header.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 52, 75);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 52, 75);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(30, 25);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 40);
            btnClose.TabIndex = 0;
            btnClose.Text = "←  Back";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(375, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(245, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Manage Users";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(348, 55);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(294, 23);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "View and manage all registered users";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(35, 45, 60);
            lblSearch.Location = new Point(30, 115);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(63, 23);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRole.ForeColor = Color.FromArgb(35, 45, 60);
            lblRole.Location = new Point(330, 115);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(45, 23);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(30, 140);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Username, name or email...";
            txtSearch.Size = new Size(280, 30);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += FilterUsers;
            // 
            // cmbRoleFilter
            // 
            cmbRoleFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoleFilter.Font = new Font("Segoe UI", 10F);
            cmbRoleFilter.Items.AddRange(new object[] { "All", "Customer", "Owner", "Admin" });
            cmbRoleFilter.Location = new Point(330, 140);
            cmbRoleFilter.Name = "cmbRoleFilter";
            cmbRoleFilter.Size = new Size(160, 31);
            cmbRoleFilter.TabIndex = 6;
            cmbRoleFilter.SelectedIndexChanged += FilterUsers;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 52, 70);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 52, 70);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeight = 42;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(35, 45, 60);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = Color.FromArgb(220, 224, 230);
            dgvUsers.Location = new Point(30, 195);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.Height = 38;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(990, 380);
            dgvUsers.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 135, 75);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 190, 105);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(584, 132);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 38);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "＋ Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(52, 152, 219);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 165, 225);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(699, 132);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 38);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "✎ Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 57, 43);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 40, 30);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 70, 55);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(815, 132);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 38);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "✕ Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(108, 117, 125);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 92, 98);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 135, 145);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(930, 133);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 38);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "↻ Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1050, 650);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvUsers);
            Controls.Add(lblRole);
            Controls.Add(cmbRoleFilter);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(header);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ManageUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Users";
            header.ResumeLayout(false);
            header.PerformLayout();
            ((ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // =============================================================
        // BUTTON CONFIGURATION
        // =============================================================

        private void ConfigureButton(
            Button button,
            string text,
            int x,
            int y,
            int width)
        {
            button.BackColor = Color.FromArgb(41, 128, 185);

            button.FlatAppearance.BorderSize = 0;

            button.FlatStyle = FlatStyle.Flat;

            button.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold);

            button.ForeColor = Color.White;

            button.Location = new Point(x, y);

            button.Size = new Size(width, 35);

            button.Text = text;

            button.UseVisualStyleBackColor = false;

            button.Cursor = Cursors.Hand;
        }
    }
}