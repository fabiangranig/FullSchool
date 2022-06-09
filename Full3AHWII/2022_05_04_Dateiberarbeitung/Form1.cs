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

namespace _20220504_Dateiverarbeitung
{
    public partial class Form1 : Form
    {
        private Klasse KL;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_AnlegenKlasse_Click(object sender, EventArgs e)
        {
            //Anlegen einer Klasse
            this.KL = new Klasse(txt_KlasseName.Text, Int32.Parse(txt_SchuelerAnzahl.Text));

            //Labels clearen
            txt_KlasseName.Text = "";
            txt_SchuelerAnzahl.Text = "";

            //Die Listbox clearen
            listBox1.Items.Clear();
        }

        private void btn_EingebenSchueler_Click(object sender, EventArgs e)
        {
            //Werte aus den Feldern erhalten
            int KatNr = Int32.Parse(txt_KatNr.Text);
            string Vorname = txt_Vorname.Text;
            string Nachname = txt_Nachname.Text;

            //Felder clearen
            txt_KatNr.Text = "";
            txt_Vorname.Text = "";
            txt_Nachname.Text = "";

            //Eingabe des Schülers in die Datenbank
            bool switch1 = KL.Eingabe(KatNr, Vorname, Nachname);
            if(switch1 == true)
            {
                Schueler s_temp = new Schueler(KatNr, Vorname, Nachname);
                listBox1.Items.Add(s_temp.toString());
            }
        }

        private void btn_Beenden_Click(object sender, EventArgs e)
        {
            //Die Anwendung schließen
            this.Close();
        }

        private void btn_SpeichernText_Click(object sender, EventArgs e)
        {
            //FileStream erstellen
            FileStream fs = new FileStream("Save.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            //Zuerst Klassenname speichern
            sw.WriteLine(this.KL._Name);

            //Dann Schüleranzahl speichern
            sw.WriteLine(Convert.ToString(this.KL.GetAnzahl()));

            //Alle Namen der Klasse speichern
            for(int i = 0; i < this.KL.GetAnzahl(); i++)
            {
                if(this.KL._KL_Schueler[i].GetKatNr() != -1)
                {
                    sw.WriteLine(Convert.ToString(this.KL._KL_Schueler[i].GetKatNr()));
                    sw.WriteLine(Convert.ToString(this.KL._KL_Schueler[i].GetVorname()));
                    sw.WriteLine(Convert.ToString(this.KL._KL_Schueler[i].GetNachname()));
                }
                else
                {
                    sw.WriteLine("empty");
                }
            }

            //Den Editor schließen
            sw.Close();
            fs.Close();
        }

        private void btn_LadenText_Click(object sender, EventArgs e)
        {
            //FileStream erstellen
            FileStream zeichen = new FileStream("Save.txt", FileMode.Open);
            StreamReader lesen = new StreamReader(zeichen);

            //Daten in ein String Array laden
            string klassenname = lesen.ReadLine();
            int anzahl = Int32.Parse(lesen.ReadLine());
            string[] arr = new string[anzahl*3];
            string zeilen = " ";
            int count = 0;
            zeilen = lesen.ReadLine();
            while (zeilen != null)
            {
                arr[count] = zeilen;
                count++;
                zeilen = lesen.ReadLine();
            }

            lesen.Close();

            //Klasse Klasse erstellen
            this.KL = new Klasse(klassenname, anzahl);

            //Textbox clearen
            listBox1.Items.Clear();

            //Die Schüler in die Klasse Klasse hinzufügen (Wichtig! Mit der Funktion Eingabe)
            for(int i = 0; i < anzahl*3; i = i + 3)
            {
                //Wenn alle Werte eingegeben wurden, null returnen
                if(arr[i] == "empty")
                {
                    break;
                }

                //Wirkliches hinzufügen
                bool switch1 = this.KL.Eingabe(Int32.Parse(arr[i]), arr[i+1], arr[i+2]);
                if (switch1 == true)
                {
                    listBox1.Items.Add(arr[i] + ";" + arr[i+1] + ";" + arr[i+2]);
                }
            }
        }

        private void btn_SpeichernBinaer_Click(object sender, EventArgs e)
        {
            //FileStream erstellen
            FileStream fs = new FileStream("Save.dat", FileMode.Create);
            BinaryWriter sw = new BinaryWriter(fs);

            //Zuerst Klassenname speichern
            sw.Write(this.KL._Name);

            //Dann Schüleranzahl speichern
            sw.Write(Convert.ToString(this.KL.GetAnzahl()));

            //Alle Namen der Klasse speichern
            for (int i = 0; i < this.KL.GetAnzahl(); i++)
            {
                if (this.KL._KL_Schueler[i].GetKatNr() != -1)
                {
                    sw.Write(Convert.ToString(this.KL._KL_Schueler[i].GetKatNr()));
                    sw.Write(Convert.ToString(this.KL._KL_Schueler[i].GetVorname()));
                    sw.Write(Convert.ToString(this.KL._KL_Schueler[i].GetNachname()));
                }
                else
                {
                    sw.Write("empty");
                }
            }

            //Den Editor schließen
            sw.Close();
            fs.Close();
        }

        private void btn_LadenBinär_Click(object sender, EventArgs e)
        {
            //FileStream erstellen
            FileStream zeichen = new FileStream("Save.dat", FileMode.Open);
            BinaryReader lesen = new BinaryReader(zeichen);

            //Daten in ein String Array laden
            string klassenname = lesen.ReadString();
            int anzahl = Int32.Parse(lesen.ReadString());
            string[] arr = new string[anzahl*3];
            string zeilen = " ";
            int count = 0;
            zeilen = lesen.ReadString();
            while (lesen.PeekChar() > -1)
            {
                arr[count] = zeilen;
                count++;
                zeilen = lesen.ReadString();
            }

            lesen.Close();

            //Klasse Klasse erstellen
            this.KL = new Klasse(klassenname, anzahl);

            //Textbox clearen
            listBox1.Items.Clear();

            //Die Schüler in die Klasse Klasse hinzufügen (Wichtig! Mit der Funktion Eingabe)
            for (int i = 0; i < anzahl*3; i = i + 3)
            {
                //Wenn alle Werte eingegeben wurden, null returnen
                if (arr[i] == "empty")
                {
                    break;
                }

                //Wirkliches hinzufügen
                bool switch1 = this.KL.Eingabe(Int32.Parse(arr[i]), arr[i+1], arr[i+2]);
                if (switch1 == true)
                {
                    listBox1.Items.Add(arr[i] + ";" + arr[i+1] + ";" + arr[i+2]);
                }
            }
        }
    }

    //Klasse Schüler
    class Schueler
    {
        //Variablen der Klasse Schüler
        private int KatNr;
        private string Vorname;
        private string Nachname;

        //Konstruktoren
        //Standart Konstruktor
        public Schueler()
        {
            this.KatNr = -1;
            this.Vorname = "";
            this.Nachname = "";
        }

        //normalen Konstruktor
        public Schueler(int KatNr1, string Vorname1, string Nachname1)
        {
            this.KatNr = KatNr1;
            this.Vorname = Vorname1;
            this.Nachname = Nachname1;
        }

        //Methoden
        //Methode zurückgeben der Informationen
        public string toString()
        {
            //Den kompletten String bauen
            string sol = Convert.ToString(this.KatNr) + ";" + this.Vorname + ";" + this.Nachname;

            //Das Ergebnis zurückgeben
            return sol;
        }

        //Methode um die Katalog Nummer zurückzugeben
        public int GetKatNr()
        {
            //Den Wert zurückgeben
            return this.KatNr;
        }

        //Methode um den Vornamen zurückzugeben
        public string GetVorname()
        {
            //Den Wert zurückgeben
            return this.Vorname;
        }

        //Methode um den Nachnamen zurückzugeben
        public string GetNachname()
        {
            //Den Wert zurückgeben
            return this.Nachname;
        }
    }

    //Klasse Klasse
    class Klasse
    {
        //Variablen der Klasse
        private string Name;
        private int AnzahlderSchueler;
        private Schueler[] KL_Schueler;

        //Kapselung machen
        public Schueler[] _KL_Schueler
        {
            get { return KL_Schueler; }
        }

        //Konstruktoren
        //Standart Konstruktor
        public Klasse()
        {
            this.Name = "";
            this.AnzahlderSchueler = 0;
            this.KL_Schueler = new Schueler[this.AnzahlderSchueler];

            //Array mit leeren Elementen füllen
            for (int i = 0; i < KL_Schueler.Length; i++)
            {
                KL_Schueler[i] = new Schueler();
            }
        }

        //überladener Konstruktor
        public Klasse(string Name1, int AnzahlderSchueler1)
        {
            this.Name = Name1;
            this.AnzahlderSchueler = AnzahlderSchueler1;
            this.KL_Schueler = new Schueler[AnzahlderSchueler1];

            //Array mit leeren Elementen füllen
            for(int i = 0; i < KL_Schueler.Length; i++)
            {
                KL_Schueler[i] = new Schueler();
            }
        }

        //Kapselung
        public string _Name
        {
            get { return Name; }
        }

        //Methoden
        //Methode Schüler zurückgeben
        public Schueler Ausgabe(int i)
        {
            //Den Schueler zurückgeben
            return this.KL_Schueler[i];
        }

        //Methode zum Zurückgeben der Anzahl der Schüler
        public int GetAnzahl()
        {
            //Diesen Wert zurückgeben
            return this.AnzahlderSchueler;
        }

        //Methode um einen Schüler ins Array einzufüllen
        public bool Eingabe(int KatNr1, string Vorname1, string Nachname1)
        {
            //Durchgehen mit for-Schleife und schauen ob noch ein Platz frei ist
            int for_sol = -1;
            for(int i = 0; i < this.KL_Schueler.Length; i++)
            {
                if(this.KL_Schueler[i].GetKatNr() == -1)
                {
                    for_sol = i;
                    break;
                }
            }

            //Wenn kein freier Platz gefunden wurde soll die Methode geschlossen werden
            if(for_sol == -1)
            {
                return false;
            }

            //Wenn ein Platz frei ist sollen die Werte eingefügt werden
            Schueler temp = new Schueler(KatNr1, Vorname1, Nachname1);
            KL_Schueler[for_sol] = temp;

            //Dadurch das man den Schüler hinzugefügt hat, true zurückgeben
            return true;
        }
    }
}
