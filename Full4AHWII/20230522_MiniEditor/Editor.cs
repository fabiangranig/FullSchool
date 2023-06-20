using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230522_MiniEditor
{
    public partial class Editor : Form
    {
        //Standart variables
        private string _FilePath;
        private string _FileName;
        private string _LastInput;
        WindowSuchen WS;

        //Menu
        private MenuStrip _MenuStrip;

        //Strip Menu Datei
        private ToolStripMenuItem _Datei;
        private ToolStripMenuItem _Neu;
        private ToolStripMenuItem _NeuesFenster;
        private ToolStripMenuItem _Oeffnen;
        private ToolStripMenuItem _Speichern;
        private ToolStripMenuItem _SpeichernUnter;
        private ToolStripSeparator _TrennDatei1;
        private ToolStripMenuItem _SeiteEinrichten;
        private ToolStripMenuItem _Drucken;
        private ToolStripSeparator _TrennDatei2;
        private ToolStripMenuItem _Beenden;

        //Initialize Menu Datei
        private void InitializeMenuDatei()
        {
            _Datei = new ToolStripMenuItem("Datei");
            _Neu = new ToolStripMenuItem("Neu");
            _Neu.Click += _Neu_Click;
            _Datei.DropDownItems.Add(_Neu);
            _NeuesFenster = new ToolStripMenuItem("neues Fenster");
            _NeuesFenster.Click += _neuesFenster_Click;
            _Datei.DropDownItems.Add(_NeuesFenster);
            _Oeffnen = new ToolStripMenuItem("Öffnen");
            _Oeffnen.Click += _Oeffnen_Click;
            _Datei.DropDownItems.Add(_Oeffnen);
            _Speichern = new ToolStripMenuItem("Speichern");
            _Speichern.Click += _Speichern_Click;
            _Datei.DropDownItems.Add(_Speichern);
            _SpeichernUnter = new ToolStripMenuItem("Speichern unter");
            _SpeichernUnter.Click += _SpeichernUnter_Click;
            _Datei.DropDownItems.Add(_SpeichernUnter);
            _TrennDatei1 = new ToolStripSeparator();
            _Datei.DropDownItems.Add(_TrennDatei1);
            _SeiteEinrichten = new ToolStripMenuItem("Seite einrichten");
            _Datei.DropDownItems.Add(_SeiteEinrichten);
            _Drucken = new ToolStripMenuItem("Drucken");
            _Datei.DropDownItems.Add(_Drucken);
            _TrennDatei2 = new ToolStripSeparator();
            _Datei.DropDownItems.Add(_TrennDatei2);
            _Beenden = new ToolStripMenuItem("Beenden");
            _Beenden.Click += _Beenden_Click;
            _Datei.DropDownItems.Add(_Beenden);

            //Add to main MenuStrip
            _MenuStrip.Items.Add(_Datei);
        }

        //Strip Menu Bearbeiten
        private ToolStripMenuItem _Bearbeiten;
        private ToolStripMenuItem _Rueckgängig;
        private ToolStripSeparator _TrennBearbeiten1;
        private ToolStripMenuItem _Ausschneiden;
        private ToolStripMenuItem _Kopieren;
        private ToolStripMenuItem _Einfuegen;
        private ToolStripMenuItem _Loeschen;
        private ToolStripSeparator _TrennBearbeiten2;
        private ToolStripMenuItem _SucheMitBing;
        private ToolStripMenuItem _Suchen;
        private ToolStripMenuItem _Weitersuchen;
        private ToolStripMenuItem _VorherigeSuchen;
        private ToolStripMenuItem _Ersetzen;
        private ToolStripMenuItem _WechselnSieZu;
        private ToolStripSeparator _TrennBearbeiten3;
        private ToolStripMenuItem _AllesMakieren;
        private ToolStripMenuItem _UhrzeitDatum;

        private void InitializeMenuBearbeiten()
        {
            _Bearbeiten = new ToolStripMenuItem("Bearbeiten");
            _Rueckgängig = new ToolStripMenuItem("Rückgängig");
            _Rueckgängig.Click += _Rueckgängig_Click;
            _Bearbeiten.DropDownItems.Add(_Rueckgängig);
            _TrennBearbeiten1 = new ToolStripSeparator();
            _Bearbeiten.DropDownItems.Add(_TrennBearbeiten1);
            _Ausschneiden = new ToolStripMenuItem("Ausschneiden");
            _Ausschneiden.Click += _CutOut_Click;
            _Bearbeiten.DropDownItems.Add(_Ausschneiden);
            _Kopieren = new ToolStripMenuItem("Kopieren");
            _Kopieren.Click += _Kopieren_Click;
            _Bearbeiten.DropDownItems.Add(_Kopieren);
            _Einfuegen = new ToolStripMenuItem("Einfügen");
            _Einfuegen.Click += _Einfuegen_Click;
            _Bearbeiten.DropDownItems.Add(_Einfuegen);
            _Loeschen = new ToolStripMenuItem("Löschen");
            _Loeschen.Click += _Loeschen_Click;
            _Bearbeiten.DropDownItems.Add(_Loeschen);
            _TrennBearbeiten2 = new ToolStripSeparator();
            _Bearbeiten.DropDownItems.Add(_TrennBearbeiten2);
            _SucheMitBing = new ToolStripMenuItem("Suche mit Bing");
            _SucheMitBing.Click += _SucheMitBing_Click;
            _Bearbeiten.DropDownItems.Add(_SucheMitBing);
            _Suchen = new ToolStripMenuItem("Suchen");
            _Suchen.Click += _Suchen_Click;
            _Bearbeiten.DropDownItems.Add(_Suchen);
            _Weitersuchen = new ToolStripMenuItem("Weitersuchen");
            _Bearbeiten.DropDownItems.Add(_Weitersuchen);
            _VorherigeSuchen = new ToolStripMenuItem("vorherige Suche");
            _Bearbeiten.DropDownItems.Add(_VorherigeSuchen);
            _Ersetzen = new ToolStripMenuItem("Ersetzen");
            _Bearbeiten.DropDownItems.Add(_Ersetzen);
            _WechselnSieZu = new ToolStripMenuItem("Wechseln Sie zu");
            _Bearbeiten.DropDownItems.Add(_WechselnSieZu);
            _TrennBearbeiten3 = new ToolStripSeparator();
            _Bearbeiten.DropDownItems.Add(_TrennBearbeiten3);
            _AllesMakieren = new ToolStripMenuItem("Alles makieren");
            _AllesMakieren.Click += _Alles_Makieren_Click;
            _Bearbeiten.DropDownItems.Add(_AllesMakieren);
            _UhrzeitDatum = new ToolStripMenuItem("Uhrzeit/Datum");
            _UhrzeitDatum.Click += _Datum_Click;
            _Bearbeiten.DropDownItems.Add(_UhrzeitDatum);

            //Add to main MenuStrip
            _MenuStrip.Items.Add(_Bearbeiten);
        }

        //Strip Menu Format
        private ToolStripMenuItem _Format;
        private ToolStripMenuItem _ZeilenUmbruch;
        private ToolStripMenuItem _Schriftart;

        private void InitializeMenuFormat()
        {
            _Format = new ToolStripMenuItem("Format");
            _ZeilenUmbruch = new ToolStripMenuItem("Zeilenumbruch");
            _Format.DropDownItems.Add(_ZeilenUmbruch);
            _Schriftart = new ToolStripMenuItem("Schriftart");
            _Format.DropDownItems.Add(_Schriftart);

            //Add to main MenuStrip
            _MenuStrip.Items.Add(_Format);
        }

        //Strip Menu Ansicht
        private ToolStripMenuItem _Ansicht;
        private ToolStripMenuItem _Zoom;
        private ToolStripMenuItem _Statusleiste;

        private void InitializeMenuAnsicht()
        {
            _Ansicht = new ToolStripMenuItem("Ansicht");
            _Zoom = new ToolStripMenuItem("Zoom");
            _Ansicht.DropDownItems.Add(_Zoom);
            _Statusleiste = new ToolStripMenuItem("Statusleiste");
            _Ansicht.DropDownItems.Add(_Statusleiste);

            //Add menu to main MenuStrip
            _MenuStrip.Items.Add(_Ansicht);
        }

        //Strip Menu Hilfe
        private ToolStripMenuItem _Hilfe;
        private ToolStripMenuItem _HilfeAnzeigen;
        private ToolStripMenuItem _FeedbackSenden;
        private ToolStripSeparator _TrennHilfe1;
        private ToolStripMenuItem _Info;

        private void InitializeMenuHilfe()
        {
            _Hilfe = new ToolStripMenuItem("Hilfe");
            _HilfeAnzeigen = new ToolStripMenuItem("Hilfe anzeigen");
            _HilfeAnzeigen.Click += _HilfeAnzeigen_Click;
            _Hilfe.DropDownItems.Add(_HilfeAnzeigen);
            _FeedbackSenden = new ToolStripMenuItem("Feedback senden");
            _Hilfe.DropDownItems.Add(_FeedbackSenden);
            _TrennHilfe1 = new ToolStripSeparator();
            _Hilfe.DropDownItems.Add(_TrennHilfe1);
            _Info = new ToolStripMenuItem("Info");
            _Info.Click += _Info_Click;
            _Hilfe.DropDownItems.Add(_Info);

            //Add menu to main MenuStrip
            _MenuStrip.Items.Add(_Hilfe);
        }

        //RichBox with Properties
        private RichTextBox _TextBox;
        public void RichBoxInitialize()
        {
            _TextBox = new RichTextBox();
            _TextBox.Location = new Point(0, 30);
            _TextBox.Size = new Size(this.Size.Width, this.Size.Height);
            _TextBox.HideSelection = false;
            _TextBox.TextChanged += _TextBoxChange;
        }


        public Editor()
        {
            //Set default values
            _FileName = null;
            _FilePath = null;
            _LastInput = "";

            //Create components
            InitializeComponent();
            ToolStripMenu_Create();

            //Create the search menu
            WS = new WindowSuchen(ref this._TextBox);
        }

        private void ToolStripMenu_Create()
        {
            //Create MenuBar
            _MenuStrip = new MenuStrip();

            //Create parts of the bar
            InitializeMenuDatei();
            InitializeMenuBearbeiten();
            InitializeMenuFormat();
            InitializeMenuAnsicht();
            InitializeMenuHilfe();

            //Initialize the textbox
            RichBoxInitialize();

            //Add MenuStrip and Textbox
            this.Controls.Add(_MenuStrip);
            this.Controls.Add(_TextBox);
        }

        //Form Related Functions
        //Form Related Functions
        //Form Related Functions

        private void Editor_Resize(object sender, EventArgs e)
        {
            //Change size of textbox
            _TextBox.Size = new Size(this.Size.Width, this.Size.Height);
        }

        //Menu Bar Related Functions
        //Menu Bar Related Functions
        //Menu Bar Related Functions

        //Button Template
        /*
        private void _Button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        */

        private void _TextBoxChange(object sender, EventArgs e)
        {
            _TextBoxChangeBackend();
        }

        private void _TextBoxChangeBackend()
        {
            if (_LastInput != _TextBox.Text)
            {
                if (this.Text[0] != '*')
                {
                    this.Text = "*" + this.Text;
                }
            }
            else
            {
                if (_LastInput == _TextBox.Text)
                {
                    if (this.Text[0] == '*')
                    {
                        this.Text = this.Text.Substring(1);
                    }
                }
            }
        }

        private void _Neu_Click(object sender, EventArgs e)
        {
            //Clear the TextBox
            _TextBox.Text = "";
            _FilePath = null;
        }

        private void _neuesFenster_Click(object sender, EventArgs e)
        {
            //Spawn new window
            Editor editor = new Editor();
            editor.Show();
        }

        private void _Oeffnen_Click(object sender, EventArgs e)
        {
            //Show dialog and get the result
            FileDialog FD = new OpenFileDialog();
            DialogResult result = FD.ShowDialog();

            //When the result is okey, load the file
            if(result == DialogResult.OK)
            {
                string path = FD.FileName;
                string[] lines = File.ReadAllLines(path);

                //Put it in the TextBox
                _TextBox.Text = "";
                _LastInput = "";
                for(int i = 0; i < lines.Length; i++)
                {
                    _TextBox.Text += lines[i] + "\n";
                    _LastInput += lines[i] + "\n";
                }

                //Put the file path in an variable
                _FilePath = path;

                //Get the file name and the file path
                string complete_path = FD.FileName;
                string[] split = complete_path.Split(Convert.ToChar(@"\"));
                _FileName = split[split.Length - 1];
                string[] split_minus_one = ReduceArrayByOne(split);
                _FilePath = PutPathTogheter(split_minus_one);

                //Add the filename to the top of the window
                this.Text = _FileName + " - Editor";
            }
        }

        private void _Speichern_Click(object sender, EventArgs e)
        {
            if(_FilePath == null && _FileName == null)
            {
                SpeichernUnterBackend();
            }
            else
            {
                //Write to that directory
                FileStream fs = new FileStream(_FilePath + _FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(_TextBox.Text);
                _LastInput = _TextBox.Text;
                sw.Close();
                fs.Close();
                _TextBoxChangeBackend();
            }
        }

        private void _SpeichernUnter_Click(object sender, EventArgs e)
        {
            SpeichernUnterBackend();
        }

        private void SpeichernUnterBackend()
        {
            //Get path to save to
            FileDialog FD = new SaveFileDialog();
            FD.FileName = "Untitled";
            FD.Filter = "Text(*.txt)|*.txt";
            DialogResult result = FD.ShowDialog();

            //When okey was pressed Output the desired result
            if (result == DialogResult.OK)
            {
                //Get the file name and the file path
                string complete_path = FD.FileName;
                string[] split = complete_path.Split(Convert.ToChar(@"\"));
                _FileName = split[split.Length - 1];
                string[] split_minus_one = ReduceArrayByOne(split);
                _FilePath = PutPathTogheter(split_minus_one);

                //Write to that directory
                FileStream fs = new FileStream(complete_path, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(_TextBox.Text);
                _LastInput = _TextBox.Text;
                sw.Close();
                fs.Close();

                //Set the FileName at the top
                this.Text = _FileName + " - Editor";

                _TextBoxChangeBackend();
            }
        }

        private void _Beenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _Rueckgängig_Click(object sender, EventArgs e)
        {
            _TextBox.Undo();
        }

        private void _CutOut_Click(object sender, EventArgs e)
        {
            _TextBox.Cut();
        }

        private void _Kopieren_Click(object sender, EventArgs e)
        {
            _TextBox.Copy();
        }

        private void _Einfuegen_Click(object sender, EventArgs e)
        {
            _TextBox.Paste();
        }

        private void _Loeschen_Click(object sender, EventArgs e)
        {
             _TextBox.SelectedText = "";
        }

        private void _SucheMitBing_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bing.com/search?q=" + _TextBox.SelectedText + "&form=NPCTXT");
        }

        private void _Suchen_Click(object sender, EventArgs e)
        {
            WS.Show();
        }

        private void _Alles_Makieren_Click(object sender, EventArgs e)
        {
            _TextBox.SelectAll();
        }

        private void _Datum_Click(object sender, EventArgs e)
        {
            _TextBox.SelectedText = DateTime.Now.ToString();
        }

        private void _HilfeAnzeigen_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bing.com/search?q=hilfe+zu+windows-editor+in+windows&filters=guid:%224466414-de-dia%22%20lang:%22de%22&form=T00032&ocid=HelpPane-BingIA");
        }

        private void _Info_Click(object sender, EventArgs e)
        {
            WindowInfo WI = new WindowInfo();
            WI.ShowDialog();
        }

        //Custom Functions
        //Custom Functions
        //Custom Functions
        private string PutPathTogheter(string[] array)
        {
            string path = "";
            for(int i = 0; i < array.Length; i++)
            {
                path += array[i] + @"\";
            }
            return path;
        }

        private string[] ReduceArrayByOne(string[] array)
        {
            string[] temp = new string[array.Length - 1];
            for(int i = 0; i < temp.Length; i++)
            {
                temp[i] = array[i];
            }
            return temp;
        }
    }
}
