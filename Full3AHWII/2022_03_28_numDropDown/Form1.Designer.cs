namespace _20220328_numDropDown
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
            this._Groupbox = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtNettobetrag = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button_Berechnen = new System.Windows.Forms.Button();
            this.Label_letztes_Ergebnis = new System.Windows.Forms.Label();
            this._Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // _Groupbox
            // 
            this._Groupbox.Controls.Add(this.Label_letztes_Ergebnis);
            this._Groupbox.Controls.Add(this.Button_Berechnen);
            this._Groupbox.Controls.Add(this.Label2);
            this._Groupbox.Controls.Add(this.numericUpDown1);
            this._Groupbox.Controls.Add(this.txtNettobetrag);
            this._Groupbox.Controls.Add(this.Label1);
            this._Groupbox.Location = new System.Drawing.Point(12, 12);
            this._Groupbox.Name = "_Groupbox";
            this._Groupbox.Size = new System.Drawing.Size(359, 166);
            this._Groupbox.TabIndex = 0;
            this._Groupbox.TabStop = false;
            this._Groupbox.Text = "Eingabefelder";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(17, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(114, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nettobetrag (TextBox):";
            // 
            // txtNettobetrag
            // 
            this.txtNettobetrag.Location = new System.Drawing.Point(185, 34);
            this.txtNettobetrag.Name = "txtNettobetrag";
            this.txtNettobetrag.Size = new System.Drawing.Size(146, 20);
            this.txtNettobetrag.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(185, 73);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(146, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(17, 75);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(148, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Steuersatz (NumericupDown):";
            // 
            // Button_Berechnen
            // 
            this.Button_Berechnen.Location = new System.Drawing.Point(256, 118);
            this.Button_Berechnen.Name = "Button_Berechnen";
            this.Button_Berechnen.Size = new System.Drawing.Size(75, 23);
            this.Button_Berechnen.TabIndex = 4;
            this.Button_Berechnen.Text = "Bruttobetrag";
            this.Button_Berechnen.UseVisualStyleBackColor = true;
            this.Button_Berechnen.Click += new System.EventHandler(this.Button_Berechnen_Click);
            // 
            // Label_letztes_Ergebnis
            // 
            this.Label_letztes_Ergebnis.AutoSize = true;
            this.Label_letztes_Ergebnis.Location = new System.Drawing.Point(17, 118);
            this.Label_letztes_Ergebnis.Name = "Label_letztes_Ergebnis";
            this.Label_letztes_Ergebnis.Size = new System.Drawing.Size(84, 13);
            this.Label_letztes_Ergebnis.TabIndex = 5;
            this.Label_letztes_Ergebnis.Text = "letztes Ergebnis:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._Groupbox);
            this.Name = "Form1";
            this.Text = "Einfache Steuerelemente";
            this._Groupbox.ResumeLayout(false);
            this._Groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _Groupbox;
        private System.Windows.Forms.Button Button_Berechnen;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtNettobetrag;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label_letztes_Ergebnis;
    }
}

