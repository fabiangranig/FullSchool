using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _20230920_ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string myConnection;
            string mySelectQuery;
            SqlConnection myConn;
            SqlDataAdapter myDataAdapter;

            DataSet custDS;
            myConnection = "Data Source=localhost;Initial Catalog=Employees;Integrated Security=true";


            mySelectQuery = "SELECT * FROM Emp";
            myConn = new SqlConnection(myConnection);
            myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = new SqlCommand(mySelectQuery, myConn);

            myConn.Open();

            custDS = new DataSet();

            myDataAdapter.FillSchema(custDS, SchemaType.Source, "Emp");
            myDataAdapter.Fill(custDS, "Emp");

            this.dataGridView1.DataSource = custDS.Tables[0];

            myConn.Close();
        }
    }
}
