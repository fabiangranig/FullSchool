
namespace _20231127_ConnectedKunden
{
    partial class Lieferantenuebersicht
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
            this.listView_Lieferanten = new System.Windows.Forms.ListView();
            this.button_Schliessen = new System.Windows.Forms.Button();
            this.button_Neu = new System.Windows.Forms.Button();
            this.button_Aendern = new System.Windows.Forms.Button();
            this.button_Loeschen = new System.Windows.Forms.Button();
            this.button_Anzeigen = new System.Windows.Forms.Button();
            this.label_Firma = new System.Windows.Forms.Label();
            this.textBox_Firma = new System.Windows.Forms.TextBox();
            this.label_Kontaktperson = new System.Windows.Forms.Label();
            this.textBox_Kontaktperson = new System.Windows.Forms.TextBox();
            this.label_Strasse = new System.Windows.Forms.Label();
            this.textBox_LieferantenNr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView_Lieferanten
            // 
            this.listView_Lieferanten.HideSelection = false;
            this.listView_Lieferanten.Location = new System.Drawing.Point(12, 67);
            this.listView_Lieferanten.Name = "listView_Lieferanten";
            this.listView_Lieferanten.Size = new System.Drawing.Size(720, 275);
            this.listView_Lieferanten.TabIndex = 0;
            this.listView_Lieferanten.UseCompatibleStateImageBehavior = false;
            this.listView_Lieferanten.View = System.Windows.Forms.View.Details;
            // 
            // button_Schliessen
            // 
            this.button_Schliessen.Location = new System.Drawing.Point(632, 348);
            this.button_Schliessen.Name = "button_Schliessen";
            this.button_Schliessen.Size = new System.Drawing.Size(100, 28);
            this.button_Schliessen.TabIndex = 1;
            this.button_Schliessen.Text = "Schließen";
            this.button_Schliessen.UseVisualStyleBackColor = true;
            this.button_Schliessen.Click += new System.EventHandler(this.button_Schliessen_Click);
            // 
            // button_Neu
            // 
            this.button_Neu.Location = new System.Drawing.Point(12, 348);
            this.button_Neu.Name = "button_Neu";
            this.button_Neu.Size = new System.Drawing.Size(100, 28);
            this.button_Neu.TabIndex = 2;
            this.button_Neu.Text = "Neu";
            this.button_Neu.UseVisualStyleBackColor = true;
            this.button_Neu.Click += new System.EventHandler(this.button_Neu_Click);
            // 
            // button_Aendern
            // 
            this.button_Aendern.Location = new System.Drawing.Point(118, 348);
            this.button_Aendern.Name = "button_Aendern";
            this.button_Aendern.Size = new System.Drawing.Size(100, 28);
            this.button_Aendern.TabIndex = 3;
            this.button_Aendern.Text = "Ändern";
            this.button_Aendern.UseVisualStyleBackColor = true;
            this.button_Aendern.Click += new System.EventHandler(this.button_Aendern_Click);
            // 
            // button_Loeschen
            // 
            this.button_Loeschen.Location = new System.Drawing.Point(224, 348);
            this.button_Loeschen.Name = "button_Loeschen";
            this.button_Loeschen.Size = new System.Drawing.Size(100, 28);
            this.button_Loeschen.TabIndex = 4;
            this.button_Loeschen.Text = "Löschen";
            this.button_Loeschen.UseVisualStyleBackColor = true;
            this.button_Loeschen.Click += new System.EventHandler(this.button_Loeschen_Click);
            // 
            // button_Anzeigen
            // 
            this.button_Anzeigen.Location = new System.Drawing.Point(330, 348);
            this.button_Anzeigen.Name = "button_Anzeigen";
            this.button_Anzeigen.Size = new System.Drawing.Size(100, 28);
            this.button_Anzeigen.TabIndex = 5;
            this.button_Anzeigen.Text = "Anzeigen";
            this.button_Anzeigen.UseVisualStyleBackColor = true;
            this.button_Anzeigen.Click += new System.EventHandler(this.button_Anzeigen_Click);
            // 
            // label_Firma
            // 
            this.label_Firma.AutoSize = true;
            this.label_Firma.Location = new System.Drawing.Point(139, 9);
            this.label_Firma.Name = "label_Firma";
            this.label_Firma.Size = new System.Drawing.Size(47, 17);
            this.label_Firma.TabIndex = 6;
            this.label_Firma.Text = "Firma:";
            // 
            // textBox_Firma
            // 
            this.textBox_Firma.Location = new System.Drawing.Point(142, 35);
            this.textBox_Firma.Name = "textBox_Firma";
            this.textBox_Firma.Size = new System.Drawing.Size(100, 22);
            this.textBox_Firma.TabIndex = 7;
            this.textBox_Firma.TextChanged += new System.EventHandler(this.textBox_Firma_TextChanged);
            // 
            // label_Kontaktperson
            // 
            this.label_Kontaktperson.AutoSize = true;
            this.label_Kontaktperson.Location = new System.Drawing.Point(265, 9);
            this.label_Kontaktperson.Name = "label_Kontaktperson";
            this.label_Kontaktperson.Size = new System.Drawing.Size(104, 17);
            this.label_Kontaktperson.TabIndex = 8;
            this.label_Kontaktperson.Text = "Kontaktperson:";
            // 
            // textBox_Kontaktperson
            // 
            this.textBox_Kontaktperson.Location = new System.Drawing.Point(268, 35);
            this.textBox_Kontaktperson.Name = "textBox_Kontaktperson";
            this.textBox_Kontaktperson.Size = new System.Drawing.Size(100, 22);
            this.textBox_Kontaktperson.TabIndex = 9;
            this.textBox_Kontaktperson.TextChanged += new System.EventHandler(this.textBox_Kontaktperson_TextChanged);
            // 
            // label_Strasse
            // 
            this.label_Strasse.AutoSize = true;
            this.label_Strasse.Location = new System.Drawing.Point(12, 9);
            this.label_Strasse.Name = "label_Strasse";
            this.label_Strasse.Size = new System.Drawing.Size(99, 17);
            this.label_Strasse.TabIndex = 10;
            this.label_Strasse.Text = "LieferantenNr:";
            // 
            // textBox_LieferantenNr
            // 
            this.textBox_LieferantenNr.Location = new System.Drawing.Point(15, 35);
            this.textBox_LieferantenNr.Name = "textBox_LieferantenNr";
            this.textBox_LieferantenNr.Size = new System.Drawing.Size(100, 22);
            this.textBox_LieferantenNr.TabIndex = 11;
            this.textBox_LieferantenNr.TextChanged += new System.EventHandler(this.textBox_Kundennummer_TextChanged);
            // 
            // Lieferantenuebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 393);
            this.Controls.Add(this.textBox_LieferantenNr);
            this.Controls.Add(this.label_Strasse);
            this.Controls.Add(this.textBox_Kontaktperson);
            this.Controls.Add(this.label_Kontaktperson);
            this.Controls.Add(this.textBox_Firma);
            this.Controls.Add(this.label_Firma);
            this.Controls.Add(this.button_Anzeigen);
            this.Controls.Add(this.button_Loeschen);
            this.Controls.Add(this.button_Aendern);
            this.Controls.Add(this.button_Neu);
            this.Controls.Add(this.button_Schliessen);
            this.Controls.Add(this.listView_Lieferanten);
            this.Name = "Lieferantenuebersicht";
            this.Text = "Lieferantenuebersicht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Lieferanten;
        private System.Windows.Forms.Button button_Schliessen;
        private System.Windows.Forms.Button button_Neu;
        private System.Windows.Forms.Button button_Aendern;
        private System.Windows.Forms.Button button_Loeschen;
        private System.Windows.Forms.Button button_Anzeigen;
        private System.Windows.Forms.Label label_Firma;
        private System.Windows.Forms.TextBox textBox_Firma;
        private System.Windows.Forms.Label label_Kontaktperson;
        private System.Windows.Forms.TextBox textBox_Kontaktperson;
        private System.Windows.Forms.Label label_Strasse;
        private System.Windows.Forms.TextBox textBox_LieferantenNr;
    }
}