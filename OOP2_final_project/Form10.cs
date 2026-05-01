using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form10 : Form
    {
        private Form home;
        public Form10(Form sender)
        {
            InitializeComponent();
            this.home = sender;
        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            home.Show();

            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
