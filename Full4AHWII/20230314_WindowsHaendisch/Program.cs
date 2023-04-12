using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230314_WindowsHaendisch
{
    class MyForm : Form
    {
        private Button OKButton;
        private Button BerechnenButton;

        private TextBox textBoxZahl1;
        private TextBox textBoxZahl2;

        private Label labelZahl1;
        private Label labelZahl2;
        private Label labelSolText;
        private Label labelSol;

        public MyForm()
        {
            //Form
            this.Text = "einfacher Rechner";

            this.Size = new System.Drawing.Size(300, 200);

            //Buttons
            OKButton = new Button();
            OKButton.Text = "OK";
            OKButton.Size = new System.Drawing.Size(100,30);
            OKButton.Location = new System.Drawing.Point(140, 120);

            BerechnenButton = new Button();
            BerechnenButton.Text = "Berechnen";
            BerechnenButton.Size = new System.Drawing.Size(100, 30);
            BerechnenButton.Location = new System.Drawing.Point(30, 120);

            //Labels
            labelZahl1 = new Label();
            labelZahl1.Text = "Zahl1: ";
            labelZahl1.Size = new System.Drawing.Size(50, 15);
            labelZahl1.Location = new System.Drawing.Point(30, 10);

            labelZahl2 = new Label();
            labelZahl2.Text = "Zahl2: ";
            labelZahl2.Size = new System.Drawing.Size(100, 15);
            labelZahl2.Location = new System.Drawing.Point(130, 10);

            labelSolText = new Label();
            labelSolText.Text = "Lösung:";
            labelSolText.Size = new System.Drawing.Size(50, 15);
            labelSolText.Location = new System.Drawing.Point(30, 60);

            labelSol = new Label();
            labelSol.Text = "noch keine Berechnung";
            labelSol.Size = new System.Drawing.Size(200, 40);
            labelSol.Location = new System.Drawing.Point(30, 80);

            //TextBox
            textBoxZahl1 = new TextBox();
            textBoxZahl1.Size = new System.Drawing.Size(100, 20);
            textBoxZahl1.Location = new System.Drawing.Point(30, 30);

            textBoxZahl2 = new TextBox();
            textBoxZahl2.Size = new System.Drawing.Size(100, 20);
            textBoxZahl2.Location = new System.Drawing.Point(130, 30);

            //Actionen
            OKButton.Click += new EventHandler(OKButton_Click);
            BerechnenButton.Click += new EventHandler(BerechnenButton_Click);

            //Add buttons
            this.Controls.Add(BerechnenButton);
            this.Controls.Add(OKButton);

            //Add labels
            this.Controls.Add(labelZahl1);
            this.Controls.Add(labelZahl2);
            this.Controls.Add(labelSolText);
            this.Controls.Add(labelSol);

            //Add textboxes
            this.Controls.Add(textBoxZahl1);
            this.Controls.Add(textBoxZahl2);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BerechnenButton_Click(object sender, EventArgs e)
        {
            int a = 0;
            if(Int32.TryParse(textBoxZahl1.Text, out a) && Int32.TryParse(textBoxZahl2.Text, out a))
            {
                labelSol.Text = Convert.ToString(Int32.Parse(textBoxZahl1.Text) + Int32.Parse(textBoxZahl2.Text));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyForm MyDialog = new MyForm();

            MyDialog.ShowDialog();
        }
    }
}
