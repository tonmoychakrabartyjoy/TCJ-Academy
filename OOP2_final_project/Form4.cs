using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OOP2_final_project
{
    public partial class Form4 : Form
    {
        Form home;
        public Form4(Form sender)
        {
            InitializeComponent();
            home = sender;
        }
        private void LoadExams()
        {
            try
            {
                var query = "SELECT * FROM dbo.Exam";
                var result = Database.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                this.dgvExam.DataSource = result.Data;
                this.dgvExam.Refresh();
                this.dgvExam.ClearSelection();
                this.resetForm();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void resetForm()
        {
            txt_section.Text = txt_total_mark.Text = txt_subject.Text = "";
            txt_exam_id.Text = "Auto Generated";
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.LoadExams();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.LoadExams();
        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var subject = txt_subject.Text;
                var totalMark = txt_total_mark.Text;
                var section = txt_section.Text;
                DateTime date = date_picker.Value.Date;

                if (string.IsNullOrWhiteSpace(subject) || string.IsNullOrWhiteSpace(totalMark) || string.IsNullOrWhiteSpace(section))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                var query = string.Empty;
                if (txt_exam_id.Text == "Auto Generated")
                {
                    query = "INSERT INTO dbo.Exam (Subject, TotalMark, SectionName, ExamDate) VALUES('" + subject + "', '" + totalMark + "', '" + section + "', '" + date + "')";
                }
                else
                {
                    query = "UPDATE dbo.Exam SET Subject='" + subject + "', TotalMark='" + totalMark + "', SectionName='" + section + "', ExamDate='" + date + "' WHERE ExamId='" + txt_exam_id.Text + "'";
                }

                var result = Database.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                MessageBox.Show("Exam added successfully.");

                this.LoadExams();
                this.resetForm();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void lbl_subject_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            this.resetForm();
        }

        private void dgvExam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            var data = dgvExam.Rows[rowIndex];

            var examId = data.Cells[0].Value.ToString();
            var totalMark = data.Cells[1].Value.ToString();
            var sectionName = data.Cells[2].Value.ToString();
            var subject = data.Cells[3].Value.ToString();
            var date = data.Cells[4].Value.ToString();

            txt_exam_id.Text = examId;
            txt_total_mark.Text = totalMark;
            txt_section.Text = sectionName;
            txt_subject.Text = subject;
            date_picker.Value = DateTime.Parse(date);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int examId;
            if (!int.TryParse(txt_exam_id.Text, out examId))
            {
                MessageBox.Show("Please select a valid exam to delete.");
                return;
            }
            try
            {
                var query = "DELETE FROM dbo.Exam WHERE ExamId=" + txt_exam_id.Text;
                var result = Database.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                MessageBox.Show("Exam deleted successfully.");
                this.LoadExams();
                this.resetForm();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void lb_co_Name_Click_1(object sender, EventArgs e)
        {
            home.Show();

            this.Hide();
        }
    }
}
