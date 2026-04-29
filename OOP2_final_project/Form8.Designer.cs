namespace OOP2_final_project
{
    partial class Form8
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
            lb_student_id = new Label();
            lb_student_name = new Label();
            lb_phone = new Label();
            lb_address = new Label();
            txt_id = new TextBox();
            txt_name = new TextBox();
            txt_phone = new TextBox();
            txt_address = new TextBox();
            btn_add_student = new Button();
            lb_co_Name = new Label();
            txt_type = new TextBox();
            lb_type = new Label();
            SuspendLayout();
            // 
            // lb_student_id
            // 
            lb_student_id.AutoSize = true;
            lb_student_id.Location = new Point(61, 107);
            lb_student_id.Name = "lb_student_id";
            lb_student_id.Size = new Size(77, 20);
            lb_student_id.TabIndex = 0;
            lb_student_id.Text = "Student Id";
            // 
            // lb_student_name
            // 
            lb_student_name.AutoSize = true;
            lb_student_name.Location = new Point(34, 145);
            lb_student_name.Name = "lb_student_name";
            lb_student_name.Size = new Size(104, 20);
            lb_student_name.TabIndex = 1;
            lb_student_name.Text = "Student Name";
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Location = new Point(88, 183);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new Size(50, 20);
            lb_phone.TabIndex = 2;
            lb_phone.Text = "Phone";
            // 
            // lb_address
            // 
            lb_address.AutoSize = true;
            lb_address.Location = new Point(76, 220);
            lb_address.Name = "lb_address";
            lb_address.Size = new Size(62, 20);
            lb_address.TabIndex = 3;
            lb_address.Text = "Address";
            lb_address.Click += lb_address_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(162, 100);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(320, 27);
            txt_id.TabIndex = 5;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(162, 138);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(320, 27);
            txt_name.TabIndex = 6;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(162, 176);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(320, 27);
            txt_phone.TabIndex = 7;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(162, 213);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(320, 27);
            txt_address.TabIndex = 8;
            // 
            // btn_add_student
            // 
            btn_add_student.Location = new Point(233, 308);
            btn_add_student.Name = "btn_add_student";
            btn_add_student.Size = new Size(162, 29);
            btn_add_student.TabIndex = 10;
            btn_add_student.Text = "Add Student";
            btn_add_student.UseVisualStyleBackColor = true;
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(403, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 17;
            lb_co_Name.Text = "TCJ Academy";
            // 
            // txt_type
            // 
            txt_type.Location = new Point(162, 254);
            txt_type.Name = "txt_type";
            txt_type.Size = new Size(320, 27);
            txt_type.TabIndex = 9;
            // 
            // lb_type
            // 
            lb_type.AutoSize = true;
            lb_type.Location = new Point(98, 261);
            lb_type.Name = "lb_type";
            lb_type.Size = new Size(40, 20);
            lb_type.TabIndex = 4;
            lb_type.Text = "Type";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1021, 493);
            Controls.Add(lb_co_Name);
            Controls.Add(btn_add_student);
            Controls.Add(txt_type);
            Controls.Add(txt_address);
            Controls.Add(txt_phone);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(lb_type);
            Controls.Add(lb_address);
            Controls.Add(lb_phone);
            Controls.Add(lb_student_name);
            Controls.Add(lb_student_id);
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_student_id;
        private Label lb_student_name;
        private Label lb_phone;
        private Label lb_address;
        private TextBox txt_id;
        private TextBox txt_name;
        private TextBox txt_phone;
        private TextBox txt_address;
        private Button btn_add_student;
        private Label lb_co_Name;
        private TextBox txt_type;
        private Label lb_type;
    }
}