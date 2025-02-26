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
            this.btnRefreshInstitution = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnEditTeacher = new System.Windows.Forms.Button();
            this.btnRefreshTeacher = new System.Windows.Forms.Button();
            this.txtInstitutionName = new System.Windows.Forms.TextBox();
            this.txtInstitutionType = new System.Windows.Forms.TextBox();
            this.txtInstitutionAddress = new System.Windows.Forms.TextBox();
            this.txtDirectorName = new System.Windows.Forms.TextBox();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtTeacherExperience = new System.Windows.Forms.TextBox();
            this.txtTeacherQualification = new System.Windows.Forms.TextBox();
            this.txtTeacherPosition = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstitutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInstitutions
            // 
            this.dgvInstitutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstitutions.Location = new System.Drawing.Point(2, 1);
            this.dgvInstitutions.Name = "dgvInstitutions";
            this.dgvInstitutions.Size = new System.Drawing.Size(570, 272);
            this.dgvInstitutions.TabIndex = 0;
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(578, 1);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.Size = new System.Drawing.Size(463, 272);
            this.dgvTeachers.TabIndex = 1;
            // 
            // btnAddInstitution
            // 
            this.btnAddInstitution.Location = new System.Drawing.Point(12, 289);
            this.btnAddInstitution.Name = "btnAddInstitution";
            this.btnAddInstitution.Size = new System.Drawing.Size(120, 50);
            this.btnAddInstitution.TabIndex = 2;
            this.btnAddInstitution.Text = "Добавить учреждение";
            this.btnAddInstitution.UseVisualStyleBackColor = true;
            this.btnAddInstitution.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEditInstitution
            // 
            this.btnEditInstitution.Location = new System.Drawing.Point(12, 401);
            this.btnEditInstitution.Name = "btnEditInstitution";
            this.btnEditInstitution.Size = new System.Drawing.Size(120, 50);
            this.btnEditInstitution.TabIndex = 3;
            this.btnEditInstitution.Text = "Изменить учреждение";
            this.btnEditInstitution.UseVisualStyleBackColor = true;
            // 
            // btnDeleteInstitution
            // 
            this.btnDeleteInstitution.Location = new System.Drawing.Point(12, 345);
            this.btnDeleteInstitution.Name = "btnDeleteInstitution";
            this.btnDeleteInstitution.Size = new System.Drawing.Size(120, 50);
            this.btnDeleteInstitution.TabIndex = 4;
            this.btnDeleteInstitution.Text = "Удалить учреждение";
            this.btnDeleteInstitution.UseVisualStyleBackColor = true;
            this.btnDeleteInstitution.Click += new System.EventHandler(this.btnDeleteInstitution_Click);
            // 
            // btnRefreshInstitution
            // 
            this.btnRefreshInstitution.Location = new System.Drawing.Point(12, 460);
            this.btnRefreshInstitution.Name = "btnRefreshInstitution";
            this.btnRefreshInstitution.Size = new System.Drawing.Size(120, 50);
            this.btnRefreshInstitution.TabIndex = 5;
            this.btnRefreshInstitution.Text = "Обновить учреждения";
            this.btnRefreshInstitution.UseVisualStyleBackColor = true;
            this.btnRefreshInstitution.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(632, 283);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(120, 50);
            this.btnAddTeacher.TabIndex = 6;
            this.btnAddTeacher.Text = "Добавить педагога";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Location = new System.Drawing.Point(632, 339);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(120, 50);
            this.btnDeleteTeacher.TabIndex = 7;
            this.btnDeleteTeacher.Text = "Удалить педагога";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.Location = new System.Drawing.Point(632, 395);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.Size = new System.Drawing.Size(120, 50);
            this.btnEditTeacher.TabIndex = 8;
            this.btnEditTeacher.Text = "Изменить педагога";
            this.btnEditTeacher.UseVisualStyleBackColor = true;
            this.btnEditTeacher.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRefreshTeacher
            // 
            this.btnRefreshTeacher.Location = new System.Drawing.Point(632, 454);
            this.btnRefreshTeacher.Name = "btnRefreshTeacher";
            this.btnRefreshTeacher.Size = new System.Drawing.Size(120, 50);
            this.btnRefreshTeacher.TabIndex = 9;
            this.btnRefreshTeacher.Text = "Обновить педагогов";
            this.btnRefreshTeacher.UseVisualStyleBackColor = true;
            // 
            // txtInstitutionName
            // 
            this.txtInstitutionName.Location = new System.Drawing.Point(223, 283);
            this.txtInstitutionName.Name = "txtInstitutionName";
            this.txtInstitutionName.Size = new System.Drawing.Size(392, 20);
            this.txtInstitutionName.TabIndex = 10;
            // 
            // txtInstitutionType
            // 
            this.txtInstitutionType.Location = new System.Drawing.Point(223, 309);
            this.txtInstitutionType.Name = "txtInstitutionType";
            this.txtInstitutionType.Size = new System.Drawing.Size(392, 20);
            this.txtInstitutionType.TabIndex = 11;
            // 
            // txtInstitutionAddress
            // 
            this.txtInstitutionAddress.Location = new System.Drawing.Point(223, 335);
            this.txtInstitutionAddress.Name = "txtInstitutionAddress";
            this.txtInstitutionAddress.Size = new System.Drawing.Size(392, 20);
            this.txtInstitutionAddress.TabIndex = 12;
            // 
            // txtDirectorName
            // 
            this.txtDirectorName.Location = new System.Drawing.Point(223, 361);
            this.txtDirectorName.Name = "txtDirectorName";
            this.txtDirectorName.Size = new System.Drawing.Size(392, 20);
            this.txtDirectorName.TabIndex = 13;
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(223, 387);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(392, 20);
            this.txtLicense.TabIndex = 14;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(223, 413);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(392, 20);
            this.txtContact.TabIndex = 15;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(223, 439);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(392, 20);
            this.txtRegion.TabIndex = 16;
            // 
            // txtTeacherExperience
            // 
            this.txtTeacherExperience.Location = new System.Drawing.Point(874, 374);
            this.txtTeacherExperience.Name = "txtTeacherExperience";
            this.txtTeacherExperience.Size = new System.Drawing.Size(167, 20);
            this.txtTeacherExperience.TabIndex = 20;
            // 
            // txtTeacherQualification
            // 
            this.txtTeacherQualification.Location = new System.Drawing.Point(874, 348);
            this.txtTeacherQualification.Name = "txtTeacherQualification";
            this.txtTeacherQualification.Size = new System.Drawing.Size(167, 20);
            this.txtTeacherQualification.TabIndex = 19;
            // 
            // txtTeacherPosition
            // 
            this.txtTeacherPosition.Location = new System.Drawing.Point(874, 322);
            this.txtTeacherPosition.Name = "txtTeacherPosition";
            this.txtTeacherPosition.Size = new System.Drawing.Size(167, 20);
            this.txtTeacherPosition.TabIndex = 18;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(874, 296);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(167, 20);
            this.txtTeacherName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Название";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Тип заведения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Директор";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Лицензия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Контакты";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Регион";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(834, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "ФИО";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(803, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Должность";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(786, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Квалификация";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(834, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Стаж";
            // 
            // InstitutionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 527);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeacherExperience);
            this.Controls.Add(this.txtTeacherQualification);
            this.Controls.Add(this.txtTeacherPosition);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.txtDirectorName);
            this.Controls.Add(this.txtInstitutionAddress);
            this.Controls.Add(this.txtInstitutionType);
            this.Controls.Add(this.txtInstitutionName);
            this.Controls.Add(this.btnRefreshTeacher);
            this.Controls.Add(this.btnEditTeacher);
            this.Controls.Add(this.btnDeleteTeacher);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.btnRefreshInstitution);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInstitutions;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Button btnAddInstitution;
        private System.Windows.Forms.Button btnEditInstitution;
        private System.Windows.Forms.Button btnDeleteInstitution;
        private System.Windows.Forms.Button btnRefreshInstitution;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnEditTeacher;
        private System.Windows.Forms.Button btnRefreshTeacher;
        private System.Windows.Forms.TextBox txtInstitutionName;
        private System.Windows.Forms.TextBox txtInstitutionType;
        private System.Windows.Forms.TextBox txtInstitutionAddress;
        private System.Windows.Forms.TextBox txtDirectorName;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtTeacherExperience;
        private System.Windows.Forms.TextBox txtTeacherQualification;
        private System.Windows.Forms.TextBox txtTeacherPosition;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}