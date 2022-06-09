namespace _20220601_ZugBeispiel
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
            this.lB_Anweisungen = new System.Windows.Forms.ListBox();
            this.btn_Auslesen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lB_Anweisungen
            // 
            this.lB_Anweisungen.FormattingEnabled = true;
            this.lB_Anweisungen.Location = new System.Drawing.Point(281, 28);
            this.lB_Anweisungen.Name = "lB_Anweisungen";
            this.lB_Anweisungen.Size = new System.Drawing.Size(453, 368);
            this.lB_Anweisungen.TabIndex = 0;
            // 
            // btn_Auslesen
            // 
            this.btn_Auslesen.Location = new System.Drawing.Point(94, 47);
            this.btn_Auslesen.Name = "btn_Auslesen";
            this.btn_Auslesen.Size = new System.Drawing.Size(75, 23);
            this.btn_Auslesen.TabIndex = 1;
            this.btn_Auslesen.Text = "Auslesen";
            this.btn_Auslesen.UseVisualStyleBackColor = true;
            this.btn_Auslesen.Click += new System.EventHandler(this.btn_Auslesen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Auslesen);
            this.Controls.Add(this.lB_Anweisungen);
            this.Name = "Form1";
            this.Text = "Beispiel: Zug";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lB_Anweisungen;
        private System.Windows.Forms.Button btn_Auslesen;
    }
}

