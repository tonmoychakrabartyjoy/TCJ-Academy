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
            txt_student_id.Focus();
            string id = txt_student_id.Text;
            string course_code = txt_course_code.Text;
            string month = txt_month.Text;
            string pay_id = txt_pay_id.Text;
            string section;

            try
            {
                int amount = int.Parse(txt_amount.Text);
                MessageBox.Show("Course added successfully");
            }
            catch (FormatException)
            {
                MessageBox.Show("Input valid amount");
                txt_amount.Focus();
            }
        }
    }
}
