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

namespace Education
{
    public partial class InstitutionsForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["EduDB"].ConnectionString;

        public InstitutionsForm()
        {
            InitializeComponent();
            LoadInstitutions();
        }

        // Загрузка учреждений
        private void LoadInstitutions()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Учебные_заведения", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvInstitutions.DataSource = dt;
            }
        }

        // Загрузка педагогов при выборе учреждения
        private void dgvInstitutions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInstitutions.CurrentRow == null) return;
            int institutionId = Convert.ToInt32(dgvInstitutions.CurrentRow.Cells["ID_учреждения"].Value);
            LoadTeachers(institutionId);
        }

        private void LoadTeachers(int institutionId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Педагоги WHERE ID_учреждения = @id",
                    conn
                );
                da.SelectCommand.Parameters.AddWithValue("@id", institutionId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTeachers.DataSource = dt;
            }
        }

        // Добавление учреждения
        private void btnAddInstitution_Click(object sender, EventArgs e)
        {
            AddInstitutionForm form = new AddInstitutionForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadInstitutions();
            }
        }

        // Удаление учреждения
        private void btnDeleteInstitution_Click(object sender, EventArgs e)
        {
            if (dgvInstitutions.CurrentRow == null) return;
            int institutionId = Convert.ToInt32(dgvInstitutions.CurrentRow.Cells["ID_учреждения"].Value);

            DialogResult result = MessageBox.Show(
                "Удалить учреждение и всех педагогов?",
                "Подтверждение",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Учебные_заведения WHERE ID_учреждения = @id",
                        conn
                    );
                    cmd.Parameters.AddWithValue("@id", institutionId);
                    cmd.ExecuteNonQuery();
                }
                LoadInstitutions();
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void InstitutionsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
