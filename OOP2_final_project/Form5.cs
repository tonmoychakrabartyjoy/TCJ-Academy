using Microsoft.Data.SqlClient;
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
            int mark;
            if (!int.TryParse(txt_mark.Text, out mark))
            {
                MessageBox.Show("Input valid mark");
                txt_mark.Focus();
                return;
            }


            try
            {
                string upload_result = "INSERT INTO ExamResult VALUES('" + exam_id + "','" + user_id + "'," + mark + ")";


                Database.AddQuery(upload_result);

                
                MessageBox.Show("saved");

                txt_exam_id.Clear();
                txt_user_id.Clear();
                txt_mark.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
