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
        private string userRole;

        // Конструктор с параметром роли
        public MainMenu(string role)
        {
            InitializeComponent();
            userRole = role;
            if (role != "Администратор") btnFinance.Enabled = false;
        }
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
