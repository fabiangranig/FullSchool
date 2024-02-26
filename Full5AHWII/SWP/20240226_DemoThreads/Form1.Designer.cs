namespace _20240226_DemoThreads
{
    partial class DemoThreads
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
            this.label_Text1 = new System.Windows.Forms.Label();
            this.button_Start1 = new System.Windows.Forms.Button();
            this.button_thread2 = new System.Windows.Forms.Button();
            this.label_Text2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Text1
            // 
            this.label_Text1.AutoSize = true;
            this.label_Text1.Location = new System.Drawing.Point(12, 9);
            this.label_Text1.Name = "label_Text1";
            this.label_Text1.Size = new System.Drawing.Size(0, 16);
            this.label_Text1.TabIndex = 0;
            // 
            // button_Start1
            // 
            this.button_Start1.Location = new System.Drawing.Point(12, 415);
            this.button_Start1.Name = "button_Start1";
            this.button_Start1.Size = new System.Drawing.Size(102, 23);
            this.button_Start1.TabIndex = 1;
            this.button_Start1.Text = "StartThread";
            this.button_Start1.UseVisualStyleBackColor = true;
            this.button_Start1.Click += new System.EventHandler(this.button_Start1_Click);
            // 
            // button_thread2
            // 
            this.button_thread2.Location = new System.Drawing.Point(120, 415);
            this.button_thread2.Name = "button_thread2";
            this.button_thread2.Size = new System.Drawing.Size(102, 23);
            this.button_thread2.TabIndex = 2;
            this.button_thread2.Text = "Start Thread 2";
            this.button_thread2.UseVisualStyleBackColor = true;
            this.button_thread2.Click += new System.EventHandler(this.button_thread2_Click);
            // 
            // label_Text2
            // 
            this.label_Text2.AutoSize = true;
            this.label_Text2.Location = new System.Drawing.Point(189, 9);
            this.label_Text2.Name = "label_Text2";
            this.label_Text2.Size = new System.Drawing.Size(0, 16);
            this.label_Text2.TabIndex = 3;
            // 
            // DemoThreads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Text2);
            this.Controls.Add(this.button_thread2);
            this.Controls.Add(this.button_Start1);
            this.Controls.Add(this.label_Text1);
            this.Name = "DemoThreads";
            this.Text = "DemoThreads";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DemoThreads_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Text1;
        private System.Windows.Forms.Button button_Start1;
        private System.Windows.Forms.Button button_thread2;
        private System.Windows.Forms.Label label_Text2;
    }
}

