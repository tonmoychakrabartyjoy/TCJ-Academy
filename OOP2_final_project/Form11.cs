using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form11 : Form
    {
        private Form home;
        public Form11(Form sender)
        {
            InitializeComponent();
            this.home = sender;
        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            home.Show();

            this.Hide();
        }
    }
}
