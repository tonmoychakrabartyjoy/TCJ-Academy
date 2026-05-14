using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace OOP2_final_project
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();

            txt_emp_id.Text = "Auto generated";
        }


        // Extra part

        private void txt_salary_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_emp_id_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_emp_id_TextChanged(object sender, EventArgs e)
        {

        }


        // End of extra part

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            Form6 home = new Form6();
            home.Show();

            this.Hide();
        }

        private void btn_add_emp_Click(object sender, EventArgs e)
        {
            if (txt_emp_name.Text == "" ||
                    txt_phone.Text == "" ||
                    txt_address.Text == "")
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else
            {
                string emp_name = txt_emp_name.Text;
                string emp_phone = txt_phone.Text;
                string emp_address = txt_address.Text;
                string emp_type = txt_emp_type.Text;

                try
                {
                    string queryEmp = "INSERT INTO Users (UserName, Phone, Address) VALUES ('" + emp_name + "', '" + emp_phone + "' , '"+emp_address+"'); SELECT SCOPE_IDENTITY();";


                    int User_id = Convert.ToInt32(Database.GetValue(queryEmp));


                    string queryType = "INSERT INTO UserType (UserId,UserType) VALUES ('" + User_id + "', '" + emp_type + "')";
                    Database.AddQuery(queryType);

                    MessageBox.Show("Employee added successfully.");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

                txt_phone.Clear();
                txt_emp_name.Clear();
                txt_address.Clear();
                txt_emp_id.Clear();
                txt_address.Clear();
                txt_emp_type.Clear();
            }
        }

        private void txt_emp_name_KeyDown(object sender, KeyEventArgs e)
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
                txt_emp_type.Focus();
            }
        }


        private void txt_emp_type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add_emp_Click(sender, e);
            }
        }
        
    }
}
