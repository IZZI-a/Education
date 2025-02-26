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
    public partial class EditInstitutionForm : Form
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Address { get; private set; }
        public string Director { get; private set; }

        public EditInstitutionForm(string currentName, string currentType, string currentAddress, string currentDirector)
        {
            InitializeComponent();
            txtName.Text = currentName;
            txtType.Text = currentType;
            txtAddress.Text = currentAddress;
            txtDirector.Text = currentDirector;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDirector_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
