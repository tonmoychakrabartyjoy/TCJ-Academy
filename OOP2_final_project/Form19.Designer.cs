namespace OOP2_final_project
{
    partial class Form19
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
            panel3 = new Panel();
            btn_add_sal = new Button();
            panel1 = new Panel();
            txt_salary = new TextBox();
            txt_id = new TextBox();
            lbl_salary = new Label();
            lbl_teacher_id = new Label();
            panel2 = new Panel();
            lbl_title = new Label();
            lb_co_Name = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleGreen;
            panel3.Controls.Add(btn_add_sal);
            panel3.Location = new Point(348, 350);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 61);
            panel3.TabIndex = 18;
            // 
            // btn_add_sal
            // 
            btn_add_sal.Cursor = Cursors.Hand;
            btn_add_sal.FlatAppearance.BorderSize = 0;
            btn_add_sal.FlatStyle = FlatStyle.Flat;
            btn_add_sal.Location = new Point(3, 3);
            btn_add_sal.Name = "btn_add_sal";
            btn_add_sal.Size = new Size(282, 55);
            btn_add_sal.TabIndex = 0;
            btn_add_sal.Text = "Add salary";
            btn_add_sal.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_salary);
            panel1.Controls.Add(txt_id);
            panel1.Controls.Add(lbl_salary);
            panel1.Controls.Add(lbl_teacher_id);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(348, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 285);
            panel1.TabIndex = 20;
            // 
            // txt_salary
            // 
            txt_salary.BorderStyle = BorderStyle.FixedSingle;
            txt_salary.Location = new Point(113, 134);
            txt_salary.Name = "txt_salary";
            txt_salary.Size = new Size(125, 27);
            txt_salary.TabIndex = 4;
            // 
            // txt_id
            // 
            txt_id.BorderStyle = BorderStyle.FixedSingle;
            txt_id.Location = new Point(113, 89);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(125, 27);
            txt_id.TabIndex = 3;
            // 
            // lbl_salary
            // 
            lbl_salary.AutoSize = true;
            lbl_salary.Location = new Point(58, 141);
            lbl_salary.Name = "lbl_salary";
            lbl_salary.Size = new Size(49, 20);
            lbl_salary.TabIndex = 2;
            lbl_salary.Text = "Salary";
            // 
            // lbl_teacher_id
            // 
            lbl_teacher_id.AutoSize = true;
            lbl_teacher_id.Location = new Point(28, 96);
            lbl_teacher_id.Name = "lbl_teacher_id";
            lbl_teacher_id.Size = new Size(79, 20);
            lbl_teacher_id.TabIndex = 1;
            lbl_teacher_id.Text = "Teacher ID";
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
            lbl_title.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(27, 22);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(240, 32);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Add Teacher Salary";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.BackColor = Color.Transparent;
            lb_co_Name.Cursor = Cursors.Hand;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(410, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 19;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click;
            // 
            // Form19
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 537);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(lb_co_Name);
            DoubleBuffered = true;
            Name = "Form19";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add teacher salary";
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Button btn_add_sal;
        private Panel panel1;
        private TextBox txt_salary;
        private TextBox txt_id;
        private Label lbl_salary;
        private Label lbl_teacher_id;
        private Panel panel2;
        private Label lbl_title;
        private Label lb_co_Name;
    }
}