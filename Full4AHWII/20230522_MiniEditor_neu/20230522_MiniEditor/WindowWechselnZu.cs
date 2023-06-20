using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230522_MiniEditor
{
    class WindowWechselnZu : Form
    {
        private Label lbl_Zeilennummer;
        private TextBox txtBox_Zeile;
        private Button btn_Ok;
        private Button btn_Beenden;
        private RichTextBox _Textbox;

        public WindowWechselnZu(ref RichTextBox richTextBox1)
        {
            _Textbox = richTextBox1;
        }

        private void InitializeComponent()
        {
            this.lbl_Zeilennummer = new System.Windows.Forms.Label();
            this.txtBox_Zeile = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Beenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Zeilennummer
            // 
            this.lbl_Zeilennummer.AutoSize = true;
            this.lbl_Zeilennummer.Location = new System.Drawing.Point(43, 9);
            this.lbl_Zeilennummer.Name = "lbl_Zeilennummer";
            this.lbl_Zeilennummer.Size = new System.Drawing.Size(102, 17);
            this.lbl_Zeilennummer.TabIndex = 0;
            this.lbl_Zeilennummer.Text = "Zeilennummer:";
            // 
            // txtBox_Zeile
            // 
            this.txtBox_Zeile.Location = new System.Drawing.Point(45, 29);
            this.txtBox_Zeile.Name = "txtBox_Zeile";
            this.txtBox_Zeile.Size = new System.Drawing.Size(100, 22);
            this.txtBox_Zeile.TabIndex = 1;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(15, 57);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 2;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Beenden
            // 
            this.btn_Beenden.Location = new System.Drawing.Point(96, 57);
            this.btn_Beenden.Name = "btn_Beenden";
            this.btn_Beenden.Size = new System.Drawing.Size(75, 23);
            this.btn_Beenden.TabIndex = 3;
            this.btn_Beenden.Text = "Beenden";
            this.btn_Beenden.UseVisualStyleBackColor = true;
            this.btn_Beenden.Click += new System.EventHandler(this.btn_Beenden_Click);
            // 
            // WindowWechselnZu
            // 
            this.ClientSize = new System.Drawing.Size(185, 93);
            this.Controls.Add(this.btn_Beenden);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txtBox_Zeile);
            this.Controls.Add(this.lbl_Zeilennummer);
            this.Name = "WindowWechselnZu";
            this.Text = "Wechseln zu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_Beenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            //int row_number = _Textbox.SelectionStart(Int32.Parse());
        }
    }
}
