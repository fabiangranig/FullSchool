using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230320_Memory
{
    class FinishedWindow : Form
    {
        private Button btn_Schließen;
        private Button btn_okey;
        private Label lbl_NameEingeben;
        private TextBox txtBox_Name;
        private MenuStrip menuStrip1;
        private int _Score;
        private C_Ranking _Ranking;

        public FinishedWindow(ref C_Ranking ranking1, int score1)
        {
            _Ranking = ranking1;
            _Score = score1;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btn_Schließen = new System.Windows.Forms.Button();
            this.btn_okey = new System.Windows.Forms.Button();
            this.lbl_NameEingeben = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // btn_Schließen
            // 
            this.btn_Schließen.Location = new System.Drawing.Point(16, 62);
            this.btn_Schließen.Name = "btn_Schließen";
            this.btn_Schließen.Size = new System.Drawing.Size(75, 23);
            this.btn_Schließen.TabIndex = 0;
            this.btn_Schließen.Text = "Schließen";
            this.btn_Schließen.UseVisualStyleBackColor = true;
            this.btn_Schließen.Click += new System.EventHandler(this.btn_Schließen_Click);
            // 
            // btn_okey
            // 
            this.btn_okey.Location = new System.Drawing.Point(125, 62);
            this.btn_okey.Name = "btn_okey";
            this.btn_okey.Size = new System.Drawing.Size(75, 23);
            this.btn_okey.TabIndex = 1;
            this.btn_okey.Text = "Okey!";
            this.btn_okey.UseVisualStyleBackColor = true;
            this.btn_okey.Click += new System.EventHandler(this.btn_okey_Click);
            // 
            // lbl_NameEingeben
            // 
            this.lbl_NameEingeben.AutoSize = true;
            this.lbl_NameEingeben.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameEingeben.Location = new System.Drawing.Point(12, 9);
            this.lbl_NameEingeben.Name = "lbl_NameEingeben";
            this.lbl_NameEingeben.Size = new System.Drawing.Size(166, 24);
            this.lbl_NameEingeben.TabIndex = 2;
            this.lbl_NameEingeben.Text = "Name eingeben:";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(16, 36);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(184, 20);
            this.txtBox_Name.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(233, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // FinishedWindow
            // 
            this.ClientSize = new System.Drawing.Size(233, 108);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.lbl_NameEingeben);
            this.Controls.Add(this.btn_okey);
            this.Controls.Add(this.btn_Schließen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FinishedWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_Schließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_okey_Click(object sender, EventArgs e)
        {
            _Ranking.AddValuesToTxt(txtBox_Name.Text, _Score);
            this.Close();
        }
    }
}
