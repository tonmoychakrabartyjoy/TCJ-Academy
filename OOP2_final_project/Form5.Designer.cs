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
            btn_cng_pass = new Button();
            btn_up_result = new Button();
            btn_payment = new Button();
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
            // btn_cng_pass
            // 
            btn_cng_pass.Location = new Point(860, 68);
            btn_cng_pass.Name = "btn_cng_pass";
            btn_cng_pass.Size = new Size(136, 29);
            btn_cng_pass.TabIndex = 20;
            btn_cng_pass.Text = "Change Password";
            btn_cng_pass.UseVisualStyleBackColor = true;
            // 
            // btn_up_result
            // 
            btn_up_result.Location = new Point(860, 103);
            btn_up_result.Name = "btn_up_result";
            btn_up_result.Size = new Size(136, 29);
            btn_up_result.TabIndex = 21;
            btn_up_result.Text = "Upload Result";
            btn_up_result.UseVisualStyleBackColor = true;
            // 
            // btn_payment
            // 
            btn_payment.Location = new Point(860, 138);
            btn_payment.Name = "btn_payment";
            btn_payment.Size = new Size(136, 29);
            btn_payment.TabIndex = 22;
            btn_payment.Text = "Check Payment";
            btn_payment.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1008, 540);
            Controls.Add(btn_payment);
            Controls.Add(btn_up_result);
            Controls.Add(btn_cng_pass);
            Controls.Add(lb_co_Name);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private Button btn_cng_pass;
        private Button btn_up_result;
        private Button btn_payment;
    }
}