namespace OOP2_final_project
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            lb_co_Name = new Label();
            txt_mark = new TextBox();
            txt_user_id = new TextBox();
            txt_exam_id = new TextBox();
            lbl_mark = new Label();
            lbl_user_id = new Label();
            lbl_exam_id = new Label();
            btn_add_result = new Button();
            panel1 = new Panel();
            lbl_update_mark = new Label();
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
            lb_co_Name.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(385, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(234, 43);
            lb_co_Name.TabIndex = 14;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click;
            // 
            // txt_mark
            // 
            txt_mark.BorderStyle = BorderStyle.FixedSingle;
            txt_mark.Location = new Point(78, 186);
            txt_mark.Name = "txt_mark";
            txt_mark.Size = new Size(190, 27);
            txt_mark.TabIndex = 38;
            // 
            // txt_user_id
            // 
            txt_user_id.BorderStyle = BorderStyle.FixedSingle;
            txt_user_id.Location = new Point(78, 150);
            txt_user_id.Name = "txt_user_id";
            txt_user_id.Size = new Size(190, 27);
            txt_user_id.TabIndex = 37;
            // 
            // txt_exam_id
            // 
            txt_exam_id.BorderStyle = BorderStyle.FixedSingle;
            txt_exam_id.Location = new Point(78, 115);
            txt_exam_id.Name = "txt_exam_id";
            txt_exam_id.Size = new Size(190, 27);
            txt_exam_id.TabIndex = 36;
            // 
            // lbl_mark
            // 
            lbl_mark.AutoSize = true;
            lbl_mark.Location = new Point(30, 186);
            lbl_mark.Name = "lbl_mark";
            lbl_mark.Size = new Size(42, 20);
            lbl_mark.TabIndex = 34;
            lbl_mark.Text = "Mark";
            // 
            // lbl_user_id
            // 
            lbl_user_id.AutoSize = true;
            lbl_user_id.Location = new Point(17, 150);
            lbl_user_id.Name = "lbl_user_id";
            lbl_user_id.Size = new Size(55, 20);
            lbl_user_id.TabIndex = 33;
            lbl_user_id.Text = "User Id";
            // 
            // lbl_exam_id
            // 
            lbl_exam_id.AutoSize = true;
            lbl_exam_id.Location = new Point(8, 115);
            lbl_exam_id.Name = "lbl_exam_id";
            lbl_exam_id.Size = new Size(64, 20);
            lbl_exam_id.TabIndex = 32;
            lbl_exam_id.Text = "Exam ID";
            // 
            // btn_add_result
            // 
            btn_add_result.BackColor = Color.PaleGreen;
            btn_add_result.Location = new Point(0, 253);
            btn_add_result.Name = "btn_add_result";
            btn_add_result.Size = new Size(296, 52);
            btn_add_result.TabIndex = 31;
            btn_add_result.Text = "Add Result";
            btn_add_result.UseVisualStyleBackColor = false;
            btn_add_result.Click += btn_add_result_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(txt_user_id);
            panel1.Controls.Add(txt_mark);
            panel1.Controls.Add(btn_add_result);
            panel1.Controls.Add(lbl_exam_id);
            panel1.Controls.Add(txt_exam_id);
            panel1.Controls.Add(lbl_user_id);
            panel1.Controls.Add(lbl_mark);
            panel1.Location = new Point(351, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 305);
            panel1.TabIndex = 39;
            // 
            // lbl_update_mark
            // 
            lbl_update_mark.AutoSize = true;
            lbl_update_mark.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_update_mark.Location = new Point(58, 20);
            lbl_update_mark.Name = "lbl_update_mark";
            lbl_update_mark.Size = new Size(175, 32);
            lbl_update_mark.TabIndex = 39;
            lbl_update_mark.Text = "Update Mrak";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Controls.Add(lbl_update_mark);
            panel2.Location = new Point(351, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 70);
            panel2.TabIndex = 40;
            // 
            // Form5
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
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upload result";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private Button btn_cng_pass;
        private Button btn_up_result;
        private Button btn_payment;
        private TextBox textBox1;
        private TextBox txt_mark;
        private TextBox txt_user_id;
        private TextBox txt_exam_id;
        private Label lbl_section;
        private Label lbl_mark;
        private Label lbl_user_id;
        private Label lbl_exam_id;
        private Button btn_add_result;
        private Panel panel1;
        private Label lbl_update_mark;
        private Panel panel2;
    }
}