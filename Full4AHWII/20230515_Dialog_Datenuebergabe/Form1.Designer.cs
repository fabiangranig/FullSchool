namespace _20230515_Dialog_Datenuebergabe
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
            this.txtBox_Hauptformular = new System.Windows.Forms.TextBox();
            this.btn_Datenuebergabe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_Hauptformular
            // 
            this.txtBox_Hauptformular.Location = new System.Drawing.Point(12, 12);
            this.txtBox_Hauptformular.Name = "txtBox_Hauptformular";
            this.txtBox_Hauptformular.Size = new System.Drawing.Size(191, 20);
            this.txtBox_Hauptformular.TabIndex = 0;
            // 
            // btn_Datenuebergabe
            // 
            this.btn_Datenuebergabe.Location = new System.Drawing.Point(12, 38);
            this.btn_Datenuebergabe.Name = "btn_Datenuebergabe";
            this.btn_Datenuebergabe.Size = new System.Drawing.Size(191, 23);
            this.btn_Datenuebergabe.TabIndex = 1;
            this.btn_Datenuebergabe.Text = "Datenübergabe";
            this.btn_Datenuebergabe.UseVisualStyleBackColor = true;
            this.btn_Datenuebergabe.Click += new System.EventHandler(this.btn_Datenuebergabe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 72);
            this.Controls.Add(this.btn_Datenuebergabe);
            this.Controls.Add(this.txtBox_Hauptformular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Hauptformular;
        private System.Windows.Forms.Button btn_Datenuebergabe;
    }
}

