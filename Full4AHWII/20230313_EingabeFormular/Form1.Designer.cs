namespace _20230313_EingabeFormular
{
    partial class FormMain
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
            this.label_DatenEingeben = new System.Windows.Forms.Label();
            this.label_DatenAnzeigen = new System.Windows.Forms.Label();
            this.groupBox_Links = new System.Windows.Forms.GroupBox();
            this.groupBox_Rechts = new System.Windows.Forms.GroupBox();
            this.label_Vorname = new System.Windows.Forms.Label();
            this.label_Nachname = new System.Windows.Forms.Label();
            this.label_Alter = new System.Windows.Forms.Label();
            this.label_Adresse = new System.Windows.Forms.Label();
            this.textBox_VornameInput = new System.Windows.Forms.TextBox();
            this.textBox_NachnameInput = new System.Windows.Forms.TextBox();
            this.textBox_AlterInput = new System.Windows.Forms.TextBox();
            this.textBox_AdresseInput = new System.Windows.Forms.TextBox();
            this.textBox_VornameOutput = new System.Windows.Forms.TextBox();
            this.textBox_AdresseOutput = new System.Windows.Forms.TextBox();
            this.textBox_NachnameOutput = new System.Windows.Forms.TextBox();
            this.textBox_AlterOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SchulwegInput = new System.Windows.Forms.TextBox();
            this.textBox_SchulwegOutput = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_uebernehmen = new System.Windows.Forms.Button();
            this.groupBox_Links.SuspendLayout();
            this.groupBox_Rechts.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_DatenEingeben
            // 
            this.label_DatenEingeben.AutoSize = true;
            this.label_DatenEingeben.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DatenEingeben.Location = new System.Drawing.Point(12, 26);
            this.label_DatenEingeben.Name = "label_DatenEingeben";
            this.label_DatenEingeben.Size = new System.Drawing.Size(145, 22);
            this.label_DatenEingeben.TabIndex = 0;
            this.label_DatenEingeben.Text = "Daten Eingeben:";
            // 
            // label_DatenAnzeigen
            // 
            this.label_DatenAnzeigen.AutoSize = true;
            this.label_DatenAnzeigen.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DatenAnzeigen.ForeColor = System.Drawing.Color.Black;
            this.label_DatenAnzeigen.Location = new System.Drawing.Point(300, 26);
            this.label_DatenAnzeigen.Name = "label_DatenAnzeigen";
            this.label_DatenAnzeigen.Size = new System.Drawing.Size(142, 22);
            this.label_DatenAnzeigen.TabIndex = 1;
            this.label_DatenAnzeigen.Text = "Daten Anzeigen:";
            // 
            // groupBox_Links
            // 
            this.groupBox_Links.Controls.Add(this.textBox_SchulwegInput);
            this.groupBox_Links.Controls.Add(this.label1);
            this.groupBox_Links.Controls.Add(this.textBox_AdresseInput);
            this.groupBox_Links.Controls.Add(this.textBox_AlterInput);
            this.groupBox_Links.Controls.Add(this.textBox_NachnameInput);
            this.groupBox_Links.Controls.Add(this.textBox_VornameInput);
            this.groupBox_Links.Controls.Add(this.label_Adresse);
            this.groupBox_Links.Controls.Add(this.label_Alter);
            this.groupBox_Links.Controls.Add(this.label_Nachname);
            this.groupBox_Links.Controls.Add(this.label_Vorname);
            this.groupBox_Links.Location = new System.Drawing.Point(16, 51);
            this.groupBox_Links.Name = "groupBox_Links";
            this.groupBox_Links.Size = new System.Drawing.Size(282, 261);
            this.groupBox_Links.TabIndex = 2;
            this.groupBox_Links.TabStop = false;
            // 
            // groupBox_Rechts
            // 
            this.groupBox_Rechts.Controls.Add(this.textBox_SchulwegOutput);
            this.groupBox_Rechts.Controls.Add(this.textBox_AlterOutput);
            this.groupBox_Rechts.Controls.Add(this.textBox_NachnameOutput);
            this.groupBox_Rechts.Controls.Add(this.textBox_AdresseOutput);
            this.groupBox_Rechts.Controls.Add(this.textBox_VornameOutput);
            this.groupBox_Rechts.Location = new System.Drawing.Point(304, 51);
            this.groupBox_Rechts.Name = "groupBox_Rechts";
            this.groupBox_Rechts.Size = new System.Drawing.Size(200, 261);
            this.groupBox_Rechts.TabIndex = 3;
            this.groupBox_Rechts.TabStop = false;
            // 
            // label_Vorname
            // 
            this.label_Vorname.AutoSize = true;
            this.label_Vorname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Vorname.Location = new System.Drawing.Point(27, 39);
            this.label_Vorname.Name = "label_Vorname";
            this.label_Vorname.Size = new System.Drawing.Size(64, 17);
            this.label_Vorname.TabIndex = 0;
            this.label_Vorname.Text = "Vorname:";
            // 
            // label_Nachname
            // 
            this.label_Nachname.AutoSize = true;
            this.label_Nachname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nachname.Location = new System.Drawing.Point(27, 78);
            this.label_Nachname.Name = "label_Nachname";
            this.label_Nachname.Size = new System.Drawing.Size(75, 17);
            this.label_Nachname.TabIndex = 1;
            this.label_Nachname.Text = "Nachname:";
            // 
            // label_Alter
            // 
            this.label_Alter.AutoSize = true;
            this.label_Alter.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Alter.Location = new System.Drawing.Point(27, 119);
            this.label_Alter.Name = "label_Alter";
            this.label_Alter.Size = new System.Drawing.Size(41, 17);
            this.label_Alter.TabIndex = 2;
            this.label_Alter.Text = "Alter:";
            // 
            // label_Adresse
            // 
            this.label_Adresse.AutoSize = true;
            this.label_Adresse.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Adresse.Location = new System.Drawing.Point(27, 154);
            this.label_Adresse.Name = "label_Adresse";
            this.label_Adresse.Size = new System.Drawing.Size(60, 17);
            this.label_Adresse.TabIndex = 3;
            this.label_Adresse.Text = "Adresse:";
            // 
            // textBox_VornameInput
            // 
            this.textBox_VornameInput.Location = new System.Drawing.Point(147, 39);
            this.textBox_VornameInput.Name = "textBox_VornameInput";
            this.textBox_VornameInput.Size = new System.Drawing.Size(100, 20);
            this.textBox_VornameInput.TabIndex = 4;
            // 
            // textBox_NachnameInput
            // 
            this.textBox_NachnameInput.Location = new System.Drawing.Point(147, 78);
            this.textBox_NachnameInput.Name = "textBox_NachnameInput";
            this.textBox_NachnameInput.Size = new System.Drawing.Size(100, 20);
            this.textBox_NachnameInput.TabIndex = 5;
            // 
            // textBox_AlterInput
            // 
            this.textBox_AlterInput.Location = new System.Drawing.Point(147, 116);
            this.textBox_AlterInput.Name = "textBox_AlterInput";
            this.textBox_AlterInput.Size = new System.Drawing.Size(100, 20);
            this.textBox_AlterInput.TabIndex = 6;
            this.textBox_AlterInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_AlterInput_KeyPress);
            // 
            // textBox_AdresseInput
            // 
            this.textBox_AdresseInput.Location = new System.Drawing.Point(147, 151);
            this.textBox_AdresseInput.Name = "textBox_AdresseInput";
            this.textBox_AdresseInput.Size = new System.Drawing.Size(100, 20);
            this.textBox_AdresseInput.TabIndex = 7;
            // 
            // textBox_VornameOutput
            // 
            this.textBox_VornameOutput.Location = new System.Drawing.Point(24, 39);
            this.textBox_VornameOutput.Name = "textBox_VornameOutput";
            this.textBox_VornameOutput.ReadOnly = true;
            this.textBox_VornameOutput.Size = new System.Drawing.Size(100, 20);
            this.textBox_VornameOutput.TabIndex = 0;
            // 
            // textBox_AdresseOutput
            // 
            this.textBox_AdresseOutput.Location = new System.Drawing.Point(24, 151);
            this.textBox_AdresseOutput.Name = "textBox_AdresseOutput";
            this.textBox_AdresseOutput.ReadOnly = true;
            this.textBox_AdresseOutput.Size = new System.Drawing.Size(100, 20);
            this.textBox_AdresseOutput.TabIndex = 1;
            // 
            // textBox_NachnameOutput
            // 
            this.textBox_NachnameOutput.Location = new System.Drawing.Point(24, 78);
            this.textBox_NachnameOutput.Name = "textBox_NachnameOutput";
            this.textBox_NachnameOutput.ReadOnly = true;
            this.textBox_NachnameOutput.Size = new System.Drawing.Size(100, 20);
            this.textBox_NachnameOutput.TabIndex = 2;
            // 
            // textBox_AlterOutput
            // 
            this.textBox_AlterOutput.Location = new System.Drawing.Point(24, 116);
            this.textBox_AlterOutput.Name = "textBox_AlterOutput";
            this.textBox_AlterOutput.ReadOnly = true;
            this.textBox_AlterOutput.Size = new System.Drawing.Size(100, 20);
            this.textBox_AlterOutput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Länge Schulweg:\r\n(z.B.: 3.5)\r\n";
            // 
            // textBox_SchulwegInput
            // 
            this.textBox_SchulwegInput.Location = new System.Drawing.Point(147, 192);
            this.textBox_SchulwegInput.Name = "textBox_SchulwegInput";
            this.textBox_SchulwegInput.Size = new System.Drawing.Size(100, 20);
            this.textBox_SchulwegInput.TabIndex = 9;
            this.textBox_SchulwegInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SchulwegInput_KeyPress);
            // 
            // textBox_SchulwegOutput
            // 
            this.textBox_SchulwegOutput.Location = new System.Drawing.Point(24, 193);
            this.textBox_SchulwegOutput.Name = "textBox_SchulwegOutput";
            this.textBox_SchulwegOutput.ReadOnly = true;
            this.textBox_SchulwegOutput.Size = new System.Drawing.Size(100, 20);
            this.textBox_SchulwegOutput.TabIndex = 4;
            // 
            // button_ok
            // 
            this.button_ok.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ok.Location = new System.Drawing.Point(304, 318);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(88, 31);
            this.button_ok.TabIndex = 5;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_uebernehmen
            // 
            this.button_uebernehmen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_uebernehmen.Location = new System.Drawing.Point(175, 318);
            this.button_uebernehmen.Name = "button_uebernehmen";
            this.button_uebernehmen.Size = new System.Drawing.Size(88, 31);
            this.button_uebernehmen.TabIndex = 6;
            this.button_uebernehmen.Text = "Übernehmen";
            this.button_uebernehmen.UseVisualStyleBackColor = true;
            this.button_uebernehmen.Click += new System.EventHandler(this.button_uebernehmen_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 361);
            this.Controls.Add(this.button_uebernehmen);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.groupBox_Rechts);
            this.Controls.Add(this.groupBox_Links);
            this.Controls.Add(this.label_DatenAnzeigen);
            this.Controls.Add(this.label_DatenEingeben);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eingabe Dialog";
            this.groupBox_Links.ResumeLayout(false);
            this.groupBox_Links.PerformLayout();
            this.groupBox_Rechts.ResumeLayout(false);
            this.groupBox_Rechts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DatenEingeben;
        private System.Windows.Forms.Label label_DatenAnzeigen;
        private System.Windows.Forms.GroupBox groupBox_Links;
        private System.Windows.Forms.TextBox textBox_SchulwegInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_AdresseInput;
        private System.Windows.Forms.TextBox textBox_AlterInput;
        private System.Windows.Forms.TextBox textBox_NachnameInput;
        private System.Windows.Forms.TextBox textBox_VornameInput;
        private System.Windows.Forms.Label label_Adresse;
        private System.Windows.Forms.Label label_Alter;
        private System.Windows.Forms.Label label_Nachname;
        private System.Windows.Forms.Label label_Vorname;
        private System.Windows.Forms.GroupBox groupBox_Rechts;
        private System.Windows.Forms.TextBox textBox_SchulwegOutput;
        private System.Windows.Forms.TextBox textBox_AlterOutput;
        private System.Windows.Forms.TextBox textBox_NachnameOutput;
        private System.Windows.Forms.TextBox textBox_AdresseOutput;
        private System.Windows.Forms.TextBox textBox_VornameOutput;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_uebernehmen;
    }
}

