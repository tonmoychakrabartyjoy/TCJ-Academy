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
            lb_co_Name = new Label();
            btn_exam = new Button();
            lbl_exam_id = new Label();
            lbl_subject = new Label();
            lbl_total_mark = new Label();
            lbl_section = new Label();
            txt_exam_id = new TextBox();
            txt_subject = new TextBox();
            txt_total_mark = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(352, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 13;
            lb_co_Name.Text = "TCJ Academy";
            // 
            // btn_exam
            // 
            btn_exam.Location = new Point(392, 291);
            btn_exam.Name = "btn_exam";
            btn_exam.Size = new Size(136, 29);
            btn_exam.TabIndex = 20;
            btn_exam.Text = "Add Exam";
            btn_exam.UseVisualStyleBackColor = true;
            // 
            // lbl_exam_id
            // 
            lbl_exam_id.AutoSize = true;
            lbl_exam_id.Location = new Point(307, 127);
            lbl_exam_id.Name = "lbl_exam_id";
            lbl_exam_id.Size = new Size(64, 20);
            lbl_exam_id.TabIndex = 23;
            lbl_exam_id.Text = "Exam ID";
            // 
            // lbl_subject
            // 
            lbl_subject.AutoSize = true;
            lbl_subject.Location = new Point(313, 162);
            lbl_subject.Name = "lbl_subject";
            lbl_subject.Size = new Size(58, 20);
            lbl_subject.TabIndex = 24;
            lbl_subject.Text = "Subject";
            // 
            // lbl_total_mark
            // 
            lbl_total_mark.AutoSize = true;
            lbl_total_mark.Location = new Point(292, 201);
            lbl_total_mark.Name = "lbl_total_mark";
            lbl_total_mark.Size = new Size(79, 20);
            lbl_total_mark.TabIndex = 25;
            lbl_total_mark.Text = "Total Mark";
            // 
            // lbl_section
            // 
            lbl_section.AutoSize = true;
            lbl_section.Location = new Point(313, 236);
            lbl_section.Name = "lbl_section";
            lbl_section.Size = new Size(58, 20);
            lbl_section.TabIndex = 26;
            lbl_section.Text = "Section";
            // 
            // txt_exam_id
            // 
            txt_exam_id.Location = new Point(377, 127);
            txt_exam_id.Name = "txt_exam_id";
            txt_exam_id.Size = new Size(190, 27);
            txt_exam_id.TabIndex = 27;
            // 
            // txt_subject
            // 
            txt_subject.Location = new Point(377, 162);
            txt_subject.Name = "txt_subject";
            txt_subject.Size = new Size(190, 27);
            txt_subject.TabIndex = 28;
            // 
            // txt_total_mark
            // 
            txt_total_mark.Location = new Point(377, 198);
            txt_total_mark.Name = "txt_total_mark";
            txt_total_mark.Size = new Size(190, 27);
            txt_total_mark.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(377, 236);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 30;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1006, 542);
            Controls.Add(textBox1);
            Controls.Add(txt_total_mark);
            Controls.Add(txt_subject);
            Controls.Add(txt_exam_id);
            Controls.Add(lbl_section);
            Controls.Add(lbl_total_mark);
            Controls.Add(lbl_subject);
            Controls.Add(lbl_exam_id);
            Controls.Add(btn_exam);
            Controls.Add(lb_co_Name);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam";
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
        private TextBox textBox1;
    }
}