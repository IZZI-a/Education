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
using System.Configuration;

namespace Education
{
    public partial class InstitutionsForm : Form
    {
        private string _connectionString;
        private DataTable _institutionsTable;
        private DataTable _teachersTable;
        private int _selectedInstitutionId = -1;
        private int _selectedTeacherId = -1;

        public InstitutionsForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            LoadInstitutions();
        }

        private void LoadInstitutions()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Учебные_заведения", conn);
                    _institutionsTable = new DataTable();
                    da.Fill(_institutionsTable);
                    dgvInstitutions.DataSource = _institutionsTable;

                    // Скрываем столбец ID_учреждения
                    dgvInstitutions.Columns["ID_учреждения"].Visible = false;

                    // Привязываем данные к TextBox'ам
                    BindInstitutionData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки учреждений: {ex.Message}");
                }
            }
        }

        private void LoadTeachers(int institutionId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT * FROM Педагоги WHERE ID_учреждения = @id", conn);
                    da.SelectCommand.Parameters.AddWithValue("@id", institutionId);
                    _teachersTable = new DataTable();
                    da.Fill(_teachersTable);
                    dgvTeachers.DataSource = _teachersTable;
                    // Скрываем столбец ID_педагога
                    dgvTeachers.Columns["ID_педагога"].Visible = false;

                    // Привязываем данные педагога к TextBox'ам
                    BindTeacherData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки педагогов: {ex.Message}");
                }
            }
        }

        private void dgvInstitutions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInstitutions.CurrentRow == null) return;

            // Получаем ID выбранного учреждения
            _selectedInstitutionId = Convert.ToInt32(dgvInstitutions.CurrentRow.Cells["ID_учреждения"].Value);
            LoadTeachers(_selectedInstitutionId);
            BindInstitutionData();
        }

        private void dgvTeachers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeachers.CurrentRow == null) return;

            // Получаем ID выбранного педагога
            _selectedTeacherId = Convert.ToInt32(dgvTeachers.CurrentRow.Cells["ID_педагога"].Value);
            BindTeacherData();
        }

        private void BindInstitutionData()
        {
            if (dgvInstitutions.CurrentRow != null)
            {
                txtInstitutionName.Text = dgvInstitutions.CurrentRow.Cells["Название"].Value?.ToString();
                txtInstitutionType.Text = dgvInstitutions.CurrentRow.Cells["Тип"].Value?.ToString();
                txtInstitutionAddress.Text = dgvInstitutions.CurrentRow.Cells["Адрес"].Value?.ToString();
                txtDirectorName.Text = dgvInstitutions.CurrentRow.Cells["Директор"].Value?.ToString();
                txtLicense.Text = dgvInstitutions.CurrentRow.Cells["Лицензия"].Value?.ToString();
                txtContact.Text = dgvInstitutions.CurrentRow.Cells["Контактные_телефоны"].Value?.ToString();
                txtRegion.Text = dgvInstitutions.CurrentRow.Cells["Район"].Value?.ToString();
            }
            else
            {
                // Очищаем TextBox'ы, если нет выбранной строки
                txtInstitutionName.Clear();
                txtInstitutionType.Clear();
                txtInstitutionAddress.Clear();
                txtDirectorName.Clear();
                txtLicense.Clear();
                txtContact.Clear();
                txtRegion.Clear();
            }
        }

        private void BindTeacherData()
        {
            if (dgvTeachers.CurrentRow != null)
            {
                txtTeacherName.Text = dgvTeachers.CurrentRow.Cells["ФИО"].Value?.ToString();
                txtTeacherPosition.Text = dgvTeachers.CurrentRow.Cells["Должность"].Value?.ToString();
                txtTeacherQualification.Text = dgvTeachers.CurrentRow.Cells["Квалификация"].Value?.ToString();
                txtTeacherExperience.Text = dgvTeachers.CurrentRow.Cells["Стаж"].Value?.ToString();
            }
            else
            {
                // Очищаем TextBox'ы, если нет выбранной строки
                txtTeacherName.Clear();
                txtTeacherPosition.Clear();
                txtTeacherQualification.Clear();
                txtTeacherExperience.Clear();
            }
        }

        // CRUD для Учебных заведений

        private void btnAddInstitution_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Учебные_заведения (Название, Тип, Адрес, Директор, Лицензия, Контактные_телефоны, Район) 
                               VALUES (@Название, @Тип, @Адрес, @Директор, @Лицензия, @Контактные_телефоны, @Район);
                               SELECT SCOPE_IDENTITY();"; // Получаем ID добавленной записи

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Название", txtInstitutionName.Text);
                    cmd.Parameters.AddWithValue("@Тип", txtInstitutionType.Text);
                    cmd.Parameters.AddWithValue("@Адрес", txtInstitutionAddress.Text);
                    cmd.Parameters.AddWithValue("@Директор", txtDirectorName.Text);
                    cmd.Parameters.AddWithValue("@Лицензия", txtLicense.Text);
                    cmd.Parameters.AddWithValue("@Контактные_телефоны", txtContact.Text);
                    cmd.Parameters.AddWithValue("@Район", txtRegion.Text);

                    int newInstitutionId = Convert.ToInt32(cmd.ExecuteScalar());

                    // Добавляем новую строку в DataTable
                    DataRow newRow = _institutionsTable.NewRow();
                    newRow["ID_учреждения"] = newInstitutionId;
                    newRow["Название"] = txtInstitutionName.Text;
                    newRow["Тип"] = txtInstitutionType.Text;
                    newRow["Адрес"] = txtInstitutionAddress.Text;
                    newRow["Директор"] = txtDirectorName.Text;
                    newRow["Лицензия"] = txtLicense.Text;
                    newRow["Контактные_телефоны"] = txtContact.Text;
                    newRow["Район"] = txtRegion.Text;
                    _institutionsTable.Rows.Add(newRow);
                    _institutionsTable.AcceptChanges();

                    MessageBox.Show("Учреждение добавлено!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления учреждения: {ex.Message}");
            }
        }

        private void btnEditInstitution_Click(object sender, EventArgs e)
        {
            if (_selectedInstitutionId == -1)
            {
                MessageBox.Show("Выберите учреждение для редактирования!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Учебные_заведения 
                               SET Название = @Название, 
                                   Тип = @Тип, 
                                   Адрес = @Адрес, 
                                   Директор = @Директор, 
                                   Лицензия = @Лицензия, 
                                   Контактные_телефоны = @Контактные_телефоны, 
                                   Район = @Район
                               WHERE ID_учреждения = @ID_учреждения";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_учреждения", _selectedInstitutionId);
                    cmd.Parameters.AddWithValue("@Название", txtInstitutionName.Text);
                    cmd.Parameters.AddWithValue("@Тип", txtInstitutionType.Text);
                    cmd.Parameters.AddWithValue("@Адрес", txtInstitutionAddress.Text);
                    cmd.Parameters.AddWithValue("@Директор", txtDirectorName.Text);
                    cmd.Parameters.AddWithValue("@Лицензия", txtLicense.Text);
                    cmd.Parameters.AddWithValue("@Контактные_телефоны", txtContact.Text);
                    cmd.Parameters.AddWithValue("@Район", txtRegion.Text);

                    cmd.ExecuteNonQuery();

                    // Обновляем строку в DataTable
                    DataRow row = _institutionsTable.Rows.Find(_selectedInstitutionId);
                    row["Название"] = txtInstitutionName.Text;
                    row["Тип"] = txtInstitutionType.Text;
                    row["Адрес"] = txtInstitutionAddress.Text;
                    row["Директор"] = txtDirectorName.Text;
                    row["Лицензия"] = txtLicense.Text;
                    row["Контактные_телефоны"] = txtContact.Text;
                    row["Район"] = txtRegion.Text;
                    _institutionsTable.AcceptChanges();

                    MessageBox.Show("Учреждение обновлено!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка редактирования учреждения: {ex.Message}");
            }
        }

        private void btnDeleteInstitution_Click(object sender, EventArgs e)
        {
            if (_selectedInstitutionId == -1)
            {
                MessageBox.Show("Выберите учреждение для удаления!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Учебные_заведения WHERE ID_учреждения = @ID_учреждения";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_учреждения", _selectedInstitutionId);
                    cmd.ExecuteNonQuery();

                    // Удаляем строку из DataTable
                    DataRow row = _institutionsTable.Rows.Find(_selectedInstitutionId);
                    row.Delete();
                    _institutionsTable.AcceptChanges();

                    MessageBox.Show("Учреждение удалено!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления учреждения: {ex.Message}");
            }
        }

        private void btnRefreshInstitution_Click(object sender, EventArgs e)
        {
            LoadInstitutions();
        }

        // CRUD для Педагогов

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            if (_selectedInstitutionId == -1)
            {
                MessageBox.Show("Выберите учебное заведение для добавления педагога!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Педагоги (ФИО, Должность, Квалификация, Стаж, ID_учреждения) 
                               VALUES (@ФИО, @Должность, @Квалификация, @Стаж, @ID_учреждения);
                               SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ФИО", txtTeacherName.Text);
                    cmd.Parameters.AddWithValue("@Должность", txtTeacherPosition.Text);
                    cmd.Parameters.AddWithValue("@Квалификация", txtTeacherQualification.Text);
                    cmd.Parameters.AddWithValue("@Стаж", txtTeacherExperience.Text);
                    cmd.Parameters.AddWithValue("@ID_учреждения", _selectedInstitutionId);

                    int newTeacherId = Convert.ToInt32(cmd.ExecuteScalar());

                    // Добавляем новую строку в DataTable
                    DataRow newRow = _teachersTable.NewRow();
                    newRow["ID_педагога"] = newTeacherId;
                    newRow["ФИО"] = txtTeacherName.Text;
                    newRow["Должность"] = txtTeacherPosition.Text;
                    newRow["Квалификация"] = txtTeacherQualification.Text;
                    newRow["Стаж"] = txtTeacherExperience.Text;
                    newRow["ID_учреждения"] = _selectedInstitutionId;
                    _teachersTable.Rows.Add(newRow);
                    _teachersTable.AcceptChanges();

                    MessageBox.Show("Педагог добавлен!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления педагога: {ex.Message}");
            }
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            if (_selectedTeacherId == -1)
            {
                MessageBox.Show("Выберите педагога для редактирования!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Педагоги 
                               SET ФИО = @ФИО, 
                                   Должность = @Должность, 
                                   Квалификация = @Квалификация, 
                                   Стаж = @Стаж, 
                                   ID_учреждения = @ID_учреждения
                               WHERE ID_педагога = @ID_педагога";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_педагога", _selectedTeacherId);
                    cmd.Parameters.AddWithValue("@ФИО", txtTeacherName.Text);
                    cmd.Parameters.AddWithValue("@Должность", txtTeacherPosition.Text);
                    cmd.Parameters.AddWithValue("@Квалификация", txtTeacherQualification.Text);
                    cmd.Parameters.AddWithValue("@Стаж", txtTeacherExperience.Text);
                    cmd.Parameters.AddWithValue("@ID_учреждения", _selectedInstitutionId);

                    cmd.ExecuteNonQuery();

                    // Обновляем строку в DataTable
                    DataRow row = _teachersTable.Rows.Find(_selectedTeacherId);
                    row["ФИО"] = txtTeacherName.Text;
                    row["Должность"] = txtTeacherPosition.Text;
                    row["Квалификация"] = txtTeacherQualification.Text;
                    row["Стаж"] = txtTeacherExperience.Text;
                    row["ID_учреждения"] = _selectedInstitutionId;
                    _teachersTable.AcceptChanges();

                    MessageBox.Show("Педагог обновлен!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка редактирования педагога: {ex.Message}");
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (_selectedTeacherId == -1)
            {
                MessageBox.Show("Выберите педагога для удаления!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Педагоги WHERE ID_педагога = @ID_педагога";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_педагога", _selectedTeacherId);
                    cmd.ExecuteNonQuery();

                    // Удаляем строку из DataTable
                    DataRow row = _teachersTable.Rows.Find(_selectedTeacherId);
                    row.Delete();
                    _teachersTable.AcceptChanges();

                    MessageBox.Show("Педагог удален!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления педагога: {ex.Message}");
            }
        }

        private void btnRefreshTeacher_Click(object sender, EventArgs e)
        {
            if (_selectedInstitutionId != -1)
            {
                LoadTeachers(_selectedInstitutionId);
            }
            else
            {
                MessageBox.Show("Выберите учебное заведение для обновления списка педагогов!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //TODO: Реализация редактирования
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //TODO: Реализация удаления
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInstitutions();
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

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
