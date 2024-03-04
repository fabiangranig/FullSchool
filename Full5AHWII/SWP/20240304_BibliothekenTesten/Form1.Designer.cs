namespace _20240304_BibliothekenTesten
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
            this.button_TestDLL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_TestDLL
            // 
            this.button_TestDLL.Location = new System.Drawing.Point(496, 311);
            this.button_TestDLL.Name = "button_TestDLL";
            this.button_TestDLL.Size = new System.Drawing.Size(135, 63);
            this.button_TestDLL.TabIndex = 0;
            this.button_TestDLL.Text = "Test DLL";
            this.button_TestDLL.UseVisualStyleBackColor = true;
            this.button_TestDLL.Click += new System.EventHandler(this.button_TestDLL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_TestDLL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_TestDLL;
    }
}

