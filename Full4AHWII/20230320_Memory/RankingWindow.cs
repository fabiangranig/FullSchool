using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230320_Memory
{
    class RankingWindow : Form
    {
        private Label lbl_Rangliste;
        private RichTextBox RTB_Display;
        private Button btn_Close;
        private C_Ranking _Rankings;

        //Constructor
        public RankingWindow(ref C_Ranking rankings1)
        {
            //Get the shortcut to the rankings
            _Rankings = rankings1;
            _Rankings.GetScoresFromTxt();

            //Get all components
            InitializeComponent();

            //Fill in all rankings
            List<C_NameWithScore> score_list = _Rankings.NamesWithScores;
            for(int i = 0; i < score_list.Count; i++)
            {
                if(i == 0)
                {
                    RTB_Display.Text += score_list[i]._Name + " (Score: " + score_list[i]._Score + ")";
                }
                else
                {
                    RTB_Display.Text += "\n" + score_list[i]._Name + " (Score: " + score_list[i]._Score + ")";
                }
            }
        }

        private void InitializeComponent()
        {
            this.lbl_Rangliste = new System.Windows.Forms.Label();
            this.RTB_Display = new System.Windows.Forms.RichTextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Rangliste
            // 
            this.lbl_Rangliste.AutoSize = true;
            this.lbl_Rangliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rangliste.Location = new System.Drawing.Point(29, 9);
            this.lbl_Rangliste.Name = "lbl_Rangliste";
            this.lbl_Rangliste.Size = new System.Drawing.Size(155, 33);
            this.lbl_Rangliste.TabIndex = 0;
            this.lbl_Rangliste.Text = "Rangliste:";
            // 
            // RTB_Display
            // 
            this.RTB_Display.Location = new System.Drawing.Point(18, 45);
            this.RTB_Display.Name = "RTB_Display";
            this.RTB_Display.Size = new System.Drawing.Size(182, 342);
            this.RTB_Display.TabIndex = 1;
            this.RTB_Display.Text = "";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(18, 393);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(182, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Schließen!";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // RankingWindow
            // 
            this.ClientSize = new System.Drawing.Size(217, 434);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.RTB_Display);
            this.Controls.Add(this.lbl_Rangliste);
            this.Name = "RankingWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
