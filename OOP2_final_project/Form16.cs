using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace OOP2_final_project
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();

            txt_emp_id.Text = "Auto generated";
            txt_emp_type.Text = "Employee";
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
            string emp_name = txt_emp_name.Text;
            string emp_phone = txt_phone.Text;
            string emp_address = txt_address.Text;
            string emp_email = txtEmail.Text;
            string emp_gender ;

            if(rbMale.Checked)
            {
                emp_gender = "Male";
            }
            else
            {
                emp_gender = "Female";
            }

                if (txt_emp_name.Text == "" ||
                txt_phone.Text == "" ||
                txt_address.Text == ""||
                string.IsNullOrWhiteSpace(emp_email) ||
                string.IsNullOrWhiteSpace(emp_gender))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            

            try
            {
                
                string queryEmp = "INSERT INTO Users (UserName, Phone, Address, Email, Gender) VALUES ('" + emp_name + "', '" + emp_phone + "', '" + emp_address + "', '" + emp_email + "', '" + emp_gender + "'); SELECT SCOPE_IDENTITY();";

                var res1 = Database.ExecuteScalarQuery(queryEmp);

                if (res1.HasError)
                {
                    MessageBox.Show(res1.Message);
                    return;
                }

                int userId = Convert.ToInt32(res1.Data.Rows[0][0]);

                
                int typeId = 1;

                
                string queryRole = "INSERT INTO UserTypeRole (userId, userTypeId) VALUES (" +userId + ", " + typeId + ")";

                var res2 = Database.ExecuteNonResultQuery(queryRole);

                if (res2.HasError)
                {
                    MessageBox.Show(res2.Message);
                    return;
                }

                MessageBox.Show("Employee added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txt_emp_name.Clear();
            txt_phone.Clear();
            txt_address.Clear();
            txtEmail.Clear();
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

        private void Form16_Load(object sender, EventArgs e)
        {

        }
    }
}
