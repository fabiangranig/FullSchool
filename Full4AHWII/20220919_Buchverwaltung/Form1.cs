using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _20220919_Buchverwaltung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variablen des Buch Arrays
        Buch[] Buchlager = new Buch[10];

        //Funktion: Listboxen aktualisieren
        private void Box_aktualisieren()
        {
            //Listbox clearen
            ListBox1.Items.Clear();

            //ListBox anzeigen
            for (int i = 0; i < Buchlager.Length; i++)
            {
                string[] arr = Buchlager[i].Anzeigen();
                ListBox1.Items.Add("BuchNr: " + arr[0] + "\t" + "Titel: " + arr[1] + "\t" + "Autor: " + arr[2] + "\t" + "Stück: " + arr[3] + "\t\t" + "Stückpreis: " + arr[4]);
            }

            //static Variablen Buch anzeigen
            textBox_GesamtUmsatz.Text = Convert.ToString(Buch._Gesamtumsatz);
            textBox_verkauft.Text = Convert.ToString(Buch._verkauft);
            textBox_geliefert.Text = Convert.ToString(Buch._geliefert);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Einlesen von der .txt in das Array
            FileStream zeichen = new FileStream("save.txt", FileMode.Open);
            StreamReader lesen = new StreamReader(zeichen);

            string zeilen = " ";
            int o = 0;
            while (zeilen != null)
            {
                zeilen = lesen.ReadLine();

                if(zeilen == null)
                {
                    break;
                }

                string[] split = zeilen.Split(' ');
                Buchlager[o] = new Buch(Int32.Parse(split[0]), split[1], split[2], Int32.Parse(split[3]), Convert.ToDouble(split[4]));
                o++;
            }

            lesen.Close();

            //Listbox aktualisieren
            Box_aktualisieren();
        }

        private void button_liefern_Click(object sender, EventArgs e)
        {
            //Liefern und Box aktualisieren
            Buchlager[ListBox1.SelectedIndex].Lieferung(Int32.Parse(textBox_liefern.Text));
            textBox_liefern.Text = "";
            Box_aktualisieren();
        }

        private void button_verkaufen_Click(object sender, EventArgs e)
        {
            //Verkaufen und Box aktualisieren
            Buchlager[ListBox1.SelectedIndex].Verkaufen(Int32.Parse(textBox_verkaufen.Text));
            textBox_verkaufen.Text = "";
            Box_aktualisieren();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lagerumsatz berechenen und ausgeben
            textBox_Lagerumsatz.Text = Convert.ToString(Buchlager[ListBox1.SelectedIndex].Lagerumsatz());
        }
    }
}
