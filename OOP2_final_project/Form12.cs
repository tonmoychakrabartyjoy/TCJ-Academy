using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form12 : Form
    {
        Form home;
        public Form12(Form home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            home.Show();

            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            txt_student_id.Focus();
            if (string.IsNullOrWhiteSpace(txt_student_id.Text) ||
                string.IsNullOrWhiteSpace(txt_course_code.Text) ||
                string.IsNullOrWhiteSpace(txt_month.Text) ||
                string.IsNullOrWhiteSpace(txt_pay_id.Text) ||
                string.IsNullOrWhiteSpace(txt_amount.Text) ||
                string.IsNullOrWhiteSpace(txtAcaY.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            string id = txt_student_id.Text;
            string course_code = txt_course_code.Text;
            string month = txt_month.Text;
            string pay_id = txt_pay_id.Text;

            if (!int.TryParse(txt_amount.Text, out int amount))
            {
                MessageBox.Show("Please enter a valid numeric amount.");
                return;
            }

            if (!int.TryParse(txtAcaY.Text, out int academic_year))
            {
                MessageBox.Show("Please enter a valid academic year number.");
                return;
            }

            string section;
            if (rbA.Checked) section = "A";
            else if (rbB.Checked) section = "B";
            else if (rbC.Checked) section = "C";
            else section = "D";

            try
            {
                string queryAcaY = "INSERT INTO AcademicYear (CourseCode, AcademicYear, SectionName) VALUES ('" + course_code + "', " + academic_year + ", '" + section + "')";


                string querypay = "INSERT INTO Payment (UserId, PayId, Amount) VALUES ('" + id + "', '" + pay_id + "', " + amount + ")";


                string querypayMonth = "INSERT INTO PaymentMonth (UserId, CourseCode, PayMonth, PayId, SectionName, AcademicYear) VALUES ('" + id + "', '" + course_code + "', '" + month + "', '" + pay_id + "', '" + section + "', " + academic_year + ")";


                var result = Database.ExecuteNonResultQuery(querypay);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                var result2 = Database.ExecuteNonResultQuery(querypayMonth);
                if (result2.HasError)
                {
                    MessageBox.Show(result2.Message);
                    return;
                }

                var result3 = Database.ExecuteNonResultQuery(queryAcaY);
                if (result3.HasError)
                {
                    MessageBox.Show(result3.Message);
                    return;
                }

                MessageBox.Show("Course added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            txtAcaY.Clear();
            txt_amount.Clear();
            txt_course_code.Clear();
            txt_month.Clear();
            txt_pay_id.Clear();
            txt_student_id.Clear();
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false; 
            rbD.Checked = false;

        }

        private void txt_pay_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_student_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_course_code.Focus();
            }
        }

        private void txt_course_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pay_id.Focus();
            }
        }

        private void txt_pay_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_amount.Focus();
            }
        }

        private void txt_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_month.Focus();
            }
        }

        private void txt_month_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //atxtAcaY.Focus();
            }
        }

        private void txtAcaY_TextChanged(object sender, EventArgs e)
        {
            //btn_update_Click(sender, e);
        }
    }
}
