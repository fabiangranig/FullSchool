namespace _20240124_MiniPaint
{
    partial class Form_Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Paint));
            this.pictureBox_PaintingField = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_currentMousePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox_ResizeDiagonal = new System.Windows.Forms.PictureBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PaintingField)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ResizeDiagonal)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_PaintingField
            // 
            this.pictureBox_PaintingField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_PaintingField.Location = new System.Drawing.Point(0, 52);
            this.pictureBox_PaintingField.Name = "pictureBox_PaintingField";
            this.pictureBox_PaintingField.Size = new System.Drawing.Size(626, 329);
            this.pictureBox_PaintingField.TabIndex = 0;
            this.pictureBox_PaintingField.TabStop = false;
            this.pictureBox_PaintingField.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_PaintingField_Paint);
            this.pictureBox_PaintingField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_PaintingField_MouseDown);
            this.pictureBox_PaintingField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_PaintingField_MouseMove);
            this.pictureBox_PaintingField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_PaintingField_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_currentMousePosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_currentMousePosition
            // 
            this.toolStripStatusLabel_currentMousePosition.Name = "toolStripStatusLabel_currentMousePosition";
            this.toolStripStatusLabel_currentMousePosition.Size = new System.Drawing.Size(127, 17);
            this.toolStripStatusLabel_currentMousePosition.Text = "                                        ";
            // 
            // pictureBox_ResizeDiagonal
            // 
            this.pictureBox_ResizeDiagonal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_ResizeDiagonal.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pictureBox_ResizeDiagonal.Location = new System.Drawing.Point(627, 384);
            this.pictureBox_ResizeDiagonal.Name = "pictureBox_ResizeDiagonal";
            this.pictureBox_ResizeDiagonal.Size = new System.Drawing.Size(10, 10);
            this.pictureBox_ResizeDiagonal.TabIndex = 4;
            this.pictureBox_ResizeDiagonal.TabStop = false;
            this.pictureBox_ResizeDiagonal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ResizeDiagonal_MouseDown);
            this.pictureBox_ResizeDiagonal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ResizeDiagonal_MouseMove);
            this.pictureBox_ResizeDiagonal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ResizeDiagonal_MouseUp);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // Form_Paint
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_ResizeDiagonal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox_PaintingField);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Paint";
            this.Text = "MiniPaint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PaintingField)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ResizeDiagonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_PaintingField;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_currentMousePosition;
        private System.Windows.Forms.PictureBox pictureBox_ResizeDiagonal;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

