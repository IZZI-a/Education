namespace Education
{
    partial class AppealsForm
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
            this.dgvAppeals = new System.Windows.Forms.DataGridView();
            this.txtAppealFIO = new System.Windows.Forms.TextBox();
            this.cmbAppealStatus = new System.Windows.Forms.ComboBox();
            this.dtpAppealDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddAppeal = new System.Windows.Forms.Button();
            this.btnDeleteAppeal = new System.Windows.Forms.Button();
            this.btnEditAppeal = new System.Windows.Forms.Button();
            this.btnRefreshAppeal = new System.Windows.Forms.Button();
            this.txtAppealText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppeals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppeals
            // 
            this.dgvAppeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppeals.Location = new System.Drawing.Point(1, 0);
            this.dgvAppeals.Name = "dgvAppeals";
            this.dgvAppeals.Size = new System.Drawing.Size(815, 301);
            this.dgvAppeals.TabIndex = 0;
            // 
            // txtAppealFIO
            // 
            this.txtAppealFIO.Location = new System.Drawing.Point(371, 322);
            this.txtAppealFIO.Name = "txtAppealFIO";
            this.txtAppealFIO.Size = new System.Drawing.Size(200, 20);
            this.txtAppealFIO.TabIndex = 1;
            // 
            // cmbAppealStatus
            // 
            this.cmbAppealStatus.FormattingEnabled = true;
            this.cmbAppealStatus.Items.AddRange(new object[] {
            "Новое",
            "В работе",
            "Завершено"});
            this.cmbAppealStatus.Location = new System.Drawing.Point(371, 374);
            this.cmbAppealStatus.Name = "cmbAppealStatus";
            this.cmbAppealStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbAppealStatus.TabIndex = 3;
            // 
            // dtpAppealDate
            // 
            this.dtpAppealDate.Location = new System.Drawing.Point(371, 348);
            this.dtpAppealDate.Name = "dtpAppealDate";
            this.dtpAppealDate.Size = new System.Drawing.Size(200, 20);
            this.dtpAppealDate.TabIndex = 4;
            // 
            // btnAddAppeal
            // 
            this.btnAddAppeal.Location = new System.Drawing.Point(12, 307);
            this.btnAddAppeal.Name = "btnAddAppeal";
            this.btnAddAppeal.Size = new System.Drawing.Size(135, 48);
            this.btnAddAppeal.TabIndex = 5;
            this.btnAddAppeal.Text = "Добавить";
            this.btnAddAppeal.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAppeal
            // 
            this.btnDeleteAppeal.Location = new System.Drawing.Point(12, 361);
            this.btnDeleteAppeal.Name = "btnDeleteAppeal";
            this.btnDeleteAppeal.Size = new System.Drawing.Size(135, 48);
            this.btnDeleteAppeal.TabIndex = 6;
            this.btnDeleteAppeal.Text = "Удалить";
            this.btnDeleteAppeal.UseVisualStyleBackColor = true;
            // 
            // btnEditAppeal
            // 
            this.btnEditAppeal.Location = new System.Drawing.Point(153, 307);
            this.btnEditAppeal.Name = "btnEditAppeal";
            this.btnEditAppeal.Size = new System.Drawing.Size(135, 48);
            this.btnEditAppeal.TabIndex = 7;
            this.btnEditAppeal.Text = "Изменить";
            this.btnEditAppeal.UseVisualStyleBackColor = true;
            // 
            // btnRefreshAppeal
            // 
            this.btnRefreshAppeal.Location = new System.Drawing.Point(153, 361);
            this.btnRefreshAppeal.Name = "btnRefreshAppeal";
            this.btnRefreshAppeal.Size = new System.Drawing.Size(135, 48);
            this.btnRefreshAppeal.TabIndex = 8;
            this.btnRefreshAppeal.Text = "Обновить";
            this.btnRefreshAppeal.UseVisualStyleBackColor = true;
            // 
            // txtAppealText
            // 
            this.txtAppealText.Location = new System.Drawing.Point(606, 307);
            this.txtAppealText.Name = "txtAppealText";
            this.txtAppealText.Size = new System.Drawing.Size(198, 102);
            this.txtAppealText.TabIndex = 9;
            this.txtAppealText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Статус";
            // 
            // AppealsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 419);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAppealText);
            this.Controls.Add(this.btnRefreshAppeal);
            this.Controls.Add(this.btnEditAppeal);
            this.Controls.Add(this.btnDeleteAppeal);
            this.Controls.Add(this.btnAddAppeal);
            this.Controls.Add(this.dtpAppealDate);
            this.Controls.Add(this.cmbAppealStatus);
            this.Controls.Add(this.txtAppealFIO);
            this.Controls.Add(this.dgvAppeals);
            this.Name = "AppealsForm";
            this.Text = "AppealsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppeals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppeals;
        private System.Windows.Forms.TextBox txtAppealFIO;
        private System.Windows.Forms.ComboBox cmbAppealStatus;
        private System.Windows.Forms.DateTimePicker dtpAppealDate;
        private System.Windows.Forms.Button btnAddAppeal;
        private System.Windows.Forms.Button btnDeleteAppeal;
        private System.Windows.Forms.Button btnEditAppeal;
        private System.Windows.Forms.Button btnRefreshAppeal;
        private System.Windows.Forms.RichTextBox txtAppealText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}