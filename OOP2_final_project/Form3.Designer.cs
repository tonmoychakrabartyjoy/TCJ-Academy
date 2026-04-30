namespace OOP2_final_project
{
    partial class Form3
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
            btn_add_course = new Button();
            btn_add_student = new Button();
            btn_add_teacher = new Button();
            btn_update_student = new Button();
            btn_update_teacher = new Button();
            btn_student_list = new Button();
            btn_teacher_list = new Button();
            btn_add_exam = new Button();
            btn_upload_result = new Button();
            SuspendLayout();
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(390, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 12;
            lb_co_Name.Text = "TCJ Academy";
            // 
            // btn_add_course
            // 
            btn_add_course.Location = new Point(12, 77);
            btn_add_course.Name = "btn_add_course";
            btn_add_course.Size = new Size(136, 29);
            btn_add_course.TabIndex = 13;
            btn_add_course.Text = "Add Course";
            btn_add_course.UseVisualStyleBackColor = true;
            // 
            // btn_add_student
            // 
            btn_add_student.Location = new Point(12, 112);
            btn_add_student.Name = "btn_add_student";
            btn_add_student.Size = new Size(136, 29);
            btn_add_student.TabIndex = 14;
            btn_add_student.Text = "Add Student";
            btn_add_student.UseVisualStyleBackColor = true;
            // 
            // btn_add_teacher
            // 
            btn_add_teacher.Location = new Point(12, 147);
            btn_add_teacher.Name = "btn_add_teacher";
            btn_add_teacher.Size = new Size(136, 29);
            btn_add_teacher.TabIndex = 15;
            btn_add_teacher.Text = "Add Teacher";
            btn_add_teacher.UseVisualStyleBackColor = true;
            // 
            // btn_update_student
            // 
            btn_update_student.Location = new Point(12, 252);
            btn_update_student.Name = "btn_update_student";
            btn_update_student.Size = new Size(136, 29);
            btn_update_student.TabIndex = 16;
            btn_update_student.Text = "Update Student";
            btn_update_student.UseVisualStyleBackColor = true;
            // 
            // btn_update_teacher
            // 
            btn_update_teacher.Location = new Point(12, 287);
            btn_update_teacher.Name = "btn_update_teacher";
            btn_update_teacher.Size = new Size(136, 29);
            btn_update_teacher.TabIndex = 17;
            btn_update_teacher.Text = "Update Teacher";
            btn_update_teacher.UseVisualStyleBackColor = true;
            // 
            // btn_student_list
            // 
            btn_student_list.Location = new Point(12, 182);
            btn_student_list.Name = "btn_student_list";
            btn_student_list.Size = new Size(136, 29);
            btn_student_list.TabIndex = 19;
            btn_student_list.Text = "Student List";
            btn_student_list.UseVisualStyleBackColor = true;
            // 
            // btn_teacher_list
            // 
            btn_teacher_list.Location = new Point(12, 217);
            btn_teacher_list.Name = "btn_teacher_list";
            btn_teacher_list.Size = new Size(136, 29);
            btn_teacher_list.TabIndex = 20;
            btn_teacher_list.Text = "Teacher List";
            btn_teacher_list.UseVisualStyleBackColor = true;
            // 
            // btn_add_exam
            // 
            btn_add_exam.Location = new Point(12, 322);
            btn_add_exam.Name = "btn_add_exam";
            btn_add_exam.Size = new Size(136, 29);
            btn_add_exam.TabIndex = 21;
            btn_add_exam.Text = "Add Exam";
            btn_add_exam.UseVisualStyleBackColor = true;
            // 
            // btn_upload_result
            // 
            btn_upload_result.Location = new Point(12, 357);
            btn_upload_result.Name = "btn_upload_result";
            btn_upload_result.Size = new Size(136, 29);
            btn_upload_result.TabIndex = 22;
            btn_upload_result.Text = "Upload Result";
            btn_upload_result.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1006, 540);
            Controls.Add(btn_upload_result);
            Controls.Add(btn_add_exam);
            Controls.Add(btn_teacher_list);
            Controls.Add(btn_student_list);
            Controls.Add(btn_update_teacher);
            Controls.Add(btn_update_student);
            Controls.Add(btn_add_teacher);
            Controls.Add(btn_add_student);
            Controls.Add(btn_add_course);
            Controls.Add(lb_co_Name);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee page";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private Button btn_add_course;
        private Button btn_add_student;
        private Button btn_add_teacher;
        private Button btn_update_student;
        private Button btn_update_teacher;
        private Button btn_student_list;
        private Button btn_teacher_list;
        private Button btn_add_exam;
        private Button btn_upload_result;
    }
}