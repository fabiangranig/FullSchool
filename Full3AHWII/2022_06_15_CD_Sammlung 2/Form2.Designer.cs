
namespace _20220615_CD_Sammlung
{
    partial class Form2
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_nichtok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(156, 57);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_nichtok
            // 
            this.btn_nichtok.Location = new System.Drawing.Point(66, 57);
            this.btn_nichtok.Name = "btn_nichtok";
            this.btn_nichtok.Size = new System.Drawing.Size(75, 23);
            this.btn_nichtok.TabIndex = 1;
            this.btn_nichtok.Text = "Nicht ok";
            this.btn_nichtok.UseVisualStyleBackColor = true;
            this.btn_nichtok.Click += new System.EventHandler(this.btn_nichtok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hinweis: Soeben eigegebene Daten gehen verloren!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 123);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_nichtok);
            this.Controls.Add(this.btn_ok);
            this.Name = "Form2";
            this.Text = "Hinweis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_nichtok;
        private System.Windows.Forms.Label label1;
    }
}