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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            lb_co_Name = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lbl_sec = new Label();
            lbl_month = new Label();
            txt_month = new TextBox();
            txt_amount = new TextBox();
            lbl_amount = new Label();
            txt_student_id = new TextBox();
            lbl_student_id = new Label();
            btn_update = new Button();
            txt_course_code = new TextBox();
            lbl_course_code = new Label();
            lbl_add_course = new Label();
            txt_pay_id = new TextBox();
            lbl_phone = new Label();
            cbD = new CheckBox();
            cbC = new CheckBox();
            cbB = new CheckBox();
            cbA = new CheckBox();
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
            lb_co_Name.Location = new Point(404, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 27;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lbl_month);
            panel1.Controls.Add(txt_month);
            panel1.Controls.Add(txt_amount);
            panel1.Controls.Add(lbl_amount);
            panel1.Controls.Add(txt_student_id);
            panel1.Controls.Add(lbl_student_id);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(txt_course_code);
            panel1.Controls.Add(lbl_course_code);
            panel1.Controls.Add(lbl_add_course);
            panel1.Controls.Add(txt_pay_id);
            panel1.Controls.Add(lbl_phone);
            panel1.Location = new Point(166, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 392);
            panel1.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(cbD);
            panel2.Controls.Add(cbC);
            panel2.Controls.Add(cbB);
            panel2.Controls.Add(cbA);
            panel2.Controls.Add(lbl_sec);
            panel2.Location = new Point(400, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 271);
            panel2.TabIndex = 29;
            // 
            // lbl_sec
            // 
            lbl_sec.AutoSize = true;
            lbl_sec.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sec.Location = new Point(3, 3);
            lbl_sec.Name = "lbl_sec";
            lbl_sec.Size = new Size(80, 23);
            lbl_sec.TabIndex = 54;
            lbl_sec.Text = "Sections";
            // 
            // lbl_month
            // 
            lbl_month.AutoSize = true;
            lbl_month.Location = new Point(108, 279);
            lbl_month.Name = "lbl_month";
            lbl_month.Size = new Size(52, 20);
            lbl_month.TabIndex = 52;
            lbl_month.Text = "Month";
            // 
            // txt_month
            // 
            txt_month.BorderStyle = BorderStyle.FixedSingle;
            txt_month.Location = new Point(166, 272);
            txt_month.Name = "txt_month";
            txt_month.Size = new Size(228, 27);
            txt_month.TabIndex = 51;
            txt_month.KeyDown += txt_month_KeyDown;
            // 
            // txt_amount
            // 
            txt_amount.BorderStyle = BorderStyle.FixedSingle;
            txt_amount.Location = new Point(166, 222);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(228, 27);
            txt_amount.TabIndex = 50;
            txt_amount.KeyDown += txt_amount_KeyDown;
            // 
            // lbl_amount
            // 
            lbl_amount.AutoSize = true;
            lbl_amount.Location = new Point(98, 222);
            lbl_amount.Name = "lbl_amount";
            lbl_amount.Size = new Size(62, 20);
            lbl_amount.TabIndex = 49;
            lbl_amount.Text = "Amount";
            // 
            // txt_student_id
            // 
            txt_student_id.BorderStyle = BorderStyle.FixedSingle;
            txt_student_id.Location = new Point(131, 28);
            txt_student_id.Name = "txt_student_id";
            txt_student_id.Size = new Size(228, 27);
            txt_student_id.TabIndex = 48;
            txt_student_id.KeyDown += txt_student_id_KeyDown;
            // 
            // lbl_student_id
            // 
            lbl_student_id.AutoSize = true;
            lbl_student_id.Location = new Point(48, 28);
            lbl_student_id.Name = "lbl_student_id";
            lbl_student_id.Size = new Size(77, 20);
            lbl_student_id.TabIndex = 47;
            lbl_student_id.Text = "Student Id";
            // 
            // btn_update
            // 
            btn_update.Cursor = Cursors.Hand;
            btn_update.Location = new Point(238, 345);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(156, 29);
            btn_update.TabIndex = 46;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // txt_course_code
            // 
            txt_course_code.BorderStyle = BorderStyle.FixedSingle;
            txt_course_code.Location = new Point(166, 130);
            txt_course_code.Name = "txt_course_code";
            txt_course_code.Size = new Size(228, 27);
            txt_course_code.TabIndex = 45;
            txt_course_code.KeyDown += txt_course_code_KeyDown;
            // 
            // lbl_course_code
            // 
            lbl_course_code.AutoSize = true;
            lbl_course_code.Location = new Point(67, 130);
            lbl_course_code.Name = "lbl_course_code";
            lbl_course_code.Size = new Size(93, 20);
            lbl_course_code.TabIndex = 44;
            lbl_course_code.Text = "Course Code";
            // 
            // lbl_add_course
            // 
            lbl_add_course.AutoSize = true;
            lbl_add_course.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_add_course.Location = new Point(48, 78);
            lbl_add_course.Name = "lbl_add_course";
            lbl_add_course.Size = new Size(158, 32);
            lbl_add_course.TabIndex = 43;
            lbl_add_course.Text = "Add Course";
            // 
            // txt_pay_id
            // 
            txt_pay_id.BorderStyle = BorderStyle.FixedSingle;
            txt_pay_id.Location = new Point(166, 173);
            txt_pay_id.Name = "txt_pay_id";
            txt_pay_id.Size = new Size(228, 27);
            txt_pay_id.TabIndex = 42;
            txt_pay_id.TextChanged += txt_pay_id_TextChanged;
            txt_pay_id.KeyDown += txt_pay_id_KeyDown;
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(110, 173);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(48, 20);
            lbl_phone.TabIndex = 41;
            lbl_phone.Text = "Pay id";
            // 
            // cbD
            // 
            cbD.AutoSize = true;
            cbD.Location = new Point(51, 173);
            cbD.Name = "cbD";
            cbD.Size = new Size(42, 24);
            cbD.TabIndex = 58;
            cbD.Text = "D";
            cbD.UseVisualStyleBackColor = true;
            // 
            // cbC
            // 
            cbC.AutoSize = true;
            cbC.Location = new Point(50, 129);
            cbC.Name = "cbC";
            cbC.Size = new Size(40, 24);
            cbC.TabIndex = 57;
            cbC.Text = "C";
            cbC.UseVisualStyleBackColor = true;
            // 
            // cbB
            // 
            cbB.AutoSize = true;
            cbB.Location = new Point(51, 89);
            cbB.Name = "cbB";
            cbB.Size = new Size(40, 24);
            cbB.TabIndex = 56;
            cbB.Text = "B";
            cbB.UseVisualStyleBackColor = true;
            // 
            // cbA
            // 
            cbA.AutoSize = true;
            cbA.Location = new Point(51, 50);
            cbA.Name = "cbA";
            cbA.Size = new Size(41, 24);
            cbA.TabIndex = 55;
            cbA.Text = "A";
            cbA.UseVisualStyleBackColor = true;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 537);
            Controls.Add(panel1);
            Controls.Add(lb_co_Name);
            DoubleBuffered = true;
            Name = "Form12";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Student";
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
        private Label lbl_month;
        private TextBox txt_month;
        private TextBox txt_amount;
        private Label lbl_amount;
        private TextBox txt_student_id;
        private Label lbl_student_id;
        private Button btn_update;
        private TextBox txt_course_code;
        private Label lbl_course_code;
        private Label lbl_add_course;
        private TextBox txt_pay_id;
        private Label lbl_phone;
        private CheckBox cbD;
        private CheckBox cbC;
        private CheckBox cbB;
        private CheckBox cbA;
    }
}