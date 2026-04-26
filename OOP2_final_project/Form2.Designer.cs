namespace OOP2_final_project
{
    partial class Form2
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
            lb_name = new Label();
            txt_name = new TextBox();
            lb_id = new Label();
            lb_old_pass = new Label();
            lb_new_pass = new Label();
            lb_con_pass = new Label();
            txt_id = new TextBox();
            txt_old_pass = new TextBox();
            txt_new_pass = new TextBox();
            txt_con_pass = new TextBox();
            btn_cng_pass = new Button();
            lb_co_Name = new Label();
            SuspendLayout();
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Location = new Point(120, 106);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(49, 20);
            lb_name.TabIndex = 0;
            lb_name.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(187, 99);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(282, 27);
            txt_name.TabIndex = 1;
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Location = new Point(147, 152);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(22, 20);
            lb_id.TabIndex = 2;
            lb_id.Text = "Id";
            // 
            // lb_old_pass
            // 
            lb_old_pass.AutoSize = true;
            lb_old_pass.Location = new Point(71, 187);
            lb_old_pass.Name = "lb_old_pass";
            lb_old_pass.Size = new Size(98, 20);
            lb_old_pass.TabIndex = 3;
            lb_old_pass.Text = "Old Password";
            // 
            // lb_new_pass
            // 
            lb_new_pass.AutoSize = true;
            lb_new_pass.Location = new Point(63, 226);
            lb_new_pass.Name = "lb_new_pass";
            lb_new_pass.Size = new Size(106, 20);
            lb_new_pass.TabIndex = 4;
            lb_new_pass.Text = "New password";
            // 
            // lb_con_pass
            // 
            lb_con_pass.AutoSize = true;
            lb_con_pass.Location = new Point(40, 265);
            lb_con_pass.Name = "lb_con_pass";
            lb_con_pass.Size = new Size(129, 20);
            lb_con_pass.TabIndex = 5;
            lb_con_pass.Text = "Confirm password";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(187, 145);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(282, 27);
            txt_id.TabIndex = 6;
            // 
            // txt_old_pass
            // 
            txt_old_pass.Location = new Point(187, 187);
            txt_old_pass.Name = "txt_old_pass";
            txt_old_pass.Size = new Size(282, 27);
            txt_old_pass.TabIndex = 7;
            // 
            // txt_new_pass
            // 
            txt_new_pass.Location = new Point(187, 226);
            txt_new_pass.Name = "txt_new_pass";
            txt_new_pass.Size = new Size(282, 27);
            txt_new_pass.TabIndex = 8;
            // 
            // txt_con_pass
            // 
            txt_con_pass.Location = new Point(187, 265);
            txt_con_pass.Name = "txt_con_pass";
            txt_con_pass.Size = new Size(282, 27);
            txt_con_pass.TabIndex = 9;
            // 
            // btn_cng_pass
            // 
            btn_cng_pass.Location = new Point(247, 328);
            btn_cng_pass.Name = "btn_cng_pass";
            btn_cng_pass.Size = new Size(156, 29);
            btn_cng_pass.TabIndex = 10;
            btn_cng_pass.Text = "Change password";
            btn_cng_pass.UseVisualStyleBackColor = true;
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(389, 27);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 11;
            lb_co_Name.Text = "TCJ Academy";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1011, 539);
            Controls.Add(lb_co_Name);
            Controls.Add(btn_cng_pass);
            Controls.Add(txt_con_pass);
            Controls.Add(txt_new_pass);
            Controls.Add(txt_old_pass);
            Controls.Add(txt_id);
            Controls.Add(lb_con_pass);
            Controls.Add(lb_new_pass);
            Controls.Add(lb_old_pass);
            Controls.Add(lb_id);
            Controls.Add(txt_name);
            Controls.Add(lb_name);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change pass page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_name;
        private TextBox txt_name;
        private Label lb_id;
        private Label lb_old_pass;
        private Label lb_new_pass;
        private Label lb_con_pass;
        private TextBox txt_id;
        private TextBox txt_old_pass;
        private TextBox txt_new_pass;
        private TextBox txt_con_pass;
        private Button btn_cng_pass;
        private Label lb_co_Name;
    }
}