namespace _20220316_Uebung
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
            this.button_Berechne = new System.Windows.Forms.Button();
            this.textBox_Zahl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Teiler = new System.Windows.Forms.TextBox();
            this.button_beenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Berechne
            // 
            this.button_Berechne.Location = new System.Drawing.Point(374, 67);
            this.button_Berechne.Name = "button_Berechne";
            this.button_Berechne.Size = new System.Drawing.Size(75, 23);
            this.button_Berechne.TabIndex = 0;
            this.button_Berechne.Text = "Berechne";
            this.button_Berechne.UseVisualStyleBackColor = true;
            this.button_Berechne.Click += new System.EventHandler(this.button_Berechne_Click);
            // 
            // textBox_Zahl
            // 
            this.textBox_Zahl.Location = new System.Drawing.Point(35, 69);
            this.textBox_Zahl.Name = "textBox_Zahl";
            this.textBox_Zahl.Size = new System.Drawing.Size(100, 20);
            this.textBox_Zahl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zahl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teiler";
            // 
            // textBox_Teiler
            // 
            this.textBox_Teiler.Location = new System.Drawing.Point(221, 69);
            this.textBox_Teiler.Multiline = true;
            this.textBox_Teiler.Name = "textBox_Teiler";
            this.textBox_Teiler.Size = new System.Drawing.Size(100, 316);
            this.textBox_Teiler.TabIndex = 4;
            // 
            // button_beenden
            // 
            this.button_beenden.Location = new System.Drawing.Point(713, 415);
            this.button_beenden.Name = "button_beenden";
            this.button_beenden.Size = new System.Drawing.Size(75, 23);
            this.button_beenden.TabIndex = 5;
            this.button_beenden.Text = "Beenden!";
            this.button_beenden.UseVisualStyleBackColor = true;
            this.button_beenden.Click += new System.EventHandler(this.button_beenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_beenden);
            this.Controls.Add(this.textBox_Teiler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Zahl);
            this.Controls.Add(this.button_Berechne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Berechne;
        private System.Windows.Forms.TextBox textBox_Zahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Teiler;
        private System.Windows.Forms.Button button_beenden;
    }
}

