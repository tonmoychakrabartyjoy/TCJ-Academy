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
            btn_cng_pass = new Button();
            btn_result = new Button();
            btn_show_course = new Button();
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
            // btn_cng_pass
            // 
            btn_cng_pass.Location = new Point(858, 57);
            btn_cng_pass.Name = "btn_cng_pass";
            btn_cng_pass.Size = new Size(136, 29);
            btn_cng_pass.TabIndex = 19;
            btn_cng_pass.Text = "Change Password";
            btn_cng_pass.UseVisualStyleBackColor = true;
            // 
            // btn_result
            // 
            btn_result.Location = new Point(858, 92);
            btn_result.Name = "btn_result";
            btn_result.Size = new Size(136, 29);
            btn_result.TabIndex = 20;
            btn_result.Text = "Result";
            btn_result.UseVisualStyleBackColor = true;
            // 
            // btn_show_course
            // 
            btn_show_course.Location = new Point(858, 127);
            btn_show_course.Name = "btn_show_course";
            btn_show_course.Size = new Size(136, 29);
            btn_show_course.TabIndex = 22;
            btn_show_course.Text = "Show Course";
            btn_show_course.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1006, 542);
            Controls.Add(btn_show_course);
            Controls.Add(btn_result);
            Controls.Add(btn_cng_pass);
            Controls.Add(lb_co_Name);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private Button btn_cng_pass;
        private Button btn_result;
        private Button btn_show_course;
    }
}