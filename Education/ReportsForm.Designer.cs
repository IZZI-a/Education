namespace Education
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.dtpReportDate = new System.Windows.Forms.DateTimePicker();
            this.txtReportFile = new System.Windows.Forms.TextBox();
            this.txtReportPeriod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddReport = new System.Windows.Forms.Button();
            this.btnEditReport = new System.Windows.Forms.Button();
            this.btnDeleteReport = new System.Windows.Forms.Button();
            this.btnRefreshReport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(-1, 0);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.Size = new System.Drawing.Size(467, 380);
            this.dgvReports.TabIndex = 0;
            this.dgvReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReports_CellContentClick);
            // 
            // dtpReportDate
            // 
            this.dtpReportDate.Location = new System.Drawing.Point(538, 64);
            this.dtpReportDate.Name = "dtpReportDate";
            this.dtpReportDate.Size = new System.Drawing.Size(122, 20);
            this.dtpReportDate.TabIndex = 1;
            // 
            // txtReportFile
            // 
            this.txtReportFile.Location = new System.Drawing.Point(527, 38);
            this.txtReportFile.Name = "txtReportFile";
            this.txtReportFile.Size = new System.Drawing.Size(144, 20);
            this.txtReportFile.TabIndex = 2;
            // 
            // txtReportPeriod
            // 
            this.txtReportPeriod.Location = new System.Drawing.Point(527, 12);
            this.txtReportPeriod.Name = "txtReportPeriod";
            this.txtReportPeriod.Size = new System.Drawing.Size(144, 20);
            this.txtReportPeriod.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Период";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Файл";
            // 
            // btnAddReport
            // 
            this.btnAddReport.Location = new System.Drawing.Point(490, 116);
            this.btnAddReport.Name = "btnAddReport";
            this.btnAddReport.Size = new System.Drawing.Size(170, 39);
            this.btnAddReport.TabIndex = 6;
            this.btnAddReport.Text = "Добавить";
            this.btnAddReport.UseVisualStyleBackColor = true;
            // 
            // btnEditReport
            // 
            this.btnEditReport.Location = new System.Drawing.Point(488, 161);
            this.btnEditReport.Name = "btnEditReport";
            this.btnEditReport.Size = new System.Drawing.Size(170, 39);
            this.btnEditReport.TabIndex = 7;
            this.btnEditReport.Text = "Изменить";
            this.btnEditReport.UseVisualStyleBackColor = true;
            // 
            // btnDeleteReport
            // 
            this.btnDeleteReport.Location = new System.Drawing.Point(490, 206);
            this.btnDeleteReport.Name = "btnDeleteReport";
            this.btnDeleteReport.Size = new System.Drawing.Size(170, 39);
            this.btnDeleteReport.TabIndex = 8;
            this.btnDeleteReport.Text = "Удалить";
            this.btnDeleteReport.UseVisualStyleBackColor = true;
            // 
            // btnRefreshReport
            // 
            this.btnRefreshReport.Location = new System.Drawing.Point(490, 251);
            this.btnRefreshReport.Name = "btnRefreshReport";
            this.btnRefreshReport.Size = new System.Drawing.Size(170, 39);
            this.btnRefreshReport.TabIndex = 9;
            this.btnRefreshReport.Text = "Обновить";
            this.btnRefreshReport.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(490, 296);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(170, 39);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 356);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnRefreshReport);
            this.Controls.Add(this.btnDeleteReport);
            this.Controls.Add(this.btnEditReport);
            this.Controls.Add(this.btnAddReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReportPeriod);
            this.Controls.Add(this.txtReportFile);
            this.Controls.Add(this.dtpReportDate);
            this.Controls.Add(this.dgvReports);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.DateTimePicker dtpReportDate;
        private System.Windows.Forms.TextBox txtReportFile;
        private System.Windows.Forms.TextBox txtReportPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddReport;
        private System.Windows.Forms.Button btnEditReport;
        private System.Windows.Forms.Button btnDeleteReport;
        private System.Windows.Forms.Button btnRefreshReport;
        private System.Windows.Forms.Button btnPrint;
    }
}