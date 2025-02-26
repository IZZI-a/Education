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
    public partial class FinanceForm : Form
    {
        private string _connectionString;
        private DataTable _financeTable;
        private int _selectedFinanceId = -1;

        public FinanceForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            LoadFinance();
        }
        private void LoadFinance()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Финансирование", conn);
                    _financeTable = new DataTable();
                    da.Fill(_financeTable);
                    dgvFinance.DataSource = _financeTable;

                    dgvFinance.Columns["ID_финансирования"].Visible = false;
                    BindFinanceData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки финансирования: {ex.Message}");
                }
            }
        }

        private void BindFinanceData()
        {
            if (dgvFinance.CurrentRow != null)
            {
                txtFinanceAmount.Text = dgvFinance.CurrentRow.Cells["Сумма"].Value?.ToString();
                txtFinanceSource.Text = dgvFinance.CurrentRow.Cells["Источник"].Value?.ToString();
                txtFinancePurpose.Text = dgvFinance.CurrentRow.Cells["Назначение"].Value?.ToString();
                dtpFinanceDate.Value = Convert.ToDateTime(dgvFinance.CurrentRow.Cells["Дата"].Value);
            }
            else
            {
                txtFinanceAmount.Clear();
                txtFinanceSource.Clear();
                txtFinancePurpose.Clear();
                dtpFinanceDate.Value = DateTime.Now;
            }
        }

        private void dgvFinance_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFinance.CurrentRow == null) return;
            _selectedFinanceId = Convert.ToInt32(dgvFinance.CurrentRow.Cells["ID_финансирования"].Value);
            BindFinanceData();
        }

        private void btnAddFinance_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Финансирование (Сумма, Источник, Назначение, Дата, ID_учреждения) 
                               VALUES (@Сумма, @Источник, @Назначение, @Дата, @ID_учреждения);
                               SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Сумма", txtFinanceAmount.Text);
                    cmd.Parameters.AddWithValue("@Источник", txtFinanceSource.Text);
                    cmd.Parameters.AddWithValue("@Назначение", txtFinancePurpose.Text);
                    cmd.Parameters.AddWithValue("@Дата", dtpFinanceDate.Value);
                    cmd.Parameters.AddWithValue("@ID_учреждения", 1); // Замените на реальный ID учреждения

                    int newFinanceId = Convert.ToInt32(cmd.ExecuteScalar());

                    DataRow newRow = _financeTable.NewRow();
                    newRow["ID_финансирования"] = newFinanceId;
                    newRow["Сумма"] = txtFinanceAmount.Text;
                    newRow["Источник"] = txtFinanceSource.Text;
                    newRow["Назначение"] = txtFinancePurpose.Text;
                    newRow["Дата"] = dtpFinanceDate.Value;
                    newRow["ID_учреждения"] = 1; // Замените на реальный ID учреждения
                    _financeTable.Rows.Add(newRow);
                    _financeTable.AcceptChanges();

                    MessageBox.Show("Финансирование добавлено!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления финансирования: {ex.Message}");
            }
        }

        private void btnEditFinance_Click(object sender, EventArgs e)
        {
            if (_selectedFinanceId == -1)
            {
                MessageBox.Show("Выберите запись финансирования для редактирования!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Финансирование 
                               SET Сумма = @Сумма, 
                                   Источник = @Источник, 
                                   Назначение = @Назначение, 
                                   Дата = @Дата, 
                                   ID_учреждения = @ID_учреждения
                               WHERE ID_финансирования = @ID_финансирования";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_финансирования", _selectedFinanceId);
                    cmd.Parameters.AddWithValue("@Сумма", txtFinanceAmount.Text);
                    cmd.Parameters.AddWithValue("@Источник", txtFinanceSource.Text);
                    cmd.Parameters.AddWithValue("@Назначение", txtFinancePurpose.Text);
                    cmd.Parameters.AddWithValue("@Дата", dtpFinanceDate.Value);
                    cmd.Parameters.AddWithValue("@ID_учреждения", 1); // Замените на реальный ID учреждения
                    cmd.ExecuteNonQuery();

                    DataRow row = _financeTable.Rows.Find(_selectedFinanceId);
                    row["Сумма"] = txtFinanceAmount.Text;
                    row["Источник"] = txtFinanceSource.Text;
                    row["Назначение"] = txtFinancePurpose.Text;
                    row["Дата"] = dtpFinanceDate.Value;
                    row["ID_учреждения"] = 1; // Замените на реальный ID учреждения
                    _financeTable.AcceptChanges();

                    MessageBox.Show("Финансирование обновлено!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка редактирования финансирования: {ex.Message}");
            }
        }

        private void btnDeleteFinance_Click(object sender, EventArgs e)
        {
            if (_selectedFinanceId == -1)
            {
                MessageBox.Show("Выберите запись финансирования для удаления!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Финансирование WHERE ID_финансирования = @ID_финансирования";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_финансирования", _selectedFinanceId);
                    cmd.ExecuteNonQuery();

                    DataRow row = _financeTable.Rows.Find(_selectedFinanceId);
                    row.Delete();
                    _financeTable.AcceptChanges();

                    MessageBox.Show("Финансирование удалено!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления финансирования: {ex.Message}");
            }
        }

        private void btnRefreshFinance_Click(object sender, EventArgs e)
        {
            LoadFinance();
        }
    }
}
