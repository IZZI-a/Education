namespace Education
{
    partial class InstitutionsForm
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
            this.dgvInstitutions = new System.Windows.Forms.DataGridView();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.btnAddInstitution = new System.Windows.Forms.Button();
            this.btnEditInstitution = new System.Windows.Forms.Button();
            this.btnDeleteInstitution = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnEditTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstitutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInstitutions
            // 
            this.dgvInstitutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstitutions.Location = new System.Drawing.Point(2, 1);
            this.dgvInstitutions.Name = "dgvInstitutions";
            this.dgvInstitutions.Size = new System.Drawing.Size(389, 272);
            this.dgvInstitutions.TabIndex = 0;
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(407, 1);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.Size = new System.Drawing.Size(392, 272);
            this.dgvTeachers.TabIndex = 1;
            // 
            // btnAddInstitution
            // 
            this.btnAddInstitution.Location = new System.Drawing.Point(12, 282);
            this.btnAddInstitution.Name = "btnAddInstitution";
            this.btnAddInstitution.Size = new System.Drawing.Size(169, 64);
            this.btnAddInstitution.TabIndex = 2;
            this.btnAddInstitution.Text = "Добавить учреждение";
            this.btnAddInstitution.UseVisualStyleBackColor = true;
            this.btnAddInstitution.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEditInstitution
            // 
            this.btnEditInstitution.Location = new System.Drawing.Point(187, 282);
            this.btnEditInstitution.Name = "btnEditInstitution";
            this.btnEditInstitution.Size = new System.Drawing.Size(169, 64);
            this.btnEditInstitution.TabIndex = 3;
            this.btnEditInstitution.Text = "Изменить учреждение";
            this.btnEditInstitution.UseVisualStyleBackColor = true;
            // 
            // btnDeleteInstitution
            // 
            this.btnDeleteInstitution.Location = new System.Drawing.Point(92, 352);
            this.btnDeleteInstitution.Name = "btnDeleteInstitution";
            this.btnDeleteInstitution.Size = new System.Drawing.Size(169, 64);
            this.btnDeleteInstitution.TabIndex = 4;
            this.btnDeleteInstitution.Text = "Удалить учреждение";
            this.btnDeleteInstitution.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 401);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(43, 37);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(444, 282);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(169, 64);
            this.btnAddTeacher.TabIndex = 6;
            this.btnAddTeacher.Text = "Добавить педагога";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Location = new System.Drawing.Point(531, 352);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(169, 64);
            this.btnDeleteTeacher.TabIndex = 7;
            this.btnDeleteTeacher.Text = "Удалить педагога";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.Location = new System.Drawing.Point(619, 282);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.Size = new System.Drawing.Size(169, 64);
            this.btnEditTeacher.TabIndex = 8;
            this.btnEditTeacher.Text = "Изменить педагога";
            this.btnEditTeacher.UseVisualStyleBackColor = true;
            this.btnEditTeacher.Click += new System.EventHandler(this.button3_Click);
            // 
            // InstitutionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditTeacher);
            this.Controls.Add(this.btnDeleteTeacher);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteInstitution);
            this.Controls.Add(this.btnEditInstitution);
            this.Controls.Add(this.btnAddInstitution);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.dgvInstitutions);
            this.Name = "InstitutionsForm";
            this.Text = "Учреждения";
            this.Load += new System.EventHandler(this.InstitutionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstitutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInstitutions;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Button btnAddInstitution;
        private System.Windows.Forms.Button btnEditInstitution;
        private System.Windows.Forms.Button btnDeleteInstitution;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnEditTeacher;
    }
}