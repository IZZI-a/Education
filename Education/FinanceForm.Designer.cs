namespace Education
{
    partial class FinanceForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefreshFinance = new System.Windows.Forms.Button();
            this.btnEditFinance = new System.Windows.Forms.Button();
            this.btnDeleteFinance = new System.Windows.Forms.Button();
            this.btnAddFinance = new System.Windows.Forms.Button();
            this.dtpFinanceDate = new System.Windows.Forms.DateTimePicker();
            this.txtFinancePurpose = new System.Windows.Forms.TextBox();
            this.txtFinanceSource = new System.Windows.Forms.TextBox();
            this.txtFinanceAmount = new System.Windows.Forms.TextBox();
            this.dgvFinance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinance)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Назначение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Источник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Сумма";
            // 
            // btnRefreshFinance
            // 
            this.btnRefreshFinance.Location = new System.Drawing.Point(487, 395);
            this.btnRefreshFinance.Name = "btnRefreshFinance";
            this.btnRefreshFinance.Size = new System.Drawing.Size(145, 46);
            this.btnRefreshFinance.TabIndex = 20;
            this.btnRefreshFinance.Text = "Обновить";
            this.btnRefreshFinance.UseVisualStyleBackColor = true;
            // 
            // btnEditFinance
            // 
            this.btnEditFinance.Location = new System.Drawing.Point(487, 343);
            this.btnEditFinance.Name = "btnEditFinance";
            this.btnEditFinance.Size = new System.Drawing.Size(145, 46);
            this.btnEditFinance.TabIndex = 19;
            this.btnEditFinance.Text = "Изменить";
            this.btnEditFinance.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFinance
            // 
            this.btnDeleteFinance.Location = new System.Drawing.Point(336, 395);
            this.btnDeleteFinance.Name = "btnDeleteFinance";
            this.btnDeleteFinance.Size = new System.Drawing.Size(145, 46);
            this.btnDeleteFinance.TabIndex = 18;
            this.btnDeleteFinance.Text = "Удалить";
            this.btnDeleteFinance.UseVisualStyleBackColor = true;
            // 
            // btnAddFinance
            // 
            this.btnAddFinance.Location = new System.Drawing.Point(336, 343);
            this.btnAddFinance.Name = "btnAddFinance";
            this.btnAddFinance.Size = new System.Drawing.Size(145, 46);
            this.btnAddFinance.TabIndex = 17;
            this.btnAddFinance.Text = "Добавить";
            this.btnAddFinance.UseVisualStyleBackColor = true;
            // 
            // dtpFinanceDate
            // 
            this.dtpFinanceDate.Location = new System.Drawing.Point(103, 421);
            this.dtpFinanceDate.Name = "dtpFinanceDate";
            this.dtpFinanceDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFinanceDate.TabIndex = 16;
            // 
            // txtFinancePurpose
            // 
            this.txtFinancePurpose.Location = new System.Drawing.Point(103, 395);
            this.txtFinancePurpose.Name = "txtFinancePurpose";
            this.txtFinancePurpose.Size = new System.Drawing.Size(200, 20);
            this.txtFinancePurpose.TabIndex = 15;
            // 
            // txtFinanceSource
            // 
            this.txtFinanceSource.Location = new System.Drawing.Point(103, 369);
            this.txtFinanceSource.Name = "txtFinanceSource";
            this.txtFinanceSource.Size = new System.Drawing.Size(200, 20);
            this.txtFinanceSource.TabIndex = 14;
            // 
            // txtFinanceAmount
            // 
            this.txtFinanceAmount.Location = new System.Drawing.Point(103, 343);
            this.txtFinanceAmount.Name = "txtFinanceAmount";
            this.txtFinanceAmount.Size = new System.Drawing.Size(200, 20);
            this.txtFinanceAmount.TabIndex = 13;
            // 
            // dgvFinance
            // 
            this.dgvFinance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinance.Location = new System.Drawing.Point(12, 12);
            this.dgvFinance.Name = "dgvFinance";
            this.dgvFinance.Size = new System.Drawing.Size(635, 325);
            this.dgvFinance.TabIndex = 12;
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefreshFinance);
            this.Controls.Add(this.btnEditFinance);
            this.Controls.Add(this.btnDeleteFinance);
            this.Controls.Add(this.btnAddFinance);
            this.Controls.Add(this.dtpFinanceDate);
            this.Controls.Add(this.txtFinancePurpose);
            this.Controls.Add(this.txtFinanceSource);
            this.Controls.Add(this.txtFinanceAmount);
            this.Controls.Add(this.dgvFinance);
            this.Name = "FinanceForm";
            this.Text = "FinanceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefreshFinance;
        private System.Windows.Forms.Button btnEditFinance;
        private System.Windows.Forms.Button btnDeleteFinance;
        private System.Windows.Forms.Button btnAddFinance;
        private System.Windows.Forms.DateTimePicker dtpFinanceDate;
        private System.Windows.Forms.TextBox txtFinancePurpose;
        private System.Windows.Forms.TextBox txtFinanceSource;
        private System.Windows.Forms.TextBox txtFinanceAmount;
        private System.Windows.Forms.DataGridView dgvFinance;
    }
}