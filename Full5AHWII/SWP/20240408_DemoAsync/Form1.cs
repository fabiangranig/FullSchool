using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20240408_DemoAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button_Suche_Click(object sender, EventArgs e)
        {
            //Deaktivieren die Schaltfläche während der Suche, um mehrfache Klicks zu verhindern
            this.button_Suche.Enabled = false;

            //Starte die Dateisuche asynchron
            //await: Auswertung wird so lange gestoppt, bis asychrone Methode abgeschlossen ist
            string[] files = await SearchFilesAsync(this.textBox_File.Text, textBox_FileExtension.Text);

            //Zeige die gefundenen Dateien in der ListBox an
            this.listBox_listFiles.Items.Clear();
            this.listBox_listFiles.Items.AddRange(files);

            //Aktiviere die Schaltfläche wieder
            button_Suche.Enabled = true;
        }

        private async Task<string[]> SearchFilesAsync(string directory, string extension)
        {
            try
            {
                //Suche rekursiv nach Dateien mit der angegebenen Erweiterung
                string[] files = await Task.Run(() => Directory.GetFiles(directory, $"*.{extension}", SearchOption.AllDirectories));
                return files;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Fehler bei der Dateisuche: {e.Message}", "Fehler");
                return new string[0];
            }
        }
    }
}
