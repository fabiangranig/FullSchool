using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231115_Schilling_Euro
{
    public partial class Form1 : Form
    {
        private OleDbConnection _OleDBConnection;
        private string _ConnectionString;

        public Form1()
        {
            InitializeComponent();

            //Create the connection string
            _ConnectionString = "Data Source=Euro_Datei.mdb; Provider=Microsoft.Jet.OLEDB.4.0";
            _OleDBConnection = new OleDbConnection(_ConnectionString);
        }

        private void button_Laden_Click(object sender, EventArgs e)
        {
            FileDialog FD = new OpenFileDialog();
            DialogResult result = FD.ShowDialog();

            if(result == DialogResult.OK)
            {
                ReadInDataFromFile(FD.FileName);
            }
        }

        private void ReadInDataFromFile(string File)
        {
            double korrekteSchilling = 0;
            double korrekteEuro = 0;
            double falscheSchilling = 0;
            double falscheEuro = 0;

            FileStream zeichen = new FileStream(File, FileMode.Open);
            StreamReader lesen = new StreamReader(zeichen);

            //Add columns to listview_richtigeDatensaetze
            this.listView_richtigeDatensaetze.Columns.Add("ID");
            this.listView_richtigeDatensaetze.Columns.Add("Schilling");
            this.listView_richtigeDatensaetze.Columns.Add("Euro");

            //Resize them
            this.listView_richtigeDatensaetze.Columns[0].Width = 40;
            this.listView_richtigeDatensaetze.Columns[2].Width = 100;

            //Add columns to listview_falscheDatensaetze
            this.listView_falscheDatensaetze.Columns.Add("ID");
            this.listView_falscheDatensaetze.Columns.Add("Schilling");
            this.listView_falscheDatensaetze.Columns.Add("Euro");

            //Resize them
            this.listView_falscheDatensaetze.Columns[0].Width = 40;
            this.listView_falscheDatensaetze.Columns[2].Width = 100;

            string zeilen = lesen.ReadLine();
            while (zeilen != null)
            {
                
                //Split and insert the line
                string[] split = zeilen.Split(';');
                double a1 = Convert.ToDouble(ChangePointToComma(split[1]));
                double a2 = Convert.ToDouble(ChangePointToComma(split[2]));
                if (Math.Round(a1 * 13.7603, 3) == Math.Round(a2, 3))
                {
                    korrekteSchilling += a1;
                    korrekteEuro += a2;
                    this.listView_richtigeDatensaetze.Items.Add(new ListViewItem(new string[3] { split[0], split[1], split[2] }));
                }
                else
                {
                    falscheSchilling += a1;
                    falscheEuro += a2;
                    this.listView_falscheDatensaetze.Items.Add(new ListViewItem(new string[3] { split[0], split[1], split[2] }));
                }

                //Read the lines
                zeilen = lesen.ReadLine();
            }

            lesen.Close();

            //Labels updaten
            this.label_korrekteSchillingUndEuro.Text = "Schilling: " + korrekteSchilling + " " + "Euro: " + korrekteEuro;
            this.label_falscheSchillingUndEuro.Text = "Schilling: " + falscheSchilling + " " + "Euro: " + falscheEuro;
        }

        private string ChangePointToComma(string input)
        {
            string result = "";
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == '.')
                {
                    result += ',';
                }
                else
                {
                    result += input[i];
                }
            }
            return result;
        }

        private void button_Beenden_Click(object sender, EventArgs e)
        {
            //Close the app
            this.Close();
        }

        private void button_Speichern_Click(object sender, EventArgs e)
        {

        }

        private void TabellenErstellen()
        {

        }

        private void ListViewZuDatenbankHinzufuegen()
        {

        }
    }
}
