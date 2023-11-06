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

namespace _20231105_Verkaufsverwaltungssystem
{
    public partial class ObjektWarten : Form
    {
        private string _TableName;

        private DataSet _DataSet;
        private SqlDataAdapter _SQLDataAdapter;
        private BindingSource _BindingSource;

        private string[] _ColumnNames;

        private Label[] _Labels;
        private TextBox[] _TextBoxes;
        private DataGridView _DataGridView;

        private Button _ButtonLoeschen;
        private Button _ButtonNeu;
        private Button _ButtonVorheriges;
        private Button _ButtonNaechtes;

        private bool _EditMode;

        public ObjektWarten(string TableName, string[] ColumnNames, ref DataSet dataset, SqlDataAdapter sqldataadapter, BindingSource bindingSource)
        {
            InitializeComponent();

            //Set the edit bool
            _EditMode = false;

            //Set the column names
            _TableName = TableName;
            _ColumnNames = ColumnNames;

            //Add sql components to the table
            _DataSet = dataset;
            _SQLDataAdapter = sqldataadapter;
            _BindingSource = bindingSource;

            //Setup window size
            this.Size = new Size((ColumnNames.Length - 1) * 150 + 100 + 20 + 20 + 20, this.Height);

            //Setup datagridview
            _DataGridView = new DataGridView();
            _DataGridView.Location = new Point(20, 110);
            _DataGridView.Size = new Size((ColumnNames.Length - 1) * 150 + 100, _DataGridView.Height);
            _DataGridView.ReadOnly = true;
            _DataGridView.MultiSelect = false;
            this.Controls.Add(_DataGridView);
            _DataGridView.DataSource = _BindingSource;

            //Create labels and textboxes
            _Labels = new Label[ColumnNames.Length];
            _TextBoxes = new TextBox[ColumnNames.Length];
            for(int i = 0; i < ColumnNames.Length; i++)
            {
                _Labels[i] = new Label();
                _Labels[i].Text = ColumnNames[i] + ":";
                _Labels[i].Location = new Point(i * 150 + 20, 20);
                this.Controls.Add(_Labels[i]);

                _TextBoxes[i] = new TextBox();
                _TextBoxes[i].Location = new Point(i * 150 + 20, 50);
                _TextBoxes[i].DataBindings.Add("Text", _BindingSource, ColumnNames[i]);
                this.Controls.Add(_TextBoxes[i]);
            }

            //Add buttons to the window
            _ButtonLoeschen = new Button();
            _ButtonLoeschen.Location = new Point(20, 80);
            _ButtonLoeschen.Text = "Löschen";
            _ButtonLoeschen.Click += EintragLoeschen;
            this.Controls.Add(_ButtonLoeschen);

            _ButtonNeu = new Button();
            _ButtonNeu.Location = new Point(20 + 100, 80);
            _ButtonNeu.Text = "Neu";
            _ButtonNeu.Click += EintragNeu;
            this.Controls.Add(_ButtonNeu);

            _ButtonVorheriges = new Button();
            _ButtonVorheriges.Location = new Point(20 + 200, 80);
            _ButtonVorheriges.Text = "Vorheriges";
            _ButtonVorheriges.Click += VorherigesFunction;
            this.Controls.Add(_ButtonVorheriges);

            _ButtonNaechtes = new Button();
            _ButtonNaechtes.Location = new Point(20 + 300, 80);
            _ButtonNaechtes.Text = "Nächstes";
            _ButtonNaechtes.Click += NaechtesFunction;
            this.Controls.Add(_ButtonNaechtes);
        }

        private void EintragLoeschen(object sender, EventArgs e)
        {
            if (_BindingSource.Current != null)
            {
                _BindingSource.RemoveCurrent();
                _SQLDataAdapter.Update(_DataSet, _TableName);
            }
        }

        private void EintragNeu(object sender, EventArgs e)
        {
            if(_EditMode == false)
            {
                _BindingSource.AddNew();

                _ButtonLoeschen.Enabled = false;
                _ButtonVorheriges.Enabled = false;
                _ButtonNaechtes.Enabled = false;

                _ButtonNeu.Text = "Bestätigen";

                _EditMode = true;
            }
            else if (_EditMode == true)
            {
                _BindingSource.EndEdit();
                _SQLDataAdapter.Update(_DataSet.Tables[_TableName]);

                _ButtonLoeschen.Enabled = true;
                _ButtonVorheriges.Enabled = true;
                _ButtonNaechtes.Enabled = true;

                _ButtonNeu.Text = "Neu";

                _EditMode = false;
            }
        }

        private void VorherigesFunction(object sender, EventArgs e)
        {
            _BindingSource.MovePrevious();
        }

        private void NaechtesFunction(object sender, EventArgs e)
        {
            _BindingSource.MoveNext();
        }
    }
}
