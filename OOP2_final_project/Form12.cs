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
        public Form12()
        {
            InitializeComponent();
        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            Form3 home = new Form3();
            home.Show();

            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txt_student_id.Text) ||
                    string.IsNullOrWhiteSpace(txt_course_code.Text) ||
                    string.IsNullOrWhiteSpace(txt_month.Text) ||
                    string.IsNullOrWhiteSpace(txt_pay_id.Text) ||
                    string.IsNullOrWhiteSpace(txt_amount.Text))
                {
                    MessageBox.Show("Please fill all fields!");
                    return;
                }

                txt_student_id.Focus();
                string id = txt_student_id.Text;
                string course_code = txt_course_code.Text;
                string month = txt_month.Text;
                string pay_id = txt_pay_id.Text;
                string section;
                int amount = int.Parse(txt_amount.Text);
                MessageBox.Show("Course added successfully");
            }
            catch (FormatException)
            {
                MessageBox.Show("Input valid amount");
                txt_amount.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
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
                btn_update_Click(sender, e);
            }
        }
    }
}
