using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=EduDB;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text; // Реализуйте хэширование

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Роль FROM Пользователи WHERE Логин=@login AND Пароль=@password", conn);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);
                string role = cmd.ExecuteScalar()?.ToString();

                if (role != null)
                {
                    MainMenu mainForm = new MainMenu(role); // Передайте роль для управления доступом
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ошибка авторизации!");
                }
            }
        }
    }
}