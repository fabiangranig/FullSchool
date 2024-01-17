namespace _20230115_GDI_Sinus
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
            this.pictureBox_Sinus = new System.Windows.Forms.PictureBox();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.label_QuadraticFunction = new System.Windows.Forms.Label();
            this.label_d = new System.Windows.Forms.Label();
            this.label_a = new System.Windows.Forms.Label();
            this.label_e = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sinus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Sinus
            // 
            this.pictureBox_Sinus.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Sinus.Name = "pictureBox_Sinus";
            this.pictureBox_Sinus.Size = new System.Drawing.Size(801, 451);
            this.pictureBox_Sinus.TabIndex = 0;
            this.pictureBox_Sinus.TabStop = false;
            this.pictureBox_Sinus.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Sinus_Paint);
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(12, 47);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(100, 20);
            this.textBox_a.TabIndex = 1;
            this.textBox_a.TextChanged += new System.EventHandler(this.textbox_TextChange);
            // 
            // textBox_d
            // 
            this.textBox_d.Location = new System.Drawing.Point(12, 99);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(100, 20);
            this.textBox_d.TabIndex = 2;
            this.textBox_d.TextChanged += new System.EventHandler(this.textbox_TextChange);
            // 
            // textBox_e
            // 
            this.textBox_e.Location = new System.Drawing.Point(12, 155);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(100, 20);
            this.textBox_e.TabIndex = 3;
            this.textBox_e.TextChanged += new System.EventHandler(this.textbox_TextChange);
            // 
            // label_QuadraticFunction
            // 
            this.label_QuadraticFunction.AutoSize = true;
            this.label_QuadraticFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_QuadraticFunction.Location = new System.Drawing.Point(12, 9);
            this.label_QuadraticFunction.Name = "label_QuadraticFunction";
            this.label_QuadraticFunction.Size = new System.Drawing.Size(139, 13);
            this.label_QuadraticFunction.TabIndex = 4;
            this.label_QuadraticFunction.Text = "Quadratische Function:";
            // 
            // label_d
            // 
            this.label_d.AutoSize = true;
            this.label_d.Location = new System.Drawing.Point(12, 83);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(16, 13);
            this.label_d.TabIndex = 5;
            this.label_d.Text = "d:";
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(12, 31);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(16, 13);
            this.label_a.TabIndex = 6;
            this.label_a.Text = "a:";
            // 
            // label_e
            // 
            this.label_e.AutoSize = true;
            this.label_e.Location = new System.Drawing.Point(12, 139);
            this.label_e.Name = "label_e";
            this.label_e.Size = new System.Drawing.Size(16, 13);
            this.label_e.TabIndex = 7;
            this.label_e.Text = "e:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_e);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.label_d);
            this.Controls.Add(this.label_QuadraticFunction);
            this.Controls.Add(this.textBox_e);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.pictureBox_Sinus);
            this.Name = "Form1";
            this.Text = "Sinus GDI";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sinus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Sinus;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.Label label_QuadraticFunction;
        private System.Windows.Forms.Label label_d;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_e;
    }
}

