namespace _20231105_Verkaufsverwaltungssystem
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
            this.dataGridView_MainScreen = new System.Windows.Forms.DataGridView();
            this.button_VerkaufNeu = new System.Windows.Forms.Button();
            this.button_Bearbeiten = new System.Windows.Forms.Button();
            this.button_Stornieren = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_KundeWarten = new System.Windows.Forms.Button();
            this.button_ProduktWarten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MainScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_MainScreen
            // 
            this.dataGridView_MainScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MainScreen.Location = new System.Drawing.Point(48, 94);
            this.dataGridView_MainScreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_MainScreen.MultiSelect = false;
            this.dataGridView_MainScreen.Name = "dataGridView_MainScreen";
            this.dataGridView_MainScreen.ReadOnly = true;
            this.dataGridView_MainScreen.RowHeadersWidth = 51;
            this.dataGridView_MainScreen.Size = new System.Drawing.Size(1022, 340);
            this.dataGridView_MainScreen.TabIndex = 0;
            // 
            // button_VerkaufNeu
            // 
            this.button_VerkaufNeu.Location = new System.Drawing.Point(48, 37);
            this.button_VerkaufNeu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_VerkaufNeu.Name = "button_VerkaufNeu";
            this.button_VerkaufNeu.Size = new System.Drawing.Size(146, 36);
            this.button_VerkaufNeu.TabIndex = 1;
            this.button_VerkaufNeu.Text = "Verkauf Neu";
            this.button_VerkaufNeu.UseVisualStyleBackColor = true;
            this.button_VerkaufNeu.Click += new System.EventHandler(this.button_VerkaufNeu_Click);
            // 
            // button_Bearbeiten
            // 
            this.button_Bearbeiten.Location = new System.Drawing.Point(202, 37);
            this.button_Bearbeiten.Margin = new System.Windows.Forms.Padding(4);
            this.button_Bearbeiten.Name = "button_Bearbeiten";
            this.button_Bearbeiten.Size = new System.Drawing.Size(146, 36);
            this.button_Bearbeiten.TabIndex = 2;
            this.button_Bearbeiten.Text = "Verkauf Bearbeiten";
            this.button_Bearbeiten.UseVisualStyleBackColor = true;
            this.button_Bearbeiten.Click += new System.EventHandler(this.button_Bearbeiten_Click);
            // 
            // button_Stornieren
            // 
            this.button_Stornieren.Location = new System.Drawing.Point(356, 37);
            this.button_Stornieren.Margin = new System.Windows.Forms.Padding(4);
            this.button_Stornieren.Name = "button_Stornieren";
            this.button_Stornieren.Size = new System.Drawing.Size(146, 36);
            this.button_Stornieren.TabIndex = 3;
            this.button_Stornieren.Text = "Verkauf Stornieren";
            this.button_Stornieren.UseVisualStyleBackColor = true;
            this.button_Stornieren.Click += new System.EventHandler(this.button_Stornieren_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(924, 442);
            this.button_OK.Margin = new System.Windows.Forms.Padding(4);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(146, 36);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "Ok";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_KundeWarten
            // 
            this.button_KundeWarten.Location = new System.Drawing.Point(48, 442);
            this.button_KundeWarten.Margin = new System.Windows.Forms.Padding(4);
            this.button_KundeWarten.Name = "button_KundeWarten";
            this.button_KundeWarten.Size = new System.Drawing.Size(146, 36);
            this.button_KundeWarten.TabIndex = 5;
            this.button_KundeWarten.Text = "Kunde Warten";
            this.button_KundeWarten.UseVisualStyleBackColor = true;
            this.button_KundeWarten.Click += new System.EventHandler(this.button_KundeWarten_Click);
            // 
            // button_ProduktWarten
            // 
            this.button_ProduktWarten.Location = new System.Drawing.Point(202, 442);
            this.button_ProduktWarten.Margin = new System.Windows.Forms.Padding(4);
            this.button_ProduktWarten.Name = "button_ProduktWarten";
            this.button_ProduktWarten.Size = new System.Drawing.Size(146, 36);
            this.button_ProduktWarten.TabIndex = 6;
            this.button_ProduktWarten.Text = "ProduktWarten";
            this.button_ProduktWarten.UseVisualStyleBackColor = true;
            this.button_ProduktWarten.Click += new System.EventHandler(this.button_ProduktWarten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 503);
            this.Controls.Add(this.button_ProduktWarten);
            this.Controls.Add(this.button_KundeWarten);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_Stornieren);
            this.Controls.Add(this.button_Bearbeiten);
            this.Controls.Add(this.button_VerkaufNeu);
            this.Controls.Add(this.dataGridView_MainScreen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Verkaufsverwaltungssystem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MainScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_MainScreen;
        private System.Windows.Forms.Button button_VerkaufNeu;
        private System.Windows.Forms.Button button_Bearbeiten;
        private System.Windows.Forms.Button button_Stornieren;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_KundeWarten;
        private System.Windows.Forms.Button button_ProduktWarten;
    }
}

