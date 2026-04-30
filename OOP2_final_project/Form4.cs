using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            Form3 home = new Form3();
            home.Show();

            this.Hide();
        }

        private void btn_exam_Click(object sender, EventArgs e)
        {
            string exam_id = txt_exam_id.Text;
            string subject = txt_subject.Text;
            string section = txt_section.Text;
            DateTime date = date_picker.Value.Date;
            try
            {
                int total_mark = int.Parse(txt_total_mark.Text);
                MessageBox.Show("Exam added successfully");

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter numbers only!");
                txt_total_mark.Focus();
            }
       
            
        }
    }
}
