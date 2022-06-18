namespace _20220530_BitOperation
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
            this.lbl_zahl1 = new System.Windows.Forms.Label();
            this.txtBox_zahl1 = new System.Windows.Forms.TextBox();
            this.lbl_zahl2 = new System.Windows.Forms.Label();
            this.txtBox_zahl2 = new System.Windows.Forms.TextBox();
            this.lbl_Ergebnis = new System.Windows.Forms.Label();
            this.txtBox_ergebnis = new System.Windows.Forms.TextBox();
            this.btn_Einserkomplement = new System.Windows.Forms.Button();
            this.btn_oder = new System.Windows.Forms.Button();
            this.btn_und = new System.Windows.Forms.Button();
            this.btn_rechts = new System.Windows.Forms.Button();
            this.btn_links = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_zahl1
            // 
            this.lbl_zahl1.AutoSize = true;
            this.lbl_zahl1.Location = new System.Drawing.Point(38, 40);
            this.lbl_zahl1.Name = "lbl_zahl1";
            this.lbl_zahl1.Size = new System.Drawing.Size(37, 13);
            this.lbl_zahl1.TabIndex = 0;
            this.lbl_zahl1.Text = "Zahl1:";
            // 
            // txtBox_zahl1
            // 
            this.txtBox_zahl1.Location = new System.Drawing.Point(41, 67);
            this.txtBox_zahl1.Name = "txtBox_zahl1";
            this.txtBox_zahl1.Size = new System.Drawing.Size(100, 20);
            this.txtBox_zahl1.TabIndex = 1;
            this.txtBox_zahl1.Text = "0";
            // 
            // lbl_zahl2
            // 
            this.lbl_zahl2.AutoSize = true;
            this.lbl_zahl2.Location = new System.Drawing.Point(38, 158);
            this.lbl_zahl2.Name = "lbl_zahl2";
            this.lbl_zahl2.Size = new System.Drawing.Size(37, 13);
            this.lbl_zahl2.TabIndex = 2;
            this.lbl_zahl2.Text = "Zahl2:";
            // 
            // txtBox_zahl2
            // 
            this.txtBox_zahl2.Location = new System.Drawing.Point(41, 190);
            this.txtBox_zahl2.Name = "txtBox_zahl2";
            this.txtBox_zahl2.Size = new System.Drawing.Size(100, 20);
            this.txtBox_zahl2.TabIndex = 3;
            this.txtBox_zahl2.Text = "0";
            // 
            // lbl_Ergebnis
            // 
            this.lbl_Ergebnis.AutoSize = true;
            this.lbl_Ergebnis.Location = new System.Drawing.Point(38, 271);
            this.lbl_Ergebnis.Name = "lbl_Ergebnis";
            this.lbl_Ergebnis.Size = new System.Drawing.Size(51, 13);
            this.lbl_Ergebnis.TabIndex = 4;
            this.lbl_Ergebnis.Text = "Ergebnis:";
            // 
            // txtBox_ergebnis
            // 
            this.txtBox_ergebnis.Location = new System.Drawing.Point(41, 299);
            this.txtBox_ergebnis.Name = "txtBox_ergebnis";
            this.txtBox_ergebnis.ReadOnly = true;
            this.txtBox_ergebnis.Size = new System.Drawing.Size(100, 20);
            this.txtBox_ergebnis.TabIndex = 5;
            // 
            // btn_Einserkomplement
            // 
            this.btn_Einserkomplement.Location = new System.Drawing.Point(586, 64);
            this.btn_Einserkomplement.Name = "btn_Einserkomplement";
            this.btn_Einserkomplement.Size = new System.Drawing.Size(75, 23);
            this.btn_Einserkomplement.TabIndex = 6;
            this.btn_Einserkomplement.Text = "Legieren";
            this.btn_Einserkomplement.UseVisualStyleBackColor = true;
            this.btn_Einserkomplement.Click += new System.EventHandler(this.btn_Legieren_Click);
            // 
            // btn_oder
            // 
            this.btn_oder.Location = new System.Drawing.Point(586, 105);
            this.btn_oder.Name = "btn_oder";
            this.btn_oder.Size = new System.Drawing.Size(75, 23);
            this.btn_oder.TabIndex = 7;
            this.btn_oder.Text = "ODER";
            this.btn_oder.UseVisualStyleBackColor = true;
            this.btn_oder.Click += new System.EventHandler(this.btn_oder_Click);
            // 
            // btn_und
            // 
            this.btn_und.Location = new System.Drawing.Point(586, 147);
            this.btn_und.Name = "btn_und";
            this.btn_und.Size = new System.Drawing.Size(75, 23);
            this.btn_und.TabIndex = 8;
            this.btn_und.Text = "UND";
            this.btn_und.UseVisualStyleBackColor = true;
            this.btn_und.Click += new System.EventHandler(this.btn_und_Click);
            // 
            // btn_rechts
            // 
            this.btn_rechts.Location = new System.Drawing.Point(586, 187);
            this.btn_rechts.Name = "btn_rechts";
            this.btn_rechts.Size = new System.Drawing.Size(75, 23);
            this.btn_rechts.TabIndex = 9;
            this.btn_rechts.Text = ">>";
            this.btn_rechts.UseVisualStyleBackColor = true;
            this.btn_rechts.Click += new System.EventHandler(this.btn_rechts_Click);
            // 
            // btn_links
            // 
            this.btn_links.Location = new System.Drawing.Point(586, 230);
            this.btn_links.Name = "btn_links";
            this.btn_links.Size = new System.Drawing.Size(75, 23);
            this.btn_links.TabIndex = 10;
            this.btn_links.Text = "<<";
            this.btn_links.UseVisualStyleBackColor = true;
            this.btn_links.Click += new System.EventHandler(this.btn_links_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_links);
            this.Controls.Add(this.btn_rechts);
            this.Controls.Add(this.btn_und);
            this.Controls.Add(this.btn_oder);
            this.Controls.Add(this.btn_Einserkomplement);
            this.Controls.Add(this.txtBox_ergebnis);
            this.Controls.Add(this.lbl_Ergebnis);
            this.Controls.Add(this.txtBox_zahl2);
            this.Controls.Add(this.lbl_zahl2);
            this.Controls.Add(this.txtBox_zahl1);
            this.Controls.Add(this.lbl_zahl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_zahl1;
        private System.Windows.Forms.TextBox txtBox_zahl1;
        private System.Windows.Forms.Label lbl_zahl2;
        private System.Windows.Forms.TextBox txtBox_zahl2;
        private System.Windows.Forms.Label lbl_Ergebnis;
        private System.Windows.Forms.TextBox txtBox_ergebnis;
        private System.Windows.Forms.Button btn_Einserkomplement;
        private System.Windows.Forms.Button btn_oder;
        private System.Windows.Forms.Button btn_und;
        private System.Windows.Forms.Button btn_rechts;
        private System.Windows.Forms.Button btn_links;
    }
}

