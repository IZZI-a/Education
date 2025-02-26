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
    public partial class AppealsForm : Form
    {
        private string _connectionString;
        private DataTable _appealsTable;
        private int _selectedAppealId = -1;

        public AppealsForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            LoadAppeals(); 
            InitializeComboBox();
        }
     
        private void LoadAppeals()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Обращения_граждан", conn);
                    _appealsTable = new DataTable();
                    da.Fill(_appealsTable);
                    dgvAppeals.DataSource = _appealsTable;

                    dgvAppeals.Columns["ID_обращения"].Visible = false;
                    BindAppealData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки обращений: {ex.Message}");
                }
            }
        }

        private void BindAppealData()
        {
            if (dgvAppeals.CurrentRow != null)
            {
                txtAppealFIO.Text = dgvAppeals.CurrentRow.Cells["ФИО_заявителя"].Value?.ToString();
                txtAppealText.Text = dgvAppeals.CurrentRow.Cells["Текст"].Value?.ToString();
                dtpAppealDate.Value = Convert.ToDateTime(dgvAppeals.CurrentRow.Cells["Дата_года"].Value);
                cmbAppealStatus.SelectedItem = dgvAppeals.CurrentRow.Cells["Статус"].Value?.ToString();
            }
            else
            {
                txtAppealFIO.Clear();
                txtAppealText.Clear();
                dtpAppealDate.Value = DateTime.Now;
                cmbAppealStatus.SelectedIndex = -1;
            }
        }

        private void InitializeComboBox()
        {
            cmbAppealStatus.Items.Add("Новое");
            cmbAppealStatus.Items.Add("В работе");
            cmbAppealStatus.Items.Add("Завершено");
            cmbAppealStatus.DropDownStyle = ComboBoxStyle.DropDownList; // Запрещаем ввод текста
        }

        private void dgvAppeals_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppeals.CurrentRow == null) return;
            _selectedAppealId = Convert.ToInt32(dgvAppeals.CurrentRow.Cells["ID_обращения"].Value);
            BindAppealData();
        }

        private void btnAddAppeal_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Обращения_граждан (ФИО_заявителя, Текст, Дата_года, Статус, ID_учреждения) 
                               VALUES (@ФИО_заявителя, @Текст, @Дата_года, @Статус, @ID_учреждения);
                               SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ФИО_заявителя", txtAppealFIO.Text);
                    cmd.Parameters.AddWithValue("@Текст", txtAppealText.Text);
                    cmd.Parameters.AddWithValue("@Дата_года", dtpAppealDate.Value);
                    cmd.Parameters.AddWithValue("@Статус", cmbAppealStatus.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@ID_учреждения", 1); // Замените на реальный ID учреждения

                    int newAppealId = Convert.ToInt32(cmd.ExecuteScalar());

                    DataRow newRow = _appealsTable.NewRow();
                    newRow["ID_обращения"] = newAppealId;
                    newRow["ФИО_заявителя"] = txtAppealFIO.Text;
                    newRow["Текст"] = txtAppealText.Text;
                    newRow["Дата_года"] = dtpAppealDate.Value;
                    newRow["Статус"] = cmbAppealStatus.SelectedItem?.ToString();
                    newRow["ID_учреждения"] = 1; // Замените на реальный ID учреждения
                    _appealsTable.Rows.Add(newRow);
                    _appealsTable.AcceptChanges();

                    MessageBox.Show("Обращение добавлено!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления обращения: {ex.Message}");
            }
        }

        private void btnEditAppeal_Click(object sender, EventArgs e)
        {
            if (_selectedAppealId == -1)
            {
                MessageBox.Show("Выберите обращение для редактирования!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Обращения_граждан 
                               SET ФИО_заявителя = @ФИО_заявителя, 
                                   Текст = @Текст, 
                                   Дата_года = @Дата_года, 
                                   Статус = @Статус, 
                                   ID_учреждения = @ID_учреждения
                               WHERE ID_обращения = @ID_обращения";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_обращения", _selectedAppealId);
                    cmd.Parameters.AddWithValue("@ФИО_заявителя", txtAppealFIO.Text);
                    cmd.Parameters.AddWithValue("@Текст", txtAppealText.Text);
                    cmd.Parameters.AddWithValue("@Дата_года", dtpAppealDate.Value);
                    cmd.Parameters.AddWithValue("@Статус", cmbAppealStatus.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@ID_учреждения", 1); // Замените на реальный ID учреждения
                    cmd.ExecuteNonQuery();

                    DataRow row = _appealsTable.Rows.Find(_selectedAppealId);
                    row["ФИО_заявителя"] = txtAppealFIO.Text;
                    row["Текст"] = txtAppealText.Text;
                    row["Дата_года"] = dtpAppealDate.Value;
                    row["Статус"] = cmbAppealStatus.SelectedItem?.ToString();
                    row["ID_учреждения"] = 1; // Замените на реальный ID учреждения
                    _appealsTable.AcceptChanges();

                    MessageBox.Show("Обращение обновлено!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка редактирования обращения: {ex.Message}");
            }
        }

        private void btnDeleteAppeal_Click(object sender, EventArgs e)
        {
            if (_selectedAppealId == -1)
            {
                MessageBox.Show("Выберите обращение для удаления!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Обращения_граждан WHERE ID_обращения = @ID_обращения";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_обращения", _selectedAppealId);
                    cmd.ExecuteNonQuery();

                    DataRow row = _appealsTable.Rows.Find(_selectedAppealId);
                    row.Delete();
                    _appealsTable.AcceptChanges();

                    MessageBox.Show("Обращение удалено!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления обращения: {ex.Message}");
            }
        }

        private void btnRefreshAppeal_Click(object sender, EventArgs e)
        {
            LoadAppeals();
        }
    }
}
