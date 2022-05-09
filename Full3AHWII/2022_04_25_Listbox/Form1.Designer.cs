namespace _20220425_Listbox
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
            this.lB_1 = new System.Windows.Forms.ListBox();
            this.txtB_1 = new System.Windows.Forms.TextBox();
            this.btn_AnfangAdd = new System.Windows.Forms.Button();
            this.btn_EndeAdd = new System.Windows.Forms.Button();
            this.btn_Entfernen = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Aendern = new System.Windows.Forms.Button();
            this.btn_Beenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lB_1
            // 
            this.lB_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB_1.FormattingEnabled = true;
            this.lB_1.Location = new System.Drawing.Point(48, 57);
            this.lB_1.Name = "lB_1";
            this.lB_1.Size = new System.Drawing.Size(251, 342);
            this.lB_1.TabIndex = 1;
            // 
            // txtB_1
            // 
            this.txtB_1.Location = new System.Drawing.Point(48, 31);
            this.txtB_1.Name = "txtB_1";
            this.txtB_1.Size = new System.Drawing.Size(251, 20);
            this.txtB_1.TabIndex = 2;
            // 
            // btn_AnfangAdd
            // 
            this.btn_AnfangAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnfangAdd.Location = new System.Drawing.Point(327, 57);
            this.btn_AnfangAdd.Name = "btn_AnfangAdd";
            this.btn_AnfangAdd.Size = new System.Drawing.Size(117, 50);
            this.btn_AnfangAdd.TabIndex = 3;
            this.btn_AnfangAdd.Text = "Wert Anfang hinzufügen";
            this.btn_AnfangAdd.UseVisualStyleBackColor = true;
            this.btn_AnfangAdd.Click += new System.EventHandler(this.btn_AnfangAdd_Click);
            // 
            // btn_EndeAdd
            // 
            this.btn_EndeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EndeAdd.Location = new System.Drawing.Point(327, 113);
            this.btn_EndeAdd.Name = "btn_EndeAdd";
            this.btn_EndeAdd.Size = new System.Drawing.Size(117, 50);
            this.btn_EndeAdd.TabIndex = 4;
            this.btn_EndeAdd.Text = "Wert Ende hinzufügen";
            this.btn_EndeAdd.UseVisualStyleBackColor = true;
            this.btn_EndeAdd.Click += new System.EventHandler(this.btn_EndeAdd_Click);
            // 
            // btn_Entfernen
            // 
            this.btn_Entfernen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entfernen.Location = new System.Drawing.Point(327, 169);
            this.btn_Entfernen.Name = "btn_Entfernen";
            this.btn_Entfernen.Size = new System.Drawing.Size(117, 50);
            this.btn_Entfernen.TabIndex = 5;
            this.btn_Entfernen.Text = "Entfernen";
            this.btn_Entfernen.UseVisualStyleBackColor = true;
            this.btn_Entfernen.Click += new System.EventHandler(this.btn_Entfernen_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(327, 225);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(117, 50);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Listbox leeren";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Aendern
            // 
            this.btn_Aendern.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aendern.Location = new System.Drawing.Point(327, 281);
            this.btn_Aendern.Name = "btn_Aendern";
            this.btn_Aendern.Size = new System.Drawing.Size(117, 50);
            this.btn_Aendern.TabIndex = 7;
            this.btn_Aendern.Text = "Ändern";
            this.btn_Aendern.UseVisualStyleBackColor = true;
            this.btn_Aendern.Click += new System.EventHandler(this.btn_Aendern_Click);
            // 
            // btn_Beenden
            // 
            this.btn_Beenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Beenden.Location = new System.Drawing.Point(327, 337);
            this.btn_Beenden.Name = "btn_Beenden";
            this.btn_Beenden.Size = new System.Drawing.Size(117, 50);
            this.btn_Beenden.TabIndex = 8;
            this.btn_Beenden.Text = "Ende";
            this.btn_Beenden.UseVisualStyleBackColor = true;
            this.btn_Beenden.Click += new System.EventHandler(this.btn_Beenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btn_Beenden);
            this.Controls.Add(this.btn_Aendern);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Entfernen);
            this.Controls.Add(this.btn_EndeAdd);
            this.Controls.Add(this.btn_AnfangAdd);
            this.Controls.Add(this.txtB_1);
            this.Controls.Add(this.lB_1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lB_1;
        private System.Windows.Forms.TextBox txtB_1;
        private System.Windows.Forms.Button btn_AnfangAdd;
        private System.Windows.Forms.Button btn_EndeAdd;
        private System.Windows.Forms.Button btn_Entfernen;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Aendern;
        private System.Windows.Forms.Button btn_Beenden;
    }
}

