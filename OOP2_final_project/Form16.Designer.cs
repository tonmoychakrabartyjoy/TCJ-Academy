namespace OOP2_final_project
{
    partial class Form16
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
            panel1 = new Panel();
            btn_add_emp = new Button();
            txt_address = new TextBox();
            txt_phone = new TextBox();
            txt_emp_id = new TextBox();
            txt_emp_name = new TextBox();
            lbl_address = new Label();
            lbl_phone = new Label();
            lbl_emp_id = new Label();
            lbl_emp_name = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.BackColor = Color.Transparent;
            lb_co_Name.Cursor = Cursors.Hand;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(374, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 16;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_add_emp);
            panel1.Controls.Add(txt_address);
            panel1.Controls.Add(txt_phone);
            panel1.Controls.Add(txt_emp_id);
            panel1.Controls.Add(txt_emp_name);
            panel1.Controls.Add(lbl_address);
            panel1.Controls.Add(lbl_phone);
            panel1.Controls.Add(lbl_emp_id);
            panel1.Controls.Add(lbl_emp_name);
            panel1.Location = new Point(206, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 369);
            panel1.TabIndex = 17;
            // 
            // btn_add_emp
            // 
            btn_add_emp.Cursor = Cursors.Hand;
            btn_add_emp.Location = new Point(226, 223);
            btn_add_emp.Name = "btn_add_emp";
            btn_add_emp.Size = new Size(146, 49);
            btn_add_emp.TabIndex = 10;
            btn_add_emp.Text = "Add Employee";
            btn_add_emp.UseVisualStyleBackColor = true;
            btn_add_emp.Click += btn_add_emp_Click;
            // 
            // txt_address
            // 
            txt_address.BorderStyle = BorderStyle.FixedSingle;
            txt_address.Location = new Point(194, 190);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(265, 27);
            txt_address.TabIndex = 8;
            txt_address.KeyDown += txt_address_KeyDown;
            // 
            // txt_phone
            // 
            txt_phone.BorderStyle = BorderStyle.FixedSingle;
            txt_phone.Location = new Point(194, 157);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(265, 27);
            txt_phone.TabIndex = 7;
            txt_phone.KeyDown += txt_phone_KeyDown;
            // 
            // txt_emp_id
            // 
            txt_emp_id.BorderStyle = BorderStyle.FixedSingle;
            txt_emp_id.Location = new Point(194, 122);
            txt_emp_id.Name = "txt_emp_id";
            txt_emp_id.Size = new Size(265, 27);
            txt_emp_id.TabIndex = 6;
            txt_emp_id.KeyDown += txt_emp_id_KeyDown;
            // 
            // txt_emp_name
            // 
            txt_emp_name.BorderStyle = BorderStyle.FixedSingle;
            txt_emp_name.Location = new Point(194, 87);
            txt_emp_name.Name = "txt_emp_name";
            txt_emp_name.Size = new Size(265, 27);
            txt_emp_name.TabIndex = 5;
            txt_emp_name.KeyDown += txt_emp_name_KeyDown;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(124, 198);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(64, 19);
            lbl_address.TabIndex = 3;
            lbl_address.Text = "Address";
            lbl_address.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(136, 165);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(52, 19);
            lbl_phone.TabIndex = 2;
            lbl_phone.Text = "Phone";
            lbl_phone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_emp_id
            // 
            lbl_emp_id.AutoSize = true;
            lbl_emp_id.Location = new Point(93, 130);
            lbl_emp_id.Name = "lbl_emp_id";
            lbl_emp_id.Size = new Size(95, 19);
            lbl_emp_id.TabIndex = 1;
            lbl_emp_id.Text = "Employee Id";
            lbl_emp_id.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_emp_name
            // 
            lbl_emp_name.AutoSize = true;
            lbl_emp_name.Location = new Point(66, 95);
            lbl_emp_name.Name = "lbl_emp_name";
            lbl_emp_name.Size = new Size(122, 19);
            lbl_emp_name.TabIndex = 0;
            lbl_emp_name.Text = "Employee Name";
            lbl_emp_name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 537);
            Controls.Add(panel1);
            Controls.Add(lb_co_Name);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form16";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private Panel panel1;
        private Label lbl_address;
        private Label lbl_phone;
        private Label lbl_emp_id;
        private Label lbl_emp_name;
        private Button btn_add_emp;
        private TextBox txt_address;
        private TextBox txt_phone;
        private TextBox txt_emp_id;
        private TextBox txt_emp_name;
    }
}