using System;
using System.Windows.Forms;

namespace _20220328_Taschenrechner
{
    public partial class Taschenrechner : Form
    {
        public Taschenrechner()
        {
            InitializeComponent();
        }

        //Variables for the last operations
        public static string last_operation = "";
        public static double last_entered_number = 0;
        public static int Tastendrücke = 0;

        //Funktion zum Berechnen von einfachen Rechnungen
        static double Calculate(double value, double value2, string operation)
        {
            double ergebnis = 0;

            if(operation == "+")
            {
                ergebnis = value + value2;
            }
            if(operation == "-")
            {
                ergebnis = value - value2;
            }
            if(operation == "*")
            {
                ergebnis = value * value2;
            }
            if(operation == "/")
            {
                ergebnis = value / value2;
            }

            return ergebnis;
        }

        //Eine Number zurückgehen
        static string Number_Back(string o)
        {
            string u = "";
            for(int i = 0; i < o.Length - 1; i++)
            {
                u += Convert.ToString(o[i]);
            }

            return u;
        }

        //Vorzeichen ändern
        static string Rebuild_without_Minus(string o)
        {
            string u = "";
            for (int i = 1; i < o.Length; i++)
            {
                u += Convert.ToString(o[i]);
            }

            return u;
        }

        //Zahlenfeld
        private void btn7_Click(object sender, EventArgs e)
        {
            if(Tastendrücke == 0)
            {
                txt_Anzeige.Text = "7";
                txtVerlauf.Text = "7";
                Tastendrücke++;
            }
            else
            {
                txt_Anzeige.Text += "7";
                txtVerlauf.Text += "7";
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (Tastendrücke == 0)
            {
                txt_Anzeige.Text = "8";
                txtVerlauf.Text = "8";
                Tastendrücke++;
            }
            else
            {
                txt_Anzeige.Text += "8";
                txtVerlauf.Text += "8";
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (Tastendrücke == 0)
            {
                txt_Anzeige.Text = "9";
                txtVerlauf.Text = "9";
                Tastendrücke++;
            }
            else
            {
                txt_Anzeige.Text += "9";
                txtVerlauf.Text += "9";
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (Tastendrücke == 0)
            {
                txt_Anzeige.Text = "4";
                txtVerlauf.Text = "4";
                Tastendrücke++;
            }
            else
            {
                txt_Anzeige.Text += "4";
                txtVerlauf.Text += "4";
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (Tastendrücke == 0)
            {
                txt_Anzeige.Text = "5";
                txtVerlauf.Text = "5";
                Tastendrücke++;
            }
            else
            {
                txt_Anzeige.Text += "5";
                txtVerlauf.Text += "5";
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (Tastendrücke == 0)
            {
                txt_Anzeige.Text = "6";
                txtVerlauf.Text = "6";
                Tastendrücke++;
            }
            else
            {
                txt_Anzeige.Text += "6";
                txtVerlauf.Text += "6";
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (Tastendrücke == 0)
            {
                txt_Anzeige.Text = "1";
                txtVerlauf.Text = "1";
                Tastendrücke++;
            }
            else
            {
                txt_Anzeige.Text += "1";
                txtVerlauf.Text += "1";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (Tastendrücke == 0)
            {
                txt_Anzeige.Text = "2";
                txtVerlauf.Text = "2";
                Tastendrücke++;
            }
            else
            {
                txt_Anzeige.Text += "2";
                txtVerlauf.Text += "2";
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (Tastendrücke == 0)
            {
                txt_Anzeige.Text = "3";
                txtVerlauf.Text = "3";
                Tastendrücke++;
            }
            else
            {
                txt_Anzeige.Text += "3";
                txtVerlauf.Text += "3";
            }
        }
        private void btnNull_Click(object sender, EventArgs e)
        {
            if (Tastendrücke == 0)
            {
                txt_Anzeige.Text = "0";
                txtVerlauf.Text = "0";
                Tastendrücke++;
            }
            else
            {
                txt_Anzeige.Text += "0";
                txtVerlauf.Text += "0";
            }
        }

        //Operationen
        //Plus Rechnen
        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtVerlauf.Text += "+";
            if (last_operation == "")
            {
                last_entered_number = Convert.ToDouble(txt_Anzeige.Text);
                last_operation = "+";
            }
            else
            {
                last_entered_number = Calculate(last_entered_number, Convert.ToDouble(txt_Anzeige.Text), last_operation);
                last_operation = "+";
            }
            
            txt_Anzeige.Text = "";
        }

        //Ergebnis Ausgeben
        private void btnErgebnis_Click(object sender, EventArgs e)
        {
            double val2 = Convert.ToDouble(txt_Anzeige.Text);
            double sol = Calculate(last_entered_number, val2, last_operation);
            last_operation = "";
            txt_Anzeige.Text = Convert.ToString(sol);
            txtVerlauf.Text = "=" + sol;
        }

        //Minus Rechnen
        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtVerlauf.Text += "-";
            if (last_operation == "")
            {
                last_entered_number = Convert.ToDouble(txt_Anzeige.Text);
                last_operation = "-";
            }
            else
            {
                last_entered_number = Calculate(last_entered_number, Convert.ToDouble(txt_Anzeige.Text), last_operation);
                last_operation = "-";
            }

            txt_Anzeige.Text = "";
        }

        //Mal Rechnen
        private void btnMal_Click(object sender, EventArgs e)
        {
            txtVerlauf.Text += "*";
            if (last_operation == "")
            {
                last_entered_number = Convert.ToDouble(txt_Anzeige.Text);
                last_operation = "*";
            }
            else
            {
                last_entered_number = Calculate(last_entered_number, Convert.ToDouble(txt_Anzeige.Text), last_operation);
                last_operation = "*";
            }

            txt_Anzeige.Text = "";
        }

        //Dividieren Rechnen
        private void btnDividieren_Click(object sender, EventArgs e)
        {
            txtVerlauf.Text += "/";
            if (last_operation == "")
            {
                last_entered_number = Convert.ToDouble(txt_Anzeige.Text);
                last_operation = "/";
            }
            else
            {
                last_entered_number = Calculate(last_entered_number, Convert.ToDouble(txt_Anzeige.Text), last_operation);
                last_operation = "/";
            }

            txt_Anzeige.Text = "";
        }

        //ein Zeichen zurückgehen
        private void btnBack_Click(object sender, EventArgs e)
        {
            txt_Anzeige.Text = Number_Back(txt_Anzeige.Text);
            txtVerlauf.Text = Number_Back(txtVerlauf.Text);
        }

        //Alles löschen
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVerlauf.Text = "";
            last_operation = "";
            last_entered_number = -1111;
            txt_Anzeige.Text = "";
        }

        //Nur Teile löschen
        private void btnClearE_Click(object sender, EventArgs e)
        {
            txt_Anzeige.Text = "";
            txtVerlauf.Text = "";
        }

        //Den Wert in Prozent umwandeln
        private void btnProzent_Click(object sender, EventArgs e)
        {
            txtVerlauf.Text += "%";
            txt_Anzeige.Text = Convert.ToString(last_entered_number / 100 * Convert.ToDouble(txt_Anzeige.Text));
        }

        //ein Komman eingeben
        private void btnKomma_Click(object sender, EventArgs e)
        {
            if(!txt_Anzeige.Text.Contains("."))
            {
                txt_Anzeige.Text += ",";
                txtVerlauf.Text += ",";
            }
        }

        //Vorzeichen ändern
        private void btnVorzeichenSwitch_Click(object sender, EventArgs e)
        {
            double wert = Convert.ToDouble(txt_Anzeige.Text);
            if(wert == 0)
            {

            }
            if(wert < 0)
            {
                txt_Anzeige.Text = Rebuild_without_Minus(txt_Anzeige.Text);

            }
            if(wert > 0)
            {
                txt_Anzeige.Text = "-" + txt_Anzeige.Text;
            }
        }

        //Wurzel berechnen
        private void btnWurzel_Click(object sender, EventArgs e)
        {
            double wert = Convert.ToDouble(txt_Anzeige.Text);
            wert = Math.Sqrt(wert);
            txt_Anzeige.Text = Convert.ToString(wert);
            txtVerlauf.Text += "] Wurzel";
        }

        //Hochzahl berechnen
        private void btnHoch2_Click(object sender, EventArgs e)
        {
            double wert = Convert.ToDouble(txt_Anzeige.Text);
            wert = Math.Pow(wert, 2);
            txt_Anzeige.Text = Convert.ToString(wert);
            txtVerlauf.Text += "²";
        }

        //Kehrwert berechnen
        private void btnKehrwert_Click(object sender, EventArgs e)
        {
            double wert = Convert.ToDouble(txt_Anzeige.Text);
            wert = 1.0 / wert;
            txt_Anzeige.Text = Convert.ToString(wert);
            txtVerlauf.Text += "] Kehrwert";
        }
    }
}