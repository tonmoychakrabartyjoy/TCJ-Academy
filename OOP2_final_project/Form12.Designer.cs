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
            lbl_amount = new Label();
            txt_amount = new TextBox();
            txt_month = new TextBox();
            lbl_month = new Label();
            lbl_sec = new Label();
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
            lbl_phone.Location = new Point(73, 278);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(48, 20);
            lbl_phone.TabIndex = 28;
            lbl_phone.Text = "Pay id";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(129, 278);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(228, 27);
            txt_phone.TabIndex = 29;
            // 
            // lbl_add_course
            // 
            lbl_add_course.AutoSize = true;
            lbl_add_course.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_add_course.Location = new Point(11, 183);
            lbl_add_course.Name = "lbl_add_course";
            lbl_add_course.Size = new Size(158, 32);
            lbl_add_course.TabIndex = 30;
            lbl_add_course.Text = "Add Course";
            // 
            // lbl_course_code
            // 
            lbl_course_code.AutoSize = true;
            lbl_course_code.Location = new Point(30, 235);
            lbl_course_code.Name = "lbl_course_code";
            lbl_course_code.Size = new Size(93, 20);
            lbl_course_code.TabIndex = 31;
            lbl_course_code.Text = "Course Code";
            // 
            // txt_course_code
            // 
            txt_course_code.Location = new Point(129, 235);
            txt_course_code.Name = "txt_course_code";
            txt_course_code.Size = new Size(228, 27);
            txt_course_code.TabIndex = 32;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(94, 429);
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
            // lbl_amount
            // 
            lbl_amount.AutoSize = true;
            lbl_amount.Location = new Point(61, 327);
            lbl_amount.Name = "lbl_amount";
            lbl_amount.Size = new Size(62, 20);
            lbl_amount.TabIndex = 36;
            lbl_amount.Text = "Amount";
            // 
            // txt_amount
            // 
            txt_amount.Location = new Point(129, 327);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(228, 27);
            txt_amount.TabIndex = 37;
            // 
            // txt_month
            // 
            txt_month.Location = new Point(129, 377);
            txt_month.Name = "txt_month";
            txt_month.Size = new Size(228, 27);
            txt_month.TabIndex = 38;
            // 
            // lbl_month
            // 
            lbl_month.AutoSize = true;
            lbl_month.Location = new Point(71, 384);
            lbl_month.Name = "lbl_month";
            lbl_month.Size = new Size(52, 20);
            lbl_month.TabIndex = 39;
            lbl_month.Text = "Month";
            // 
            // lbl_sec
            // 
            lbl_sec.AutoSize = true;
            lbl_sec.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sec.Location = new Point(429, 232);
            lbl_sec.Name = "lbl_sec";
            lbl_sec.Size = new Size(80, 23);
            lbl_sec.TabIndex = 40;
            lbl_sec.Text = "Sections";
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1026, 537);
            Controls.Add(lbl_sec);
            Controls.Add(lbl_month);
            Controls.Add(txt_month);
            Controls.Add(txt_amount);
            Controls.Add(lbl_amount);
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
        private Label lbl_amount;
        private TextBox txt_amount;
        private TextBox txt_month;
        private Label lbl_month;
        private Label lbl_sec;
    }
}