namespace _20220427_ListBoxWechsler
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
            this.lB1 = new System.Windows.Forms.ListBox();
            this.lB2 = new System.Windows.Forms.ListBox();
            this.btn_nachRechts = new System.Windows.Forms.Button();
            this.btn_nachLinks = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_alldelete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Laden = new System.Windows.Forms.Button();
            this.btn_SaveBinaer = new System.Windows.Forms.Button();
            this.btn_LoadBinaer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lB1
            // 
            this.lB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB1.FormattingEnabled = true;
            this.lB1.ItemHeight = 24;
            this.lB1.Location = new System.Drawing.Point(22, 22);
            this.lB1.Margin = new System.Windows.Forms.Padding(6);
            this.lB1.Name = "lB1";
            this.lB1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lB1.Size = new System.Drawing.Size(481, 628);
            this.lB1.TabIndex = 0;
            // 
            // lB2
            // 
            this.lB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB2.FormattingEnabled = true;
            this.lB2.ItemHeight = 24;
            this.lB2.Location = new System.Drawing.Point(961, 22);
            this.lB2.Margin = new System.Windows.Forms.Padding(6);
            this.lB2.Name = "lB2";
            this.lB2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lB2.Size = new System.Drawing.Size(481, 628);
            this.lB2.TabIndex = 1;
            // 
            // btn_nachRechts
            // 
            this.btn_nachRechts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nachRechts.Location = new System.Drawing.Point(517, 22);
            this.btn_nachRechts.Margin = new System.Windows.Forms.Padding(6);
            this.btn_nachRechts.Name = "btn_nachRechts";
            this.btn_nachRechts.Size = new System.Drawing.Size(433, 159);
            this.btn_nachRechts.TabIndex = 2;
            this.btn_nachRechts.Text = ">>";
            this.btn_nachRechts.UseVisualStyleBackColor = true;
            this.btn_nachRechts.Click += new System.EventHandler(this.btn_nachRechts_Click);
            // 
            // btn_nachLinks
            // 
            this.btn_nachLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nachLinks.Location = new System.Drawing.Point(517, 192);
            this.btn_nachLinks.Margin = new System.Windows.Forms.Padding(6);
            this.btn_nachLinks.Name = "btn_nachLinks";
            this.btn_nachLinks.Size = new System.Drawing.Size(433, 159);
            this.btn_nachLinks.TabIndex = 3;
            this.btn_nachLinks.Text = "<<";
            this.btn_nachLinks.UseVisualStyleBackColor = true;
            this.btn_nachLinks.Click += new System.EventHandler(this.btn_nachLinks_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(517, 362);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(433, 159);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Löschen";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(1012, 665);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(433, 159);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Beenden";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_alldelete
            // 
            this.btn_alldelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alldelete.Location = new System.Drawing.Point(517, 532);
            this.btn_alldelete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_alldelete.Name = "btn_alldelete";
            this.btn_alldelete.Size = new System.Drawing.Size(433, 159);
            this.btn_alldelete.TabIndex = 6;
            this.btn_alldelete.Text = "Alles löschen";
            this.btn_alldelete.UseVisualStyleBackColor = true;
            this.btn_alldelete.Click += new System.EventHandler(this.btn_alldelete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(22, 665);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(236, 78);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Speichern";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Laden
            // 
            this.btn_Laden.Location = new System.Drawing.Point(22, 746);
            this.btn_Laden.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Laden.Name = "btn_Laden";
            this.btn_Laden.Size = new System.Drawing.Size(236, 78);
            this.btn_Laden.TabIndex = 8;
            this.btn_Laden.Text = "Laden";
            this.btn_Laden.UseVisualStyleBackColor = true;
            this.btn_Laden.Click += new System.EventHandler(this.btn_Laden_Click);
            // 
            // btn_SaveBinaer
            // 
            this.btn_SaveBinaer.Location = new System.Drawing.Point(267, 665);
            this.btn_SaveBinaer.Margin = new System.Windows.Forms.Padding(6);
            this.btn_SaveBinaer.Name = "btn_SaveBinaer";
            this.btn_SaveBinaer.Size = new System.Drawing.Size(236, 78);
            this.btn_SaveBinaer.TabIndex = 9;
            this.btn_SaveBinaer.Text = "Speichern Binär";
            this.btn_SaveBinaer.UseVisualStyleBackColor = true;
            this.btn_SaveBinaer.Click += new System.EventHandler(this.btn_SaveBinaer_Click);
            // 
            // btn_LoadBinaer
            // 
            this.btn_LoadBinaer.Location = new System.Drawing.Point(267, 746);
            this.btn_LoadBinaer.Margin = new System.Windows.Forms.Padding(6);
            this.btn_LoadBinaer.Name = "btn_LoadBinaer";
            this.btn_LoadBinaer.Size = new System.Drawing.Size(236, 78);
            this.btn_LoadBinaer.TabIndex = 10;
            this.btn_LoadBinaer.Text = "Laden Binär";
            this.btn_LoadBinaer.UseVisualStyleBackColor = true;
            this.btn_LoadBinaer.Click += new System.EventHandler(this.btn_LoadBinaer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.btn_LoadBinaer);
            this.Controls.Add(this.btn_SaveBinaer);
            this.Controls.Add(this.btn_Laden);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_alldelete);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_nachLinks);
            this.Controls.Add(this.btn_nachRechts);
            this.Controls.Add(this.lB2);
            this.Controls.Add(this.lB1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "ListBox Wechsler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lB1;
        private System.Windows.Forms.ListBox lB2;
        private System.Windows.Forms.Button btn_nachRechts;
        private System.Windows.Forms.Button btn_nachLinks;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_alldelete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Laden;
        private System.Windows.Forms.Button btn_SaveBinaer;
        private System.Windows.Forms.Button btn_LoadBinaer;
    }
}

