using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace _20240219_Geometrie
{
    public partial class Geometrie : Form
    {
        private List<GeometricObject> _GeometricObjects;
        private string _Path;

        public Geometrie()
        {
            InitializeComponent();
            this.pictureBox_Zeichnen.Width = 300;
            this.pictureBox_Zeichnen.Height = 300;
            this._GeometricObjects = new List<GeometricObject>();
        }

        public void ReadInFile()
        {
            string[] lines = File.ReadAllLines(this._Path);
            for(int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(';');
                this._GeometricObjects.Add(new GeometricObject(split[0], Int32.Parse(split[1]), Int32.Parse(split[2]), Int32.Parse(split[3]), Int32.Parse(split[4])));
            }
            this.pictureBox_Zeichnen.Invalidate();
        }

        private void pictureBox_Zeichnen_Paint(object sender, PaintEventArgs e)
        {
            Pen PenBlue = new Pen(Color.Blue);
            Pen PenRed = new Pen(Color.Red);
            Pen PenGreen = new Pen(Color.Green);
            Graphics PictureBox_Grapics = e.Graphics;
            foreach (GeometricObject item in this._GeometricObjects)
            {
                switch(item.Name)
                {
                    case "Linie":
                        PictureBox_Grapics.DrawLine(PenBlue, new Point(item.XBegin, item.YBegin), new Point(item.XEnd, item.YEnd));
                        break;
                    case "Rechteck":
                        PictureBox_Grapics.DrawRectangle(PenRed, item.XBegin, item.YBegin, item.XEnd, item.YEnd);
                        break;
                    case "Ellipse":
                        PictureBox_Grapics.DrawEllipse(PenGreen, item.XBegin, item.YBegin, item.XEnd, item.YEnd);
                        break;
                }
            }
        }

        private void button_Grafiken_Click(object sender, EventArgs e)
        {
            //Count the graphics
            int CountLinie = CountGrafikName("Linie");
            int CountRechteck = CountGrafikName("Rechteck");
            int CountEllipse = CountGrafikName("Ellipse");

            //Show the counted objects
            MessageBox.Show("" +
                "Linienanzahl: " + CountLinie + "\n" +
                "Rechteckanzahl: " + CountRechteck + "\n" +
                "Ellipsenanzahl: " + CountEllipse);
        }

        private int CountGrafikName(string NameToBeCounted)
        {
            int count = 0;
            foreach(GeometricObject item in this._GeometricObjects)
            {
                if(item.Name == NameToBeCounted)
                {
                    count++;
                }
            }
            return count;
        }

        private void GetTableFromDataBase()
        {
            //Set connection and command
            OleDbConnection OleDBConnectionGeometrie = new OleDbConnection("Data Source=Geometrie.mdb; Provider=Microsoft.Jet.OLEDB.4.0");
            OleDbCommand command = new OleDbCommand();
            command.Connection = OleDBConnectionGeometrie;
            command.CommandText = "SELECT  * FROM GEOMETRIE;";

            //Open connection
            OleDBConnectionGeometrie.Open();
            OleDbDataReader DataReader = command.ExecuteReader();

            //Add line by line
            while (DataReader.Read())
            {
                this._GeometricObjects.Add(new GeometricObject(DataReader.GetString(0), DataReader.GetInt32(1), DataReader.GetInt32(2), DataReader.GetInt32(3), DataReader.GetInt32(4)));
            }

            //Close connection
            OleDBConnectionGeometrie.Close();

            //Reload Picturebox
            this.pictureBox_Zeichnen.Invalidate();
        }

        private void button_DrawTxt_Click(object sender, EventArgs e)
        {
            FileDialog FD = new OpenFileDialog();
            DialogResult result = FD.ShowDialog();
            this._Path = FD.FileName;
            ReadInFile();
        }

        private void button_DrawSQL_Click(object sender, EventArgs e)
        {
            GetTableFromDataBase();
        }
    }
}
