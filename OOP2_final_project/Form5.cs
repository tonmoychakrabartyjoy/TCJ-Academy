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
        public Form5()
        {
            InitializeComponent();
        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            Form3 home = new Form3();
            home.Show();

            this.Hide();
        }

        private void btn_add_result_Click(object sender, EventArgs e)
        {
            string exam_id = txt_exam_id.Text;
            string user_id = txt_user_id.Text;
            try
            {
                int mark = int.Parse(txt_mark.Text);
                MessageBox.Show("Result upload successfull");
            }
            catch (FormatException)
            {
                MessageBox.Show("Input valid mark");
                txt_mark.Focus();
            }
        }
    }
}
