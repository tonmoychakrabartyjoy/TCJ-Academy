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
            lb_co_Name = new Label();
            panel1 = new Panel();
            btn_add_emp = new Button();
            txt_salary = new TextBox();
            txt_type = new TextBox();
            txt_id = new TextBox();
            lb_salary = new Label();
            lb_type = new Label();
            lb_id = new Label();
            txt_name = new TextBox();
            lb_name = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.Cursor = Cursors.Hand;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(387, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 11;
            lb_co_Name.Text = "TCJ Academy";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btn_add_emp);
            panel1.Controls.Add(txt_salary);
            panel1.Controls.Add(txt_type);
            panel1.Controls.Add(txt_id);
            panel1.Controls.Add(lb_salary);
            panel1.Controls.Add(lb_type);
            panel1.Controls.Add(lb_id);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(lb_name);
            panel1.Location = new Point(253, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 281);
            panel1.TabIndex = 12;
            // 
            // btn_add_emp
            // 
            btn_add_emp.Location = new Point(167, 214);
            btn_add_emp.Name = "btn_add_emp";
            btn_add_emp.Size = new Size(156, 29);
            btn_add_emp.TabIndex = 19;
            btn_add_emp.Text = "Add employee";
            btn_add_emp.UseVisualStyleBackColor = true;
            // 
            // txt_salary
            // 
            txt_salary.BorderStyle = BorderStyle.FixedSingle;
            txt_salary.Location = new Point(113, 165);
            txt_salary.Name = "txt_salary";
            txt_salary.Size = new Size(282, 27);
            txt_salary.TabIndex = 18;
            // 
            // txt_type
            // 
            txt_type.BorderStyle = BorderStyle.FixedSingle;
            txt_type.Location = new Point(113, 126);
            txt_type.Name = "txt_type";
            txt_type.Size = new Size(282, 27);
            txt_type.TabIndex = 17;
            // 
            // txt_id
            // 
            txt_id.BorderStyle = BorderStyle.FixedSingle;
            txt_id.Location = new Point(113, 84);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(282, 27);
            txt_id.TabIndex = 16;
            // 
            // lb_salary
            // 
            lb_salary.AutoSize = true;
            lb_salary.Location = new Point(46, 172);
            lb_salary.Name = "lb_salary";
            lb_salary.Size = new Size(49, 20);
            lb_salary.TabIndex = 15;
            lb_salary.Text = "Salary";
            // 
            // lb_type
            // 
            lb_type.AutoSize = true;
            lb_type.Location = new Point(55, 126);
            lb_type.Name = "lb_type";
            lb_type.Size = new Size(40, 20);
            lb_type.TabIndex = 14;
            lb_type.Text = "Type";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Location = new Point(73, 91);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(22, 20);
            lb_id.TabIndex = 13;
            lb_id.Text = "Id";
            // 
            // txt_name
            // 
            txt_name.BorderStyle = BorderStyle.FixedSingle;
            txt_name.Location = new Point(113, 38);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(282, 27);
            txt_name.TabIndex = 12;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Location = new Point(46, 45);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(49, 20);
            lb_name.TabIndex = 11;
            lb_name.Text = "Name";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1016, 537);
            Controls.Add(panel1);
            Controls.Add(lb_co_Name);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_old_pass;
        private Label lb_new_pass;
        private Label lb_con_pass;
        private TextBox txt_old_pass;
        private TextBox txt_new_pass;
        private TextBox txt_con_pass;
        private Label lb_co_Name;
        private Panel panel1;
        private Button btn_add_emp;
        private TextBox txt_salary;
        private TextBox txt_type;
        private TextBox txt_id;
        private Label lb_salary;
        private Label lb_type;
        private Label lb_id;
        private TextBox txt_name;
        private Label lb_name;
    }
}