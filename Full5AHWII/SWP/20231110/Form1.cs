using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231110
{
    public partial class Form1 : Form
    {
        private SqlConnection _SQLConnection;

        private SqlDataAdapter _SQLDataAdapterVerlag;
        private SqlCommand _SQLCommandVerlagSelect;
        private DataSet _DataSetVerlag;
        private BindingSource _BindingSourceVerlag;

        private SqlDataAdapter _SQLDataAdapterBuchnummer;
        private SqlCommand _SQLCommandBuchnummerSelect;
        private DataSet _DataSetBuchnummer;
        private BindingSource _BindingSourceBuchnummer;

        private SqlDataAdapter _SQLDataAdapterGesamt;
        private SqlCommand _SQLCommandGesamtSelect;
        private DataSet _DataSetGesamt;
        private BindingSource _BindingSourceGesamt;

        public Form1()
        {
            InitializeComponent();

            _SQLConnection = new SqlConnection("Data Source=localhost;Initial Catalog=master;Integrated Security= true");

            _SQLDataAdapterVerlag = new SqlDataAdapter();
            _SQLCommandVerlagSelect = new SqlCommand("SELECT * FROM Verlag;", _SQLConnection);
            _SQLDataAdapterVerlag.SelectCommand = _SQLCommandVerlagSelect;
            _DataSetVerlag = new DataSet();
            _SQLDataAdapterVerlag.FillSchema(_DataSetVerlag, SchemaType.Source, "Verlag");
            _SQLDataAdapterVerlag.Fill(_DataSetVerlag, "Verlag");
            _BindingSourceVerlag = new BindingSource();
            _BindingSourceVerlag.DataSource = _DataSetVerlag;
            _BindingSourceVerlag.DataMember = "Verlag";
            _BindingSourceVerlag.DataSource = _DataSetVerlag.Tables["Verlag"];

            _SQLDataAdapterBuchnummer = new SqlDataAdapter();
            _SQLCommandBuchnummerSelect = new SqlCommand("SELECT * FROM Buch;", _SQLConnection);
            _SQLDataAdapterBuchnummer.SelectCommand = _SQLCommandBuchnummerSelect;
            _DataSetBuchnummer = new DataSet();
            _SQLDataAdapterBuchnummer.FillSchema(_DataSetBuchnummer, SchemaType.Source, "Buch");
            _SQLDataAdapterBuchnummer.Fill(_DataSetBuchnummer, "Buch");
            _BindingSourceBuchnummer = new BindingSource();
            _BindingSourceBuchnummer.DataSource = _DataSetBuchnummer;
            _BindingSourceBuchnummer.DataMember = "Buch";
            _BindingSourceBuchnummer.DataSource = _DataSetBuchnummer.Tables["Buch"];


            _SQLDataAdapterGesamt = new SqlDataAdapter();
            _SQLCommandGesamtSelect = new SqlCommand("SELECT * FROM Buch b, Verlag v WHERE b.Verlagnummer = v.Nummer;", _SQLConnection);
            _SQLDataAdapterGesamt.SelectCommand = _SQLCommandGesamtSelect;
            _DataSetGesamt = new DataSet();
            _SQLDataAdapterGesamt.FillSchema(_DataSetGesamt, SchemaType.Source, "Gesamt");
            _SQLDataAdapterGesamt.Fill(_DataSetGesamt, "Gesamt");
            _BindingSourceGesamt = new BindingSource();
            _BindingSourceGesamt.DataSource = _DataSetGesamt;
            _BindingSourceGesamt.DataMember = "Gesamt";
            _BindingSourceGesamt.DataSource = _DataSetGesamt.Tables["Gesamt"];

            dataGridView_Buecher.DataSource = _BindingSourceBuchnummer;

            comboBox_Verlag.DataSource = _BindingSourceVerlag;
            comboBox_Verlag.DisplayMember = "Bezeichnung";
            comboBox_Verlag.ValueMember = "Nummer";

            RefreshTable();
            comboBox_Verlag.SelectedIndexChanged += ComboBox_Verlag_SelectedIndexChanged;
        }

        private void ComboBox_Verlag_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            _SQLCommandBuchnummerSelect = new SqlCommand("SELECT * FROM Buch WHERE Verlagnummer = " + comboBox_Verlag.SelectedValue + ";", _SQLConnection);
            _SQLDataAdapterBuchnummer.SelectCommand = _SQLCommandBuchnummerSelect;

            _DataSetBuchnummer.Tables["Buch"].Clear();
            _SQLDataAdapterBuchnummer.FillSchema(_DataSetBuchnummer, SchemaType.Source, "Buch");
            _SQLDataAdapterBuchnummer.Fill(_DataSetBuchnummer, "Buch");
        }
    }
}
