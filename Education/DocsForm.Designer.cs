namespace Education
{
    partial class DocsForm
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
            this.dgvDocs = new System.Windows.Forms.DataGridView();
            this.txtDocType = new System.Windows.Forms.TextBox();
            this.txtDocNumber = new System.Windows.Forms.TextBox();
            this.txtDocDescription = new System.Windows.Forms.TextBox();
            this.txtDocFile = new System.Windows.Forms.TextBox();
            this.dtpDocDate = new System.Windows.Forms.DateTimePicker();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddDoc = new System.Windows.Forms.Button();
            this.btnEditDoc = new System.Windows.Forms.Button();
            this.btnDeleteDoc = new System.Windows.Forms.Button();
            this.btnRefreshDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocs
            // 
            this.dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocs.Location = new System.Drawing.Point(2, 1);
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.Size = new System.Drawing.Size(457, 357);
            this.dgvDocs.TabIndex = 0;
            // 
            // txtDocType
            // 
            this.txtDocType.Location = new System.Drawing.Point(579, 12);
            this.txtDocType.Name = "txtDocType";
            this.txtDocType.Size = new System.Drawing.Size(209, 20);
            this.txtDocType.TabIndex = 1;
            // 
            // txtDocNumber
            // 
            this.txtDocNumber.Location = new System.Drawing.Point(579, 38);
            this.txtDocNumber.Name = "txtDocNumber";
            this.txtDocNumber.Size = new System.Drawing.Size(209, 20);
            this.txtDocNumber.TabIndex = 2;
            // 
            // txtDocDescription
            // 
            this.txtDocDescription.Location = new System.Drawing.Point(579, 90);
            this.txtDocDescription.Name = "txtDocDescription";
            this.txtDocDescription.Size = new System.Drawing.Size(209, 20);
            this.txtDocDescription.TabIndex = 3;
            // 
            // txtDocFile
            // 
            this.txtDocFile.Location = new System.Drawing.Point(579, 116);
            this.txtDocFile.Name = "txtDocFile";
            this.txtDocFile.Size = new System.Drawing.Size(209, 20);
            this.txtDocFile.TabIndex = 4;
            // 
            // dtpDocDate
            // 
            this.dtpDocDate.Location = new System.Drawing.Point(579, 64);
            this.dtpDocDate.Name = "dtpDocDate";
            this.dtpDocDate.Size = new System.Drawing.Size(209, 20);
            this.dtpDocDate.TabIndex = 5;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(611, 177);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(177, 170);
            this.webBrowser1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Тип документа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Описание ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Номер документа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Файл";
            // 
            // btnAddDoc
            // 
            this.btnAddDoc.Location = new System.Drawing.Point(465, 177);
            this.btnAddDoc.Name = "btnAddDoc";
            this.btnAddDoc.Size = new System.Drawing.Size(140, 38);
            this.btnAddDoc.TabIndex = 12;
            this.btnAddDoc.Text = "Добавить";
            this.btnAddDoc.UseVisualStyleBackColor = true;
            // 
            // btnEditDoc
            // 
            this.btnEditDoc.Location = new System.Drawing.Point(465, 221);
            this.btnEditDoc.Name = "btnEditDoc";
            this.btnEditDoc.Size = new System.Drawing.Size(140, 38);
            this.btnEditDoc.TabIndex = 13;
            this.btnEditDoc.Text = "Изменить";
            this.btnEditDoc.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDoc
            // 
            this.btnDeleteDoc.Location = new System.Drawing.Point(465, 265);
            this.btnDeleteDoc.Name = "btnDeleteDoc";
            this.btnDeleteDoc.Size = new System.Drawing.Size(140, 38);
            this.btnDeleteDoc.TabIndex = 14;
            this.btnDeleteDoc.Text = "Удалить";
            this.btnDeleteDoc.UseVisualStyleBackColor = true;
            // 
            // btnRefreshDoc
            // 
            this.btnRefreshDoc.Location = new System.Drawing.Point(465, 309);
            this.btnRefreshDoc.Name = "btnRefreshDoc";
            this.btnRefreshDoc.Size = new System.Drawing.Size(140, 38);
            this.btnRefreshDoc.TabIndex = 15;
            this.btnRefreshDoc.Text = "Обновить";
            this.btnRefreshDoc.UseVisualStyleBackColor = true;
            // 
            // DocsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.btnRefreshDoc);
            this.Controls.Add(this.btnDeleteDoc);
            this.Controls.Add(this.btnEditDoc);
            this.Controls.Add(this.btnAddDoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.dtpDocDate);
            this.Controls.Add(this.txtDocFile);
            this.Controls.Add(this.txtDocDescription);
            this.Controls.Add(this.txtDocNumber);
            this.Controls.Add(this.txtDocType);
            this.Controls.Add(this.dgvDocs);
            this.Name = "DocsForm";
            this.Text = "DocsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocs;
        private System.Windows.Forms.TextBox txtDocType;
        private System.Windows.Forms.TextBox txtDocNumber;
        private System.Windows.Forms.TextBox txtDocDescription;
        private System.Windows.Forms.TextBox txtDocFile;
        private System.Windows.Forms.DateTimePicker dtpDocDate;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddDoc;
        private System.Windows.Forms.Button btnEditDoc;
        private System.Windows.Forms.Button btnDeleteDoc;
        private System.Windows.Forms.Button btnRefreshDoc;
    }
}