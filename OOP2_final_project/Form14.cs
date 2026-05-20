using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form14 : Form
    {
        Form home;
        public Form14(Form sender)
        {
            InitializeComponent();
            home = sender;
        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            home.Show();

            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                int exam_id = int.Parse(txt_exam_id.Text);

                dgvR.AutoGenerateColumns = true;

                var query = @"SELECT U.UserId, U.UserName, ER.Mark, E.TotalMark 
                      FROM Users U 
                      JOIN ExamResult ER ON U.UserId = ER.UserId
                      JOIN Exam E ON ER.ExamId = E.ExamId
                      WHERE E.ExamId = " + exam_id;

                var result = Database.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvR.DataSource = result.Data;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid Exam ID!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static int userId;
        public static int Mark;
        private void dgvR_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            userId = int.Parse(dgvR.Rows[e.RowIndex].Cells[0].Value.ToString());
            Mark = int.Parse(dgvR.Rows[e.RowIndex].Cells[2].Value.ToString());
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String queryDelete = "DELETE FROM Users WHERE UserId = " + userId + " AND Mark = " + Mark;
                var result = Database.ExecuteNonResultQuery(queryDelete);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    MessageBox.Show("Employee deleted successfully.");
                    Form14_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            dgvR.Refresh();
        }
    }
}

