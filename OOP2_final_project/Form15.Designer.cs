namespace OOP2_final_project
{
    partial class Form15
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
            components = new System.ComponentModel.Container();
            lb_co_Name = new Label();
            dgvResult = new DataGridView();
            CourseCode = new DataGridViewTextBoxColumn();
            Subject = new DataGridViewTextBoxColumn();
            CourseDay = new DataGridViewTextBoxColumn();
            CourseFee = new DataGridViewTextBoxColumn();
            lbl_course_list = new Label();
            databaseBindingSource = new BindingSource(components);
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.BackColor = Color.Transparent;
            lb_co_Name.Cursor = Cursors.Hand;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(420, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 13;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click;
            // 
            // dgvResult
            // 
            dgvResult.AllowUserToAddRows = false;
            dgvResult.AllowUserToDeleteRows = false;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Columns.AddRange(new DataGridViewColumn[] { CourseCode, Subject, CourseDay, CourseFee });
            dgvResult.Location = new Point(107, 121);
            dgvResult.Name = "dgvResult";
            dgvResult.ReadOnly = true;
            dgvResult.RowHeadersWidth = 51;
            dgvResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResult.Size = new Size(853, 390);
            dgvResult.TabIndex = 14;
            dgvResult.CellDoubleClick += dgvResult_CellDoubleClick;
            // 
            // CourseCode
            // 
            CourseCode.DataPropertyName = "CourseCode";
            CourseCode.FillWeight = 170F;
            CourseCode.HeaderText = "Course Code";
            CourseCode.MinimumWidth = 6;
            CourseCode.Name = "CourseCode";
            CourseCode.ReadOnly = true;
            CourseCode.Width = 175;
            // 
            // Subject
            // 
            Subject.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Subject.DataPropertyName = "CourseSubject";
            Subject.FillWeight = 170F;
            Subject.HeaderText = "Subject";
            Subject.MinimumWidth = 6;
            Subject.Name = "Subject";
            Subject.ReadOnly = true;
            // 
            // CourseDay
            // 
            CourseDay.DataPropertyName = "CourseDay";
            CourseDay.FillWeight = 240F;
            CourseDay.HeaderText = "Course Day";
            CourseDay.MinimumWidth = 6;
            CourseDay.Name = "CourseDay";
            CourseDay.ReadOnly = true;
            CourseDay.Width = 250;
            // 
            // CourseFee
            // 
            CourseFee.DataPropertyName = "CourseFee";
            CourseFee.HeaderText = "Course Fee";
            CourseFee.MinimumWidth = 6;
            CourseFee.Name = "CourseFee";
            CourseFee.ReadOnly = true;
            CourseFee.Width = 125;
            // 
            // lbl_course_list
            // 
            lbl_course_list.AutoSize = true;
            lbl_course_list.BackColor = Color.Transparent;
            lbl_course_list.Cursor = Cursors.Hand;
            lbl_course_list.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_course_list.Location = new Point(110, 86);
            lbl_course_list.Name = "lbl_course_list";
            lbl_course_list.Size = new Size(138, 32);
            lbl_course_list.TabIndex = 15;
            lbl_course_list.Text = "Course list";
            lbl_course_list.Click += lbl_course_list_Click;
            // 
            // databaseBindingSource
            // 
            databaseBindingSource.DataSource = typeof(Database);
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(583, 68);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(177, 28);
            txtSearch.TabIndex = 32;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(866, 66);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(766, 66);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 30;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 537);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(lbl_course_list);
            Controls.Add(dgvResult);
            Controls.Add(lb_co_Name);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(1034, 584);
            Name = "Form15";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course list";
            Load += Form15_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private DataGridView dgvResult;
        private Label lbl_course_list;
        private BindingSource databaseBindingSource;
        private DataGridViewTextBoxColumn CourseCode;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn CourseDay;
        private DataGridViewTextBoxColumn CourseFee;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnSearch;
    }
}