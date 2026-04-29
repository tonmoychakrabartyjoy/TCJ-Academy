namespace OOP2_final_project
{
    partial class Form7
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
            txt_course_title = new TextBox();
            lb_course_code = new Label();
            lb_course_subject = new Label();
            lb_course_day = new Label();
            lb_disc = new Label();
            txt_course_subject = new TextBox();
            txt_course_day = new TextBox();
            txt_course_dis = new TextBox();
            lb_co_Name = new Label();
            lbl_sec = new Label();
            btn_add_course = new Button();
            SuspendLayout();
            // 
            // txt_course_title
            // 
            txt_course_title.Location = new Point(157, 63);
            txt_course_title.Name = "txt_course_title";
            txt_course_title.Size = new Size(376, 27);
            txt_course_title.TabIndex = 0;
            // 
            // lb_course_code
            // 
            lb_course_code.AutoSize = true;
            lb_course_code.Location = new Point(55, 70);
            lb_course_code.Name = "lb_course_code";
            lb_course_code.Size = new Size(93, 20);
            lb_course_code.TabIndex = 1;
            lb_course_code.Text = "Course Code";
            // 
            // lb_course_subject
            // 
            lb_course_subject.AutoSize = true;
            lb_course_subject.Location = new Point(32, 113);
            lb_course_subject.Name = "lb_course_subject";
            lb_course_subject.Size = new Size(107, 20);
            lb_course_subject.TabIndex = 2;
            lb_course_subject.Text = "Course Subject";
            // 
            // lb_course_day
            // 
            lb_course_day.AutoSize = true;
            lb_course_day.Location = new Point(55, 154);
            lb_course_day.Name = "lb_course_day";
            lb_course_day.Size = new Size(84, 20);
            lb_course_day.TabIndex = 3;
            lb_course_day.Text = "Course Day";
            // 
            // lb_disc
            // 
            lb_disc.AutoSize = true;
            lb_disc.Location = new Point(32, 204);
            lb_disc.Name = "lb_disc";
            lb_disc.Size = new Size(107, 20);
            lb_disc.TabIndex = 4;
            lb_disc.Text = "Academic Year";
            // 
            // txt_course_subject
            // 
            txt_course_subject.Location = new Point(157, 106);
            txt_course_subject.Name = "txt_course_subject";
            txt_course_subject.Size = new Size(376, 27);
            txt_course_subject.TabIndex = 5;
            // 
            // txt_course_day
            // 
            txt_course_day.Location = new Point(157, 147);
            txt_course_day.Name = "txt_course_day";
            txt_course_day.Size = new Size(376, 27);
            txt_course_day.TabIndex = 6;
            // 
            // txt_course_dis
            // 
            txt_course_dis.Location = new Point(157, 197);
            txt_course_dis.Name = "txt_course_dis";
            txt_course_dis.Size = new Size(376, 27);
            txt_course_dis.TabIndex = 7;
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(466, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 16;
            lb_co_Name.Text = "TCJ Academy";
            // 
            // lbl_sec
            // 
            lbl_sec.AutoSize = true;
            lbl_sec.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sec.Location = new Point(614, 88);
            lbl_sec.Name = "lbl_sec";
            lbl_sec.Size = new Size(80, 23);
            lbl_sec.TabIndex = 17;
            lbl_sec.Text = "Sections";
            // 
            // btn_add_course
            // 
            btn_add_course.Location = new Point(200, 312);
            btn_add_course.Name = "btn_add_course";
            btn_add_course.Size = new Size(162, 29);
            btn_add_course.TabIndex = 22;
            btn_add_course.Text = "Add Course";
            btn_add_course.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1021, 502);
            Controls.Add(btn_add_course);
            Controls.Add(lbl_sec);
            Controls.Add(lb_co_Name);
            Controls.Add(txt_course_dis);
            Controls.Add(txt_course_day);
            Controls.Add(txt_course_subject);
            Controls.Add(lb_disc);
            Controls.Add(lb_course_day);
            Controls.Add(lb_course_subject);
            Controls.Add(lb_course_code);
            Controls.Add(txt_course_title);
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Course";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_course_title;
        private Label lb_course_code;
        private Label lb_course_subject;
        private Label lb_course_day;
        private Label lb_disc;
        private TextBox txt_course_subject;
        private TextBox txt_course_day;
        private TextBox txt_course_dis;
        private Label lb_co_Name;
        private Label lbl_sec;
        private Button btn_add_course;
    }
}