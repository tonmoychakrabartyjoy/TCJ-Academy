namespace OOP2_final_project
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            dgvs = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            studnet_id = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            lbl_student = new Label();
            lb_co_Name = new Label();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvs).BeginInit();
            SuspendLayout();
            // 
            // dgvs
            // 
            dgvs.AllowUserToAddRows = false;
            dgvs.AllowUserToDeleteRows = false;
            dgvs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvs.Columns.AddRange(new DataGridViewColumn[] { name, studnet_id, phone, address });
            dgvs.Location = new Point(30, 106);
            dgvs.Name = "dgvs";
            dgvs.ReadOnly = true;
            dgvs.RowHeadersWidth = 51;
            dgvs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvs.Size = new Size(928, 358);
            dgvs.TabIndex = 1;
            dgvs.CellContentClick += dataGridView1_CellContentClick;
            dgvs.CellDoubleClick += dgvs_CellDoubleClick;
            // 
            // name
            // 
            name.DataPropertyName = "UserName";
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 125;
            // 
            // studnet_id
            // 
            studnet_id.DataPropertyName = "UserId";
            studnet_id.HeaderText = "Student Id";
            studnet_id.MinimumWidth = 6;
            studnet_id.Name = "studnet_id";
            studnet_id.ReadOnly = true;
            studnet_id.Width = 125;
            // 
            // phone
            // 
            phone.DataPropertyName = "Phone";
            phone.HeaderText = "Phone";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.ReadOnly = true;
            phone.Width = 125;
            // 
            // address
            // 
            address.DataPropertyName = "Address";
            address.FillWeight = 480F;
            address.HeaderText = "Address";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.ReadOnly = true;
            address.Width = 500;
            // 
            // lbl_student
            // 
            lbl_student.AutoSize = true;
            lbl_student.BackColor = Color.Transparent;
            lbl_student.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_student.Location = new Point(40, 68);
            lbl_student.Name = "lbl_student";
            lbl_student.Size = new Size(126, 35);
            lbl_student.TabIndex = 2;
            lbl_student.Text = "Students";
            lbl_student.Click += lbl_student_Click;
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.BackColor = Color.Transparent;
            lb_co_Name.Cursor = Cursors.Hand;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(421, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 23;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(578, 70);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(177, 27);
            txtSearch.TabIndex = 26;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(861, 68);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(761, 68);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form10
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
            Controls.Add(lbl_student);
            Controls.Add(dgvs);
            DoubleBuffered = true;
            MaximumSize = new Size(1034, 584);
            Name = "Form10";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student list";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)dgvs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvs;
        private Label lbl_student;
        private Label lb_co_Name;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn studnet_id;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn address;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnSearch;
    }
}