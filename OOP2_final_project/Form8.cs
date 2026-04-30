using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void lb_address_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string name = txt_name.Text;
            string address = txt_address.Text;
            string phone = txt_phone.Text;
            string role = txt_type.Text;

            MessageBox.Show("Student added successfull");
        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            Form3 home = new Form3();
            home.Show();

            this.Hide();
        }
    }
}
