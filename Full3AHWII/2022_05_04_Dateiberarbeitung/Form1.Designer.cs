namespace _20220504_Dateiverarbeitung
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_SchuelerAnzahl = new System.Windows.Forms.TextBox();
            this.txt_KlasseName = new System.Windows.Forms.TextBox();
            this.btn_AnlegenKlasse = new System.Windows.Forms.Button();
            this.lbl_SchuelerAnzahl = new System.Windows.Forms.Label();
            this.lbl_Klasse = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Nachname = new System.Windows.Forms.TextBox();
            this.txt_Vorname = new System.Windows.Forms.TextBox();
            this.txt_KatNr = new System.Windows.Forms.TextBox();
            this.btn_EingebenSchueler = new System.Windows.Forms.Button();
            this.lbl_Nachname = new System.Windows.Forms.Label();
            this.lbl_Vorname = new System.Windows.Forms.Label();
            this.lbl_KatNr = new System.Windows.Forms.Label();
            this.btn_SpeichernText = new System.Windows.Forms.Button();
            this.btn_LadenText = new System.Windows.Forms.Button();
            this.btn_SpeichernBinaer = new System.Windows.Forms.Button();
            this.btn_LadenBinär = new System.Windows.Forms.Button();
            this.btn_Beenden = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_SchuelerAnzahl);
            this.groupBox1.Controls.Add(this.txt_KlasseName);
            this.groupBox1.Controls.Add(this.btn_AnlegenKlasse);
            this.groupBox1.Controls.Add(this.lbl_SchuelerAnzahl);
            this.groupBox1.Controls.Add(this.lbl_Klasse);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // txt_SchuelerAnzahl
            // 
            this.txt_SchuelerAnzahl.Location = new System.Drawing.Point(134, 57);
            this.txt_SchuelerAnzahl.Name = "txt_SchuelerAnzahl";
            this.txt_SchuelerAnzahl.Size = new System.Drawing.Size(100, 20);
            this.txt_SchuelerAnzahl.TabIndex = 4;
            // 
            // txt_KlasseName
            // 
            this.txt_KlasseName.Location = new System.Drawing.Point(13, 57);
            this.txt_KlasseName.Name = "txt_KlasseName";
            this.txt_KlasseName.Size = new System.Drawing.Size(100, 20);
            this.txt_KlasseName.TabIndex = 3;
            // 
            // btn_AnlegenKlasse
            // 
            this.btn_AnlegenKlasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnlegenKlasse.Location = new System.Drawing.Point(13, 83);
            this.btn_AnlegenKlasse.Name = "btn_AnlegenKlasse";
            this.btn_AnlegenKlasse.Size = new System.Drawing.Size(221, 40);
            this.btn_AnlegenKlasse.TabIndex = 2;
            this.btn_AnlegenKlasse.Text = "Anlegen";
            this.btn_AnlegenKlasse.UseVisualStyleBackColor = true;
            this.btn_AnlegenKlasse.Click += new System.EventHandler(this.btn_AnlegenKlasse_Click);
            // 
            // lbl_SchuelerAnzahl
            // 
            this.lbl_SchuelerAnzahl.AutoSize = true;
            this.lbl_SchuelerAnzahl.Location = new System.Drawing.Point(131, 35);
            this.lbl_SchuelerAnzahl.Name = "lbl_SchuelerAnzahl";
            this.lbl_SchuelerAnzahl.Size = new System.Drawing.Size(81, 13);
            this.lbl_SchuelerAnzahl.TabIndex = 1;
            this.lbl_SchuelerAnzahl.Text = "Schüler Anzahl:";
            // 
            // lbl_Klasse
            // 
            this.lbl_Klasse.AutoSize = true;
            this.lbl_Klasse.Location = new System.Drawing.Point(10, 35);
            this.lbl_Klasse.Name = "lbl_Klasse";
            this.lbl_Klasse.Size = new System.Drawing.Size(41, 13);
            this.lbl_Klasse.TabIndex = 0;
            this.lbl_Klasse.Text = "Klasse:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Nachname);
            this.groupBox2.Controls.Add(this.txt_Vorname);
            this.groupBox2.Controls.Add(this.txt_KatNr);
            this.groupBox2.Controls.Add(this.btn_EingebenSchueler);
            this.groupBox2.Controls.Add(this.lbl_Nachname);
            this.groupBox2.Controls.Add(this.lbl_Vorname);
            this.groupBox2.Controls.Add(this.lbl_KatNr);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // txt_Nachname
            // 
            this.txt_Nachname.Location = new System.Drawing.Point(134, 130);
            this.txt_Nachname.Name = "txt_Nachname";
            this.txt_Nachname.Size = new System.Drawing.Size(100, 20);
            this.txt_Nachname.TabIndex = 6;
            // 
            // txt_Vorname
            // 
            this.txt_Vorname.Location = new System.Drawing.Point(134, 86);
            this.txt_Vorname.Name = "txt_Vorname";
            this.txt_Vorname.Size = new System.Drawing.Size(100, 20);
            this.txt_Vorname.TabIndex = 5;
            // 
            // txt_KatNr
            // 
            this.txt_KatNr.Location = new System.Drawing.Point(134, 38);
            this.txt_KatNr.Name = "txt_KatNr";
            this.txt_KatNr.Size = new System.Drawing.Size(100, 20);
            this.txt_KatNr.TabIndex = 4;
            // 
            // btn_EingebenSchueler
            // 
            this.btn_EingebenSchueler.Location = new System.Drawing.Point(29, 166);
            this.btn_EingebenSchueler.Name = "btn_EingebenSchueler";
            this.btn_EingebenSchueler.Size = new System.Drawing.Size(205, 38);
            this.btn_EingebenSchueler.TabIndex = 3;
            this.btn_EingebenSchueler.Text = "Eingeben";
            this.btn_EingebenSchueler.UseVisualStyleBackColor = true;
            this.btn_EingebenSchueler.Click += new System.EventHandler(this.btn_EingebenSchueler_Click);
            // 
            // lbl_Nachname
            // 
            this.lbl_Nachname.AutoSize = true;
            this.lbl_Nachname.Location = new System.Drawing.Point(28, 133);
            this.lbl_Nachname.Name = "lbl_Nachname";
            this.lbl_Nachname.Size = new System.Drawing.Size(62, 13);
            this.lbl_Nachname.TabIndex = 2;
            this.lbl_Nachname.Text = "Nachname:";
            // 
            // lbl_Vorname
            // 
            this.lbl_Vorname.AutoSize = true;
            this.lbl_Vorname.Location = new System.Drawing.Point(26, 89);
            this.lbl_Vorname.Name = "lbl_Vorname";
            this.lbl_Vorname.Size = new System.Drawing.Size(52, 13);
            this.lbl_Vorname.TabIndex = 1;
            this.lbl_Vorname.Text = "Vorname:";
            // 
            // lbl_KatNr
            // 
            this.lbl_KatNr.AutoSize = true;
            this.lbl_KatNr.Location = new System.Drawing.Point(26, 38);
            this.lbl_KatNr.Name = "lbl_KatNr";
            this.lbl_KatNr.Size = new System.Drawing.Size(37, 13);
            this.lbl_KatNr.TabIndex = 0;
            this.lbl_KatNr.Text = "KatNr:";
            // 
            // btn_SpeichernText
            // 
            this.btn_SpeichernText.Location = new System.Drawing.Point(308, 58);
            this.btn_SpeichernText.Name = "btn_SpeichernText";
            this.btn_SpeichernText.Size = new System.Drawing.Size(150, 40);
            this.btn_SpeichernText.TabIndex = 2;
            this.btn_SpeichernText.Text = "Speichern Text";
            this.btn_SpeichernText.UseVisualStyleBackColor = true;
            this.btn_SpeichernText.Click += new System.EventHandler(this.btn_SpeichernText_Click);
            // 
            // btn_LadenText
            // 
            this.btn_LadenText.Location = new System.Drawing.Point(308, 104);
            this.btn_LadenText.Name = "btn_LadenText";
            this.btn_LadenText.Size = new System.Drawing.Size(150, 40);
            this.btn_LadenText.TabIndex = 3;
            this.btn_LadenText.Text = "Laden Text";
            this.btn_LadenText.UseVisualStyleBackColor = true;
            this.btn_LadenText.Click += new System.EventHandler(this.btn_LadenText_Click);
            // 
            // btn_SpeichernBinaer
            // 
            this.btn_SpeichernBinaer.Location = new System.Drawing.Point(308, 216);
            this.btn_SpeichernBinaer.Name = "btn_SpeichernBinaer";
            this.btn_SpeichernBinaer.Size = new System.Drawing.Size(150, 40);
            this.btn_SpeichernBinaer.TabIndex = 4;
            this.btn_SpeichernBinaer.Text = "Speichern Binär";
            this.btn_SpeichernBinaer.UseVisualStyleBackColor = true;
            this.btn_SpeichernBinaer.Click += new System.EventHandler(this.btn_SpeichernBinaer_Click);
            // 
            // btn_LadenBinär
            // 
            this.btn_LadenBinär.Location = new System.Drawing.Point(308, 262);
            this.btn_LadenBinär.Name = "btn_LadenBinär";
            this.btn_LadenBinär.Size = new System.Drawing.Size(150, 40);
            this.btn_LadenBinär.TabIndex = 5;
            this.btn_LadenBinär.Text = "Laden Binär";
            this.btn_LadenBinär.UseVisualStyleBackColor = true;
            this.btn_LadenBinär.Click += new System.EventHandler(this.btn_LadenBinär_Click);
            // 
            // btn_Beenden
            // 
            this.btn_Beenden.Location = new System.Drawing.Point(553, 327);
            this.btn_Beenden.Name = "btn_Beenden";
            this.btn_Beenden.Size = new System.Drawing.Size(150, 40);
            this.btn_Beenden.TabIndex = 6;
            this.btn_Beenden.Text = "Beenden";
            this.btn_Beenden.UseVisualStyleBackColor = true;
            this.btn_Beenden.Click += new System.EventHandler(this.btn_Beenden_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(486, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 251);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Beenden);
            this.Controls.Add(this.btn_LadenBinär);
            this.Controls.Add(this.btn_SpeichernBinaer);
            this.Controls.Add(this.btn_LadenText);
            this.Controls.Add(this.btn_SpeichernText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Schüler Klasse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_SchuelerAnzahl;
        private System.Windows.Forms.TextBox txt_KlasseName;
        private System.Windows.Forms.Button btn_AnlegenKlasse;
        private System.Windows.Forms.Label lbl_SchuelerAnzahl;
        private System.Windows.Forms.Label lbl_Klasse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Nachname;
        private System.Windows.Forms.TextBox txt_Vorname;
        private System.Windows.Forms.TextBox txt_KatNr;
        private System.Windows.Forms.Button btn_EingebenSchueler;
        private System.Windows.Forms.Label lbl_Nachname;
        private System.Windows.Forms.Label lbl_Vorname;
        private System.Windows.Forms.Label lbl_KatNr;
        private System.Windows.Forms.Button btn_SpeichernText;
        private System.Windows.Forms.Button btn_LadenText;
        private System.Windows.Forms.Button btn_SpeichernBinaer;
        private System.Windows.Forms.Button btn_LadenBinär;
        private System.Windows.Forms.Button btn_Beenden;
        private System.Windows.Forms.ListBox listBox1;
    }
}

