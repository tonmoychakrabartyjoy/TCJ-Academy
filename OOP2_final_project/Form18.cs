using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            Form6 home = new Form6();
            home.Show();

            this.Hide();
        }

        private void btn_add_fee_Click(object sender, EventArgs e)
        {
            if (txt_fee.Text == "" || txt_code.Text == "")
            {
                MessageBox.Show("Please enter the course fee or course code.");
                return;
            }

            string code = txt_code.Text;
            decimal course_fee;

            if (!decimal.TryParse(txt_fee.Text, out course_fee))
            {
                MessageBox.Show("Invalid fee format.");
                return;
            }

            try
            {
                string query = "UPDATE Course SET CourseFee = " + course_fee + " WHERE CourseCode = '" + code + "'";

                var result = Database.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                MessageBox.Show("Course fee updated successfully.");

                txt_code.Clear();
                txt_fee.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_fee.Focus();
            }
        }

        private void txt_fee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add_fee_Click(sender, e);
            }
        }
    }
}
