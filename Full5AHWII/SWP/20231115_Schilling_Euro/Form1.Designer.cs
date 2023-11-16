namespace _20231115_Schilling_Euro
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
            this.listView_richtigeDatensaetze = new System.Windows.Forms.ListView();
            this.button_Laden = new System.Windows.Forms.Button();
            this.button_Speichern = new System.Windows.Forms.Button();
            this.button_Beenden = new System.Windows.Forms.Button();
            this.label_korrekteSchillingUndEuro = new System.Windows.Forms.Label();
            this.label_falscheSchillingUndEuro = new System.Windows.Forms.Label();
            this.listView_falscheDatensaetze = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView_richtigeDatensaetze
            // 
            this.listView_richtigeDatensaetze.HideSelection = false;
            this.listView_richtigeDatensaetze.Location = new System.Drawing.Point(16, 15);
            this.listView_richtigeDatensaetze.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_richtigeDatensaetze.Name = "listView_richtigeDatensaetze";
            this.listView_richtigeDatensaetze.Size = new System.Drawing.Size(315, 182);
            this.listView_richtigeDatensaetze.TabIndex = 0;
            this.listView_richtigeDatensaetze.UseCompatibleStateImageBehavior = false;
            this.listView_richtigeDatensaetze.View = System.Windows.Forms.View.Details;
            // 
            // button_Laden
            // 
            this.button_Laden.Location = new System.Drawing.Point(679, 15);
            this.button_Laden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Laden.Name = "button_Laden";
            this.button_Laden.Size = new System.Drawing.Size(100, 28);
            this.button_Laden.TabIndex = 2;
            this.button_Laden.Text = "Laden";
            this.button_Laden.UseVisualStyleBackColor = true;
            this.button_Laden.Click += new System.EventHandler(this.button_Laden_Click);
            // 
            // button_Speichern
            // 
            this.button_Speichern.Location = new System.Drawing.Point(679, 50);
            this.button_Speichern.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Speichern.Name = "button_Speichern";
            this.button_Speichern.Size = new System.Drawing.Size(100, 28);
            this.button_Speichern.TabIndex = 3;
            this.button_Speichern.Text = "Speichern";
            this.button_Speichern.UseVisualStyleBackColor = true;
            this.button_Speichern.Click += new System.EventHandler(this.button_Speichern_Click);
            // 
            // button_Beenden
            // 
            this.button_Beenden.Location = new System.Drawing.Point(679, 86);
            this.button_Beenden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Beenden.Name = "button_Beenden";
            this.button_Beenden.Size = new System.Drawing.Size(100, 28);
            this.button_Beenden.TabIndex = 4;
            this.button_Beenden.Text = "Beenden";
            this.button_Beenden.UseVisualStyleBackColor = true;
            this.button_Beenden.Click += new System.EventHandler(this.button_Beenden_Click);
            // 
            // label_korrekteSchillingUndEuro
            // 
            this.label_korrekteSchillingUndEuro.AutoSize = true;
            this.label_korrekteSchillingUndEuro.Location = new System.Drawing.Point(16, 213);
            this.label_korrekteSchillingUndEuro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_korrekteSchillingUndEuro.Name = "label_korrekteSchillingUndEuro";
            this.label_korrekteSchillingUndEuro.Size = new System.Drawing.Size(114, 16);
            this.label_korrekteSchillingUndEuro.TabIndex = 5;
            this.label_korrekteSchillingUndEuro.Text = "Schilling: 0 Euro: 0";
            // 
            // label_falscheSchillingUndEuro
            // 
            this.label_falscheSchillingUndEuro.AutoSize = true;
            this.label_falscheSchillingUndEuro.Location = new System.Drawing.Point(336, 213);
            this.label_falscheSchillingUndEuro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_falscheSchillingUndEuro.Name = "label_falscheSchillingUndEuro";
            this.label_falscheSchillingUndEuro.Size = new System.Drawing.Size(114, 16);
            this.label_falscheSchillingUndEuro.TabIndex = 6;
            this.label_falscheSchillingUndEuro.Text = "Schilling: 0 Euro: 0";
            // 
            // listView_falscheDatensaetze
            // 
            this.listView_falscheDatensaetze.HideSelection = false;
            this.listView_falscheDatensaetze.Location = new System.Drawing.Point(340, 15);
            this.listView_falscheDatensaetze.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_falscheDatensaetze.Name = "listView_falscheDatensaetze";
            this.listView_falscheDatensaetze.Size = new System.Drawing.Size(315, 182);
            this.listView_falscheDatensaetze.TabIndex = 8;
            this.listView_falscheDatensaetze.UseCompatibleStateImageBehavior = false;
            this.listView_falscheDatensaetze.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 251);
            this.Controls.Add(this.listView_falscheDatensaetze);
            this.Controls.Add(this.label_falscheSchillingUndEuro);
            this.Controls.Add(this.label_korrekteSchillingUndEuro);
            this.Controls.Add(this.button_Beenden);
            this.Controls.Add(this.button_Speichern);
            this.Controls.Add(this.button_Laden);
            this.Controls.Add(this.listView_richtigeDatensaetze);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Umrechnung - Schilling zu Euro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_richtigeDatensaetze;
        private System.Windows.Forms.Button button_Laden;
        private System.Windows.Forms.Button button_Speichern;
        private System.Windows.Forms.Button button_Beenden;
        private System.Windows.Forms.Label label_korrekteSchillingUndEuro;
        private System.Windows.Forms.Label label_falscheSchillingUndEuro;
        private System.Windows.Forms.ListView listView_falscheDatensaetze;
    }
}

