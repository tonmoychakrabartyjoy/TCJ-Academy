namespace OOP2_final_project
{
    partial class Form18
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
            panel1 = new Panel();
            panel3 = new Panel();
            btn_add_fee = new Button();
            txt_fee = new TextBox();
            txt_code = new TextBox();
            lbl_fee = new Label();
            lbl_course_code = new Label();
            panel2 = new Panel();
            lbl_title = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
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
            lb_co_Name.Location = new Point(387, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 16;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txt_fee);
            panel1.Controls.Add(txt_code);
            panel1.Controls.Add(lbl_fee);
            panel1.Controls.Add(lbl_course_code);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(333, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 285);
            panel1.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleGreen;
            panel3.Controls.Add(btn_add_fee);
            panel3.Location = new Point(0, 224);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 61);
            panel3.TabIndex = 1;
            // 
            // btn_add_fee
            // 
            btn_add_fee.Cursor = Cursors.Hand;
            btn_add_fee.FlatAppearance.BorderSize = 0;
            btn_add_fee.FlatStyle = FlatStyle.Flat;
            btn_add_fee.Location = new Point(3, 0);
            btn_add_fee.Name = "btn_add_fee";
            btn_add_fee.Size = new Size(282, 58);
            btn_add_fee.TabIndex = 0;
            btn_add_fee.Text = "Add Fee";
            btn_add_fee.UseVisualStyleBackColor = true;
            btn_add_fee.Click += btn_add_fee_Click;
            // 
            // txt_fee
            // 
            txt_fee.BorderStyle = BorderStyle.FixedSingle;
            txt_fee.Location = new Point(132, 155);
            txt_fee.Name = "txt_fee";
            txt_fee.Size = new Size(125, 27);
            txt_fee.TabIndex = 4;
            txt_fee.KeyDown += txt_fee_KeyDown;
            // 
            // txt_code
            // 
            txt_code.BorderStyle = BorderStyle.FixedSingle;
            txt_code.Location = new Point(132, 110);
            txt_code.Name = "txt_code";
            txt_code.Size = new Size(125, 27);
            txt_code.TabIndex = 3;
            txt_code.KeyDown += txt_code_KeyDown;
            // 
            // lbl_fee
            // 
            lbl_fee.AutoSize = true;
            lbl_fee.Location = new Point(89, 163);
            lbl_fee.Name = "lbl_fee";
            lbl_fee.Size = new Size(34, 19);
            lbl_fee.TabIndex = 2;
            lbl_fee.Text = "Fee";
            // 
            // lbl_course_code
            // 
            lbl_course_code.AutoSize = true;
            lbl_course_code.Location = new Point(25, 112);
            lbl_course_code.Name = "lbl_course_code";
            lbl_course_code.Size = new Size(98, 19);
            lbl_course_code.TabIndex = 1;
            lbl_course_code.Text = "Course Code";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Controls.Add(lbl_title);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 72);
            panel2.TabIndex = 0;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(36, 23);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(212, 35);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Add course Fee";
            // 
            // Form18
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 537);
            Controls.Add(panel1);
            Controls.Add(lb_co_Name);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form18";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add course fee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private Panel panel1;
        private Panel panel2;
        private TextBox txt_fee;
        private TextBox txt_code;
        private Label lbl_fee;
        private Label lbl_course_code;
        private Label lbl_title;
        private Panel panel3;
        private Button btn_add_fee;
    }
}