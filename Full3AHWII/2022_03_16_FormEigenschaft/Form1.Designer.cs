namespace _20220316_FormEigenschaft
{
    partial class Form_Window
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
            this.label_text = new System.Windows.Forms.Label();
            this.button_change_Layout = new System.Windows.Forms.Button();
            this.button_layout_reset = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_text.ForeColor = System.Drawing.Color.Snow;
            this.label_text.Location = new System.Drawing.Point(62, 36);
            this.label_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(189, 23);
            this.label_text.TabIndex = 0;
            this.label_text.Text = "Mein erstes Formular";
            // 
            // button_change_Layout
            // 
            this.button_change_Layout.BackColor = System.Drawing.Color.Blue;
            this.button_change_Layout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_change_Layout.Location = new System.Drawing.Point(33, 111);
            this.button_change_Layout.Margin = new System.Windows.Forms.Padding(4);
            this.button_change_Layout.Name = "button_change_Layout";
            this.button_change_Layout.Size = new System.Drawing.Size(131, 34);
            this.button_change_Layout.TabIndex = 1;
            this.button_change_Layout.Text = "Layout ändern";
            this.button_change_Layout.UseVisualStyleBackColor = false;
            this.button_change_Layout.Click += new System.EventHandler(this.button_change_Layout_Click);
            // 
            // button_layout_reset
            // 
            this.button_layout_reset.BackColor = System.Drawing.Color.Blue;
            this.button_layout_reset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_layout_reset.Location = new System.Drawing.Point(172, 111);
            this.button_layout_reset.Margin = new System.Windows.Forms.Padding(4);
            this.button_layout_reset.Name = "button_layout_reset";
            this.button_layout_reset.Size = new System.Drawing.Size(149, 34);
            this.button_layout_reset.TabIndex = 2;
            this.button_layout_reset.Text = "Layout zurücksetzen";
            this.button_layout_reset.UseVisualStyleBackColor = false;
            this.button_layout_reset.Click += new System.EventHandler(this.button_layout_reset_Click);
            // 
            // button_Ok
            // 
            this.button_Ok.BackColor = System.Drawing.Color.Blue;
            this.button_Ok.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button_Ok.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Ok.Location = new System.Drawing.Point(329, 111);
            this.button_Ok.Margin = new System.Windows.Forms.Padding(4);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(112, 34);
            this.button_Ok.TabIndex = 3;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = false;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // Form_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(464, 161);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.button_layout_reset);
            this.Controls.Add(this.button_change_Layout);
            this.Controls.Add(this.label_text);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Username: Granig";
            this.Load += new System.EventHandler(this.Form_Start);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Button button_change_Layout;
        private System.Windows.Forms.Button button_layout_reset;
        private System.Windows.Forms.Button button_Ok;
    }
}

