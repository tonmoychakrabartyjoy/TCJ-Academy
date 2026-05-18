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
            if (txt_emp_name.Text == "" ||
                txt_phone.Text == "" ||
                txt_address.Text == "")
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            string emp_name = txt_emp_name.Text;
            string emp_phone = txt_phone.Text;
            string emp_address = txt_address.Text;
            string emp_type = "Employee";

            try
            {
                // 🔹 Insert into Users + get ID
                string queryEmp = "INSERT INTO Users (UserName, Phone, Address) VALUES ('" + emp_name + "', '" + emp_phone + "', '" + emp_address + "'); SELECT SCOPE_IDENTITY(); ";
        
            var res1 = Database.ExecuteScalarQuery(queryEmp);

                if (res1.HasError)
                {
                    MessageBox.Show(res1.Message);
                    return;
                }

                int userId = Convert.ToInt32(res1.Data.Rows[0][0]);

                // 🔹 Insert into UserType
                string queryType = "INSERT INTO UserType (UserId, UserType) VALUES ('" + userId + "', '" + emp_type + "')";

                var res2 = Database.ExecuteNonResultQuery(queryType);

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

            // Clear fields
            txt_phone.Clear();
            txt_emp_name.Clear();
            txt_address.Clear();
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
