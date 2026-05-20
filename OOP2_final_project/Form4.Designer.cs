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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            lb_co_Name = new Label();
            lbl_exam_id = new Label();
            lbl_subject = new Label();
            totalMark = new Label();
            lbl_section = new Label();
            txt_exam_id = new TextBox();
            txt_subject = new TextBox();
            txt_total_mark = new TextBox();
            txt_section = new TextBox();
            panel1 = new Panel();
            date_picker = new DateTimePicker();
            panel2 = new Panel();
            lbl_add_new_exam = new Label();
            panel_top = new Panel();
            btn_delete = new Button();
            btn_Add = new Button();
            btn_new = new Button();
            btn_refresh = new Button();
            panel_left = new Panel();
            dgvExam = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel_top.SuspendLayout();
            panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExam).BeginInit();
            SuspendLayout();
            // 
            // lb_co_Name
            // 
            lb_co_Name.AutoSize = true;
            lb_co_Name.BackColor = Color.Transparent;
            lb_co_Name.Cursor = Cursors.Hand;
            lb_co_Name.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_co_Name.ForeColor = Color.Black;
            lb_co_Name.Location = new Point(19, 9);
            lb_co_Name.Name = "lb_co_Name";
            lb_co_Name.Size = new Size(242, 42);
            lb_co_Name.TabIndex = 13;
            lb_co_Name.Text = "TCJ Academy";
            lb_co_Name.Click += lb_co_Name_Click_1;
            // 
            // lbl_exam_id
            // 
            lbl_exam_id.AutoSize = true;
            lbl_exam_id.Location = new Point(31, 119);
            lbl_exam_id.Name = "lbl_exam_id";
            lbl_exam_id.Size = new Size(64, 20);
            lbl_exam_id.TabIndex = 23;
            lbl_exam_id.Text = "Exam ID";
            // 
            // lbl_subject
            // 
            lbl_subject.AutoSize = true;
            lbl_subject.Location = new Point(37, 161);
            lbl_subject.Name = "lbl_subject";
            lbl_subject.Size = new Size(58, 20);
            lbl_subject.TabIndex = 24;
            lbl_subject.Text = "Subject";
            lbl_subject.Click += lbl_subject_Click;
            // 
            // totalMark
            // 
            totalMark.AutoSize = true;
            totalMark.Location = new Point(16, 200);
            totalMark.Name = "totalMark";
            totalMark.Size = new Size(79, 20);
            totalMark.TabIndex = 25;
            totalMark.Text = "Total Mark";
            // 
            // lbl_section
            // 
            lbl_section.AutoSize = true;
            lbl_section.Location = new Point(37, 238);
            lbl_section.Name = "lbl_section";
            lbl_section.Size = new Size(58, 20);
            lbl_section.TabIndex = 26;
            lbl_section.Text = "Section";
            // 
            // txt_exam_id
            // 
            txt_exam_id.BorderStyle = BorderStyle.FixedSingle;
            txt_exam_id.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txt_exam_id.Location = new Point(107, 116);
            txt_exam_id.Name = "txt_exam_id";
            txt_exam_id.ReadOnly = true;
            txt_exam_id.Size = new Size(190, 30);
            txt_exam_id.TabIndex = 27;
            txt_exam_id.Text = "Auto Generated";
            txt_exam_id.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_subject
            // 
            txt_subject.BorderStyle = BorderStyle.FixedSingle;
            txt_subject.Location = new Point(107, 158);
            txt_subject.Name = "txt_subject";
            txt_subject.Size = new Size(190, 27);
            txt_subject.TabIndex = 28;
            // 
            // txt_total_mark
            // 
            txt_total_mark.BorderStyle = BorderStyle.FixedSingle;
            txt_total_mark.Location = new Point(107, 197);
            txt_total_mark.Name = "txt_total_mark";
            txt_total_mark.Size = new Size(190, 27);
            txt_total_mark.TabIndex = 29;
            // 
            // txt_section
            // 
            txt_section.BorderStyle = BorderStyle.FixedSingle;
            txt_section.Location = new Point(107, 235);
            txt_section.Name = "txt_section";
            txt_section.Size = new Size(190, 27);
            txt_section.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(date_picker);
            panel1.Controls.Add(lbl_exam_id);
            panel1.Controls.Add(txt_exam_id);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txt_subject);
            panel1.Controls.Add(txt_total_mark);
            panel1.Controls.Add(txt_section);
            panel1.Controls.Add(lbl_subject);
            panel1.Controls.Add(totalMark);
            panel1.Controls.Add(lbl_section);
            panel1.Location = new Point(653, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 391);
            panel1.TabIndex = 31;
            // 
            // date_picker
            // 
            date_picker.Location = new Point(16, 277);
            date_picker.Name = "date_picker";
            date_picker.Size = new Size(296, 27);
            date_picker.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSpringGreen;
            panel2.Controls.Add(lbl_add_new_exam);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(327, 75);
            panel2.TabIndex = 32;
            // 
            // lbl_add_new_exam
            // 
            lbl_add_new_exam.AutoSize = true;
            lbl_add_new_exam.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_add_new_exam.Location = new Point(69, 17);
            lbl_add_new_exam.Name = "lbl_add_new_exam";
            lbl_add_new_exam.Size = new Size(210, 34);
            lbl_add_new_exam.TabIndex = 31;
            lbl_add_new_exam.Text = "Add New Exam";
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.Gainsboro;
            panel_top.Controls.Add(btn_delete);
            panel_top.Controls.Add(btn_Add);
            panel_top.Controls.Add(btn_new);
            panel_top.Controls.Add(btn_refresh);
            panel_top.Location = new Point(12, 59);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(955, 50);
            panel_top.TabIndex = 33;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.IndianRed;
            btn_delete.FlatStyle = FlatStyle.Popup;
            btn_delete.Location = new Point(827, 6);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(95, 38);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.MediumSpringGreen;
            btn_Add.FlatStyle = FlatStyle.Popup;
            btn_Add.Location = new Point(726, 6);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(95, 38);
            btn_Add.TabIndex = 2;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_new
            // 
            btn_new.BackColor = Color.LightSkyBlue;
            btn_new.FlatStyle = FlatStyle.Popup;
            btn_new.Location = new Point(625, 6);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(95, 38);
            btn_new.TabIndex = 1;
            btn_new.Text = "New";
            btn_new.UseVisualStyleBackColor = false;
            btn_new.Click += btn_new_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.BackColor = Color.MediumSpringGreen;
            btn_refresh.FlatStyle = FlatStyle.Popup;
            btn_refresh.Location = new Point(8, 6);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(95, 38);
            btn_refresh.TabIndex = 0;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // panel_left
            // 
            panel_left.BackColor = Color.Silver;
            panel_left.Controls.Add(dgvExam);
            panel_left.Location = new Point(12, 116);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(620, 394);
            panel_left.TabIndex = 34;
            // 
            // dgvExam
            // 
            dgvExam.BackgroundColor = Color.WhiteSmoke;
            dgvExam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExam.Dock = DockStyle.Fill;
            dgvExam.Location = new Point(0, 0);
            dgvExam.Name = "dgvExam";
            dgvExam.ReadOnly = true;
            dgvExam.RowHeadersWidth = 51;
            dgvExam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExam.Size = new Size(620, 394);
            dgvExam.TabIndex = 0;
            dgvExam.CellDoubleClick += dgvExam_CellDoubleClick;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 537);
            Controls.Add(panel_left);
            Controls.Add(panel1);
            Controls.Add(panel_top);
            Controls.Add(lb_co_Name);
            DoubleBuffered = true;
            MaximumSize = new Size(1034, 584);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam";
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_top.ResumeLayout(false);
            panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_co_Name;
        private Label lbl_exam_id;
        private Label lbl_subject;
        private Label totalMark;
        private Label lbl_section;
        private TextBox txt_exam_id;
        private TextBox txt_subject;
        private TextBox txt_total_mark;
        private TextBox txt_section;
        private Panel panel1;
        private Label lbl_add_new_exam;
        private DateTimePicker date_picker;
        private Panel panel2;
        private Panel panel_top;
        private Button btn_refresh;
        private Button btn_new;
        private Button btn_Add;
        private Button btn_delete;
        private Panel panel_left;
        private DataGridView dgvExam;
    }
}