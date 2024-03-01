using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Threading;

namespace _20240226_Wegstrecke
{
    public partial class Wegstrecke : Form
    {
        //Parameter ohne String Concenation
        //Thread: auch Änderungen zeigen die in einem anderen Programm gemacht werden

        private Thread _ThreadUpdate;
        private BindingSource _BindingSourceLieferant;
        private DataTable _DataTableLieferant;

        public Wegstrecke()
        {
            //Initialize BindingSource
            this._BindingSourceLieferant = new BindingSource();

            InitializeComponent();
            RefreshDataTable();
            GetDataFromTable();
            ConfigureTableLayout();


            //Start Thread to Update Data
            this._ThreadUpdate = new Thread(InformationUpdater);
            this._ThreadUpdate.Start();
        }

        private void TextBoxKmUpdate(string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<string>(TextBoxKmUpdate), text);
            }
            else
            {
                textBox_Km.Text = text;
            }
        }

        private void RefreshDataGridView()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(RefreshDataGridView));
            }
            else
            {
                dataGridView1.DataSource = this._BindingSourceLieferant;
            }
        }

        private void RefreshDataTable()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(RefreshDataTable));
            }
            else
            {
                string connectionstring = "Data Source=Wegstrecken.mdb; Provider=Microsoft.Jet.OLEDB.4.0";
                OleDbConnection oleDbConnection = new OleDbConnection(connectionstring);

                oleDbConnection.Open();
                OleDbCommand Command = new OleDbCommand();
                Command.Connection = oleDbConnection;
                Command.CommandText = "SELECT * FROM Lieferungen;";
                OleDbDataReader DataReader = Command.ExecuteReader();

                //Load table into dataGridView
                this._DataTableLieferant = new DataTable();
                this._DataTableLieferant.Clear();
                this._DataTableLieferant.Load(DataReader);
                this._BindingSourceLieferant.DataSource = this._DataTableLieferant;
                oleDbConnection.Close();
            }
        }

        private void InformationUpdater()
        {
            while(true)
            {
                //Refresh table data
                RefreshDataTable();
                RefreshDataGridView();

                //Calculate the sum of column
                double sum_km = 0;
                for (int i = 0; i < this._DataTableLieferant.Rows.Count; i++)
                {
                    //Sum of km
                    sum_km += Convert.ToDouble(this._DataTableLieferant.Rows[i][2].ToString());
                }

                //Update the Km textbox
                TextBoxKmUpdate(Convert.ToString(sum_km));

                //Wait for 3 seconds and then do again
                Thread.Sleep(3000);
            }
        }

        private void GetDataFromTable()
        {
            //Load data into DataGridView
            dataGridView1.DataSource = this._DataTableLieferant;
        }

        private void ConfigureTableLayout()
        {
            //Set some columns to read only
            this.dataGridView1.Columns["Nummer"].ReadOnly = true;
            this.dataGridView1.Columns["Kunde"].ReadOnly = true;

            //Check for wrong values
            for(int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)
            {
                double value1 = Convert.ToDouble(this._DataTableLieferant.Rows[i][3].ToString());
                double value2 = KilometresToMiles(Convert.ToDouble(this._DataTableLieferant.Rows[i][2].ToString()));

                if(!(value1 == value2))
                {
                    this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                }
            }
        }

        private double KilometresToMiles(double kilometres)
        {
            return kilometres * 0.621371;
        }
    }
}
