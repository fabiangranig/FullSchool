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
        WindowSuchen _WS;

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
            _SeiteEinrichten.Enabled = false;
            _Datei.DropDownItems.Add(_SeiteEinrichten);
            _Drucken = new ToolStripMenuItem("Drucken");
            _Drucken.Enabled = false;
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
            _Weitersuchen.Click += _Weitersuchen_Click;
            _Bearbeiten.DropDownItems.Add(_Weitersuchen);
            _VorherigeSuchen = new ToolStripMenuItem("vorherige Suche");
            _Bearbeiten.DropDownItems.Add(_VorherigeSuchen);
            _Ersetzen = new ToolStripMenuItem("Ersetzen");
            _Ersetzen.Click += _Ersetzen_Click;
            _Bearbeiten.DropDownItems.Add(_Ersetzen);
            _WechselnSieZu = new ToolStripMenuItem("Wechseln Sie zu");
            _WechselnSieZu.Click += _WechselnSieZu_Click;
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
            _ZeilenUmbruch.Click += _Zeilenumbruch_Click;
            _Format.DropDownItems.Add(_ZeilenUmbruch);
            _Schriftart = new ToolStripMenuItem("Schriftart");
            _Schriftart.Click += _Schriftart_Click;
            _Format.DropDownItems.Add(_Schriftart);

            //Add to main MenuStrip
            _MenuStrip.Items.Add(_Format);
        }

        //Strip Menu Ansicht
        private ToolStripMenuItem _Ansicht;
        private ToolStripMenuItem _Zoom;
        private ToolStripMenuItem _Vergroessern;
        private ToolStripMenuItem _Verkleinern;
        private ToolStripMenuItem _StandartWiederherstellen;
        private ToolStripMenuItem _Statusleiste;

        private void InitializeMenuAnsicht()
        {
            _Ansicht = new ToolStripMenuItem("Ansicht");
            _Zoom = new ToolStripMenuItem("Zoom");
            _Vergroessern = new ToolStripMenuItem("Vergrößern");
            _Vergroessern.Click += _Vergroessern_Click;
            _Verkleinern = new ToolStripMenuItem("Verkleinern");
            _Verkleinern.Click += _Verkleinern_Click;
            _StandartWiederherstellen = new ToolStripMenuItem("Standart wiederherstellen");
            _StandartWiederherstellen.Click += _StandartWiederherstellen_Click;
            _Zoom.DropDownItems.Add(_Vergroessern);
            _Zoom.DropDownItems.Add(_Verkleinern);
            _Zoom.DropDownItems.Add(_StandartWiederherstellen);
            _Ansicht.DropDownItems.Add(_Zoom);
            _Statusleiste = new ToolStripMenuItem("Statusleiste");
            _Statusleiste.Click += _Statusleiste_Click;
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
            _FeedbackSenden.Enabled = false;
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
            _TextBox.Location = new Point(0, 65);
            _TextBox.Size = new Size(this.Size.Width, this.Size.Height - 125);
            _TextBox.HideSelection = false;
            _TextBox.TextChanged += _TextBoxChange;

            //Add automatic resizing when size is changed
            this.Resize += Editor_Resize;
        }

        //Statusbar with properties
        private StatusBar _statusbar;
        private StatusBarPanel _statusbarUhrzeit;
        private StatusBarPanel _statusbarWoerter;
        private StatusBarPanel _statusbarZeichen;
        public void StatusBarInitialize()
        {
            _statusbar = new StatusBar();
            _statusbarUhrzeit = new StatusBarPanel();
            _statusbarUhrzeit.Text = DateTime.Now.ToString();
            _statusbarUhrzeit.AutoSize = StatusBarPanelAutoSize.Spring;
            _statusbar.Panels.Add(_statusbarUhrzeit);
            _statusbarWoerter = new StatusBarPanel();
            _statusbarWoerter.Text = "Wörter: 0";
            _statusbar.Panels.Add(_statusbarWoerter);
            _statusbarZeichen = new StatusBarPanel();
            _statusbarZeichen.Text = "Zeichen: 0";
            _statusbar.Panels.Add(_statusbarZeichen);

            //Set Timer for time
            Timer UhrzeitTimer = new Timer();
            UhrzeitTimer.Interval = 1000;
            UhrzeitTimer.Tick += UhrzeitUpdate;
            UhrzeitTimer.Start();
        }

        private void UhrzeitUpdate(object sender, EventArgs e)
        {
            _statusbarUhrzeit.Text = DateTime.Now.ToString();
        }

        //Toolbox with properties
        private ToolBar _toolBar;
        private Button _toolBarButtonNeu;
        private Button _toolBarButtonOeffnen;
        private Button _toolBarButtonSave;
        private ComboBox _toolBarFont;
        private Button _toolBarButtonBold;
        private Button _toolBarButtonItalic;
        private Button _toolBarButtonUnterline;
        public void ToolBarInitialize()
        {
            //Create toolbar
            _toolBar = new ToolBar();
            _toolBar.AutoSize = true;

            //Create controls for toolbar
            _toolBarButtonNeu = new Button();
            _toolBarButtonNeu.Text = "Neu";
            _toolBarButtonNeu.Location = new Point(0, 10);
            _toolBarButtonNeu.Size = new Size(50, 20);
            _toolBarButtonNeu.Click += _Neu_Click;
            _toolBarButtonOeffnen = new Button();
            _toolBarButtonOeffnen.Text = "Öffnen";
            _toolBarButtonOeffnen.Location = new Point(50, 10);
            _toolBarButtonOeffnen.Size = new Size(50, 20);
            _toolBarButtonOeffnen.Click += _Oeffnen_Click;
            _toolBarButtonSave = new Button();
            _toolBarButtonSave.Text = "Save";
            _toolBarButtonSave.Location = new Point(100, 10);
            _toolBarButtonSave.Size = new Size(50, 20);
            _toolBarButtonSave.Click += _SpeichernUnter_Click;
            _toolBarFont = new ComboBox();
            _toolBarFont.Location = new Point(150, 10);
            _toolBarButtonBold = new Button();
            _toolBarButtonBold.Text = "F";
            _toolBarButtonBold.Location = new Point(271, 10);
            _toolBarButtonBold.Size = new Size(50, 20);;
            _toolBarButtonItalic = new Button();
            _toolBarButtonItalic.Text = "I";
            _toolBarButtonItalic.Location = new Point(321, 10);
            _toolBarButtonItalic.Size = new Size(50, 20);
            _toolBarButtonUnterline = new Button();
            _toolBarButtonUnterline.Text = "U";
            _toolBarButtonUnterline.Location = new Point(371, 10);
            _toolBarButtonUnterline.Size = new Size(50, 20);
            foreach (FontFamily font in FontFamily.Families) { _toolBarFont.Items.Add(font.Name); }
            _toolBarFont.TextChanged += _toolBarFont_TextChanged;

            //Add images to image list
            //ImageList imageList = new ImageList();
            //imageList.Images.Add(Image.FromFile(@"images\New.png"));
            //imageList.Images.Add(Image.FromFile(@"images\Open.png"));
            //imageList.Images.Add(Image.FromFile(@"images\Save.png"));
            //_toolBar.ImageList = imageList;

            ////Add images to buttons
            //_toolBarButtonNeu.ImageIndex = 0;
            //_toolBarButtonOeffnen.ImageIndex = 1;
            //_toolBarButtonSave.ImageIndex = 2;

            //Add buttons to toolbar
            _toolBar.Controls.Add(_toolBarButtonNeu);
            _toolBar.Controls.Add(_toolBarButtonOeffnen);
            _toolBar.Controls.Add(_toolBarButtonSave);
            _toolBar.Controls.Add(_toolBarFont);
            _toolBar.Controls.Add(_toolBarButtonBold);
            _toolBar.Controls.Add(_toolBarButtonItalic);
            _toolBar.Controls.Add(_toolBarButtonUnterline);
        }

        //Contextmenu with properties
        private ContextMenu _contextMenu;
        public void ContextInitialize()
        {
            //Create context menu with buttons
            _contextMenu = new ContextMenu();
            _contextMenu.MenuItems.Add("Kopieren");
            _contextMenu.MenuItems.Add("Ausschneiden");
            _contextMenu.MenuItems.Add("Einfügen");

            //Add click events
            _contextMenu.MenuItems[0].Click += _Kopieren_Click;
            _contextMenu.MenuItems[1].Click += _CutOut_Click;
            _contextMenu.MenuItems[2].Click += _Einfuegen_Click;

            //Assign it to the textbox
            _TextBox.ContextMenu = _contextMenu;
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
            _WS = new WindowSuchen(ref this._TextBox);
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

            //Initialize the textbox, toolBar, ContextMenu and statusbar
            RichBoxInitialize();
            StatusBarInitialize();
            ToolBarInitialize();
            ContextInitialize();

            //Add MenuStrip, Statusbar, ToolStrip and Textbox
            this.Controls.Add(_toolBar);
            this.Controls.Add(_MenuStrip);
            this.Controls.Add(_TextBox);
            _statusbar.ShowPanels = true;
            this.Controls.Add(_statusbar);
        }

        //Form Related Functions
        //Form Related Functions
        //Form Related Functions

        private void Editor_Resize(object sender, EventArgs e)
        {
            //Change size of textbox
            _TextBox.Size = new Size(this.Size.Width, this.Size.Height - 125);
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
            //Check for saved condition
            _TextBoxChangeBackend();

            //Change words in display
            _statusbarZeichen.Text = "Zeichen: " + _TextBox.Text.Length;
            string[] split = _TextBox.Text.Split(' ');
            _statusbarWoerter.Text = "Wörter: " + split.Length;
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
            _Neu_Click_Backend();
        }

        private void _Neu_Click_Backend()
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
            _Oeffnen_Click_Backend();
        }

        private void _Oeffnen_Click_Backend()
        {
            //Show dialog and get the result
            FileDialog FD = new OpenFileDialog();
            DialogResult result = FD.ShowDialog();

            //When the result is okey, load the file
            if (result == DialogResult.OK)
            {
                string path = FD.FileName;

                //Put the file path in an variable
                _FilePath = path;

                if (path[path.Length - 1] == 'f' && path[path.Length - 2] == 't' && path[path.Length - 3] == 'r')
                {
                    _TextBox.Font = DefaultFont;
                    _TextBox.LoadFile(path);
                }

                if(path[path.Length - 1] == 't' && path[path.Length - 2] == 'x' && path[path.Length - 3] == 't')
                {
                    _TextBox.Font = DefaultFont;

                    //Get the file name and the file path
                    string complete_path = FD.FileName;
                    string[] split = complete_path.Split(Convert.ToChar(@"\"));
                    _FileName = split[split.Length - 1];
                    string[] split_minus_one = ReduceArrayByOne(split);
                    _FilePath = PutPathTogheter(split_minus_one);

                    string[] lines = File.ReadAllLines(path);

                    //Put it in the TextBox
                    _TextBox.Text = "";
                    for (int i = 0; i < lines.Length; i++)
                    {
                        _TextBox.Text += lines[i] + "\n";
                    }
                    _LastInput = _TextBox.Text;

                    //Add the filename to the top of the window
                    this.Text = _FileName + " - Editor";
                }
            }
        }

        private void _Speichern_Click(object sender, EventArgs e)
        {
            _Speichern_Click_Backend();
        }

        private void _Speichern_Click_Backend()
        {
            if (_FilePath == null && _FileName == null)
            {
                SpeichernUnterBackend();
            }
            else
            {
                if(_FilePath[_FilePath.Length - 1] == 't' && _FilePath[_FilePath.Length - 2] == 'x' && _FilePath[_FilePath.Length - 3] == 't')
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

                if (_FilePath[_FilePath.Length - 1] == 'f' && _FilePath[_FilePath.Length - 2] == 't' && _FilePath[_FilePath.Length - 3] == 'r')
                {
                    _TextBox.SaveFile(_FilePath);
                }
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
            FD.Filter = "Text(*.txt)|*.txt|RTF File (.rtf)|.rtf";

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

                if (complete_path[complete_path.Length - 1] == 't' && complete_path[complete_path.Length - 2] == 'x' && complete_path[complete_path.Length - 3] == 't')
                {
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

                if (complete_path[complete_path.Length - 1] == 'f' && complete_path[complete_path.Length - 2] == 't' && complete_path[complete_path.Length - 3] == 'r')
                {
                    _TextBox.SaveFile(complete_path);

                    //Set the FileName at the top
                    this.Text = _FileName + " - Editor";

                    _TextBoxChangeBackend();
                }
            }
        }

        private void _toolBarFont_TextChanged(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families) 
            {
                if(font.Name == _toolBarFont.Text)
                {
                    _TextBox.SelectionFont = new Font(font.Name, _TextBox.Font.Size);
                    break;
                }
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
            _WS.Show();
        }

        private void _Weitersuchen_Click(object sender, EventArgs e)
        {
            _WS.SearchBottom();
        }

        private void _Ersetzen_Click(object sender, EventArgs e)
        {
            WindowErsetzen WE = new WindowErsetzen(ref _TextBox);
            WE.Show();
        }

        private void _WechselnSieZu_Click(object sender, EventArgs e)
        {
            //Get the position to set to
            string number = SelfBuildDialogues.TextDialog("Zeile eingeben: ", "Eingabe");
            int line;
            bool enable = Int32.TryParse(number, out line);

            if(enable == true)
            {
                //Set the pointer to the position
                string text = _TextBox.Text;
                string[] split = text.Split('\n');
                int sum = 0;
                for (int i = 0; i < split.Length; i++)
                {
                    sum += split[i].Length + 1;

                    if (i == line - 2)
                    {
                        break;
                    }
                }
                _TextBox.SelectionStart = sum;
            }
        }

        private void _Alles_Makieren_Click(object sender, EventArgs e)
        {
            _TextBox.SelectAll();
        }

        private void _Datum_Click(object sender, EventArgs e)
        {
            _TextBox.SelectedText = DateTime.Now.ToString();
        }

        private void _Zeilenumbruch_Click(object sender, EventArgs e)
        {
            _TextBox.SelectedText = "\n";
        }

        private void _Schriftart_Click(object sender, EventArgs e)
        {
            FontDialog FD = new FontDialog();
            DialogResult result = FD.ShowDialog();

            if(result == DialogResult.OK)
            {
                _TextBox.Font = FD.Font;
            }
        }

        private void _Vergroessern_Click(object sender, EventArgs e)
        {
            _TextBox.ZoomFactor *= 1.1f;
        }

        private void _Verkleinern_Click(object sender, EventArgs e)
        {
            _TextBox.ZoomFactor *= 0.9f;
        }

        private void _StandartWiederherstellen_Click(object sender, EventArgs e)
        {
            _TextBox.ZoomFactor = 1;
        }

        private void _Statusleiste_Click(object sender, EventArgs e)
        {
            _statusbar.Visible = !_statusbar.Visible;
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
