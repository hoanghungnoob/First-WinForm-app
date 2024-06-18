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
using WindowsFormsApp2.View;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {


        string strCon = @"Data Source=msi\sqlexpress;Initial Catalog=testLogin;Integrated Security=True;";
        SqlConnection sqlCon = null;

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
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void onChange_Username(object sender, EventArgs e)
        {
            this.name = username.Text;
        }

        private void onChange_password(object sender, EventArgs e)
        {
            this.pass = password.Text;
        }
        private void Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please input name and password");
                return;
            }
            else
            {
                try
                {
                    using (sqlCon = new SqlConnection(strCon))
                    {
                        sqlCon.Open();
                        string query = "SELECT COUNT(1) FROM login WHERE name=@Username AND password=@Password";
                        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                        sqlCmd.Parameters.AddWithValue("@Username", name);
                        sqlCmd.Parameters.AddWithValue("@Password", pass);
                        int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                        if(count == 1)
                        {
                            MessageBox.Show("Login successfull");
                            // thêm các điều hướng sau khi login
                        }
                        else
                        {
                            MessageBox.Show("Login failed, please input username and password correctly");
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error"+ ex);
                }
            }
        }

        private void Open_Register(object sender, EventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.ShowDialog();
            this.Show();
        }
    }
}
