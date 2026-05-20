namespace OOP2_final_project
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            lb_co_Name = new Label();
            lbl_teacher = new Label();
            dgvt = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            teacher_id = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvt).BeginInit();
            SuspendLayout();
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.BackColor = Color.Transparent;
            lb_co_Name.Cursor = Cursors.Hand;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(395, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 26;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click;
            // 
            // lbl_teacher
            // 
            lbl_teacher.AutoSize = true;
            lbl_teacher.BackColor = Color.Transparent;
            lbl_teacher.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_teacher.Location = new Point(15, 85);
            lbl_teacher.Name = "lbl_teacher";
            lbl_teacher.Size = new Size(125, 35);
            lbl_teacher.TabIndex = 25;
            lbl_teacher.Text = "Teachers";
            lbl_teacher.Click += lbl_teacher_Click;
            // 
            // dgvt
            // 
            dgvt.AllowUserToAddRows = false;
            dgvt.AllowUserToDeleteRows = false;
            dgvt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvt.Columns.AddRange(new DataGridViewColumn[] { name, teacher_id, phone, address });
            dgvt.Location = new Point(12, 123);
            dgvt.Name = "dgvt";
            dgvt.ReadOnly = true;
            dgvt.RowHeadersWidth = 51;
            dgvt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvt.Size = new Size(999, 358);
            dgvt.TabIndex = 24;
            dgvt.CellDoubleClick += dgvt_CellDoubleClick;
            // 
            // name
            // 
            name.DataPropertyName = "UserName";
            name.FillWeight = 240F;
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 250;
            // 
            // teacher_id
            // 
            teacher_id.DataPropertyName = "UserId";
            teacher_id.FillWeight = 150F;
            teacher_id.HeaderText = "Teacher Id";
            teacher_id.MinimumWidth = 6;
            teacher_id.Name = "teacher_id";
            teacher_id.ReadOnly = true;
            teacher_id.Width = 175;
            // 
            // phone
            // 
            phone.DataPropertyName = "Phone";
            phone.FillWeight = 200F;
            phone.HeaderText = "Phone";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.ReadOnly = true;
            phone.Width = 200;
            // 
            // address
            // 
            address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            address.DataPropertyName = "Address";
            address.FillWeight = 300F;
            address.HeaderText = "Address";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.ReadOnly = true;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(627, 87);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(177, 27);
            txtSearch.TabIndex = 29;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(910, 85);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(810, 85);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 27;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 537);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(lb_co_Name);
            Controls.Add(lbl_teacher);
            Controls.Add(dgvt);
            DoubleBuffered = true;
            MaximumSize = new Size(1034, 584);
            Name = "Form11";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher show";
            Load += Form11_Load;
            ((System.ComponentModel.ISupportInitialize)dgvt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private Label lbl_teacher;
        private DataGridView dgvt;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnSearch;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn teacher_id;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn address;
    }
}