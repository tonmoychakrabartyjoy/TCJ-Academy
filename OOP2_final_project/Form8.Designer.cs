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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            lb_co_Name = new Label();
            panel1 = new Panel();
            btn_add_student = new Button();
            txt_type = new TextBox();
            txt_address = new TextBox();
            txt_phone = new TextBox();
            txt_name = new TextBox();
            txt_id = new TextBox();
            lb_type = new Label();
            lb_address = new Label();
            lb_phone = new Label();
            lb_student_name = new Label();
            lb_student_id = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.BackColor = Color.Transparent;
            lb_co_Name.Cursor = Cursors.Hand;
            lb_co_Name.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(403, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(224, 38);
            lb_co_Name.TabIndex = 17;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btn_add_student);
            panel1.Controls.Add(txt_type);
            panel1.Controls.Add(txt_address);
            panel1.Controls.Add(txt_phone);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(txt_id);
            panel1.Controls.Add(lb_type);
            panel1.Controls.Add(lb_address);
            panel1.Controls.Add(lb_phone);
            panel1.Controls.Add(lb_student_name);
            panel1.Controls.Add(lb_student_id);
            panel1.Location = new Point(221, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 318);
            panel1.TabIndex = 18;
            // 
            // btn_add_student
            // 
            btn_add_student.Cursor = Cursors.Hand;
            btn_add_student.Location = new Point(235, 244);
            btn_add_student.Name = "btn_add_student";
            btn_add_student.Size = new Size(162, 29);
            btn_add_student.TabIndex = 21;
            btn_add_student.Text = "Add Student";
            btn_add_student.UseVisualStyleBackColor = true;
            btn_add_student.Click += btn_add_student_Click;
            // 
            // txt_type
            // 
            txt_type.BorderStyle = BorderStyle.FixedSingle;
            txt_type.Location = new Point(164, 190);
            txt_type.Name = "txt_type";
            txt_type.Size = new Size(320, 27);
            txt_type.TabIndex = 20;
            // 
            // txt_address
            // 
            txt_address.BorderStyle = BorderStyle.FixedSingle;
            txt_address.Location = new Point(164, 149);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(320, 27);
            txt_address.TabIndex = 19;
            // 
            // txt_phone
            // 
            txt_phone.BorderStyle = BorderStyle.FixedSingle;
            txt_phone.Location = new Point(164, 112);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(320, 27);
            txt_phone.TabIndex = 18;
            // 
            // txt_name
            // 
            txt_name.BorderStyle = BorderStyle.FixedSingle;
            txt_name.Location = new Point(164, 74);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(320, 27);
            txt_name.TabIndex = 17;
            // 
            // txt_id
            // 
            txt_id.BorderStyle = BorderStyle.FixedSingle;
            txt_id.Location = new Point(164, 36);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(320, 27);
            txt_id.TabIndex = 16;
            // 
            // lb_type
            // 
            lb_type.AutoSize = true;
            lb_type.Location = new Point(100, 197);
            lb_type.Name = "lb_type";
            lb_type.Size = new Size(40, 20);
            lb_type.TabIndex = 15;
            lb_type.Text = "Type";
            // 
            // lb_address
            // 
            lb_address.AutoSize = true;
            lb_address.Location = new Point(78, 156);
            lb_address.Name = "lb_address";
            lb_address.Size = new Size(62, 20);
            lb_address.TabIndex = 14;
            lb_address.Text = "Address";
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Location = new Point(90, 119);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new Size(50, 20);
            lb_phone.TabIndex = 13;
            lb_phone.Text = "Phone";
            // 
            // lb_student_name
            // 
            lb_student_name.AutoSize = true;
            lb_student_name.Location = new Point(36, 81);
            lb_student_name.Name = "lb_student_name";
            lb_student_name.Size = new Size(104, 20);
            lb_student_name.TabIndex = 12;
            lb_student_name.Text = "Student Name";
            // 
            // lb_student_id
            // 
            lb_student_id.AutoSize = true;
            lb_student_id.Location = new Point(63, 43);
            lb_student_id.Name = "lb_student_id";
            lb_student_id.Size = new Size(77, 20);
            lb_student_id.TabIndex = 11;
            lb_student_id.Text = "Student Id";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 537);
            Controls.Add(panel1);
            Controls.Add(lb_co_Name);
            DoubleBuffered = true;
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Student";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_co_Name;
        private Panel panel1;
        private Button btn_add_student;
        private TextBox txt_type;
        private TextBox txt_address;
        private TextBox txt_phone;
        private TextBox txt_name;
        private TextBox txt_id;
        private Label lb_type;
        private Label lb_address;
        private Label lb_phone;
        private Label lb_student_name;
        private Label lb_student_id;
    }
}