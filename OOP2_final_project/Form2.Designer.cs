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
            txt_id = new TextBox();
            btn_add_emp = new Button();
            lb_co_Name = new Label();
            lb_type = new Label();
            lb_salary = new Label();
            txt_type = new TextBox();
            txt_salary = new TextBox();
            SuspendLayout();
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Location = new Point(269, 149);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(49, 20);
            lb_name.TabIndex = 0;
            lb_name.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(336, 142);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(282, 27);
            txt_name.TabIndex = 1;
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Location = new Point(296, 195);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(22, 20);
            lb_id.TabIndex = 2;
            lb_id.Text = "Id";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(336, 188);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(282, 27);
            txt_id.TabIndex = 6;
            // 
            // btn_add_emp
            // 
            btn_add_emp.Location = new Point(390, 318);
            btn_add_emp.Name = "btn_add_emp";
            btn_add_emp.Size = new Size(156, 29);
            btn_add_emp.TabIndex = 10;
            btn_add_emp.Text = "Add employee";
            btn_add_emp.UseVisualStyleBackColor = true;
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
            // lb_type
            // 
            lb_type.AutoSize = true;
            lb_type.Location = new Point(278, 230);
            lb_type.Name = "lb_type";
            lb_type.Size = new Size(40, 20);
            lb_type.TabIndex = 3;
            lb_type.Text = "Type";
            // 
            // lb_salary
            // 
            lb_salary.AutoSize = true;
            lb_salary.Location = new Point(269, 276);
            lb_salary.Name = "lb_salary";
            lb_salary.Size = new Size(49, 20);
            lb_salary.TabIndex = 4;
            lb_salary.Text = "Salary";
            // 
            // txt_type
            // 
            txt_type.Location = new Point(336, 230);
            txt_type.Name = "txt_type";
            txt_type.Size = new Size(282, 27);
            txt_type.TabIndex = 7;
            // 
            // txt_salary
            // 
            txt_salary.Location = new Point(336, 269);
            txt_salary.Name = "txt_salary";
            txt_salary.Size = new Size(282, 27);
            txt_salary.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1011, 539);
            Controls.Add(lb_co_Name);
            Controls.Add(btn_add_emp);
            Controls.Add(txt_salary);
            Controls.Add(txt_type);
            Controls.Add(txt_id);
            Controls.Add(lb_salary);
            Controls.Add(lb_type);
            Controls.Add(lb_id);
            Controls.Add(txt_name);
            Controls.Add(lb_name);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add employee";
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
        private Button btn_add_emp;
        private Label lb_co_Name;
        private Label lb_type;
        private Label lb_salary;
        private TextBox txt_type;
        private TextBox txt_salary;
    }
}