namespace OOP2_final_project
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            lb_co_Name = new Label();
            btn_exam = new Button();
            lbl_exam_id = new Label();
            lbl_subject = new Label();
            lbl_total_mark = new Label();
            lbl_section = new Label();
            txt_exam_id = new TextBox();
            txt_subject = new TextBox();
            txt_total_mark = new TextBox();
            txt_section = new TextBox();
            panel1 = new Panel();
            date_picker = new DateTimePicker();
            lbl_add_new_exam = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.BackColor = Color.Transparent;
            lb_co_Name.Cursor = Cursors.Hand;
            lb_co_Name.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(367, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(242, 42);
            lb_co_Name.TabIndex = 13;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click;
            // 
            // btn_exam
            // 
            btn_exam.BackColor = Color.MediumSpringGreen;
            btn_exam.Location = new Point(0, 321);
            btn_exam.Name = "btn_exam";
            btn_exam.Size = new Size(327, 55);
            btn_exam.TabIndex = 20;
            btn_exam.Text = "Add Exam";
            btn_exam.UseVisualStyleBackColor = false;
            btn_exam.Click += btn_exam_Click;
            // 
            // lbl_exam_id
            // 
            lbl_exam_id.AutoSize = true;
            lbl_exam_id.Location = new Point(31, 119);
            lbl_exam_id.Name = "lbl_exam_id";
            lbl_exam_id.Size = new Size(64, 20);
            lbl_exam_id.TabIndex = 23;
            lbl_exam_id.Text = "Exam ID";
            // 
            // lbl_subject
            // 
            lbl_subject.AutoSize = true;
            lbl_subject.Location = new Point(37, 161);
            lbl_subject.Name = "lbl_subject";
            lbl_subject.Size = new Size(58, 20);
            lbl_subject.TabIndex = 24;
            lbl_subject.Text = "Subject";
            // 
            // lbl_total_mark
            // 
            lbl_total_mark.AutoSize = true;
            lbl_total_mark.Location = new Point(16, 200);
            lbl_total_mark.Name = "lbl_total_mark";
            lbl_total_mark.Size = new Size(79, 20);
            lbl_total_mark.TabIndex = 25;
            lbl_total_mark.Text = "Total Mark";
            // 
            // lbl_section
            // 
            lbl_section.AutoSize = true;
            lbl_section.Location = new Point(37, 238);
            lbl_section.Name = "lbl_section";
            lbl_section.Size = new Size(58, 20);
            lbl_section.TabIndex = 26;
            lbl_section.Text = "Section";
            // 
            // txt_exam_id
            // 
            txt_exam_id.BorderStyle = BorderStyle.FixedSingle;
            txt_exam_id.Location = new Point(107, 116);
            txt_exam_id.Name = "txt_exam_id";
            txt_exam_id.Size = new Size(190, 27);
            txt_exam_id.TabIndex = 27;
            // 
            // txt_subject
            // 
            txt_subject.BorderStyle = BorderStyle.FixedSingle;
            txt_subject.Location = new Point(107, 158);
            txt_subject.Name = "txt_subject";
            txt_subject.Size = new Size(190, 27);
            txt_subject.TabIndex = 28;
            // 
            // txt_total_mark
            // 
            txt_total_mark.BorderStyle = BorderStyle.FixedSingle;
            txt_total_mark.Location = new Point(107, 197);
            txt_total_mark.Name = "txt_total_mark";
            txt_total_mark.Size = new Size(190, 27);
            txt_total_mark.TabIndex = 29;
            // 
            // txt_section
            // 
            txt_section.BorderStyle = BorderStyle.FixedSingle;
            txt_section.Location = new Point(107, 235);
            txt_section.Name = "txt_section";
            txt_section.Size = new Size(190, 27);
            txt_section.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(date_picker);
            panel1.Controls.Add(lbl_exam_id);
            panel1.Controls.Add(btn_exam);
            panel1.Controls.Add(txt_exam_id);
            panel1.Controls.Add(txt_subject);
            panel1.Controls.Add(txt_total_mark);
            panel1.Controls.Add(txt_section);
            panel1.Controls.Add(lbl_subject);
            panel1.Controls.Add(lbl_total_mark);
            panel1.Controls.Add(lbl_section);
            panel1.Location = new Point(330, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 376);
            panel1.TabIndex = 31;
            // 
            // date_picker
            // 
            date_picker.Location = new Point(16, 277);
            date_picker.Name = "date_picker";
            date_picker.Size = new Size(296, 27);
            date_picker.TabIndex = 32;
            // 
            // lbl_add_new_exam
            // 
            lbl_add_new_exam.AutoSize = true;
            lbl_add_new_exam.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_add_new_exam.Location = new Point(69, 17);
            lbl_add_new_exam.Name = "lbl_add_new_exam";
            lbl_add_new_exam.Size = new Size(210, 34);
            lbl_add_new_exam.TabIndex = 31;
            lbl_add_new_exam.Text = "Add New Exam";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSpringGreen;
            panel2.Controls.Add(lbl_add_new_exam);
            panel2.Location = new Point(330, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(327, 75);
            panel2.TabIndex = 32;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 537);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lb_co_Name);
            DoubleBuffered = true;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private Button btn_exam;
        private Label lbl_exam_id;
        private Label lbl_subject;
        private Label lbl_total_mark;
        private Label lbl_section;
        private TextBox txt_exam_id;
        private TextBox txt_subject;
        private TextBox txt_total_mark;
        private TextBox txt_section;
        private Panel panel1;
        private Label lbl_add_new_exam;
        private DateTimePicker date_picker;
        private Panel panel2;
    }
}