using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230508_bewegterText
{
    public partial class Form1 : Form
    {
        //Variables
        private MenuStrip _Menu;

        private ToolStripMenuItem _Programm;
        private ToolStripMenuItem _Starten;
        private ToolStripMenuItem _Beenden;
        private ToolStripSeparator _Trenn;
        private ToolStripMenuItem _Schließen;

        private ToolStripMenuItem _Richtung;
        private ToolStripMenuItem _Links;
        private ToolStripMenuItem _Rechts;
        private ToolStripMenuItem _Unten;
        private ToolStripMenuItem _Oben;
        private ToolStripSeparator _Trenn2;

        private int _Speed;
        private char _Direction;
        private Label _bewegenderText;
        private Timer _MovementTimer;

        private TrackBar _Trackbar;


        public Form1()
        {
            InitializeComponent();

            //Initialize componenets
            _Menu = new MenuStrip();

            //First Top Menues
            _Programm = new ToolStripMenuItem("Programm");
            _Starten = new ToolStripMenuItem("Starten");
            _Starten.Click += StarterMove;
            _Programm.DropDownItems.Add(_Starten);
            _Beenden = new ToolStripMenuItem("Beenden");
            _Beenden.Click += StopMove;
            _Programm.DropDownItems.Add(_Beenden);
            _Trenn = new ToolStripSeparator();
            _Programm.DropDownItems.Add(_Trenn);
            _Schließen = new ToolStripMenuItem("Schließen");
            _Schließen.Click += CloseApp;
            _Programm.DropDownItems.Add(_Schließen);

            _Richtung = new ToolStripMenuItem("Richtung");
            _Links = new ToolStripMenuItem("Links");
            _Links.Click += DirectionSetter;
            _Richtung.DropDownItems.Add(_Links);
            _Rechts = new ToolStripMenuItem("Rechts");
            _Rechts.Click += DirectionSetter;
            _Richtung.DropDownItems.Add(_Rechts);
            _Unten = new ToolStripMenuItem("Unten");
            _Unten.Click += DirectionSetter;
            _Richtung.DropDownItems.Add(_Unten);
            _Oben = new ToolStripMenuItem("Oben");
            _Oben.Click += DirectionSetter;
            _Richtung.DropDownItems.Add(_Oben);
            _Trenn2 = new ToolStripSeparator();
            _Richtung.DropDownItems.Add(_Trenn2);

            //Add Menues to bars
            _Menu.Items.Add(_Programm);
            _Menu.Items.Add(_Richtung);

            //Add items to form
            this.Controls.Add(_Menu);

            //Set the speed
            _Speed = 3;

            //Add the trackbar
            _Trackbar = new TrackBar();
            _Trackbar.Location = new Point(20, 40);
            _Trackbar.Value = _Speed;
            this.Controls.Add(_Trackbar);

            //Set default value for char
            _Direction = 'D';

            //Initialize the bewegenden Text
            _bewegenderText = new Label();
            _bewegenderText.Text = "bewegender Text";
            _bewegenderText.Location = new Point(this.Size.Width / 3, this.Size.Height / 3);
            this.Controls.Add(_bewegenderText);
        }

        public void DirectionSetter(object sender, EventArgs e)
        {
            ToolStripMenuItem temp = (ToolStripMenuItem)sender;
            _Direction = temp.Text[0];
        }

        public void StarterMove(object sender, EventArgs e)
        {
            //Timer for movement
            _MovementTimer = new Timer();
            _MovementTimer.Interval = 10;
            _MovementTimer.Tick += TimerMovement;
            _MovementTimer.Start();
        }

        public void TimerMovement(object sender, EventArgs e)
        {
            //Get the new position
            _Speed = _Trackbar.Value;

            //Move towards that direction
            if(_Direction == 'L')
            {
                if(_bewegenderText.Location.X - _Speed > 0)
                {
                    _bewegenderText.Location = new Point(_bewegenderText.Location.X - _Speed, _bewegenderText.Location.Y);
                }
            }
            if (_Direction == 'R')
            {
                if(_bewegenderText.Location.X + _Speed < this.Size.Width - _bewegenderText.Width)
                {
                    _bewegenderText.Location = new Point(_bewegenderText.Location.X + _Speed, _bewegenderText.Location.Y);
                }
            }
            if (_Direction == 'O')
            {
                if(_bewegenderText.Location.Y - _Speed > 0 + 50)
                {
                    _bewegenderText.Location = new Point(_bewegenderText.Location.X, _bewegenderText.Location.Y - _Speed);
                }
            }
            if (_Direction == 'U')
            {
                if(_bewegenderText.Location.Y + _Speed < this.Size.Height - _bewegenderText.Height - 50)
                {
                    _bewegenderText.Location = new Point(_bewegenderText.Location.X, _bewegenderText.Location.Y + _Speed);
                }
            }
        }

        public void StopMove(object sender, EventArgs e)
        {
            _MovementTimer.Stop();
        }

        public void CloseApp(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
