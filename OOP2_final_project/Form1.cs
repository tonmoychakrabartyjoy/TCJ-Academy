

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
            string name = txt_name.Text;
            string id = txt_id.Text;
            string pass = txt_pass.Text;

            if (pass != "1234")
            {
                MessageBox.Show("Invalid Password!");
                return;
            }

            string query = "SELECT U.UserId, U.UserName, R.UserTypeId " +
                           "FROM Users U, UserTypeRole R " +
                           "WHERE U.UserId = R.UserId " +
                           "AND U.UserName = '" + name + "' " +
                           "AND U.UserId = '" + id + "'";

            var result = Database.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            if (result.Data.Rows.Count == 1)
            {
                int userTypeId = Convert.ToInt32(result.Data.Rows[0]["UserTypeId"]);
                Case.UserName = name;
               

                if (userTypeId == 1)
                {
                    Form3 emp_page = new Form3();
                    emp_page.Show();
                    this.Hide();
                }

                
                else if (userTypeId == 2)
                {
                    Form6 admin_page = new Form6();
                    admin_page.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Id!");
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
