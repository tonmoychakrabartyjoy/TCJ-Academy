using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form5 : Form
    {
        Form home;
        public Form5(Form home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void resetForm()
        {
            txt_exam_id.Text = "";
            txt_user_id.Text = "";
            txt_mark.Text = "";
        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            home.Show();

            this.Hide();
        }

        private void btn_add_result_Click(object sender, EventArgs e)
        {
            try
            {
                string exam_id = txt_exam_id.Text;
                string user_id = txt_user_id.Text;
                int mark;

                if (string.IsNullOrWhiteSpace(exam_id) || string.IsNullOrWhiteSpace(user_id) || string.IsNullOrWhiteSpace(txt_mark.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (!int.TryParse(txt_mark.Text, out mark))
                {
                    MessageBox.Show("Input valid mark");
                    txt_mark.Focus();
                    return;
                }

                var query = "INSERT INTO dbo.ExamResult (ExamId, UserId, Mark) VALUES('" + exam_id + "', '" + user_id + "', " + mark + ")";

                var result = Database.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                MessageBox.Show("Exam result added successfully.");

                this.resetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_update_mark_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
