namespace Education
{
    partial class UchrezhdeniyaForm
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
            this.dgvUchrezhdeniya = new System.Windows.Forms.DataGridView();
            this.dgvPedagogi = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUchrezhdeniya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedagogi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUchrezhdeniya
            // 
            this.dgvUchrezhdeniya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUchrezhdeniya.Location = new System.Drawing.Point(2, 1);
            this.dgvUchrezhdeniya.Name = "dgvUchrezhdeniya";
            this.dgvUchrezhdeniya.Size = new System.Drawing.Size(411, 272);
            this.dgvUchrezhdeniya.TabIndex = 0;
            // 
            // dgvPedagogi
            // 
            this.dgvPedagogi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedagogi.Location = new System.Drawing.Point(419, 1);
            this.dgvPedagogi.Name = "dgvPedagogi";
            this.dgvPedagogi.Size = new System.Drawing.Size(380, 272);
            this.dgvPedagogi.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(543, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // UchrezhdeniyaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPedagogi);
            this.Controls.Add(this.dgvUchrezhdeniya);
            this.Name = "UchrezhdeniyaForm";
            this.Text = "Учреждения";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUchrezhdeniya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedagogi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUchrezhdeniya;
        private System.Windows.Forms.DataGridView dgvPedagogi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}