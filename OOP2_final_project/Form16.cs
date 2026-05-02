using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            Form6 home = new Form6();
            home.Show();

            this.Hide();
        }

        private void btn_add_emp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_emp_id.Text == "" ||
                    txt_emp_name.Text == "" ||
                    txt_phone.Text == "" ||
                    txt_address.Text == "" ||
                    txt_salary.Text == "")
                {
                    MessageBox.Show("Please fill all the fields.");
                }
                else
                {
                    string emp_id = txt_emp_id.Text;
                    string emp_name = txt_emp_name.Text;
                    string emp_phone = txt_phone.Text;
                    string emp_address = txt_address.Text;
                    int emp_salary = int.Parse(txt_salary.Text);
                    MessageBox.Show("Employee added successfully.");

                    txt_salary.Clear();
                    txt_phone.Clear();
                    txt_emp_name.Clear();
                    txt_address.Clear();
                    txt_emp_id.Clear();
                    txt_address.Clear();
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid salary.");
                txt_salary.Focus();
            }
        }

        private void txt_emp_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_emp_id.Focus();
            }
        }

        private void txt_emp_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_phone.Focus();
            }
        }

        private void txt_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_address.Focus();
            }
        }

        private void txt_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_salary.Focus();
            }
        }

        private void txt_salary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            { 
                btn_add_emp_Click(sender, e);
            }
        }
    }
}
