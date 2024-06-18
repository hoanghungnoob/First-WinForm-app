using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        private string name;
        private string pass;
        public void setUserName(string username)
        {
            this.name = username;
        }
        public void setPassword(string password)
        {
            this.pass = password;
        }
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.name = username.Text;
            this.pass = password.Text;
            MessageBox.Show("name: " + this.name + " Pass:" + this.pass);
        }
    }
}
