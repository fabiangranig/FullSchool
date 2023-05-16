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

        private ToolStripMenuItem _Layout;
        private ToolStripMenuItem _Hintergrundfarbe;
        private ToolStripMenuItem _Schriftart;
        private ToolStripMenuItem _Blinken;

        private ToolStripMenuItem _Text;
        private ToolStripMenuItem _TextAendern;

        private int _Speed;
        private char _Direction;
        private Label _bewegenderText;
        private Timer _MovementTimer;

        private TrackBar _Trackbar;

        private Color c1;
        private Color c2;


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

            _Layout = new ToolStripMenuItem("Layout");
            _Hintergrundfarbe = new ToolStripMenuItem("Hintergrundfarbe");
            _Hintergrundfarbe.Click += _Hintergrundfarbe_Click;
            _Layout.DropDownItems.Add(_Hintergrundfarbe);
            _Schriftart = new ToolStripMenuItem("Schriftart");
            _Schriftart.Click += _Schriftart_Click;
            _Layout.DropDownItems.Add(_Schriftart);
            _Blinken = new ToolStripMenuItem("Blinken");
            _Blinken.Click += _Blinken_Click;
            _Layout.DropDownItems.Add(_Blinken);

            _Text = new ToolStripMenuItem("Text");
            _TextAendern = new ToolStripMenuItem("Text ändern");
            _TextAendern.Click += _TextAendern_Click;
            _Text.DropDownItems.Add(_TextAendern);

            //Add Menues to bars
            _Menu.Items.Add(_Programm);
            _Menu.Items.Add(_Richtung);
            _Menu.Items.Add(_Layout);
            _Menu.Items.Add(_Text);

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

        private void _TextAendern_Click(object sender, EventArgs e)
        {
            TextAendernUntermenue TAU = new TextAendernUntermenue(_bewegenderText.Text);
            DialogResult result = TAU.ShowDialog();
            if(result == DialogResult.OK)
            {
                _bewegenderText.Text = TAU.Aenderungstext;
                _bewegenderText.Width = _bewegenderText.Text.Length * 10;
            }
        }

        private void _Blinken_Click(object sender, EventArgs e)
        {
            //Set colors
            ColorDialog MyDialog = new ColorDialog();
            DialogResult MyRes;

            MyDialog.Color = this.BackColor;
            MyRes = MyDialog.ShowDialog();
            if (MyRes == DialogResult.OK)
            {
                c1 = MyDialog.Color;
            }

            MyDialog.Color = this.BackColor;
            MyRes = MyDialog.ShowDialog();
            if (MyRes == DialogResult.OK)
            {
                c2 = MyDialog.Color;
            }

            //Set the first backcolor
            this.BackColor = c1;

            //Enable Blinker
            Timer Blinker = new Timer();
            Blinker.Interval = 1500;
            Blinker.Tick += Blinker_Tick;
            Blinker.Start();
        }

        private void Blinker_Tick(object sender, EventArgs e)
        {
            if(c1.Name == this.BackColor.Name)
            {
                this.BackColor = c2;
            }
            else if (c2.Name == this.BackColor.Name)
            {
                this.BackColor = c1;
            }
        }

        private void _Schriftart_Click(object sender, EventArgs e)
        {
            FontDialog FD = new FontDialog();
            DialogResult MyRes;
            FD.Font = this.Font;
            MyRes = FD.ShowDialog();

            if(MyRes == DialogResult.OK)
            {
                this.Font = FD.Font;
            }
        }

        private void _Hintergrundfarbe_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            DialogResult MyRes;
            MyDialog.Color = this.BackColor;
            MyRes = MyDialog.ShowDialog();

            if(MyRes == DialogResult.OK)
            {
                this.BackColor = MyDialog.Color;
            }
        }

        public void DirectionSetter(object sender, EventArgs e)
        {
            //Remove all clicked buttons
            _Links.ForeColor = Color.Black;
            _Rechts.ForeColor = Color.Black;
            _Unten.ForeColor = Color.Black;
            _Oben.ForeColor = Color.Black;

            //Set clicked status
            ToolStripMenuItem temp = (ToolStripMenuItem)sender;
            _Direction = temp.Text[0];
            temp.ForeColor = Color.Green;
        }

        public void StarterMove(object sender, EventArgs e)
        {
            //Timer for movement
            _MovementTimer = new Timer();
            _MovementTimer.Interval = _Speed;
            _MovementTimer.Tick += TimerMovement;
            _MovementTimer.Start();
        }

        public void TimerMovement(object sender, EventArgs e)
        {
            //Set the speed
            _Speed = _Trackbar.Value;

            //Move towards that direction
            if (_Direction == 'L')
            {
                _bewegenderText.Location = new Point(_bewegenderText.Location.X - _Speed, _bewegenderText.Location.Y);

                if(_bewegenderText.Location.X < -1 * _bewegenderText.Width)
                {
                    _bewegenderText.Location = new Point(this.Width, _bewegenderText.Location.Y);
                }
            }
            if (_Direction == 'R')
            {
                _bewegenderText.Location = new Point(_bewegenderText.Location.X + _Speed, _bewegenderText.Location.Y);

                if (_bewegenderText.Location.X > this.Width)
                {
                    _bewegenderText.Location = new Point(-1 * _bewegenderText.Width, _bewegenderText.Location.Y);
                }
            }
            if (_Direction == 'O')
            {
                _bewegenderText.Location = new Point(_bewegenderText.Location.X, _bewegenderText.Location.Y - _Speed);

                if (_bewegenderText.Location.Y < 0)
                {
                    _bewegenderText.Location = new Point(_bewegenderText.Location.X, this.Height);
                }
            }
            if (_Direction == 'U')
            {
                _bewegenderText.Location = new Point(_bewegenderText.Location.X, _bewegenderText.Location.Y + _Speed);

                if (_bewegenderText.Location.Y > this.Height)
                {
                    _bewegenderText.Location = new Point(_bewegenderText.Location.X, -20);
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
