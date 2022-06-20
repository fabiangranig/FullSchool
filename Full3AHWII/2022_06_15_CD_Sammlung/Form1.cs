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

namespace _20220615_CD_Sammlung
{
    public partial class CD_Sammlung : Form
    {
        public CD_Sammlung()
        {
            InitializeComponent();
        }

        private void btn_hinzufuegen1_Click(object sender, EventArgs e)
        {
            //Den Text aus den Textboxen herausholen
            string musikgruppe = txtBox_Musikgruppe.Text;
            string CDName1 = txtBox_CDName1.Text;

            //Checken ob dieser Wert schon hinzugefügt wurde
            bool Contains = false;
            for(int i = 0; i < listBox_1.Items.Count; i++)
            {
                //Dieses Item aufsplitten
                string[] split = Convert.ToString(listBox_1.Items[i]).Split('/');

                if(split[0] == musikgruppe)
                {
                    Contains = true;
                }
                if(split[1] == CDName1)
                {
                    Contains = true;
                }
            }

            if(Contains == false)
            {
                //Diesen Wert zu der ListBox hinzufügen
                listBox_1.Items.Add(musikgruppe + "/" + CDName1);

                //Die Textboxen clearen
                txtBox_Musikgruppe.Text = "";
                txtBox_CDName1.Text = "";
            }
        }

        private void btn_Loeschen1_Click(object sender, EventArgs e)
        {
            //Den Index von dem zu löschenden Item suchen
            int index = listBox_1.SelectedIndex;

            //Diesen Wert entfernen
            listBox_1.Items.RemoveAt(index);
        }

        private void btn_Aendern1_Click(object sender, EventArgs e)
        {
            //Den ausgewählten Wert rausholen und dann speichern
            int index = listBox_1.SelectedIndex;

            //Den Wert abspeichern und splitten
            string[] item = Convert.ToString(listBox_1.Items[index]).Split('/');

            //Den Wert aus der ListBox entfernen
            listBox_1.Items.RemoveAt(index);

            //in die Textboxen die Werte wieder einfügen
            txtBox_Musikgruppe.Text = item[0];
            txtBox_CDName1.Text = item[1];
        }

        private void btn_Hinzufuegen2_Click(object sender, EventArgs e)
        {
            //Den Text aus den Textboxen herausholen
            string CDName2 = txtBox_CDName2.Text;
            string Musikstueck = txtBox_Musikstueck.Text;

            //Checken ob dieser Wert schon hinzugefügt wurde
            bool Contains = false;
            for (int i = 0; i < listBox_2.Items.Count; i++)
            {
                //Dieses Item aufsplitten
                string[] split = Convert.ToString(listBox_2.Items[i]).Split('/');

                if (split[1] == Musikstueck)
                {
                    Contains = true;
                }
            }

            if (Contains == false)
            {
                //Diesen Wert zu der ListBox hinzufügen
                listBox_2.Items.Add(CDName2 + "/" + Musikstueck);

                //Die Textboxen clearen
                txtBox_CDName2.Text = "";
                txtBox_Musikstueck.Text = "";
            }
        }

        private void btn_Loeschen2_Click(object sender, EventArgs e)
        {
            //Den Index von dem zu löschenden Item suchen
            int index = listBox_2.SelectedIndex;

            //Diesen Wert entfernen
            listBox_2.Items.RemoveAt(index);
        }

        private void btn_Aendern2_Click(object sender, EventArgs e)
        {
            //Den ausgewählten Wert rausholen und dann speichern
            int index = listBox_2.SelectedIndex;

            //Den Wert abspeichern und splitten
            string[] item = Convert.ToString(listBox_2.Items[index]).Split('/');

            //Den Wert aus der ListBox entfernen
            listBox_2.Items.RemoveAt(index);

            //in die Textboxen die Werte wieder einfügen
            txtBox_CDName2.Text = item[0];
            txtBox_Musikstueck.Text = item[1];
        }

        private void btn_Abgleichen_Click(object sender, EventArgs e)
        {
            //Combobox leeren
            comboBox1.Items.Clear();

            //Von der ersten Listbox jede Musikgruppe durchgehen
            for(int i = 0; i < listBox_1.Items.Count; i++)
            {
                //Das Item aufsplitten
                string[] split1 = Convert.ToString(listBox_1.Items[i]).Split('/');

                //Den String zusammenfügen und die Größe des Strings messen
                string sol = split1[0] + "/" + split1[1] + "/";
                int length = sol.Length;

                //Musikstücke suchen welche zu diesem Wert passen
                string found_values = "";
                int found_values_count = 0;
                for(int u = 0; u < listBox_2.Items.Count; u++)
                {
                    //Den Wert wieder aufplitten
                    string[] split2 = Convert.ToString(listBox_2.Items[u]).Split('/');

                    //Checken ob der Wert passt und wenn er passt einfügen
                    if (split2[0] == split1[1] && found_values_count > 0)
                    {
                        found_values += "," + split2[1];
                    }
                    if (split2[0] == split1[1] && found_values_count == 0)
                    {
                        found_values += split2[1];
                        found_values_count++;
                    }
                }

                //Diese zwei String zusammenfügen
                sol += found_values;

                //Wenn der String jetzt Werte hat, dann soll er in die Combobox eingefügt werden
                if(length != sol.Length)
                {
                    comboBox1.Items.Add(sol);
                }
            }
        }

        private void btn_Speichern_Click(object sender, EventArgs e)
        {
            //FileStream erstellen
            FileStream fs = new FileStream("CD_Sammlung.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            //Den Wert speichern
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                //Den jetzigen zu bearbeiteten Wert auswählen
                string input = Convert.ToString(comboBox1.Items[i]);

                //Den String splitten und die neuen Worttrenner einfügen
                string[] split = input.Split('/');
                string sol = "";
                for(int u = 0; u < split.Length; u++)
                {
                    sol += split[u];

                    if (split.Length - 1 > u)
                    {
                        sol += ";";
                    }
                }

                sw.WriteLine(Convert.ToString(sol));
            }

            //Den FileStream schließen
            sw.Close();
            fs.Close();
        }

        private void btn_Laden_Click(object sender, EventArgs e)
        {
            //Bestätigen ob es ausgeführt wird
            Form2 form2 = new Form2();
            form2.ShowDialog();

            //Schauen ob man ausführen soll
            bool schalter = form2.schalter;

            if (schalter == true)
            {
                //Alle Boxen leeren
                listBox_1.Items.Clear();
                listBox_1.Items.Clear();
                comboBox1.Items.Clear();

                //Den FileStream öffnen
                FileStream zeichen = new FileStream("CD_Sammlung.txt", FileMode.Open);
                StreamReader lesen = new StreamReader(zeichen);

                //Die Zeilen einlesen und in die Combobox hinzufügen
                string zeilen = " ";
                while (zeilen != null)
                {
                    zeilen = lesen.ReadLine();

                    if (zeilen != null)
                    {
                        //Die ';' in '/' abändern
                        string[] split = zeilen.Split(';');
                        string newzeilen = "";
                        for (int i = 0; i < split.Length; i++)
                        {
                            newzeilen += split[i];

                            if (split.Length - 1 > i)
                            {
                                newzeilen += "/";
                            }
                        }

                        //Zur Combobox hinzufügen
                        comboBox1.Items.Add(newzeilen);
                    }
                }

                //Den FileStream schließen
                lesen.Close();

                //Werte zu den ListBoxen hinzufügen
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    //Sich den String aus der Combobox nehmen
                    string input = Convert.ToString(comboBox1.Items[i]);

                    //Wert für die erste Listbox hinzufügen
                    string[] split1 = input.Split('/');
                    listBox_1.Items.Add(split1[0] + "/" + split1[1]);

                    //Die Songs aufplitten
                    string[] split2 = split1[2].Split(',');

                    //Diese Songs zur zweiten Listbox hinzufügen
                    for (int u = 0; u < split2.Length; u++)
                    {
                        listBox_2.Items.Add(split1[1] + "/" + split2[u]);
                    }
                }
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            btn_Abgleichen_Click(sender, e);
            btn_Speichern_Click(sender, e);
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            //Bestätigen ob es ausgeführt wird
            Form2 form2 = new Form2();
            form2.ShowDialog();

            //Schauen ob man ausführen soll
            bool schalter = form2.schalter;

            //Wenn der Schalter true ist wird das Programm beendet
            if (true)
            {
                this.Close();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            listBox_1.Items.Clear();
            listBox_2.Items.Clear();
            comboBox1.Items.Clear();
        }
    }
}
