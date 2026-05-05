

namespace OOP2_final_project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        string name;
        string id;
        string pass;



        private void btn_login_Click(object sender, EventArgs e)
        {

            name = txt_name.Text;
            id = txt_id.Text;
            pass = txt_pass.Text;



            if (name == "Tonmoy" && id == "2000-0002" && pass == "1234")
            {
                Form3 emp_page = new Form3();
                emp_page.Show();

                this.Hide();
            }

            else if(name == "Joy" && id == "1000-0001" && pass == "1234")
            {
                Form6 admin_page = new Form6();
                admin_page.Show();

                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid Id or Password!");
            }
        }




        private void login_Load(object sender, EventArgs e)
        {

        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_id.Focus();
            }
        }

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pass.Focus();
            }
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }
    }
}
