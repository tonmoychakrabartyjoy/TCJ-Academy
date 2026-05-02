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
            try
            {
                if (txt_fee.Text == "" ||
                    txt_code.Text == "")
                {
                    MessageBox.Show("Please enter the course fee.");
                    return;
                }
                else
                {
                    string code = txt_code.Text;
                    decimal course_fee = decimal.Parse(txt_fee.Text);
                    MessageBox.Show($"Course fee for {code} has been set to {course_fee:C}.");

                    txt_code.Clear();
                    txt_fee.Clear();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("input valid fee");
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
