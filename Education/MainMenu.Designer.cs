namespace Education
{
    partial class MainMenu
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
            this.btnAppeals = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnDocs = new System.Windows.Forms.Button();
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnInstitutions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAppeals
            // 
            this.btnAppeals.Location = new System.Drawing.Point(33, 165);
            this.btnAppeals.Name = "btnAppeals";
            this.btnAppeals.Size = new System.Drawing.Size(232, 45);
            this.btnAppeals.TabIndex = 0;
            this.btnAppeals.Text = "Обращения граждан";
            this.btnAppeals.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(33, 63);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(232, 45);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Отчёты";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnDocs
            // 
            this.btnDocs.Location = new System.Drawing.Point(33, 114);
            this.btnDocs.Name = "btnDocs";
            this.btnDocs.Size = new System.Drawing.Size(232, 45);
            this.btnDocs.TabIndex = 2;
            this.btnDocs.Text = "Документация";
            this.btnDocs.UseVisualStyleBackColor = true;
            // 
            // btnFinance
            // 
            this.btnFinance.Location = new System.Drawing.Point(33, 216);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(232, 45);
            this.btnFinance.TabIndex = 3;
            this.btnFinance.Text = "Финансирование";
            this.btnFinance.UseVisualStyleBackColor = true;
            // 
            // btnInstitutions
            // 
            this.btnInstitutions.Location = new System.Drawing.Point(33, 12);
            this.btnInstitutions.Name = "btnInstitutions";
            this.btnInstitutions.Size = new System.Drawing.Size(232, 45);
            this.btnInstitutions.TabIndex = 4;
            this.btnInstitutions.Text = "Учереждения";
            this.btnInstitutions.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 325);
            this.Controls.Add(this.btnInstitutions);
            this.Controls.Add(this.btnFinance);
            this.Controls.Add(this.btnDocs);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnAppeals);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAppeals;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnDocs;
        private System.Windows.Forms.Button btnFinance;
        private System.Windows.Forms.Button btnInstitutions;
    }
}