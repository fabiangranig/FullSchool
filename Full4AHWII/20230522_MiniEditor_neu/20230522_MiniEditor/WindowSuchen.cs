using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230522_MiniEditor
{
    class WindowSuchen : Form
    {
        private RichTextBox _RTB;

        private Label lbl_SuchenNach;
        private TextBox textBox_Suchen;
        private Button btn_Weitersuchen;
        private Button btn_Abbrechen;
        private CheckBox checkBox_GrossKleinschreibung;
        private CheckBox checkBox_AmEndeVonVorneBeginnen;
        private GroupBox groupBox_Suchrichtung;
        private RadioButton radioButton_NachUnten;
        private RadioButton radioButton_NachOben;

        private int _Last_Index;

        public WindowSuchen(ref RichTextBox RTB)
        {
            this._RTB = RTB;
            _Last_Index = 0;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lbl_SuchenNach = new System.Windows.Forms.Label();
            this.textBox_Suchen = new System.Windows.Forms.TextBox();
            this.btn_Weitersuchen = new System.Windows.Forms.Button();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.checkBox_GrossKleinschreibung = new System.Windows.Forms.CheckBox();
            this.checkBox_AmEndeVonVorneBeginnen = new System.Windows.Forms.CheckBox();
            this.groupBox_Suchrichtung = new System.Windows.Forms.GroupBox();
            this.radioButton_NachUnten = new System.Windows.Forms.RadioButton();
            this.radioButton_NachOben = new System.Windows.Forms.RadioButton();
            this.groupBox_Suchrichtung.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_SuchenNach
            // 
            this.lbl_SuchenNach.AutoSize = true;
            this.lbl_SuchenNach.Location = new System.Drawing.Point(12, 9);
            this.lbl_SuchenNach.Name = "lbl_SuchenNach";
            this.lbl_SuchenNach.Size = new System.Drawing.Size(95, 17);
            this.lbl_SuchenNach.TabIndex = 0;
            this.lbl_SuchenNach.Text = "Suchen nach:";
            // 
            // textBox_Suchen
            // 
            this.textBox_Suchen.Location = new System.Drawing.Point(92, 6);
            this.textBox_Suchen.Name = "textBox_Suchen";
            this.textBox_Suchen.Size = new System.Drawing.Size(297, 22);
            this.textBox_Suchen.TabIndex = 1;
            // 
            // btn_Weitersuchen
            // 
            this.btn_Weitersuchen.Location = new System.Drawing.Point(395, 6);
            this.btn_Weitersuchen.Name = "btn_Weitersuchen";
            this.btn_Weitersuchen.Size = new System.Drawing.Size(86, 20);
            this.btn_Weitersuchen.TabIndex = 2;
            this.btn_Weitersuchen.Text = "Weitersuchen";
            this.btn_Weitersuchen.UseVisualStyleBackColor = true;
            this.btn_Weitersuchen.Click += new System.EventHandler(this.btn_Weitersuchen_Click);
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(395, 31);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(86, 20);
            this.btn_Abbrechen.TabIndex = 3;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // checkBox_GrossKleinschreibung
            // 
            this.checkBox_GrossKleinschreibung.AutoSize = true;
            this.checkBox_GrossKleinschreibung.Enabled = false;
            this.checkBox_GrossKleinschreibung.Location = new System.Drawing.Point(15, 34);
            this.checkBox_GrossKleinschreibung.Name = "checkBox_GrossKleinschreibung";
            this.checkBox_GrossKleinschreibung.Size = new System.Drawing.Size(173, 21);
            this.checkBox_GrossKleinschreibung.TabIndex = 4;
            this.checkBox_GrossKleinschreibung.Text = "Groß-/Kleinschreibung";
            this.checkBox_GrossKleinschreibung.UseVisualStyleBackColor = true;
            // 
            // checkBox_AmEndeVonVorneBeginnen
            // 
            this.checkBox_AmEndeVonVorneBeginnen.AutoSize = true;
            this.checkBox_AmEndeVonVorneBeginnen.Enabled = false;
            this.checkBox_AmEndeVonVorneBeginnen.Location = new System.Drawing.Point(15, 57);
            this.checkBox_AmEndeVonVorneBeginnen.Name = "checkBox_AmEndeVonVorneBeginnen";
            this.checkBox_AmEndeVonVorneBeginnen.Size = new System.Drawing.Size(217, 21);
            this.checkBox_AmEndeVonVorneBeginnen.TabIndex = 5;
            this.checkBox_AmEndeVonVorneBeginnen.Text = "Am Ende von vorne beginnen";
            this.checkBox_AmEndeVonVorneBeginnen.UseVisualStyleBackColor = true;
            // 
            // groupBox_Suchrichtung
            // 
            this.groupBox_Suchrichtung.Controls.Add(this.radioButton_NachUnten);
            this.groupBox_Suchrichtung.Controls.Add(this.radioButton_NachOben);
            this.groupBox_Suchrichtung.Location = new System.Drawing.Point(188, 31);
            this.groupBox_Suchrichtung.Name = "groupBox_Suchrichtung";
            this.groupBox_Suchrichtung.Size = new System.Drawing.Size(200, 47);
            this.groupBox_Suchrichtung.TabIndex = 6;
            this.groupBox_Suchrichtung.TabStop = false;
            this.groupBox_Suchrichtung.Text = "Suchrichtung";
            // 
            // radioButton_NachUnten
            // 
            this.radioButton_NachUnten.AutoSize = true;
            this.radioButton_NachUnten.Location = new System.Drawing.Point(103, 19);
            this.radioButton_NachUnten.Name = "radioButton_NachUnten";
            this.radioButton_NachUnten.Size = new System.Drawing.Size(102, 21);
            this.radioButton_NachUnten.TabIndex = 1;
            this.radioButton_NachUnten.TabStop = true;
            this.radioButton_NachUnten.Text = "Nach unten";
            this.radioButton_NachUnten.UseVisualStyleBackColor = true;
            // 
            // radioButton_NachOben
            // 
            this.radioButton_NachOben.AutoSize = true;
            this.radioButton_NachOben.Location = new System.Drawing.Point(19, 19);
            this.radioButton_NachOben.Name = "radioButton_NachOben";
            this.radioButton_NachOben.Size = new System.Drawing.Size(98, 21);
            this.radioButton_NachOben.TabIndex = 0;
            this.radioButton_NachOben.TabStop = true;
            this.radioButton_NachOben.Text = "Nach oben";
            this.radioButton_NachOben.UseVisualStyleBackColor = true;
            // 
            // WindowSuchen
            // 
            this.ClientSize = new System.Drawing.Size(492, 90);
            this.Controls.Add(this.groupBox_Suchrichtung);
            this.Controls.Add(this.checkBox_AmEndeVonVorneBeginnen);
            this.Controls.Add(this.checkBox_GrossKleinschreibung);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_Weitersuchen);
            this.Controls.Add(this.textBox_Suchen);
            this.Controls.Add(this.lbl_SuchenNach);
            this.Name = "WindowSuchen";
            this.Text = "Suchen";
            this.groupBox_Suchrichtung.ResumeLayout(false);
            this.groupBox_Suchrichtung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Weitersuchen_Click(object sender, EventArgs e)
        {
            if(radioButton_NachUnten.Checked == true)
            {
                SearchBottom();
            }
            if(radioButton_NachOben.Checked == true)
            {
                SearchTop();
            }
        }

        public void SearchBottom()
        {
            string searched_after = textBox_Suchen.Text;
            int found_position = _RTB.Find(searched_after, _Last_Index, RichTextBoxFinds.MatchCase);
            if(found_position != -1)
            {
                _RTB.Select(found_position, searched_after.Length);
                _Last_Index = found_position + searched_after.Length;
            }
            else
            {
                MessageBox.Show("keine Wert gefunden!");
            }
        }

        public void SearchTop()
        {
            string searched_after = textBox_Suchen.Text;
            int found_position = _RTB.Find(searched_after, 0, _Last_Index, RichTextBoxFinds.Reverse);
            if (found_position != -1)
            {
                _RTB.Select(found_position, searched_after.Length);
                _Last_Index = found_position - 1;

                if(_Last_Index == -1)
                {
                    _Last_Index = 0;
                }
            }
            else
            {
                MessageBox.Show("keine Wert gefunden!");
            }
        }
    }
}
