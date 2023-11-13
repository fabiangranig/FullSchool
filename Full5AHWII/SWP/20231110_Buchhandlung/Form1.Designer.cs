namespace _20231110
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Verlag = new System.Windows.Forms.ComboBox();
            this.dataGridView_Buecher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Buecher)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Verlag
            // 
            this.comboBox_Verlag.FormattingEnabled = true;
            this.comboBox_Verlag.Location = new System.Drawing.Point(73, 53);
            this.comboBox_Verlag.Name = "comboBox_Verlag";
            this.comboBox_Verlag.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Verlag.TabIndex = 0;
            // 
            // dataGridView_Buecher
            // 
            this.dataGridView_Buecher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Buecher.Location = new System.Drawing.Point(73, 138);
            this.dataGridView_Buecher.Name = "dataGridView_Buecher";
            this.dataGridView_Buecher.RowHeadersWidth = 51;
            this.dataGridView_Buecher.RowTemplate.Height = 24;
            this.dataGridView_Buecher.Size = new System.Drawing.Size(956, 252);
            this.dataGridView_Buecher.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 450);
            this.Controls.Add(this.dataGridView_Buecher);
            this.Controls.Add(this.comboBox_Verlag);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Buecher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Verlag;
        private System.Windows.Forms.DataGridView dataGridView_Buecher;
    }
}

