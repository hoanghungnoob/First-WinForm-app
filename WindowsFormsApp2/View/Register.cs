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


namespace WindowsFormsApp2.View
{
    public partial class Register : Form
    {
        private string Username;
        private string Password;
        private string RePassword;
        string strCon = @"Data Source=msi\sqlexpress;Initial Catalog=testLogin;Integrated Security=True;";
        SqlConnection sqlCon = null;
        public Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void onChange_password(object sender, EventArgs e)
        {
            this.Password = password.Text;
        }
        private void onChange_repassword(object sender, EventArgs e)
        {
            this.RePassword = repassword.Text;
        }

        private void onChange_username(object sender, EventArgs e)
        {
            this.Username = username.Text;
        }

        private void onClick_Register(object sender, EventArgs e)
        {
            // xử lý register
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(RePassword))
            {
                MessageBox.Show("Please input full information!");
            }
            else if (Password != RePassword)
            {
                MessageBox.Show("Password and password confirm not match");
            }
            else
            {
                try
                {
                    using (sqlCon = new SqlConnection(strCon))
                    {
                        sqlCon.Open();
                        string query = "INSERT INTO login (name, password) values (@Username, @Password)";
                        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                        sqlCmd.Parameters.AddWithValue("@Username", Username);
                        sqlCmd.Parameters.AddWithValue("@Password", Password);
                        int result = sqlCmd.ExecuteNonQuery(); // Use ExecuteNonQuery for INSERT

                        if (result > 0)
                        {
                            // edit dispaly message in MessageBox
                            MessageBox.Show("Registration successful!","Succcessfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            this.Hide();
                            Login formLogin = new Login();
                            formLogin.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Show();
        }
    }
}
