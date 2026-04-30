using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void btn_add_exam_Click(object sender, EventArgs e)
        {
            Form4 create_exam = new Form4();
            create_exam.Show();

            this.Hide();
        }





        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_teacher_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        
    }
}
