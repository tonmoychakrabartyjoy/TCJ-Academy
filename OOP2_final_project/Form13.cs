using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form13 : Form
    {
        public Form13()
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
                if(txt_teacher_id.Text == "" || txt_course_code.Text == "")
                {
                    string teacher_id = txt_teacher_id.Text;
                    string course_code = txt_course_code.Text;
                    string section;

                    MessageBox.Show("Please fill all the fields!");
                }
                else
                {
                    MessageBox.Show("Information Updated Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
