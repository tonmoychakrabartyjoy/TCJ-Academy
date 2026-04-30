namespace OOP2_final_project
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            lb_co_Name = new Label();
            panel1 = new Panel();
            txt_subject = new TextBox();
            lb_subject = new Label();
            btn_add_teacher = new Button();
            txt_address = new TextBox();
            txt_phone = new TextBox();
            txt_name = new TextBox();
            txt_id = new TextBox();
            lb_address = new Label();
            lb_phone = new Label();
            lb_teacher_name = new Label();
            lb_teacher_id = new Label();
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
            lb_co_Name.Location = new Point(410, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 22;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(txt_subject);
            panel1.Controls.Add(lb_subject);
            panel1.Controls.Add(btn_add_teacher);
            panel1.Controls.Add(txt_address);
            panel1.Controls.Add(txt_phone);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(txt_id);
            panel1.Controls.Add(lb_address);
            panel1.Controls.Add(lb_phone);
            panel1.Controls.Add(lb_teacher_name);
            panel1.Controls.Add(lb_teacher_id);
            panel1.Location = new Point(187, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 317);
            panel1.TabIndex = 23;
            // 
            // txt_subject
            // 
            txt_subject.BorderStyle = BorderStyle.FixedSingle;
            txt_subject.Location = new Point(192, 199);
            txt_subject.Name = "txt_subject";
            txt_subject.Size = new Size(320, 27);
            txt_subject.TabIndex = 35;
            // 
            // lb_subject
            // 
            lb_subject.AutoSize = true;
            lb_subject.Location = new Point(110, 202);
            lb_subject.Name = "lb_subject";
            lb_subject.Size = new Size(58, 20);
            lb_subject.TabIndex = 34;
            lb_subject.Text = "Subject";
            // 
            // btn_add_teacher
            // 
            btn_add_teacher.Cursor = Cursors.Hand;
            btn_add_teacher.Location = new Point(246, 244);
            btn_add_teacher.Name = "btn_add_teacher";
            btn_add_teacher.Size = new Size(162, 42);
            btn_add_teacher.TabIndex = 33;
            btn_add_teacher.Text = "Add Teacher";
            btn_add_teacher.UseVisualStyleBackColor = true;
            btn_add_teacher.Click += btn_add_teacher_Click;
            // 
            // txt_address
            // 
            txt_address.BorderStyle = BorderStyle.FixedSingle;
            txt_address.Location = new Point(192, 155);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(320, 27);
            txt_address.TabIndex = 32;
            // 
            // txt_phone
            // 
            txt_phone.BorderStyle = BorderStyle.FixedSingle;
            txt_phone.Location = new Point(192, 118);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(320, 27);
            txt_phone.TabIndex = 31;
            // 
            // txt_name
            // 
            txt_name.BorderStyle = BorderStyle.FixedSingle;
            txt_name.Location = new Point(192, 80);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(320, 27);
            txt_name.TabIndex = 30;
            // 
            // txt_id
            // 
            txt_id.BorderStyle = BorderStyle.FixedSingle;
            txt_id.Location = new Point(192, 42);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(320, 27);
            txt_id.TabIndex = 29;
            // 
            // lb_address
            // 
            lb_address.AutoSize = true;
            lb_address.Location = new Point(106, 162);
            lb_address.Name = "lb_address";
            lb_address.Size = new Size(62, 20);
            lb_address.TabIndex = 28;
            lb_address.Text = "Address";
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Location = new Point(118, 125);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new Size(50, 20);
            lb_phone.TabIndex = 27;
            lb_phone.Text = "Phone";
            // 
            // lb_teacher_name
            // 
            lb_teacher_name.AutoSize = true;
            lb_teacher_name.Location = new Point(64, 87);
            lb_teacher_name.Name = "lb_teacher_name";
            lb_teacher_name.Size = new Size(104, 20);
            lb_teacher_name.TabIndex = 26;
            lb_teacher_name.Text = "Teacher Name";
            // 
            // lb_teacher_id
            // 
            lb_teacher_id.AutoSize = true;
            lb_teacher_id.Location = new Point(91, 49);
            lb_teacher_id.Name = "lb_teacher_id";
            lb_teacher_id.Size = new Size(77, 20);
            lb_teacher_id.TabIndex = 25;
            lb_teacher_id.Text = "Teacher Id";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1022, 543);
            Controls.Add(panel1);
            Controls.Add(lb_co_Name);
            DoubleBuffered = true;
            Name = "Form9";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add teacher";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_co_Name;
        private Panel panel1;
        private TextBox txt_subject;
        private Label lb_subject;
        private Button btn_add_teacher;
        private TextBox txt_address;
        private TextBox txt_phone;
        private TextBox txt_name;
        private TextBox txt_id;
        private Label lb_address;
        private Label lb_phone;
        private Label lb_teacher_name;
        private Label lb_teacher_id;
    }
}