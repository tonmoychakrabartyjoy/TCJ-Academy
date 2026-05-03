namespace OOP2_final_project
{
    partial class Form17
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
            lb_co_Name = new Label();
            lbl_emp_list = new Label();
            dataGridView1 = new DataGridView();
            emp_id = new DataGridViewTextBoxColumn();
            emp_name = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
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
            lb_co_Name.Location = new Point(394, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 16;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click;
            // 
            // lbl_emp_list
            // 
            lbl_emp_list.AutoSize = true;
            lbl_emp_list.BackColor = Color.Transparent;
            lbl_emp_list.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_emp_list.Location = new Point(29, 103);
            lbl_emp_list.Name = "lbl_emp_list";
            lbl_emp_list.Size = new Size(168, 32);
            lbl_emp_list.TabIndex = 17;
            lbl_emp_list.Text = "Employee list";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { emp_id, emp_name, phone, salary, address });
            dataGridView1.Location = new Point(29, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(955, 326);
            dataGridView1.TabIndex = 18;
            // 
            // emp_id
            // 
            emp_id.HeaderText = "Employee ID";
            emp_id.MinimumWidth = 6;
            emp_id.Name = "emp_id";
            emp_id.ReadOnly = true;
            emp_id.Width = 125;
            // 
            // emp_name
            // 
            emp_name.HeaderText = "Employee Name";
            emp_name.MinimumWidth = 6;
            emp_name.Name = "emp_name";
            emp_name.ReadOnly = true;
            emp_name.Width = 125;
            // 
            // phone
            // 
            phone.HeaderText = "Phone";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.ReadOnly = true;
            phone.Width = 125;
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
            address.FillWeight = 390F;
            address.HeaderText = "Address";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.ReadOnly = true;
            address.Width = 400;
            // 
            // Form17
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 537);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_emp_list);
            Controls.Add(lb_co_Name);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form17";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee list";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private Label lbl_emp_list;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn emp_id;
        private DataGridViewTextBoxColumn emp_name;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn salary;
        private DataGridViewTextBoxColumn address;
    }
}