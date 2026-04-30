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
            else
            {
                MessageBox.Show("Invalid Id or Password!");
            }
        }




        private void login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
