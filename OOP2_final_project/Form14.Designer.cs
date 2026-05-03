namespace OOP2_final_project
{
    partial class Form14
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
            dataGridView1 = new DataGridView();
            user_id = new DataGridViewTextBoxColumn();
            user_name = new DataGridViewTextBoxColumn();
            mark = new DataGridViewTextBoxColumn();
            total_mark = new DataGridViewTextBoxColumn();
            lb_co_Name = new Label();
            lbl_result = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            btn_search = new Button();
            panel2 = new Panel();
            lbl_search_result = new Label();
            txt_exam_id = new TextBox();
            lbl_exam_id = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { user_id, user_name, mark, total_mark });
            dataGridView1.Location = new Point(333, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(639, 414);
            dataGridView1.TabIndex = 0;
            // 
            // user_id
            // 
            user_id.FillWeight = 120F;
            user_id.HeaderText = "Student Id";
            user_id.MinimumWidth = 6;
            user_id.Name = "user_id";
            user_id.ReadOnly = true;
            user_id.Width = 135;
            // 
            // user_name
            // 
            user_name.FillWeight = 190F;
            user_name.HeaderText = "Student Name";
            user_name.MinimumWidth = 6;
            user_name.Name = "user_name";
            user_name.ReadOnly = true;
            user_name.Width = 200;
            // 
            // mark
            // 
            mark.HeaderText = "Mark";
            mark.MinimumWidth = 6;
            mark.Name = "mark";
            mark.ReadOnly = true;
            mark.Width = 125;
            // 
            // total_mark
            // 
            total_mark.HeaderText = "Total mark";
            total_mark.MinimumWidth = 6;
            total_mark.Name = "total_mark";
            total_mark.ReadOnly = true;
            total_mark.Width = 125;
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.BackColor = Color.Transparent;
            lb_co_Name.Cursor = Cursors.Hand;
            lb_co_Name.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(376, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(194, 35);
            lb_co_Name.TabIndex = 14;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click;
            // 
            // lbl_result
            // 
            lbl_result.AutoSize = true;
            lbl_result.BackColor = Color.Transparent;
            lbl_result.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_result.Location = new Point(336, 73);
            lbl_result.Name = "lbl_result";
            lbl_result.Size = new Size(90, 32);
            lbl_result.TabIndex = 15;
            lbl_result.Text = "Result";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txt_exam_id);
            panel1.Controls.Add(lbl_exam_id);
            panel1.Location = new Point(33, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 269);
            panel1.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleGreen;
            panel3.Controls.Add(btn_search);
            panel3.Location = new Point(0, 204);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 65);
            panel3.TabIndex = 3;
            // 
            // btn_search
            // 
            btn_search.Cursor = Cursors.Hand;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Location = new Point(3, 0);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(254, 62);
            btn_search.TabIndex = 0;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Controls.Add(lbl_search_result);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 65);
            panel2.TabIndex = 2;
            // 
            // lbl_search_result
            // 
            lbl_search_result.AutoSize = true;
            lbl_search_result.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_search_result.Location = new Point(60, 23);
            lbl_search_result.Name = "lbl_search_result";
            lbl_search_result.Size = new Size(143, 26);
            lbl_search_result.TabIndex = 0;
            lbl_search_result.Text = "Search Result";
            // 
            // txt_exam_id
            // 
            txt_exam_id.BorderStyle = BorderStyle.FixedSingle;
            txt_exam_id.Location = new Point(72, 123);
            txt_exam_id.Name = "txt_exam_id";
            txt_exam_id.Size = new Size(182, 27);
            txt_exam_id.TabIndex = 1;
            // 
            // lbl_exam_id
            // 
            lbl_exam_id.AutoSize = true;
            lbl_exam_id.Location = new Point(4, 123);
            lbl_exam_id.Name = "lbl_exam_id";
            lbl_exam_id.Size = new Size(62, 20);
            lbl_exam_id.TabIndex = 0;
            lbl_exam_id.Text = "Exam Id";
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 537);
            Controls.Add(panel1);
            Controls.Add(lbl_result);
            Controls.Add(lb_co_Name);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "Form14";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show result";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lb_co_Name;
        private Label lbl_result;
        private Panel panel1;
        private Label lbl_exam_id;
        private Panel panel3;
        private Button btn_search;
        private Panel panel2;
        private Label lbl_search_result;
        private TextBox txt_exam_id;
        private DataGridViewTextBoxColumn user_id;
        private DataGridViewTextBoxColumn user_name;
        private DataGridViewTextBoxColumn mark;
        private DataGridViewTextBoxColumn total_mark;
    }
}