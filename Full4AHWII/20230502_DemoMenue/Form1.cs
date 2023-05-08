using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230502_DemoMenue
{
    public partial class Form1 : Form
    {
        private MenuStrip HauptMenue;

        private ToolStripMenuItem mnuSpeichern;
        private ToolStripMenuItem mnuLaden;
        private ToolStripMenuItem mnuOeffnen;
        private ToolStripMenuItem mnuDatei;
        private ToolStripMenuItem mnuBearbeiten;
        private ToolStripMenuItem mnuAuschneiden;
        private ToolStripMenuItem mnuKopieren;
        private ToolStripMenuItem mnuBearbeitenCt;
        private ToolStripMenuItem mnuAuschneidenCt;
        private ToolStripMenuItem mnuKopierenCt;
        private ToolStripSeparator mnuTrenn;
        private ContextMenuStrip MyContextMenu;
        private ContextMenuStrip MyContextMenuPict;

        //Toolbox Elemente
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripTextBox toolStripTextBox1;

        //Statusbar
        private StatusStrip statusStrip1;
        private ToolStripLabel statusStripZeit;

        public Form1()
        {
            InitializeComponent();
            this.HauptMenue = new MenuStrip();

            this.mnuDatei = new ToolStripMenuItem("Datei");
            this.mnuOeffnen = new ToolStripMenuItem("Öffnen");
            this.mnuSpeichern = new ToolStripMenuItem("Speichern");
            this.mnuLaden = new ToolStripMenuItem("Laden");
            this.mnuOeffnen.ShortcutKeys = Keys.Control | Keys.S;
            this.mnuBearbeiten = new ToolStripMenuItem("Bearbeiten");
            this.mnuAuschneiden = new ToolStripMenuItem("Ausschneiden");
            this.mnuKopieren = new ToolStripMenuItem("Kopieren");
            this.mnuTrenn = new ToolStripSeparator();
            this.mnuOeffnen.Click += new EventHandler(mnuOeffnen_Click);
            this.MyContextMenu = new ContextMenuStrip();

            this.mnuAuschneiden.Click += new EventHandler(mnuOeffnen_Click);


            this.HauptMenue.Items.Add(this.mnuDatei);
            this.HauptMenue.Items.Add(mnuTrenn);
            this.HauptMenue.Items.Add(this.mnuBearbeiten);

            this.mnuDatei.DropDownItems.Add(mnuOeffnen);
            this.mnuDatei.DropDownItems.Add(mnuSpeichern);
            this.mnuDatei.DropDownItems.Add(mnuLaden);

            this.mnuBearbeiten.DropDownItems.Add(mnuAuschneiden);
            this.mnuBearbeiten.DropDownItems.Add(mnuKopieren);
            this.mnuOeffnen.Image = Image.FromFile("OpenImage.png");

            this.mnuKopierenCt = new ToolStripMenuItem("Kopieren");
            this.mnuAuschneidenCt = new ToolStripMenuItem("Ausschneiden");
            this.MyContextMenu.Items.Add(this.mnuKopierenCt);
            this.MyContextMenu.Items.Add(this.mnuAuschneidenCt);

            this.MainMenuStrip = this.HauptMenue;

            this.ContextMenuStrip = this.MyContextMenu;

            //Hinzufügen
            this.Controls.Add(HauptMenue);

            //Toolbar
            this.toolStrip1 = new ToolStrip();

            this.toolStripButton1 = new ToolStripButton();
            this.toolStripButton1.Image = Image.FromFile("Diskette.png");
            this.toolStripButton2 = new ToolStripButton();
            //this.toolStripButton2.Image = Image.FromFile("");

            this.toolStripSplitButton1 = new ToolStripSplitButton("Lesezeichen");

            this.toolStrip1.Items.Add(this.toolStripButton1);
            this.toolStrip1.Items.Add(this.toolStripSplitButton1);

            this.toolStripSplitButton1.DropDownItems.Add(this.toolStripButton2);

            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.HauptMenue);

            statusStrip1 = new StatusStrip();
            statusStripZeit = new ToolStripLabel();
            statusStripZeit.Text = "Zeit: " + DateTime.Now.ToLongTimeString();
            statusStrip1.Items.Add(statusStripZeit);
            this.Controls.Add(this.statusStrip1);

            //Timer für die zeit starten
            Timer TimerZeit = new Timer();
            TimerZeit.Interval = 1000;
            TimerZeit.Tick += TimerZeit_Tick;
            TimerZeit.Start();
        }

        private void TimerZeit_Tick(object sender, EventArgs e)
        {
            statusStripZeit.Text = "Zeit: " + DateTime.Now.ToLongTimeString();
        }

        public void mnuOeffnen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funktioniert!");
        }
    }
}
