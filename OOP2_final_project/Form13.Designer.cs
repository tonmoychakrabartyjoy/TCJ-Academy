namespace OOP2_final_project
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            lb_co_Name = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lbl_sec = new Label();
            txt_teacher_id = new TextBox();
            lbl_student_id = new Label();
            btn_update = new Button();
            txt_course_code = new TextBox();
            lbl_course_code = new Label();
            lbl_add_course = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.BackColor = Color.Transparent;
            lb_co_Name.Cursor = Cursors.Hand;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(402, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 28;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txt_teacher_id);
            panel1.Controls.Add(lbl_student_id);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(txt_course_code);
            panel1.Controls.Add(lbl_course_code);
            panel1.Controls.Add(lbl_add_course);
            panel1.Location = new Point(172, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 310);
            panel1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(lbl_sec);
            panel2.Location = new Point(410, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 222);
            panel2.TabIndex = 51;
            // 
            // lbl_sec
            // 
            lbl_sec.AutoSize = true;
            lbl_sec.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sec.Location = new Point(3, 3);
            lbl_sec.Name = "lbl_sec";
            lbl_sec.Size = new Size(80, 23);
            lbl_sec.TabIndex = 52;
            lbl_sec.Text = "Sections";
            // 
            // txt_teacher_id
            // 
            txt_teacher_id.BorderStyle = BorderStyle.FixedSingle;
            txt_teacher_id.Location = new Point(107, 22);
            txt_teacher_id.Name = "txt_teacher_id";
            txt_teacher_id.Size = new Size(228, 25);
            txt_teacher_id.TabIndex = 50;
            // 
            // lbl_student_id
            // 
            lbl_student_id.AutoSize = true;
            lbl_student_id.Location = new Point(24, 22);
            lbl_student_id.Name = "lbl_student_id";
            lbl_student_id.Size = new Size(72, 17);
            lbl_student_id.TabIndex = 49;
            lbl_student_id.Text = "Teacher Id";
            // 
            // btn_update
            // 
            btn_update.Cursor = Cursors.Hand;
            btn_update.Location = new Point(89, 197);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(156, 42);
            btn_update.TabIndex = 48;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // txt_course_code
            // 
            txt_course_code.BorderStyle = BorderStyle.FixedSingle;
            txt_course_code.Location = new Point(162, 125);
            txt_course_code.Name = "txt_course_code";
            txt_course_code.Size = new Size(228, 25);
            txt_course_code.TabIndex = 47;
            // 
            // lbl_course_code
            // 
            lbl_course_code.AutoSize = true;
            lbl_course_code.Location = new Point(53, 125);
            lbl_course_code.Name = "lbl_course_code";
            lbl_course_code.Size = new Size(85, 17);
            lbl_course_code.TabIndex = 46;
            lbl_course_code.Text = "Course Code";
            // 
            // lbl_add_course
            // 
            lbl_add_course.AutoSize = true;
            lbl_add_course.Cursor = Cursors.Help;
            lbl_add_course.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_add_course.Location = new Point(15, 76);
            lbl_add_course.Name = "lbl_add_course";
            lbl_add_course.Size = new Size(158, 32);
            lbl_add_course.TabIndex = 45;
            lbl_add_course.Text = "Add Course";
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 539);
            Controls.Add(panel1);
            Controls.Add(lb_co_Name);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form13";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update teacher";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private Panel panel1;
        private Panel panel2;
        private Label lbl_sec;
        private TextBox txt_teacher_id;
        private Label lbl_student_id;
        private Button btn_update;
        private TextBox txt_course_code;
        private Label lbl_course_code;
        private Label lbl_add_course;
    }
}