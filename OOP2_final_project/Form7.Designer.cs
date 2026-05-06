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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            lb_co_Name = new Label();
            panel1 = new Panel();
            txt_course_fee = new TextBox();
            lbl_course_fee = new Label();
            panel2 = new Panel();
            lbl_sec = new Label();
            btn_add_course = new Button();
            txt_aca_year = new TextBox();
            txt_course_day = new TextBox();
            txt_course_subject = new TextBox();
            lb_disc = new Label();
            lb_course_day = new Label();
            lb_course_subject = new Label();
            lb_course_code = new Label();
            txt_course_code = new TextBox();
            com_section = new ComboBox();
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
            lb_co_Name.Location = new Point(419, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 16;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(txt_course_fee);
            panel1.Controls.Add(lbl_course_fee);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_add_course);
            panel1.Controls.Add(txt_aca_year);
            panel1.Controls.Add(txt_course_day);
            panel1.Controls.Add(txt_course_subject);
            panel1.Controls.Add(lb_disc);
            panel1.Controls.Add(lb_course_day);
            panel1.Controls.Add(lb_course_subject);
            panel1.Controls.Add(lb_course_code);
            panel1.Controls.Add(txt_course_code);
            panel1.Location = new Point(160, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 298);
            panel1.TabIndex = 17;
            // 
            // txt_course_fee
            // 
            txt_course_fee.BorderStyle = BorderStyle.FixedSingle;
            txt_course_fee.Location = new Point(128, 187);
            txt_course_fee.Name = "txt_course_fee";
            txt_course_fee.ReadOnly = true;
            txt_course_fee.Size = new Size(376, 27);
            txt_course_fee.TabIndex = 35;
            txt_course_fee.TextChanged += txt_course_fee_TextChanged;
            // 
            // lbl_course_fee
            // 
            lbl_course_fee.AutoSize = true;
            lbl_course_fee.Location = new Point(9, 189);
            lbl_course_fee.Name = "lbl_course_fee";
            lbl_course_fee.Size = new Size(113, 20);
            lbl_course_fee.TabIndex = 34;
            lbl_course_fee.Text = "Add Course Fee";
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(com_section);
            panel2.Controls.Add(lbl_sec);
            panel2.Location = new Point(531, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(146, 211);
            panel2.TabIndex = 33;
            // 
            // lbl_sec
            // 
            lbl_sec.AutoSize = true;
            lbl_sec.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sec.Location = new Point(3, 3);
            lbl_sec.Name = "lbl_sec";
            lbl_sec.Size = new Size(80, 23);
            lbl_sec.TabIndex = 31;
            lbl_sec.Text = "Sections";
            // 
            // btn_add_course
            // 
            btn_add_course.BackColor = Color.Crimson;
            btn_add_course.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_course.ForeColor = SystemColors.ButtonHighlight;
            btn_add_course.Location = new Point(190, 240);
            btn_add_course.Name = "btn_add_course";
            btn_add_course.Size = new Size(224, 44);
            btn_add_course.TabIndex = 32;
            btn_add_course.Text = "Add Course";
            btn_add_course.UseVisualStyleBackColor = false;
            btn_add_course.Click += btn_add_course_Click;
            // 
            // txt_aca_year
            // 
            txt_aca_year.BorderStyle = BorderStyle.FixedSingle;
            txt_aca_year.Location = new Point(128, 150);
            txt_aca_year.Name = "txt_aca_year";
            txt_aca_year.Size = new Size(376, 27);
            txt_aca_year.TabIndex = 30;
            // 
            // txt_course_day
            // 
            txt_course_day.BorderStyle = BorderStyle.FixedSingle;
            txt_course_day.Location = new Point(128, 107);
            txt_course_day.Name = "txt_course_day";
            txt_course_day.Size = new Size(376, 27);
            txt_course_day.TabIndex = 29;
            // 
            // txt_course_subject
            // 
            txt_course_subject.BorderStyle = BorderStyle.FixedSingle;
            txt_course_subject.Location = new Point(128, 66);
            txt_course_subject.Name = "txt_course_subject";
            txt_course_subject.Size = new Size(376, 27);
            txt_course_subject.TabIndex = 28;
            // 
            // lb_disc
            // 
            lb_disc.AutoSize = true;
            lb_disc.Location = new Point(15, 150);
            lb_disc.Name = "lb_disc";
            lb_disc.Size = new Size(107, 20);
            lb_disc.TabIndex = 27;
            lb_disc.Text = "Academic Year";
            // 
            // lb_course_day
            // 
            lb_course_day.AutoSize = true;
            lb_course_day.Location = new Point(38, 110);
            lb_course_day.Name = "lb_course_day";
            lb_course_day.Size = new Size(84, 20);
            lb_course_day.TabIndex = 26;
            lb_course_day.Text = "Course Day";
            // 
            // lb_course_subject
            // 
            lb_course_subject.AutoSize = true;
            lb_course_subject.Location = new Point(15, 66);
            lb_course_subject.Name = "lb_course_subject";
            lb_course_subject.Size = new Size(107, 20);
            lb_course_subject.TabIndex = 25;
            lb_course_subject.Text = "Course Subject";
            // 
            // lb_course_code
            // 
            lb_course_code.AutoSize = true;
            lb_course_code.Location = new Point(29, 30);
            lb_course_code.Name = "lb_course_code";
            lb_course_code.Size = new Size(93, 20);
            lb_course_code.TabIndex = 24;
            lb_course_code.Text = "Course Code";
            // 
            // txt_course_code
            // 
            txt_course_code.BorderStyle = BorderStyle.FixedSingle;
            txt_course_code.Location = new Point(128, 23);
            txt_course_code.Name = "txt_course_code";
            txt_course_code.ReadOnly = true;
            txt_course_code.Size = new Size(376, 27);
            txt_course_code.TabIndex = 23;
            // 
            // com_section
            // 
            com_section.FormattingEnabled = true;
            com_section.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            com_section.Location = new Point(6, 33);
            com_section.Name = "com_section";
            com_section.Size = new Size(133, 28);
            com_section.TabIndex = 32;
            // 
            // Form7
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
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Course";
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
        private Button btn_add_course;
        private TextBox txt_aca_year;
        private TextBox txt_course_day;
        private TextBox txt_course_subject;
        private Label lb_disc;
        private Label lb_course_day;
        private Label lb_course_subject;
        private Label lb_course_code;
        private TextBox txt_course_code;
        private TextBox txt_course_fee;
        private Label lbl_course_fee;
        private ComboBox com_section;
    }
}