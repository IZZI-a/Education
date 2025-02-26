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
    public partial class AddInstitutionForm : Form
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Address { get; private set; }
        public string Director { get; private set; }

        public AddInstitutionForm()
        {
            InitializeComponent();
        }

        private void AddInstitutionForm_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Name = txtName.Text;
            Type = txtType.Text;
            Address = txtAddress.Text;
            Director = txtDirector.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

