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
            components = new System.ComponentModel.Container();
            lb_co_Name = new Label();
            lbl_emp_list = new Label();
            databaseBindingSource = new BindingSource(components);
            dgv_emp_table = new DataGridView();
            UserId = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_emp_table).BeginInit();
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
            lbl_emp_list.Cursor = Cursors.Hand;
            lbl_emp_list.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_emp_list.Location = new Point(29, 103);
            lbl_emp_list.Name = "lbl_emp_list";
            lbl_emp_list.Size = new Size(168, 32);
            lbl_emp_list.TabIndex = 17;
            lbl_emp_list.Text = "Employee list";
            lbl_emp_list.Click += lbl_emp_list_Click;
            // 
            // databaseBindingSource
            // 
            databaseBindingSource.DataSource = typeof(Database);
            // 
            // dgv_emp_table
            // 
            dgv_emp_table.AllowUserToAddRows = false;
            dgv_emp_table.AllowUserToDeleteRows = false;
            dgv_emp_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_emp_table.Columns.AddRange(new DataGridViewColumn[] { UserId, UserName, Phone, Address });
            dgv_emp_table.Location = new Point(29, 138);
            dgv_emp_table.Name = "dgv_emp_table";
            dgv_emp_table.ReadOnly = true;
            dgv_emp_table.RowHeadersWidth = 51;
            dgv_emp_table.Size = new Size(905, 355);
            dgv_emp_table.TabIndex = 18;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "ID";
            UserId.MinimumWidth = 6;
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Width = 125;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.FillWeight = 240F;
            UserName.HeaderText = "Name";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Width = 250;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.FillWeight = 170F;
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            Phone.Width = 175;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.FillWeight = 290F;
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 300;
            // 
            // Form17
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 537);
            Controls.Add(dgv_emp_table);
            Controls.Add(lbl_emp_list);
            Controls.Add(lb_co_Name);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form17";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee list";
            Load += Form17_Load;
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_emp_table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private Label lbl_emp_list;
        private BindingSource databaseBindingSource;
        private DataGridView dgv_emp_table;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
    }
}