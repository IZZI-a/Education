using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=PROK-PC;Initial Catalog=EduDB;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text; // Хэширование пароля

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Роль FROM Пользователи WHERE Логин=@login AND Пароль=@password", conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();
                        MainMenu mainForm = new MainMenu(role, connectionString); // Передаем connectionString
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка авторизации!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}");
                }
            }
        }


       

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}