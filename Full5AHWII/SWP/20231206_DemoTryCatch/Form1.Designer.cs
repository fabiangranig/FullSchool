namespace _20231206_DemoTryCatch
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
            this.button_Berechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Berechnen
            // 
            this.button_Berechnen.Location = new System.Drawing.Point(12, 12);
            this.button_Berechnen.Name = "button_Berechnen";
            this.button_Berechnen.Size = new System.Drawing.Size(75, 23);
            this.button_Berechnen.TabIndex = 0;
            this.button_Berechnen.Text = "Berechnen";
            this.button_Berechnen.UseVisualStyleBackColor = true;
            this.button_Berechnen.Click += new System.EventHandler(this.button_Berechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Berechnen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Berechnen;
    }
}

