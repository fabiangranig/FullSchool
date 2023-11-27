namespace _20231127_ConnectedKunden
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
            this.menuStrip_Top = new System.Windows.Forms.MenuStrip();
            this.stammdatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lieferantenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Top
            // 
            this.menuStrip_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stammdatenToolStripMenuItem});
            this.menuStrip_Top.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Top.Name = "menuStrip_Top";
            this.menuStrip_Top.Size = new System.Drawing.Size(984, 24);
            this.menuStrip_Top.TabIndex = 0;
            // 
            // stammdatenToolStripMenuItem
            // 
            this.stammdatenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kundenToolStripMenuItem,
            this.lieferantenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.stammdatenToolStripMenuItem.Name = "stammdatenToolStripMenuItem";
            this.stammdatenToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.stammdatenToolStripMenuItem.Text = "Stammdaten";
            // 
            // kundenToolStripMenuItem
            // 
            this.kundenToolStripMenuItem.Name = "kundenToolStripMenuItem";
            this.kundenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kundenToolStripMenuItem.Text = "Kunden";
            this.kundenToolStripMenuItem.Click += new System.EventHandler(this.kundenToolStripMenuItem_Click);
            // 
            // lieferantenToolStripMenuItem
            // 
            this.lieferantenToolStripMenuItem.Name = "lieferantenToolStripMenuItem";
            this.lieferantenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lieferantenToolStripMenuItem.Text = "Lieferanten";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.menuStrip_Top);
            this.MainMenuStrip = this.menuStrip_Top;
            this.Name = "Form1";
            this.Text = "Nordwind";
            this.menuStrip_Top.ResumeLayout(false);
            this.menuStrip_Top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Top;
        private System.Windows.Forms.ToolStripMenuItem stammdatenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lieferantenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
    }
}

