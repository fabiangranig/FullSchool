namespace _20240226_Wegstrecke
{
    partial class Wegstrecke
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
            this.menuStrip_Hauptmenue = new System.Windows.Forms.MenuStrip();
            this.ToolStripItemDatei = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItemLaden = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItemAenderungenSpeichern = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItemCSVSpeichern = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Km = new System.Windows.Forms.Label();
            this.textBox_Km = new System.Windows.Forms.TextBox();
            this.textBox_Meilen = new System.Windows.Forms.TextBox();
            this.label_Meilen = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip_Hauptmenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_Hauptmenue
            // 
            this.menuStrip_Hauptmenue.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Hauptmenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripItemDatei});
            this.menuStrip_Hauptmenue.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Hauptmenue.Name = "menuStrip_Hauptmenue";
            this.menuStrip_Hauptmenue.Size = new System.Drawing.Size(687, 28);
            this.menuStrip_Hauptmenue.TabIndex = 0;
            this.menuStrip_Hauptmenue.Text = "menuStrip_Hauptmenue";
            // 
            // ToolStripItemDatei
            // 
            this.ToolStripItemDatei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripItemLaden,
            this.ToolStripItemAenderungenSpeichern,
            this.ToolStripItemCSVSpeichern});
            this.ToolStripItemDatei.Name = "ToolStripItemDatei";
            this.ToolStripItemDatei.Size = new System.Drawing.Size(59, 24);
            this.ToolStripItemDatei.Text = "Datei";
            // 
            // ToolStripItemLaden
            // 
            this.ToolStripItemLaden.Name = "ToolStripItemLaden";
            this.ToolStripItemLaden.Size = new System.Drawing.Size(325, 26);
            this.ToolStripItemLaden.Text = "Datei/Liste laden";
            // 
            // ToolStripItemAenderungenSpeichern
            // 
            this.ToolStripItemAenderungenSpeichern.Name = "ToolStripItemAenderungenSpeichern";
            this.ToolStripItemAenderungenSpeichern.Size = new System.Drawing.Size(325, 26);
            this.ToolStripItemAenderungenSpeichern.Text = "Datei/Änderung speichern";
            // 
            // ToolStripItemCSVSpeichern
            // 
            this.ToolStripItemCSVSpeichern.Name = "ToolStripItemCSVSpeichern";
            this.ToolStripItemCSVSpeichern.Size = new System.Drawing.Size(325, 26);
            this.ToolStripItemCSVSpeichern.Text = "Datei/Liste als CSV-Datei speichern";
            // 
            // label_Km
            // 
            this.label_Km.AutoSize = true;
            this.label_Km.Location = new System.Drawing.Point(12, 41);
            this.label_Km.Name = "label_Km";
            this.label_Km.Size = new System.Drawing.Size(29, 16);
            this.label_Km.TabIndex = 1;
            this.label_Km.Text = "Km:";
            // 
            // textBox_Km
            // 
            this.textBox_Km.Location = new System.Drawing.Point(47, 41);
            this.textBox_Km.Name = "textBox_Km";
            this.textBox_Km.Size = new System.Drawing.Size(100, 22);
            this.textBox_Km.TabIndex = 2;
            // 
            // textBox_Meilen
            // 
            this.textBox_Meilen.Location = new System.Drawing.Point(242, 41);
            this.textBox_Meilen.Name = "textBox_Meilen";
            this.textBox_Meilen.Size = new System.Drawing.Size(100, 22);
            this.textBox_Meilen.TabIndex = 3;
            // 
            // label_Meilen
            // 
            this.label_Meilen.AutoSize = true;
            this.label_Meilen.Location = new System.Drawing.Point(186, 44);
            this.label_Meilen.Name = "label_Meilen";
            this.label_Meilen.Size = new System.Drawing.Size(50, 16);
            this.label_Meilen.TabIndex = 4;
            this.label_Meilen.Text = "Meilen:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(660, 356);
            this.dataGridView1.TabIndex = 5;
            // 
            // Wegstrecke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_Meilen);
            this.Controls.Add(this.textBox_Meilen);
            this.Controls.Add(this.textBox_Km);
            this.Controls.Add(this.label_Km);
            this.Controls.Add(this.menuStrip_Hauptmenue);
            this.MainMenuStrip = this.menuStrip_Hauptmenue;
            this.Name = "Wegstrecke";
            this.Text = "Wegstrecke";
            this.menuStrip_Hauptmenue.ResumeLayout(false);
            this.menuStrip_Hauptmenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Hauptmenue;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemDatei;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemLaden;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemAenderungenSpeichern;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemCSVSpeichern;
        private System.Windows.Forms.Label label_Km;
        private System.Windows.Forms.TextBox textBox_Km;
        private System.Windows.Forms.TextBox textBox_Meilen;
        private System.Windows.Forms.Label label_Meilen;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

