using System;
using System.Collections;
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

        private double _korrekteSchilling;
        private double _korrekteEuro;
        private double _falscheSchilling;
        private double _falscheEuro;

        public Form1()
        {
            InitializeComponent();

            //Create the connection string
            this._ConnectionString = "Data Source=Euro_Datei.mdb; Provider=Microsoft.Jet.OLEDB.4.0";
            this._OleDBConnection = new OleDbConnection(this._ConnectionString);
        }

        private void button_Laden_Click(object sender, EventArgs e)
        {
            //Show the dialog
            FileDialog FD = new OpenFileDialog();
            DialogResult result = FD.ShowDialog();

            //Use the result
            if(result == DialogResult.OK)
            {
                //Remove existing data from the listviews
                this.listView_richtigeDatensaetze.Clear();
                this.listView_falscheDatensaetze.Clear();

                //Read data
                ReadInDataFromFile(FD.FileName);
            }
        }

        private void button_Speichern_Click(object sender, EventArgs e)
        {
            //Drop the tables
            DropTwoTables();

            //Create the two tables
            CreateTwoTables();

            //Fill both tables from the listview
            ListViewIntoTables();
        }

        private void button_Beenden_Click(object sender, EventArgs e)
        {
            //Close the app
            this.Close();
        }

        private void ReadInDataFromFile(string File)
        {
            //Add the columns to both listviews
            ListViewAddColumns(ref this.listView_richtigeDatensaetze);
            ListViewAddColumns(ref this.listView_falscheDatensaetze);

            //Open the file reader
            FileStream zeichen = new FileStream(File, FileMode.Open);
            StreamReader lesen = new StreamReader(zeichen);

            //Go through the values and insert them into the listview
            string zeilen = lesen.ReadLine();
            while(zeilen != null)
            {
                //Split the line into the corresponding parts
                string[] parts = zeilen.Split(';');

                //Get current Schilling and Euro
                double schilling = Convert.ToDouble(GeneralFunction.ChangePointToComma(parts[1]));
                double euro = Convert.ToDouble(GeneralFunction.ChangePointToComma(parts[2]));

                //Check to which listview this line should be added
                if(Math.Round(schilling * 13.7603, 3) == Math.Round(euro, 3))
                {
                    //Add item to listview
                    this.listView_richtigeDatensaetze.Items.Add(new ListViewItem(new string[3] { parts[0], parts[1], parts[2] }));

                    //Add to the total sum
                    this._korrekteSchilling += schilling;
                    this._korrekteEuro += euro;
                }
                else
                {
                    //Add item to listview
                    this.listView_falscheDatensaetze.Items.Add(new ListViewItem(new string[3] { parts[0], parts[1], parts[2] }));

                    //Add to the total sum
                    this._falscheSchilling += schilling;
                    this._falscheEuro += euro;
                }

                //Get the next value
                zeilen = lesen.ReadLine();
            }

            //Close the reader
            lesen.Close();

            //Labels updaten
            UpdateLabels();
        }

        private void ListViewAddColumns(ref ListView listview)
        {
            //Add columns
            listview.Columns.Add("ID");
            listview.Columns.Add("Schilling");
            listview.Columns.Add("Euro");

            //Change column size
            listview.Columns[0].Width = 40;
            listview.Columns[2].Width = 100;
        }

        private void UpdateLabels()
        {
            //Set the value
            this.label_korrekteSchillingUndEuro.Text = "Schilling: " + _korrekteSchilling + " --- " + "Euro: " + _korrekteEuro;
            this.label_falscheSchillingUndEuro.Text = "Schilling: " + _falscheSchilling + " --- " + "Euro: " + _falscheEuro;
        }

        private void DropTwoTables()
        {
            try
            {
                FastExecuteNonQuery("DROP TABLE BankomatAuszug;");
            }
            catch(Exception e)
            {
                _OleDBConnection.Close();

                //Show error message
                MessageBox.Show("BankomatAuszug existiert nicht! -> " + e.ToString());
            }
            try
            {
                FastExecuteNonQuery("DROP TABLE AuszugFehler;");
            }
            catch (Exception e)
            {
                _OleDBConnection.Close();

                //Show error message
                MessageBox.Show("Auszugsfehler existiert nicht! -> " + e.ToString());
            }
        }

        private void CreateTwoTables()
        {
            FastExecuteNonQuery("CREATE TABLE Bankomatauszug (ID int, Schilling float, Euro float, CONSTRAINT PK_BankomatAuszug_ID PRIMARY KEY(ID))");
            FastExecuteNonQuery("CREATE TABLE Auszugfehler (ID int, Schilling float, Euro float, CONSTRAINT PK_BankomatAuszug_ID PRIMARY KEY(ID))");
        }

        private void ListViewIntoTables()
        {
            //Open the connection
            _OleDBConnection.Open();

            //Fill the tables
            for (int i = 0; i < this.listView_richtigeDatensaetze.Items.Count; i++)
            {
                ListViewItem item = this.listView_richtigeDatensaetze.Items[i];
                ExecuteNonQueryNoOpenClose("INSERT INTO Bankomatauszug (ID, Schilling, Euro) VALUES (" + item.SubItems[0].Text + ", " + item.SubItems[1].Text + "," + item.SubItems[2].Text + ");");
            }

            for (int i = 0; i < this.listView_falscheDatensaetze.Items.Count; i++)
            {
                ListViewItem item = this.listView_falscheDatensaetze.Items[i];
                ExecuteNonQueryNoOpenClose("INSERT INTO AuszugFehler (ID, Schilling, Euro) VALUES (" + item.SubItems[0].Text + ", " + item.SubItems[1].Text + "," + item.SubItems[2].Text + ");");
            }

            //Close the connection
            _OleDBConnection.Close();
        }

        private void ExecuteNonQueryNoOpenClose(string query)
        {
            //Set the command and execute it
            OleDbCommand Command = new OleDbCommand();
            Command.Connection = _OleDBConnection;
            Command.CommandText = query;
            Command.ExecuteNonQuery();
        }

        private void FastExecuteNonQuery(string query)
        {
            //Open the connection
            _OleDBConnection.Open();

            //Set the command and execute it
            OleDbCommand Command = new OleDbCommand();
            Command.Connection = _OleDBConnection;
            Command.CommandText = query;
            Command.ExecuteNonQuery();

            //Close the connections
            _OleDBConnection.Close();
        }
    }
}
