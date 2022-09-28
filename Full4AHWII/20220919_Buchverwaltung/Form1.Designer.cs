namespace _20220919_Buchverwaltung
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
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.textBox_GesamtUmsatz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_verkauft = new System.Windows.Forms.TextBox();
            this.textBox_geliefert = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_liefern = new System.Windows.Forms.TextBox();
            this.textBox_verkaufen = new System.Windows.Forms.TextBox();
            this.button_liefern = new System.Windows.Forms.Button();
            this.button_verkaufen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Lagerumsatz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(12, 27);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(498, 186);
            this.ListBox1.TabIndex = 0;
            this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // textBox_GesamtUmsatz
            // 
            this.textBox_GesamtUmsatz.Location = new System.Drawing.Point(622, 24);
            this.textBox_GesamtUmsatz.Name = "textBox_GesamtUmsatz";
            this.textBox_GesamtUmsatz.ReadOnly = true;
            this.textBox_GesamtUmsatz.Size = new System.Drawing.Size(100, 20);
            this.textBox_GesamtUmsatz.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bücherregal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gesamtumsatz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "verkauft Anzahl:";
            // 
            // textBox_verkauft
            // 
            this.textBox_verkauft.Location = new System.Drawing.Point(622, 50);
            this.textBox_verkauft.Name = "textBox_verkauft";
            this.textBox_verkauft.ReadOnly = true;
            this.textBox_verkauft.Size = new System.Drawing.Size(100, 20);
            this.textBox_verkauft.TabIndex = 5;
            // 
            // textBox_geliefert
            // 
            this.textBox_geliefert.Location = new System.Drawing.Point(622, 76);
            this.textBox_geliefert.Name = "textBox_geliefert";
            this.textBox_geliefert.ReadOnly = true;
            this.textBox_geliefert.Size = new System.Drawing.Size(100, 20);
            this.textBox_geliefert.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "geliefert Anzahl:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ausgewähltes Buch:";
            // 
            // textBox_liefern
            // 
            this.textBox_liefern.Location = new System.Drawing.Point(15, 271);
            this.textBox_liefern.Name = "textBox_liefern";
            this.textBox_liefern.Size = new System.Drawing.Size(100, 20);
            this.textBox_liefern.TabIndex = 9;
            // 
            // textBox_verkaufen
            // 
            this.textBox_verkaufen.Location = new System.Drawing.Point(15, 297);
            this.textBox_verkaufen.Name = "textBox_verkaufen";
            this.textBox_verkaufen.Size = new System.Drawing.Size(100, 20);
            this.textBox_verkaufen.TabIndex = 10;
            // 
            // button_liefern
            // 
            this.button_liefern.Location = new System.Drawing.Point(121, 271);
            this.button_liefern.Name = "button_liefern";
            this.button_liefern.Size = new System.Drawing.Size(75, 23);
            this.button_liefern.TabIndex = 11;
            this.button_liefern.Text = "Liefern!";
            this.button_liefern.UseVisualStyleBackColor = true;
            this.button_liefern.Click += new System.EventHandler(this.button_liefern_Click);
            // 
            // button_verkaufen
            // 
            this.button_verkaufen.Location = new System.Drawing.Point(121, 297);
            this.button_verkaufen.Name = "button_verkaufen";
            this.button_verkaufen.Size = new System.Drawing.Size(75, 23);
            this.button_verkaufen.TabIndex = 12;
            this.button_verkaufen.Text = "Verkaufen!";
            this.button_verkaufen.UseVisualStyleBackColor = true;
            this.button_verkaufen.Click += new System.EventHandler(this.button_verkaufen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lagerumsatz:";
            // 
            // textBox_Lagerumsatz
            // 
            this.textBox_Lagerumsatz.Location = new System.Drawing.Point(622, 130);
            this.textBox_Lagerumsatz.Name = "textBox_Lagerumsatz";
            this.textBox_Lagerumsatz.ReadOnly = true;
            this.textBox_Lagerumsatz.Size = new System.Drawing.Size(100, 20);
            this.textBox_Lagerumsatz.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 334);
            this.Controls.Add(this.textBox_Lagerumsatz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_verkaufen);
            this.Controls.Add(this.button_liefern);
            this.Controls.Add(this.textBox_verkaufen);
            this.Controls.Add(this.textBox_liefern);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_geliefert);
            this.Controls.Add(this.textBox_verkauft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_GesamtUmsatz);
            this.Controls.Add(this.ListBox1);
            this.Name = "Form1";
            this.Text = "Buchverwaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.TextBox textBox_GesamtUmsatz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_verkauft;
        private System.Windows.Forms.TextBox textBox_geliefert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_liefern;
        private System.Windows.Forms.TextBox textBox_verkaufen;
        private System.Windows.Forms.Button button_liefern;
        private System.Windows.Forms.Button button_verkaufen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Lagerumsatz;
    }
}

