namespace _20240408_DemoAsync
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
            this.textBox_File = new System.Windows.Forms.TextBox();
            this.textBox_FileExtension = new System.Windows.Forms.TextBox();
            this.listBox_listFiles = new System.Windows.Forms.ListBox();
            this.button_Suche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_File
            // 
            this.textBox_File.Location = new System.Drawing.Point(12, 12);
            this.textBox_File.Name = "textBox_File";
            this.textBox_File.Size = new System.Drawing.Size(264, 22);
            this.textBox_File.TabIndex = 0;
            // 
            // textBox_FileExtension
            // 
            this.textBox_FileExtension.Location = new System.Drawing.Point(282, 12);
            this.textBox_FileExtension.Name = "textBox_FileExtension";
            this.textBox_FileExtension.Size = new System.Drawing.Size(236, 22);
            this.textBox_FileExtension.TabIndex = 1;
            // 
            // listBox_listFiles
            // 
            this.listBox_listFiles.FormattingEnabled = true;
            this.listBox_listFiles.ItemHeight = 16;
            this.listBox_listFiles.Location = new System.Drawing.Point(12, 40);
            this.listBox_listFiles.Name = "listBox_listFiles";
            this.listBox_listFiles.Size = new System.Drawing.Size(1212, 308);
            this.listBox_listFiles.TabIndex = 2;
            // 
            // button_Suche
            // 
            this.button_Suche.Location = new System.Drawing.Point(12, 354);
            this.button_Suche.Name = "button_Suche";
            this.button_Suche.Size = new System.Drawing.Size(93, 34);
            this.button_Suche.TabIndex = 3;
            this.button_Suche.Text = "Suche";
            this.button_Suche.UseVisualStyleBackColor = true;
            this.button_Suche.Click += new System.EventHandler(this.button_Suche_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 450);
            this.Controls.Add(this.button_Suche);
            this.Controls.Add(this.listBox_listFiles);
            this.Controls.Add(this.textBox_FileExtension);
            this.Controls.Add(this.textBox_File);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_File;
        private System.Windows.Forms.TextBox textBox_FileExtension;
        private System.Windows.Forms.ListBox listBox_listFiles;
        private System.Windows.Forms.Button button_Suche;
    }
}

