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

namespace _20230920_ADO
{
    public partial class Form1 : Form
    {
        private BindingSource MySource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string myConnection;
            string mySelectQuery;
            OleDbConnection myConn;
            OleDbDataAdapter myDataAdapter;

            DataSet custDS;
            //myConnection = "Data Source=K:\\Employees.mdb; Provider=Microsoft.Jet.OLEDB.4.0";
            myConnection = "Data Source=K:\\5AHWII\\SWP\\20230920_ADO\\bin\\Debug\\Employees.mdb; Provider=Microsoft.Jet.OLEDB.4.0";


            mySelectQuery = "SELECT * FROM Emp";
            myConn = new OleDbConnection(myConnection);
            myDataAdapter = new OleDbDataAdapter();
            myDataAdapter.SelectCommand = new OleDbCommand(mySelectQuery, myConn);

            myConn.Open();

            custDS = new DataSet();

            myDataAdapter.FillSchema(custDS, SchemaType.Source, "Emp");
            myDataAdapter.Fill(custDS, "Emp");

            this.dataGridView1.DataSource = custDS.Tables[0];

            MySource = new BindingSource();
            MySource.DataSource = custDS;
            MySource.DataMember = custDS.Tables[0].TableName;
            textBox_Name.DataBindings.Add("Text", MySource, "ENAME");

            myConn.Close();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            MySource.MoveNext();
        }
    }
}
