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
            lb_co_Name = new Label();
            txt_total_mark = new TextBox();
            txt_user_id = new TextBox();
            txt_exam_id = new TextBox();
            lbl_mark = new Label();
            lbl_user_id = new Label();
            lbl_exam_id = new Label();
            btn_add_result = new Button();
            SuspendLayout();
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(375, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 14;
            lb_co_Name.Text = "TCJ Academy";
            // 
            // txt_total_mark
            // 
            txt_total_mark.Location = new Point(379, 231);
            txt_total_mark.Name = "txt_total_mark";
            txt_total_mark.Size = new Size(190, 27);
            txt_total_mark.TabIndex = 38;
            // 
            // txt_user_id
            // 
            txt_user_id.Location = new Point(379, 195);
            txt_user_id.Name = "txt_user_id";
            txt_user_id.Size = new Size(190, 27);
            txt_user_id.TabIndex = 37;
            // 
            // txt_exam_id
            // 
            txt_exam_id.Location = new Point(379, 160);
            txt_exam_id.Name = "txt_exam_id";
            txt_exam_id.Size = new Size(190, 27);
            txt_exam_id.TabIndex = 36;
            // 
            // lbl_mark
            // 
            lbl_mark.AutoSize = true;
            lbl_mark.Location = new Point(331, 231);
            lbl_mark.Name = "lbl_mark";
            lbl_mark.Size = new Size(42, 20);
            lbl_mark.TabIndex = 34;
            lbl_mark.Text = "Mark";
            // 
            // lbl_user_id
            // 
            lbl_user_id.AutoSize = true;
            lbl_user_id.Location = new Point(318, 195);
            lbl_user_id.Name = "lbl_user_id";
            lbl_user_id.Size = new Size(55, 20);
            lbl_user_id.TabIndex = 33;
            lbl_user_id.Text = "User Id";
            // 
            // lbl_exam_id
            // 
            lbl_exam_id.AutoSize = true;
            lbl_exam_id.Location = new Point(309, 160);
            lbl_exam_id.Name = "lbl_exam_id";
            lbl_exam_id.Size = new Size(64, 20);
            lbl_exam_id.TabIndex = 32;
            lbl_exam_id.Text = "Exam ID";
            // 
            // btn_add_result
            // 
            btn_add_result.Location = new Point(398, 275);
            btn_add_result.Name = "btn_add_result";
            btn_add_result.Size = new Size(136, 29);
            btn_add_result.TabIndex = 31;
            btn_add_result.Text = "Add Result";
            btn_add_result.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1008, 540);
            Controls.Add(txt_total_mark);
            Controls.Add(txt_user_id);
            Controls.Add(txt_exam_id);
            Controls.Add(lbl_mark);
            Controls.Add(lbl_user_id);
            Controls.Add(lbl_exam_id);
            Controls.Add(btn_add_result);
            Controls.Add(lb_co_Name);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upload result";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private Button btn_cng_pass;
        private Button btn_up_result;
        private Button btn_payment;
        private TextBox textBox1;
        private TextBox txt_total_mark;
        private TextBox txt_user_id;
        private TextBox txt_exam_id;
        private Label lbl_section;
        private Label lbl_mark;
        private Label lbl_user_id;
        private Label lbl_exam_id;
        private Button btn_add_result;
    }
}