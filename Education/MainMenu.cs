using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education
{
    public partial class MainMenu : Form
    {
        private string _userRole;
        private string _connectionString;

        // Конструктор с параметром роли
        public MainMenu(string role, string connectionString)
        {
            InitializeComponent();
            _userRole = role;
            _connectionString = connectionString;
            if (role != "Администратор")
            {
                btnFinance.Enabled = false; 
            } 
                
        }
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnInstitutions_Click(object sender, EventArgs e)
        {
            InstitutionsForm form = new InstitutionsForm(_connectionString); // Передаем строку подключения
            form.ShowDialog();
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm form = new ReportsForm(_connectionString);
            form.ShowDialog();
        }
         private void btnDocs_Click(object sender, EventArgs e)
        {
            DocsForm form = new DocsForm(_connectionString);
            form.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
