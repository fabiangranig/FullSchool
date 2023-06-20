using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230522_MiniEditor
{
    class WindowInfo : Form
    {
        private LinkLabel linklbl_Webseite;
        private Label lbl_WebsiteAngabe;
        private Label lbl_SchuleAngabe;
        private Label lbl_Schule;
        private Label lbl_NameAngabe;
        private Label lbl_Name;
        private PictureBox pictureBoxTopPicture;
        private Label lbl_Line;

        public WindowInfo()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.linklbl_Webseite = new System.Windows.Forms.LinkLabel();
            this.lbl_WebsiteAngabe = new System.Windows.Forms.Label();
            this.lbl_SchuleAngabe = new System.Windows.Forms.Label();
            this.lbl_Schule = new System.Windows.Forms.Label();
            this.lbl_NameAngabe = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pictureBoxTopPicture = new System.Windows.Forms.PictureBox();
            this.lbl_Line = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // linklbl_Webseite
            // 
            this.linklbl_Webseite.AutoSize = true;
            this.linklbl_Webseite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_Webseite.Location = new System.Drawing.Point(120, 164);
            this.linklbl_Webseite.Name = "linklbl_Webseite";
            this.linklbl_Webseite.Size = new System.Drawing.Size(132, 24);
            this.linklbl_Webseite.TabIndex = 0;
            this.linklbl_Webseite.TabStop = true;
            this.linklbl_Webseite.Text = "fabiangranig.at";
            this.linklbl_Webseite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_Webseite_LinkClicked);
            // 
            // lbl_WebsiteAngabe
            // 
            this.lbl_WebsiteAngabe.AutoSize = true;
            this.lbl_WebsiteAngabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WebsiteAngabe.Location = new System.Drawing.Point(12, 164);
            this.lbl_WebsiteAngabe.Name = "lbl_WebsiteAngabe";
            this.lbl_WebsiteAngabe.Size = new System.Drawing.Size(83, 24);
            this.lbl_WebsiteAngabe.TabIndex = 1;
            this.lbl_WebsiteAngabe.Text = "Website:";
            // 
            // lbl_SchuleAngabe
            // 
            this.lbl_SchuleAngabe.AutoSize = true;
            this.lbl_SchuleAngabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SchuleAngabe.Location = new System.Drawing.Point(12, 126);
            this.lbl_SchuleAngabe.Name = "lbl_SchuleAngabe";
            this.lbl_SchuleAngabe.Size = new System.Drawing.Size(74, 24);
            this.lbl_SchuleAngabe.TabIndex = 2;
            this.lbl_SchuleAngabe.Text = "Schule:";
            // 
            // lbl_Schule
            // 
            this.lbl_Schule.AutoSize = true;
            this.lbl_Schule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Schule.Location = new System.Drawing.Point(120, 126);
            this.lbl_Schule.Name = "lbl_Schule";
            this.lbl_Schule.Size = new System.Drawing.Size(136, 24);
            this.lbl_Schule.TabIndex = 3;
            this.lbl_Schule.Text = "HTL Wolfsberg";
            // 
            // lbl_NameAngabe
            // 
            this.lbl_NameAngabe.AutoSize = true;
            this.lbl_NameAngabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameAngabe.Location = new System.Drawing.Point(12, 90);
            this.lbl_NameAngabe.Name = "lbl_NameAngabe";
            this.lbl_NameAngabe.Size = new System.Drawing.Size(83, 24);
            this.lbl_NameAngabe.TabIndex = 4;
            this.lbl_NameAngabe.Text = "Ersteller:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(120, 90);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(129, 24);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "Fabian Granig";
            // 
            // pictureBoxTopPicture
            // 
            this.pictureBoxTopPicture.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxTopPicture.Name = "pictureBoxTopPicture";
            this.pictureBoxTopPicture.Size = new System.Drawing.Size(244, 50);
            this.pictureBoxTopPicture.TabIndex = 8;
            this.pictureBoxTopPicture.TabStop = false;
            // 
            // lbl_Line
            // 
            this.lbl_Line.AutoSize = true;
            this.lbl_Line.Location = new System.Drawing.Point(9, 65);
            this.lbl_Line.Name = "lbl_Line";
            this.lbl_Line.Size = new System.Drawing.Size(247, 13);
            this.lbl_Line.TabIndex = 9;
            this.lbl_Line.Text = "________________________________________";
            // 
            // WindowInfo
            // 
            this.ClientSize = new System.Drawing.Size(276, 205);
            this.Controls.Add(this.lbl_Line);
            this.Controls.Add(this.pictureBoxTopPicture);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_NameAngabe);
            this.Controls.Add(this.lbl_Schule);
            this.Controls.Add(this.lbl_SchuleAngabe);
            this.Controls.Add(this.lbl_WebsiteAngabe);
            this.Controls.Add(this.linklbl_Webseite);
            this.Name = "WindowInfo";
            this.Text = "Info über Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void linklbl_Webseite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.fabiangranig.at");
        }
    }
}
