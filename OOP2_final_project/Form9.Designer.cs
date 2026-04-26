namespace OOP2_final_project
{
    partial class Form9
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
            btn_add_teacher = new Button();
            txt_password = new TextBox();
            txt_address = new TextBox();
            txt_phone = new TextBox();
            txt_name = new TextBox();
            txt_id = new TextBox();
            lb_password = new Label();
            lb_address = new Label();
            lb_phone = new Label();
            lb_teacher_name = new Label();
            lb_teacher_id = new Label();
            lb_co_Name = new Label();
            lb_subject = new Label();
            txt_subject = new TextBox();
            SuspendLayout();
            // 
            // btn_add_teacher
            // 
            btn_add_teacher.Location = new Point(211, 333);
            btn_add_teacher.Name = "btn_add_teacher";
            btn_add_teacher.Size = new Size(162, 29);
            btn_add_teacher.TabIndex = 21;
            btn_add_teacher.Text = "Add Teacher";
            btn_add_teacher.UseVisualStyleBackColor = true;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(155, 279);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(320, 27);
            txt_password.TabIndex = 20;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(155, 194);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(320, 27);
            txt_address.TabIndex = 19;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(155, 157);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(320, 27);
            txt_phone.TabIndex = 18;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(155, 119);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(320, 27);
            txt_name.TabIndex = 17;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(155, 81);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(320, 27);
            txt_id.TabIndex = 16;
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Location = new Point(61, 282);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(70, 20);
            lb_password.TabIndex = 15;
            lb_password.Text = "Password";
            // 
            // lb_address
            // 
            lb_address.AutoSize = true;
            lb_address.Location = new Point(69, 201);
            lb_address.Name = "lb_address";
            lb_address.Size = new Size(62, 20);
            lb_address.TabIndex = 14;
            lb_address.Text = "Address";
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Location = new Point(81, 164);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new Size(50, 20);
            lb_phone.TabIndex = 13;
            lb_phone.Text = "Phone";
            // 
            // lb_teacher_name
            // 
            lb_teacher_name.AutoSize = true;
            lb_teacher_name.Location = new Point(27, 126);
            lb_teacher_name.Name = "lb_teacher_name";
            lb_teacher_name.Size = new Size(104, 20);
            lb_teacher_name.TabIndex = 12;
            lb_teacher_name.Text = "Teacher Name";
            // 
            // lb_teacher_id
            // 
            lb_teacher_id.AutoSize = true;
            lb_teacher_id.Location = new Point(54, 88);
            lb_teacher_id.Name = "lb_teacher_id";
            lb_teacher_id.Size = new Size(77, 20);
            lb_teacher_id.TabIndex = 11;
            lb_teacher_id.Text = "Teacher Id";
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(410, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 22;
            lb_co_Name.Text = "TCJ Academy";
            // 
            // lb_subject
            // 
            lb_subject.AutoSize = true;
            lb_subject.Location = new Point(73, 241);
            lb_subject.Name = "lb_subject";
            lb_subject.Size = new Size(58, 20);
            lb_subject.TabIndex = 23;
            lb_subject.Text = "Subject";
            // 
            // txt_subject
            // 
            txt_subject.Location = new Point(155, 238);
            txt_subject.Name = "txt_subject";
            txt_subject.Size = new Size(320, 27);
            txt_subject.TabIndex = 24;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1022, 543);
            Controls.Add(txt_subject);
            Controls.Add(lb_subject);
            Controls.Add(lb_co_Name);
            Controls.Add(btn_add_teacher);
            Controls.Add(txt_password);
            Controls.Add(txt_address);
            Controls.Add(txt_phone);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(lb_password);
            Controls.Add(lb_address);
            Controls.Add(lb_phone);
            Controls.Add(lb_teacher_name);
            Controls.Add(lb_teacher_id);
            Name = "Form9";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add teacher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add_teacher;
        private TextBox txt_password;
        private TextBox txt_address;
        private TextBox txt_phone;
        private TextBox txt_name;
        private TextBox txt_id;
        private Label lb_password;
        private Label lb_address;
        private Label lb_phone;
        private Label lb_teacher_name;
        private Label lb_teacher_id;
        private Label lb_co_Name;
        private Label lb_subject;
        private TextBox txt_subject;
    }
}