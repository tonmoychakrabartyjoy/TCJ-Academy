using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form11 : Form
    {
        private Form home;
        public Form11(Form sender)
        {
            InitializeComponent();
            this.home = sender;
        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            home.Show();

            this.Hide();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            dgvt.AutoGenerateColumns = false;

            try
            {
                var query = @"
            SELECT U.UserId, U.UserName, U.Phone, U.Address
            FROM Users U, UserTypeRole UR, UserType UT
            WHERE U.UserId = UR.UserId
            AND UR.UserTypeId = UT.UserTypeId
            AND UT.UserType = 'Teacher'";

                var result = Database.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvt.DataSource = result.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_teacher_Click(object sender, EventArgs e)
        {
            Form11_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int TeacherId = int.Parse(txtSearch.Text);

            try
            {
                String querySearch = "SELECT U.UserId, U.UserName, U.Phone, U.Address FROM Users U WHERE U.UserId = " + TeacherId;

                var result = Database.GetQueryData(querySearch);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    dgvt.DataSource = result.Data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int selectedTeacherId;
        private void dgvt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedTeacherId = int.Parse(dgvt.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String queryDelete = "DELETE FROM Users WHERE UserId = " + selectedTeacherId;
                var result = Database.ExecuteNonResultQuery(queryDelete);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    MessageBox.Show("Teacher deleted successfully.");
                    Form11_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
