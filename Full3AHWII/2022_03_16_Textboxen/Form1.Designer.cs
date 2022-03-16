namespace _20220316_Textboxen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Zahl1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Zahl2 = new System.Windows.Forms.TextBox();
            this.btn_addieren = new System.Windows.Forms.Button();
            this.lbl_Ergebnis = new System.Windows.Forms.Label();
            this.btn_Beenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zahl1";
            // 
            // txt_Zahl1
            // 
            this.txt_Zahl1.Location = new System.Drawing.Point(56, 79);
            this.txt_Zahl1.Name = "txt_Zahl1";
            this.txt_Zahl1.Size = new System.Drawing.Size(100, 20);
            this.txt_Zahl1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zahl2";
            // 
            // txt_Zahl2
            // 
            this.txt_Zahl2.Location = new System.Drawing.Point(278, 79);
            this.txt_Zahl2.Name = "txt_Zahl2";
            this.txt_Zahl2.Size = new System.Drawing.Size(100, 20);
            this.txt_Zahl2.TabIndex = 3;
            // 
            // btn_addieren
            // 
            this.btn_addieren.Location = new System.Drawing.Point(56, 141);
            this.btn_addieren.Name = "btn_addieren";
            this.btn_addieren.Size = new System.Drawing.Size(75, 23);
            this.btn_addieren.TabIndex = 4;
            this.btn_addieren.Text = "Addieren";
            this.btn_addieren.UseVisualStyleBackColor = true;
            this.btn_addieren.Click += new System.EventHandler(this.btn_addieren_Click);
            // 
            // lbl_Ergebnis
            // 
            this.lbl_Ergebnis.AutoSize = true;
            this.lbl_Ergebnis.Location = new System.Drawing.Point(465, 85);
            this.lbl_Ergebnis.Name = "lbl_Ergebnis";
            this.lbl_Ergebnis.Size = new System.Drawing.Size(54, 13);
            this.lbl_Ergebnis.TabIndex = 5;
            this.lbl_Ergebnis.Text = "Ergebnis: ";
            // 
            // btn_Beenden
            // 
            this.btn_Beenden.Location = new System.Drawing.Point(713, 415);
            this.btn_Beenden.Name = "btn_Beenden";
            this.btn_Beenden.Size = new System.Drawing.Size(75, 23);
            this.btn_Beenden.TabIndex = 6;
            this.btn_Beenden.Text = "Beenden!";
            this.btn_Beenden.UseVisualStyleBackColor = true;
            this.btn_Beenden.Click += new System.EventHandler(this.btn_Beenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Beenden);
            this.Controls.Add(this.lbl_Ergebnis);
            this.Controls.Add(this.btn_addieren);
            this.Controls.Add(this.txt_Zahl2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Zahl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Zahl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Zahl2;
        private System.Windows.Forms.Button btn_addieren;
        private System.Windows.Forms.Label lbl_Ergebnis;
        private System.Windows.Forms.Button btn_Beenden;
    }
}

