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
    public partial class DocsForm : Form
    {
        private string _connectionString;
        private DataTable _docsTable;
        private int _selectedDocId = -1;

        public DocsForm(string connectionString)
        {
            InitializeComponent();
            connectionString = connectionString;
            LoadDocs();
        }
        private void LoadDocs()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Нормативные_документы", conn);
                    _docsTable = new DataTable();
                    da.Fill(_docsTable);
                    dgvDocs.DataSource = _docsTable;
                    dgvDocs.Columns["ID_документа"].Visible = false;
                    BindDocData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки документов: {ex.Message}");
                }
            }
        }

        private void BindDocData()
        {
            if (dgvDocs.CurrentRow != null)
            {
                txtDocType.Text = dgvDocs.CurrentRow.Cells["Тип"].Value?.ToString();
                txtDocNumber.Text = dgvDocs.CurrentRow.Cells["Номер"].Value?.ToString();
                dtpDocDate.Value = Convert.ToDateTime(dgvDocs.CurrentRow.Cells["Дата"].Value);
                txtDocDescription.Text = dgvDocs.CurrentRow.Cells["Описание"].Value?.ToString();
                txtDocFile.Text = dgvDocs.CurrentRow.Cells["Файл"].Value?.ToString();
            }
            else
            {
                txtDocType.Clear();
                txtDocNumber.Clear();
                dtpDocDate.Value = DateTime.Now;
                txtDocDescription.Clear();
                txtDocFile.Clear();
            }
        }

        private void dgvDocs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDocs.CurrentRow != null && dgvDocs.CurrentRow.Cells["Файл"].Value != DBNull.Value)
            {
                _selectedDocId = Convert.ToInt32(dgvDocs.CurrentRow.Cells["ID_документа"].Value);
                BindDocData();

                string filePath = dgvDocs.CurrentRow.Cells["Файл"].Value.ToString();
                try
                {
                    webBrowser1.Navigate(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка открытия файла: {ex.Message}");
                }
            }
        }

        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Нормативные_документы (Тип, Номер, Дата, Описание, Файл) 
                               VALUES (@Тип, @Номер, @Дата, @Описание, @Файл);
                               SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Тип", txtDocType.Text);
                    cmd.Parameters.AddWithValue("@Номер", txtDocNumber.Text);
                    cmd.Parameters.AddWithValue("@Дата", dtpDocDate.Value);
                    cmd.Parameters.AddWithValue("@Описание", txtDocDescription.Text);
                    cmd.Parameters.AddWithValue("@Файл", txtDocFile.Text);

                    int newDocId = Convert.ToInt32(cmd.ExecuteScalar());

                    DataRow newRow = _docsTable.NewRow();
                    newRow["ID_документа"] = newDocId;
                    newRow["Тип"] = txtDocType.Text;
                    newRow["Номер"] = txtDocNumber.Text;
                    newRow["Дата"] = dtpDocDate.Value;
                    newRow["Описание"] = txtDocDescription.Text;
                    newRow["Файл"] = txtDocFile.Text;
                    _docsTable.Rows.Add(newRow);
                    _docsTable.AcceptChanges();

                    MessageBox.Show("Документ добавлен!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления документа: {ex.Message}");
            }
        }

        private void btnEditDoc_Click(object sender, EventArgs e)
        {
            if (_selectedDocId == -1)
            {
                MessageBox.Show("Выберите документ для редактирования!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Нормативные_документы 
                               SET Тип = @Тип, 
                                   Номер = @Номер, 
                                   Дата = @Дата, 
                                   Описание = @Описание, 
                                   Файл = @Файл
                               WHERE ID_документа = @ID_документа";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_документа", _selectedDocId);
                    cmd.Parameters.AddWithValue("@Тип", txtDocType.Text);
                    cmd.Parameters.AddWithValue("@Номер", txtDocNumber.Text);
                    cmd.Parameters.AddWithValue("@Дата", dtpDocDate.Value);
                    cmd.Parameters.AddWithValue("@Описание", txtDocDescription.Text);
                    cmd.Parameters.AddWithValue("@Файл", txtDocFile.Text);

                    cmd.ExecuteNonQuery();

                    DataRow row = _docsTable.Rows.Find(_selectedDocId);
                    row["Тип"] = txtDocType.Text;
                    row["Номер"] = txtDocNumber.Text;
                    row["Дата"] = dtpDocDate.Value;
                    row["Описание"] = txtDocDescription.Text;
                    row["Файл"] = txtDocFile.Text;
                    _docsTable.AcceptChanges();

                    MessageBox.Show("Документ обновлен!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка редактирования документа: {ex.Message}");
            }
        }

        private void btnDeleteDoc_Click(object sender, EventArgs e)
        {
            if (_selectedDocId == -1)
            {
                MessageBox.Show("Выберите документ для удаления!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Нормативные_документы WHERE ID_документа = @ID_документа";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_документа", _selectedDocId);
                    cmd.ExecuteNonQuery();

                    DataRow row = _docsTable.Rows.Find(_selectedDocId);
                    row.Delete();
                    _docsTable.AcceptChanges();

                    MessageBox.Show("Документ удален!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления документа: {ex.Message}");
            }
        }

        private void btnRefreshDoc_Click(object sender, EventArgs e)
        {
            LoadDocs();
        }
    }
}