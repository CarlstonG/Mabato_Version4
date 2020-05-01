using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mabato_V4
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseMB.mdf;Integrated Security=True");
            try
            {
                //open db if closed
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                String query = "SELECT COUNT(1) FROM login WHERE Username=@Username AND Password=@Password";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConn);
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                sqlcmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
                
                //open Dashboard if data match in DB
                if (count == 1)
                {


                    MabatoV4 form1 = new MabatoV4();
                    form1.Show();
                    this.Hide();
                 

                }
                //Data not match invalid messsage
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
                
            }
               //Any other prog error message catched
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //needs to load
        }

                    private void btnRegister_Click(object sender, EventArgs e)
                    {
                        Registration register = new Registration();
                        register.Show();
                        this.Hide();
                    }
    }
}
