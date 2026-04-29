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
            lb_co_Name = new Label();
            txt_teacher_id = new TextBox();
            lbl_student_id = new Label();
            btn_update = new Button();
            txt_course_code = new TextBox();
            lbl_course_code = new Label();
            lbl_add_course = new Label();
            lbl_sec = new Label();
            SuspendLayout();
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(402, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 28;
            lb_co_Name.Text = "TCJ Academy";
            // 
            // txt_teacher_id
            // 
            txt_teacher_id.Location = new Point(104, 81);
            txt_teacher_id.Name = "txt_teacher_id";
            txt_teacher_id.Size = new Size(228, 25);
            txt_teacher_id.TabIndex = 43;
            // 
            // lbl_student_id
            // 
            lbl_student_id.AutoSize = true;
            lbl_student_id.Location = new Point(21, 81);
            lbl_student_id.Name = "lbl_student_id";
            lbl_student_id.Size = new Size(72, 17);
            lbl_student_id.TabIndex = 42;
            lbl_student_id.Text = "Teacher Id";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(75, 398);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(156, 29);
            btn_update.TabIndex = 41;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // txt_course_code
            // 
            txt_course_code.Location = new Point(159, 184);
            txt_course_code.Name = "txt_course_code";
            txt_course_code.Size = new Size(228, 25);
            txt_course_code.TabIndex = 40;
            // 
            // lbl_course_code
            // 
            lbl_course_code.AutoSize = true;
            lbl_course_code.Location = new Point(50, 184);
            lbl_course_code.Name = "lbl_course_code";
            lbl_course_code.Size = new Size(85, 17);
            lbl_course_code.TabIndex = 39;
            lbl_course_code.Text = "Course Code";
            // 
            // lbl_add_course
            // 
            lbl_add_course.AutoSize = true;
            lbl_add_course.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_add_course.Location = new Point(12, 135);
            lbl_add_course.Name = "lbl_add_course";
            lbl_add_course.Size = new Size(158, 32);
            lbl_add_course.TabIndex = 38;
            lbl_add_course.Text = "Add Course";
            // 
            // lbl_sec
            // 
            lbl_sec.AutoSize = true;
            lbl_sec.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sec.Location = new Point(55, 233);
            lbl_sec.Name = "lbl_sec";
            lbl_sec.Size = new Size(80, 23);
            lbl_sec.TabIndex = 44;
            lbl_sec.Text = "Sections";
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1024, 539);
            Controls.Add(lbl_sec);
            Controls.Add(txt_teacher_id);
            Controls.Add(lbl_student_id);
            Controls.Add(btn_update);
            Controls.Add(txt_course_code);
            Controls.Add(lbl_course_code);
            Controls.Add(lbl_add_course);
            Controls.Add(lb_co_Name);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form13";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update teacher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private TextBox txt_teacher_id;
        private Label lbl_student_id;
        private Button btn_update;
        private TextBox txt_course_code;
        private Label lbl_course_code;
        private Label lbl_add_course;
        private Label lbl_sec;
    }
}