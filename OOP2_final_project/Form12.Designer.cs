namespace OOP2_final_project
{
    partial class Form12
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
            lbl_phone = new Label();
            txt_phone = new TextBox();
            lbl_add_course = new Label();
            lbl_course_code = new Label();
            txt_course_code = new TextBox();
            btn_update = new Button();
            lbl_student_id = new Label();
            txt_student_id = new TextBox();
            SuspendLayout();
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(416, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 27;
            lb_co_Name.Text = "TCJ Academy";
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(38, 208);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(50, 20);
            lbl_phone.TabIndex = 28;
            lbl_phone.Text = "Phone";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(94, 205);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(228, 27);
            txt_phone.TabIndex = 29;
            // 
            // lbl_add_course
            // 
            lbl_add_course.AutoSize = true;
            lbl_add_course.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_add_course.Location = new Point(12, 249);
            lbl_add_course.Name = "lbl_add_course";
            lbl_add_course.Size = new Size(158, 32);
            lbl_add_course.TabIndex = 30;
            lbl_add_course.Text = "Add Course";
            // 
            // lbl_course_code
            // 
            lbl_course_code.AutoSize = true;
            lbl_course_code.Location = new Point(25, 309);
            lbl_course_code.Name = "lbl_course_code";
            lbl_course_code.Size = new Size(93, 20);
            lbl_course_code.TabIndex = 31;
            lbl_course_code.Text = "Course Code";
            // 
            // txt_course_code
            // 
            txt_course_code.Location = new Point(124, 302);
            txt_course_code.Name = "txt_course_code";
            txt_course_code.Size = new Size(228, 27);
            txt_course_code.TabIndex = 32;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(94, 366);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(156, 29);
            btn_update.TabIndex = 33;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // lbl_student_id
            // 
            lbl_student_id.AutoSize = true;
            lbl_student_id.Location = new Point(11, 133);
            lbl_student_id.Name = "lbl_student_id";
            lbl_student_id.Size = new Size(77, 20);
            lbl_student_id.TabIndex = 34;
            lbl_student_id.Text = "Student Id";
            // 
            // txt_student_id
            // 
            txt_student_id.Location = new Point(94, 133);
            txt_student_id.Name = "txt_student_id";
            txt_student_id.Size = new Size(228, 27);
            txt_student_id.TabIndex = 35;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1026, 525);
            Controls.Add(txt_student_id);
            Controls.Add(lbl_student_id);
            Controls.Add(btn_update);
            Controls.Add(txt_course_code);
            Controls.Add(lbl_course_code);
            Controls.Add(lbl_add_course);
            Controls.Add(txt_phone);
            Controls.Add(lbl_phone);
            Controls.Add(lb_co_Name);
            Name = "Form12";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private Label lbl_phone;
        private TextBox txt_phone;
        private Label lbl_add_course;
        private Label lbl_course_code;
        private TextBox txt_course_code;
        private Button btn_update;
        private Label lbl_student_id;
        private TextBox txt_student_id;
    }
}