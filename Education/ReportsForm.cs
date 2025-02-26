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
using System.Drawing.Printing;

namespace Education
{
    public partial class ReportsForm : Form
    {
        private string _connectionString;
        private DataTable _reportsTable;
        private int _selectedReportId = -1;

        public ReportsForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            LoadReports();
        }
        private void LoadReports()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Отчеты", conn);
                    _reportsTable = new DataTable();
                    da.Fill(_reportsTable);
                    dgvReports.DataSource = _reportsTable;

                    dgvReports.Columns["ID_отчета"].Visible = false;
                    BindReportData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки отчетов: {ex.Message}");
                }
            }
        }

        private void BindReportData()
        {
            if (dgvReports.CurrentRow != null)
            {
                dtpReportDate.Value = Convert.ToDateTime(dgvReports.CurrentRow.Cells["Дата"].Value);
                txtReportPeriod.Text = dgvReports.CurrentRow.Cells["Период"].Value?.ToString();
                txtReportFile.Text = dgvReports.CurrentRow.Cells["Файл"].Value?.ToString();
            }
            else
            {
                dtpReportDate.Value = DateTime.Now;
                txtReportPeriod.Clear();
                txtReportFile.Clear();
            }
        }

        private void dgvReports_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReports.CurrentRow == null) return;
            _selectedReportId = Convert.ToInt32(dgvReports.CurrentRow.Cells["ID_отчета"].Value);
            BindReportData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += (s, ev) =>
                {
                    if (dgvReports.CurrentRow != null)
                    {
                        int reportId = Convert.ToInt32(dgvReports.CurrentRow.Cells["ID_отчета"].Value);
                        string period = dgvReports.CurrentRow.Cells["Период"].Value.ToString();
                        ev.Graphics.DrawString($"Отчет ID: {reportId}, Период: {period}", new Font("Arial", 14), Brushes.Black, 100, 100);
                    }
                    else
                    {
                        ev.Graphics.DrawString("Отчёт", new Font("Arial", 14), Brushes.Black, 100, 100);
                    }
                };
                doc.Print();
            }
        }

        private void btnAddReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Отчеты (Дата, Период, Файл, ID_учреждения) 
                               VALUES (@Дата, @Период, @Файл, @ID_учреждения);
                               SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Дата", dtpReportDate.Value);
                    cmd.Parameters.AddWithValue("@Период", txtReportPeriod.Text);
                    cmd.Parameters.AddWithValue("@Файл", txtReportFile.Text);
                    cmd.Parameters.AddWithValue("@ID_учреждения", 1); // Замените на реальный ID учреждения

                    int newReportId = Convert.ToInt32(cmd.ExecuteScalar());

                    DataRow newRow = _reportsTable.NewRow();
                    newRow["ID_отчета"] = newReportId;
                    newRow["Дата"] = dtpReportDate.Value;
                    newRow["Период"] = txtReportPeriod.Text;
                    newRow["Файл"] = txtReportFile.Text;
                    newRow["ID_учреждения"] = 1; // Замените на реальный ID учреждения
                    _reportsTable.Rows.Add(newRow);
                    _reportsTable.AcceptChanges();

                    MessageBox.Show("Отчет добавлен!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления отчета: {ex.Message}");
            }
        }

        private void btnEditReport_Click(object sender, EventArgs e)
        {
            if (_selectedReportId == -1)
            {
                MessageBox.Show("Выберите отчет для редактирования!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Отчеты 
                               SET Дата = @Дата, 
                                   Период = @Период, 
                                   Файл = @Файл, 
                                   ID_учреждения = @ID_учреждения
                               WHERE ID_отчета = @ID_отчета";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_отчета", _selectedReportId);
                    cmd.Parameters.AddWithValue("@Дата", dtpReportDate.Value);
                    cmd.Parameters.AddWithValue("@Период", txtReportPeriod.Text);
                    cmd.Parameters.AddWithValue("@Файл", txtReportFile.Text);
                    cmd.Parameters.AddWithValue("@ID_учреждения", 1); // Замените на реальный ID учреждения
                    cmd.ExecuteNonQuery();

                    DataRow row = _reportsTable.Rows.Find(_selectedReportId);
                    row["Дата"] = dtpReportDate.Value;
                    row["Период"] = txtReportPeriod.Text;
                    row["Файл"] = txtReportFile.Text;
                    row["ID_учреждения"] = 1; // Замените на реальный ID учреждения
                    _reportsTable.AcceptChanges();

                    MessageBox.Show("Отчет обновлен!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка редактирования отчета: {ex.Message}");
            }
        }

        private void btnDeleteReport_Click(object sender, EventArgs e)
        {
            if (_selectedReportId == -1)
            {
                MessageBox.Show("Выберите отчет для удаления!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Отчеты WHERE ID_отчета = @ID_отчета";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_отчета", _selectedReportId);
                    cmd.ExecuteNonQuery();

                    DataRow row = _reportsTable.Rows.Find(_selectedReportId);
                    row.Delete();
                    _reportsTable.AcceptChanges();

                    MessageBox.Show("Отчет удален!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления отчета: {ex.Message}");
            }
        }

        private void btnRefreshReport_Click(object sender, EventArgs e)
        {
            LoadReports();
        }
 

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
