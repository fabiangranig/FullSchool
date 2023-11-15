namespace _2023115_DemoDataReader
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
            this.button_Verbinden = new System.Windows.Forms.Button();
            this.label_AusgeleseneDaten = new System.Windows.Forms.Label();
            this.button_Schliessen = new System.Windows.Forms.Button();
            this.button_TabelleErzeugen = new System.Windows.Forms.Button();
            this.buttonDatenEinfuegen = new System.Windows.Forms.Button();
            this.button_DatenAuslesen = new System.Windows.Forms.Button();
            this.button_TabelleLoeschen = new System.Windows.Forms.Button();
            this.button_Beenden = new System.Windows.Forms.Button();
            this.listView_AusgeleseneDaten = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button_Verbinden
            // 
            this.button_Verbinden.Location = new System.Drawing.Point(12, 12);
            this.button_Verbinden.Name = "button_Verbinden";
            this.button_Verbinden.Size = new System.Drawing.Size(97, 40);
            this.button_Verbinden.TabIndex = 0;
            this.button_Verbinden.Text = "Verbinden";
            this.button_Verbinden.UseVisualStyleBackColor = true;
            this.button_Verbinden.Click += new System.EventHandler(this.button_Verbinden_Click);
            // 
            // label_AusgeleseneDaten
            // 
            this.label_AusgeleseneDaten.AutoSize = true;
            this.label_AusgeleseneDaten.Location = new System.Drawing.Point(243, 12);
            this.label_AusgeleseneDaten.Name = "label_AusgeleseneDaten";
            this.label_AusgeleseneDaten.Size = new System.Drawing.Size(100, 13);
            this.label_AusgeleseneDaten.TabIndex = 7;
            this.label_AusgeleseneDaten.Text = "Ausgelesene Daten";
            // 
            // button_Schliessen
            // 
            this.button_Schliessen.Location = new System.Drawing.Point(12, 59);
            this.button_Schliessen.Name = "button_Schliessen";
            this.button_Schliessen.Size = new System.Drawing.Size(97, 40);
            this.button_Schliessen.TabIndex = 9;
            this.button_Schliessen.Text = "Schliessen";
            this.button_Schliessen.UseVisualStyleBackColor = true;
            this.button_Schliessen.Click += new System.EventHandler(this.button_Schliessen_Click);
            // 
            // button_TabelleErzeugen
            // 
            this.button_TabelleErzeugen.Location = new System.Drawing.Point(12, 105);
            this.button_TabelleErzeugen.Name = "button_TabelleErzeugen";
            this.button_TabelleErzeugen.Size = new System.Drawing.Size(97, 40);
            this.button_TabelleErzeugen.TabIndex = 10;
            this.button_TabelleErzeugen.Text = "Tabelle erzeugen";
            this.button_TabelleErzeugen.UseVisualStyleBackColor = true;
            this.button_TabelleErzeugen.Click += new System.EventHandler(this.button_TabelleErzeugen_Click);
            // 
            // buttonDatenEinfuegen
            // 
            this.buttonDatenEinfuegen.Location = new System.Drawing.Point(115, 12);
            this.buttonDatenEinfuegen.Name = "buttonDatenEinfuegen";
            this.buttonDatenEinfuegen.Size = new System.Drawing.Size(97, 40);
            this.buttonDatenEinfuegen.TabIndex = 11;
            this.buttonDatenEinfuegen.Text = "Daten einfügen";
            this.buttonDatenEinfuegen.UseVisualStyleBackColor = true;
            this.buttonDatenEinfuegen.Click += new System.EventHandler(this.buttonDatenEinfuegen_Click);
            // 
            // button_DatenAuslesen
            // 
            this.button_DatenAuslesen.Location = new System.Drawing.Point(115, 58);
            this.button_DatenAuslesen.Name = "button_DatenAuslesen";
            this.button_DatenAuslesen.Size = new System.Drawing.Size(97, 40);
            this.button_DatenAuslesen.TabIndex = 12;
            this.button_DatenAuslesen.Text = "Daten auslesen";
            this.button_DatenAuslesen.UseVisualStyleBackColor = true;
            this.button_DatenAuslesen.Click += new System.EventHandler(this.button_DatenAuslesen_Click);
            // 
            // button_TabelleLoeschen
            // 
            this.button_TabelleLoeschen.Location = new System.Drawing.Point(115, 105);
            this.button_TabelleLoeschen.Name = "button_TabelleLoeschen";
            this.button_TabelleLoeschen.Size = new System.Drawing.Size(97, 40);
            this.button_TabelleLoeschen.TabIndex = 13;
            this.button_TabelleLoeschen.Text = "Tabelle löschen";
            this.button_TabelleLoeschen.UseVisualStyleBackColor = true;
            this.button_TabelleLoeschen.Click += new System.EventHandler(this.button_TabelleLoeschen_Click);
            // 
            // button_Beenden
            // 
            this.button_Beenden.Location = new System.Drawing.Point(115, 151);
            this.button_Beenden.Name = "button_Beenden";
            this.button_Beenden.Size = new System.Drawing.Size(97, 40);
            this.button_Beenden.TabIndex = 14;
            this.button_Beenden.Text = "Beenden";
            this.button_Beenden.UseVisualStyleBackColor = true;
            this.button_Beenden.Click += new System.EventHandler(this.button_Beenden_Click);
            // 
            // listView_AusgeleseneDaten
            // 
            this.listView_AusgeleseneDaten.GridLines = true;
            this.listView_AusgeleseneDaten.HideSelection = false;
            this.listView_AusgeleseneDaten.Location = new System.Drawing.Point(246, 37);
            this.listView_AusgeleseneDaten.Name = "listView_AusgeleseneDaten";
            this.listView_AusgeleseneDaten.Size = new System.Drawing.Size(289, 154);
            this.listView_AusgeleseneDaten.TabIndex = 15;
            this.listView_AusgeleseneDaten.UseCompatibleStateImageBehavior = false;
            this.listView_AusgeleseneDaten.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 220);
            this.Controls.Add(this.listView_AusgeleseneDaten);
            this.Controls.Add(this.button_Beenden);
            this.Controls.Add(this.button_TabelleLoeschen);
            this.Controls.Add(this.button_DatenAuslesen);
            this.Controls.Add(this.buttonDatenEinfuegen);
            this.Controls.Add(this.button_TabelleErzeugen);
            this.Controls.Add(this.button_Schliessen);
            this.Controls.Add(this.label_AusgeleseneDaten);
            this.Controls.Add(this.button_Verbinden);
            this.Name = "Form1";
            this.Text = "Demo, Connection, Command, Datareader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Verbinden;
        private System.Windows.Forms.Label label_AusgeleseneDaten;
        private System.Windows.Forms.Button button_Schliessen;
        private System.Windows.Forms.Button button_TabelleErzeugen;
        private System.Windows.Forms.Button buttonDatenEinfuegen;
        private System.Windows.Forms.Button button_DatenAuslesen;
        private System.Windows.Forms.Button button_TabelleLoeschen;
        private System.Windows.Forms.Button button_Beenden;
        private System.Windows.Forms.ListView listView_AusgeleseneDaten;
    }
}

