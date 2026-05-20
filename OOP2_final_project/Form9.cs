using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            txt_id.Text = "Auto generated";
        }

        private void btn_add_teacher_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string phone = txt_phone.Text;
            string address = txt_address.Text;
            string emp_email = txtEmail.Text;
            string emp_gender;

            if (rbMale.Checked)
            {
                emp_gender = "Male";
            }
            else
            {
                emp_gender = "Female";
            }

            try
            {

                string queryEmp =
                    "INSERT INTO Users (UserName, Phone, Address, Email, Gender) VALUES " +
                    "('" + name + "', '" + phone + "', '" + address + "', '" + emp_email + "', '" + emp_gender + "'); " +
                    "SELECT SCOPE_IDENTITY();";

                var res1 = Database.ExecuteScalarQuery(queryEmp);

                if (res1.HasError)
                {
                    MessageBox.Show(res1.Message);
                    return;
                }

                int userId = Convert.ToInt32(res1.Data.Rows[0][0]);


                int typeId = 3;


                string queryRole =
                    "INSERT INTO UserTypeRole (userId, userTypeId) VALUES (" +
                    userId + ", " + typeId + ")";

                var res2 = Database.ExecuteNonResultQuery(queryRole);

                if (res2.HasError)
                {
                    MessageBox.Show(res2.Message);
                    return;
                }

                MessageBox.Show("Teacher added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txt_name.Clear();
            txt_phone.Clear();
            txt_address.Clear();
            txtEmail.Clear();

        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            Form3 home = new Form3();
            home.Show();

            this.Hide();
        }
    }
}
