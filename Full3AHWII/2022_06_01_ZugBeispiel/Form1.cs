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

namespace _20220601_ZugBeispiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int[] DataReadIn()
        {
            //Die Datei öffnen
            FileStream zeichen = new FileStream("BIN_Log.csv", FileMode.Open);
            StreamReader lesen = new StreamReader(zeichen);

            //Die Nummer auslesen
            List<string> numbers = new List<string>();
            int i = 0;
            string zeile = " ";
            while (zeile != null)
            {
                zeile = lesen.ReadLine();
                numbers.Add(zeile);
                i++;
            }

            //Die Datei schließen
            lesen.Close();

            //Die Liste in ein Array konvertieren
            int[] arr = new Int32[numbers.Count];
            for(int u = 0; u < numbers.Count - 1; u++)
            {
                arr[u] = Int32.Parse(numbers[u]);
            }

            //Den Wert zurückgeben
            return arr;
        }

        static int BitAtPosition(int number, int position)
        {
            //Die Nummer finden um zu vergleichen
            int number_temp = Convert.ToInt32(Math.Pow(2, position));

            //Die beiden mit und verbinden
            int sol = number & number_temp;

            //Ausgeben wenn es vorkommt
            if (sol > 0)
            {
                return 1;
            }

            //Wenn es nicht vorkommt
            return 0;
        }

        static int[] BitsinArr(int data)
        {
            //Ins Array speichern
            int[] Bits = new Int32[8];
            for (int i = 0; i < 8; i++)
            {
                Bits[i] = BitAtPosition(data, i);
            }

            //Das Array zurückgeben
            return Bits;
        }

        static bool CheckByte(int[] Bits)
        {
            //Nachprüfen ob die Bedingungen gegeben sind
            //1.Der Zug fährt
            if (Bits[0] == 0)
            {
                //2.Ampel muss grün sein
                if(Bits[1] == 0)
                {
                    //3. - 5. ist auch egal
                    //6.Tür muss geschlossen sein
                    if(Bits[5] == 0)
                    {
                        //7.Licht muss ein sein
                        if(Bits[6] == 1)
                        {
                            //8.Strom muss ein sein
                            if(Bits[7] == 1)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            //1.Der Zug fährt nicht
            if (Bits[0] == 1)
            {
                //2.Ampel ist egal
                //3. - 5. ist auch egal
                //6. - 8.Auch egal, da der Zug steht
                return true;
            }

            //Falls etwas nicht stimmt false zurückgeben
            return false;
        }

        private void btn_Auslesen_Click(object sender, EventArgs e)
        {
            //Die Datei auslesen
            int[] read = DataReadIn();

            //Zum Schreiben bereitmachen
            FileStream myStream = new FileStream("Fehler.Dat", FileMode.Create);
            BinaryWriter Writer = new BinaryWriter(myStream);

            //Alle Werte ansehen mithilfe einer for-Schleife
            for (int i = 0; i < read.Length - 1; i++)
            {
                //Anzeigen welche Zahl gerade geprüft wird
                lB_Anweisungen.Items.Add("Der " + (i + 1) + ".Byte wird angezeigt.");
                lB_Anweisungen.Items.Add(read[i]);
                string binaer = Convert.ToString(read[i], 2);
                lB_Anweisungen.Items.Add(binaer);

                //Die Bits in ein Array geben
                int[] Bits = BitsinArr(read[i]);

                //Alle Bits ausgeben
                for(int u = 0; u < Bits.Length; u++)
                {
                    //Context
                    string context = "";
                    
                    //Bit 1
                    if(u == 0 && Bits[u] == 0)
                    {
                        context = "Zug fährt";
                    }
                    else if(u == 0 && Bits[u] == 1)
                    {
                        context = "Zug steht";
                    }

                    //Bit 2
                    if (u == 1 && Bits[u] == 0)
                    {
                        context = "Ampel grün";
                    }
                    else if(u == 1 && Bits[u] == 1)
                    {
                        context = "Ampel rot";
                    }

                    //Bit 3
                    if (u == 2 && Bits[u] == 0)
                    {
                        context = "Weiche1 rechts gesetzt";
                    }
                    else if(u == 2 && Bits[u] == 1)
                    {
                        context = "Weiche1 links gesetzt";
                    }

                    //Bit 4
                    if (u == 3 && Bits[u] == 0)
                    {
                        context = "Weiche2 rechts gesetzt";
                    }
                    else if(u == 3 && Bits[u] == 1)
                    {
                        context = "Weiche2 links gesetz";
                    }

                    //Bit 5
                    if (u == 4 && Bits[u] == 0)
                    {
                        context = "Weiche3 rechts gesetzt";
                    }
                    else if(u == 4 && Bits[u] == 1)
                    {
                        context = "Weiche3 links gesetzt";
                    }

                    //Bit 6
                    if (u == 5 && Bits[u] == 0)
                    {
                        context = "Tür geschlossen";
                    }
                    else if(u == 5 && Bits[u] == 1)
                    {
                        context = "Tür offen";
                    }

                    //Bit 7
                    if (u == 6 && Bits[u] == 0)
                    {
                        context = "Licht aus";
                    }
                    else if(u == 6 && Bits[u] == 1)
                    {
                        context = "Licht ein";
                    }

                    //Bit 8
                    if (u == 7 && Bits[u] == 0)
                    {
                        context = "Strom Oberleitung aus";
                    }
                    else if(u == 7 && Bits[u] == 1)
                    {
                        context = "Stom Oberleitung ein";
                    }

                    lB_Anweisungen.Items.Add((u + 1) + ".Bit: " + Bits[u] + " - " + context);
                }

                //Checken ob dieser Bit erlaubt ist
                bool check = CheckByte(Bits);

                //Ausgeben ob er erlaubt ist
                lB_Anweisungen.Items.Add(check);

                //Einen Abspaltung anzeigen
                lB_Anweisungen.Items.Add("----------");

                //Bei Fehler in Dokument speichern
                if(check == false)
                {
                    Writer.Write((i+1) + " " + read[i]);
                }
            }

            //Schreiber schließen
            Writer.Close();
            myStream.Close();
        }
    }
}
