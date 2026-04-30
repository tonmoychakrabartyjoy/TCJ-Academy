namespace OOP2_final_project
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            txt_name = new TextBox();
            txt_id = new TextBox();
            txt_pass = new TextBox();
            btn_login = new Button();
            lb1 = new Label();
            lb2 = new Label();
            lb3 = new Label();
            lb6 = new Label();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Location = new Point(134, 178);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(232, 27);
            txt_name.TabIndex = 0;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(134, 225);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(232, 27);
            txt_id.TabIndex = 1;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(134, 273);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(232, 27);
            txt_pass.TabIndex = 2;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Transparent;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(175, 325);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(92, 40);
            btn_login.TabIndex = 3;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.BackColor = Color.Transparent;
            lb1.ForeColor = Color.White;
            lb1.Location = new Point(71, 185);
            lb1.Name = "lb1";
            lb1.Size = new Size(52, 20);
            lb1.TabIndex = 4;
            lb1.Text = "Name:";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.BackColor = Color.Transparent;
            lb2.ForeColor = Color.White;
            lb2.Location = new Point(98, 228);
            lb2.Name = "lb2";
            lb2.Size = new Size(25, 20);
            lb2.TabIndex = 5;
            lb2.Text = "Id:";
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.BackColor = Color.Transparent;
            lb3.ForeColor = Color.White;
            lb3.Location = new Point(48, 273);
            lb3.Name = "lb3";
            lb3.Size = new Size(75, 20);
            lb3.TabIndex = 6;
            lb3.Text = "password:";
            // 
            // lb6
            // 
            lb6.AutoSize = true;
            lb6.BackColor = Color.Transparent;
            lb6.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb6.ForeColor = Color.White;
            lb6.Location = new Point(98, 9);
            lb6.Name = "lb6";
            lb6.Size = new Size(242, 42);
            lb6.TabIndex = 10;
            lb6.Text = "TCJ Academy";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1009, 544);
            Controls.Add(lb6);
            Controls.Add(lb3);
            Controls.Add(lb2);
            Controls.Add(lb1);
            Controls.Add(btn_login);
            Controls.Add(txt_pass);
            Controls.Add(txt_id);
            Controls.Add(txt_name);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_id;
        private TextBox txt_pass;
        private Button btn_login;
        private Label lb1;
        private Label lb2;
        private Label lb3;
        private Label lb6;
    }
}
