namespace _20230110_GID
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
            this.button_Zeichnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Zeichnen
            // 
            this.button_Zeichnen.Location = new System.Drawing.Point(713, 415);
            this.button_Zeichnen.Name = "button_Zeichnen";
            this.button_Zeichnen.Size = new System.Drawing.Size(75, 23);
            this.button_Zeichnen.TabIndex = 0;
            this.button_Zeichnen.Text = "Zeichnen";
            this.button_Zeichnen.UseVisualStyleBackColor = true;
            this.button_Zeichnen.Click += new System.EventHandler(this.button_Zeichnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Zeichnen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Zeichnen;
    }
}

