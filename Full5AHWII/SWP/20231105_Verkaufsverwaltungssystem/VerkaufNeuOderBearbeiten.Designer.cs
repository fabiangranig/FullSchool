namespace _20231105_Verkaufsverwaltungssystem
{
    partial class VerkaufNeuOderBearbeiten
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
            this.label_Kundennummer = new System.Windows.Forms.Label();
            this.label_Produkt = new System.Windows.Forms.Label();
            this.label_Menge = new System.Windows.Forms.Label();
            this.label_Datum = new System.Windows.Forms.Label();
            this.comboBox_Kundenummer = new System.Windows.Forms.ComboBox();
            this.comboBox_Produkt = new System.Windows.Forms.ComboBox();
            this.textBox_Menge = new System.Windows.Forms.TextBox();
            this.textBox_Datum = new System.Windows.Forms.TextBox();
            this.button_KundennummerSuchen = new System.Windows.Forms.Button();
            this.button_ProduktSuchen = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Kundennummer
            // 
            this.label_Kundennummer.AutoSize = true;
            this.label_Kundennummer.Location = new System.Drawing.Point(12, 22);
            this.label_Kundennummer.Name = "label_Kundennummer";
            this.label_Kundennummer.Size = new System.Drawing.Size(78, 13);
            this.label_Kundennummer.TabIndex = 0;
            this.label_Kundennummer.Text = "Kundenummer:";
            // 
            // label_Produkt
            // 
            this.label_Produkt.AutoSize = true;
            this.label_Produkt.Location = new System.Drawing.Point(42, 60);
            this.label_Produkt.Name = "label_Produkt";
            this.label_Produkt.Size = new System.Drawing.Size(47, 13);
            this.label_Produkt.TabIndex = 1;
            this.label_Produkt.Text = "Produkt:";
            // 
            // label_Menge
            // 
            this.label_Menge.AutoSize = true;
            this.label_Menge.Location = new System.Drawing.Point(46, 97);
            this.label_Menge.Name = "label_Menge";
            this.label_Menge.Size = new System.Drawing.Size(43, 13);
            this.label_Menge.TabIndex = 2;
            this.label_Menge.Text = "Menge:";
            // 
            // label_Datum
            // 
            this.label_Datum.AutoSize = true;
            this.label_Datum.Location = new System.Drawing.Point(48, 133);
            this.label_Datum.Name = "label_Datum";
            this.label_Datum.Size = new System.Drawing.Size(41, 13);
            this.label_Datum.TabIndex = 3;
            this.label_Datum.Text = "Datum:";
            // 
            // comboBox_Kundenummer
            // 
            this.comboBox_Kundenummer.FormattingEnabled = true;
            this.comboBox_Kundenummer.Location = new System.Drawing.Point(96, 19);
            this.comboBox_Kundenummer.Name = "comboBox_Kundenummer";
            this.comboBox_Kundenummer.Size = new System.Drawing.Size(163, 21);
            this.comboBox_Kundenummer.TabIndex = 4;
            // 
            // comboBox_Produkt
            // 
            this.comboBox_Produkt.FormattingEnabled = true;
            this.comboBox_Produkt.Location = new System.Drawing.Point(96, 57);
            this.comboBox_Produkt.Name = "comboBox_Produkt";
            this.comboBox_Produkt.Size = new System.Drawing.Size(163, 21);
            this.comboBox_Produkt.TabIndex = 5;
            // 
            // textBox_Menge
            // 
            this.textBox_Menge.Location = new System.Drawing.Point(96, 94);
            this.textBox_Menge.Name = "textBox_Menge";
            this.textBox_Menge.Size = new System.Drawing.Size(163, 20);
            this.textBox_Menge.TabIndex = 6;
            // 
            // textBox_Datum
            // 
            this.textBox_Datum.Location = new System.Drawing.Point(96, 130);
            this.textBox_Datum.Name = "textBox_Datum";
            this.textBox_Datum.Size = new System.Drawing.Size(163, 20);
            this.textBox_Datum.TabIndex = 7;
            // 
            // button_KundennummerSuchen
            // 
            this.button_KundennummerSuchen.Location = new System.Drawing.Point(274, 17);
            this.button_KundennummerSuchen.Name = "button_KundennummerSuchen";
            this.button_KundennummerSuchen.Size = new System.Drawing.Size(75, 23);
            this.button_KundennummerSuchen.TabIndex = 8;
            this.button_KundennummerSuchen.Text = "suchen";
            this.button_KundennummerSuchen.UseVisualStyleBackColor = true;
            this.button_KundennummerSuchen.Click += new System.EventHandler(this.button_KundennummerSuchen_Click);
            // 
            // button_ProduktSuchen
            // 
            this.button_ProduktSuchen.Location = new System.Drawing.Point(274, 55);
            this.button_ProduktSuchen.Name = "button_ProduktSuchen";
            this.button_ProduktSuchen.Size = new System.Drawing.Size(75, 23);
            this.button_ProduktSuchen.TabIndex = 9;
            this.button_ProduktSuchen.Text = "suchen";
            this.button_ProduktSuchen.UseVisualStyleBackColor = true;
            this.button_ProduktSuchen.Click += new System.EventHandler(this.button_ProduktSuchen_Click);
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(175, 217);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 10;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(274, 217);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 11;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // VerkaufNeuOderBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.button_ProduktSuchen);
            this.Controls.Add(this.button_KundennummerSuchen);
            this.Controls.Add(this.textBox_Datum);
            this.Controls.Add(this.textBox_Menge);
            this.Controls.Add(this.comboBox_Produkt);
            this.Controls.Add(this.comboBox_Kundenummer);
            this.Controls.Add(this.label_Datum);
            this.Controls.Add(this.label_Menge);
            this.Controls.Add(this.label_Produkt);
            this.Controls.Add(this.label_Kundennummer);
            this.Name = "VerkaufNeuOderBearbeiten";
            this.Text = "VerkaufNeuOderBearbeiten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Kundennummer;
        private System.Windows.Forms.Label label_Produkt;
        private System.Windows.Forms.Label label_Menge;
        private System.Windows.Forms.Label label_Datum;
        private System.Windows.Forms.ComboBox comboBox_Kundenummer;
        private System.Windows.Forms.ComboBox comboBox_Produkt;
        private System.Windows.Forms.TextBox textBox_Menge;
        private System.Windows.Forms.TextBox textBox_Datum;
        private System.Windows.Forms.Button button_KundennummerSuchen;
        private System.Windows.Forms.Button button_ProduktSuchen;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancel;
    }
}