namespace OOP2_final_project
{
    partial class Form15
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
            dataGridView1 = new DataGridView();
            course_code = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            day = new DataGridViewTextBoxColumn();
            lbl_course_list = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.BackColor = Color.Transparent;
            lb_co_Name.Cursor = Cursors.Hand;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(420, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 13;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { course_code, subject, day });
            dataGridView1.Location = new Point(107, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(803, 390);
            dataGridView1.TabIndex = 14;
            // 
            // course_code
            // 
            course_code.FillWeight = 200F;
            course_code.HeaderText = "Course code";
            course_code.MinimumWidth = 6;
            course_code.Name = "course_code";
            course_code.ReadOnly = true;
            course_code.Width = 250;
            // 
            // subject
            // 
            subject.FillWeight = 200F;
            subject.HeaderText = "Course Subject";
            subject.MinimumWidth = 6;
            subject.Name = "subject";
            subject.ReadOnly = true;
            subject.Width = 250;
            // 
            // day
            // 
            day.FillWeight = 200F;
            day.HeaderText = "Course Day";
            day.MinimumWidth = 6;
            day.Name = "day";
            day.ReadOnly = true;
            day.Width = 250;
            // 
            // lbl_course_list
            // 
            lbl_course_list.AutoSize = true;
            lbl_course_list.BackColor = Color.Transparent;
            lbl_course_list.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_course_list.Location = new Point(110, 86);
            lbl_course_list.Name = "lbl_course_list";
            lbl_course_list.Size = new Size(138, 32);
            lbl_course_list.TabIndex = 15;
            lbl_course_list.Text = "Course list";
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 537);
            Controls.Add(lbl_course_list);
            Controls.Add(dataGridView1);
            Controls.Add(lb_co_Name);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form15";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course list";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn course_code;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn day;
        private Label lbl_course_list;
    }
}