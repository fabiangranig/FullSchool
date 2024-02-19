namespace _20240219_Geometrie
{
    partial class Geometrie
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
            this.pictureBox_Zeichnen = new System.Windows.Forms.PictureBox();
            this.button_DrawTxt = new System.Windows.Forms.Button();
            this.button_Grafiken = new System.Windows.Forms.Button();
            this.button_DrawSQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Zeichnen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Zeichnen
            // 
            this.pictureBox_Zeichnen.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Zeichnen.Name = "pictureBox_Zeichnen";
            this.pictureBox_Zeichnen.Size = new System.Drawing.Size(300, 300);
            this.pictureBox_Zeichnen.TabIndex = 0;
            this.pictureBox_Zeichnen.TabStop = false;
            this.pictureBox_Zeichnen.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Zeichnen_Paint);
            // 
            // button_DrawTxt
            // 
            this.button_DrawTxt.Location = new System.Drawing.Point(685, 12);
            this.button_DrawTxt.Name = "button_DrawTxt";
            this.button_DrawTxt.Size = new System.Drawing.Size(103, 29);
            this.button_DrawTxt.TabIndex = 2;
            this.button_DrawTxt.Text = "DrawTxt";
            this.button_DrawTxt.UseVisualStyleBackColor = true;
            this.button_DrawTxt.Click += new System.EventHandler(this.button_DrawTxt_Click);
            // 
            // button_Grafiken
            // 
            this.button_Grafiken.Location = new System.Drawing.Point(685, 82);
            this.button_Grafiken.Name = "button_Grafiken";
            this.button_Grafiken.Size = new System.Drawing.Size(103, 29);
            this.button_Grafiken.TabIndex = 3;
            this.button_Grafiken.Text = "Grafiken";
            this.button_Grafiken.UseVisualStyleBackColor = true;
            this.button_Grafiken.Click += new System.EventHandler(this.button_Grafiken_Click);
            // 
            // button_DrawSQL
            // 
            this.button_DrawSQL.Location = new System.Drawing.Point(685, 47);
            this.button_DrawSQL.Name = "button_DrawSQL";
            this.button_DrawSQL.Size = new System.Drawing.Size(103, 29);
            this.button_DrawSQL.TabIndex = 4;
            this.button_DrawSQL.Text = "DrawSQL";
            this.button_DrawSQL.UseVisualStyleBackColor = true;
            this.button_DrawSQL.Click += new System.EventHandler(this.button_DrawSQL_Click);
            // 
            // Geometrie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_DrawSQL);
            this.Controls.Add(this.button_Grafiken);
            this.Controls.Add(this.button_DrawTxt);
            this.Controls.Add(this.pictureBox_Zeichnen);
            this.Name = "Geometrie";
            this.Text = "Geometrie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Zeichnen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Zeichnen;
        private System.Windows.Forms.Button button_DrawTxt;
        private System.Windows.Forms.Button button_Grafiken;
        private System.Windows.Forms.Button button_DrawSQL;
    }
}

