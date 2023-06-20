using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230522_MiniEditor
{
    class WindowErsetzen : Form
    {
        private RichTextBox _TextBox;

        private TextBox txtBox_ShouldReplace;
        private Label lbl_Von;
        private Label lbl_Zu;
        private Button btn_AlleErsetzen;
        private TextBox txtBox_BeReplaced;

        public WindowErsetzen(ref RichTextBox richTextBox1)
        {
            _TextBox = richTextBox1;

            //Create the components
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtBox_ShouldReplace = new System.Windows.Forms.TextBox();
            this.txtBox_BeReplaced = new System.Windows.Forms.TextBox();
            this.lbl_Von = new System.Windows.Forms.Label();
            this.lbl_Zu = new System.Windows.Forms.Label();
            this.btn_AlleErsetzen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_ShouldReplace
            // 
            this.txtBox_ShouldReplace.Location = new System.Drawing.Point(12, 29);
            this.txtBox_ShouldReplace.Name = "txtBox_ShouldReplace";
            this.txtBox_ShouldReplace.Size = new System.Drawing.Size(100, 22);
            this.txtBox_ShouldReplace.TabIndex = 0;
            // 
            // txtBox_BeReplaced
            // 
            this.txtBox_BeReplaced.Location = new System.Drawing.Point(138, 29);
            this.txtBox_BeReplaced.Name = "txtBox_BeReplaced";
            this.txtBox_BeReplaced.Size = new System.Drawing.Size(100, 22);
            this.txtBox_BeReplaced.TabIndex = 1;
            // 
            // lbl_Von
            // 
            this.lbl_Von.AutoSize = true;
            this.lbl_Von.Location = new System.Drawing.Point(12, 9);
            this.lbl_Von.Name = "lbl_Von";
            this.lbl_Von.Size = new System.Drawing.Size(37, 17);
            this.lbl_Von.TabIndex = 2;
            this.lbl_Von.Text = "Von:";
            // 
            // lbl_Zu
            // 
            this.lbl_Zu.AutoSize = true;
            this.lbl_Zu.Location = new System.Drawing.Point(135, 9);
            this.lbl_Zu.Name = "lbl_Zu";
            this.lbl_Zu.Size = new System.Drawing.Size(29, 17);
            this.lbl_Zu.TabIndex = 3;
            this.lbl_Zu.Text = "Zu:";
            // 
            // btn_AlleErsetzen
            // 
            this.btn_AlleErsetzen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlleErsetzen.Location = new System.Drawing.Point(257, 12);
            this.btn_AlleErsetzen.Name = "btn_AlleErsetzen";
            this.btn_AlleErsetzen.Size = new System.Drawing.Size(93, 39);
            this.btn_AlleErsetzen.TabIndex = 4;
            this.btn_AlleErsetzen.Text = "Ersetzen";
            this.btn_AlleErsetzen.UseVisualStyleBackColor = true;
            this.btn_AlleErsetzen.Click += new System.EventHandler(this.btn_AlleErsetzen_Click);
            // 
            // WindowErsetzen
            // 
            this.ClientSize = new System.Drawing.Size(366, 63);
            this.Controls.Add(this.btn_AlleErsetzen);
            this.Controls.Add(this.lbl_Zu);
            this.Controls.Add(this.lbl_Von);
            this.Controls.Add(this.txtBox_BeReplaced);
            this.Controls.Add(this.txtBox_ShouldReplace);
            this.Name = "WindowErsetzen";
            this.Text = "Ersetzen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_AlleErsetzen_Click(object sender, EventArgs e)
        {
            _TextBox.Text = _TextBox.Text.Replace(txtBox_ShouldReplace.Text, txtBox_BeReplaced.Text);
        }
    }
}
