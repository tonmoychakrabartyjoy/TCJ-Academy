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
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            teacher_id = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            salary = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, teacher_id, phone, subject, salary, address });
            dataGridView1.Location = new Point(12, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(999, 358);
            dataGridView1.TabIndex = 24;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 125;
            // 
            // teacher_id
            // 
            teacher_id.HeaderText = "Teacher Id";
            teacher_id.MinimumWidth = 6;
            teacher_id.Name = "teacher_id";
            teacher_id.ReadOnly = true;
            teacher_id.Width = 125;
            // 
            // phone
            // 
            phone.HeaderText = "Phone";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.ReadOnly = true;
            phone.Width = 125;
            // 
            // subject
            // 
            subject.HeaderText = "Subject";
            subject.MinimumWidth = 6;
            subject.Name = "subject";
            subject.ReadOnly = true;
            subject.Width = 125;
            // 
            // salary
            // 
            salary.HeaderText = "Salary";
            salary.MinimumWidth = 6;
            salary.Name = "salary";
            salary.ReadOnly = true;
            salary.Width = 125;
            // 
            // address
            // 
            address.FillWeight = 300F;
            address.HeaderText = "Address";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.ReadOnly = true;
            address.Width = 320;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 537);
            Controls.Add(lb_co_Name);
            Controls.Add(lbl_teacher);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "Form11";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher show";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private Label lbl_teacher;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn teacher_id;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn salary;
        private DataGridViewTextBoxColumn address;
    }
}