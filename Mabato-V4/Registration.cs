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

    
    public partial class Registration : MaterialSkin.Controls.MaterialForm
    {

        private SqlCommand sql_cmd;
        private string txtQuery;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            
        }

      

        private void btnlogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            GC.Collect();
            this.Hide();
            
        }

        private void txtConpass_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConpass.Text)
            {
                
                
               
                MessageBox.Show("Password must match please try again", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                txtPassword.Text = "";
                txtConpass.Text = "";
                return;
            }

            else if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password and Username must at least be 6 Characters", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                txtPassword.Text = "";
                txtConpass.Text = "";
                return;
            }

            else if (txtusername.Text.Length < 6)

            {
                MessageBox.Show("Password and Username must at least be 6 Characters", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                txtPassword.Text = "";
                txtConpass.Text = "";
                return;
            }

            else if(txtusername.Text != String.Empty && txtPassword.Text != String.Empty)
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseMB.mdf;Integrated Security=True");
                sqlcon.Open();
                sql_cmd = sqlcon.CreateCommand();
                sql_cmd.CommandText = txtQuery = "INSERT INTO login(Username, Password) VALUES('" + this.txtusername.Text +"','" + this.txtPassword.Text + "')";
                sql_cmd.ExecuteNonQuery();
                MessageBox.Show("Successful Registration. Welcome Teacher!");
                
                //close the connection
                sqlcon.Close();
                txtusername.Text = "";
                txtPassword.Text = "";
                txtConpass.Text = "";
                LoginForm log = new LoginForm();
                log.Show();
                GC.Collect();
                this.Hide();
                


            
            }

            else
            {
                MessageBox.Show("USERNAME AND PASSWORD MUST NOT BE EMPTY!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
