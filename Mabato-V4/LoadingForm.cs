using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabato_V4
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 2; 
            if(panel2.Width >= 357)
            {
                timer1.Stop();
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
              
            }
        }
    }
}
