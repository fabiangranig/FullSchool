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

namespace _20220427_ListBoxWechsler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Close the programm
            this.Close();
        }

        private void btn_nachRechts_Click(object sender, EventArgs e)
        {
            //Save the information from the listbox
            int runs = lB1.SelectedIndices.Count;
            int[] list1 = new Int32[runs];
            int[] list2 = new Int32[runs];
            for (int i = 0; i < runs; i++)
            {
                //Save index + number
                int index = lB1.SelectedIndex;
                list1[i] = index + i;
                list2[i] = Int32.Parse(Convert.ToString(lB1.Items[index]));

                //Delete the value
                lB1.Items.RemoveAt(index);
            }

            //Remove the selected items
            while (lB1.SelectedItems.Count > 0)
            {
                lB1.Items.Remove(lB1.SelectedItems[0]);
            }

            //Insert these values on the other site
            for(int i = 0; i < list1.Length; i++)
            {
                int howlarge = lB2.Items.Count;
                if(howlarge > list1[i] + i)
                {
                    lB2.Items.Insert(list1[i], list2[i]);
                }
                else
                {
                    lB2.Items.Add(list2[i]);
                }
            }
        }

        

        private void btn_nachLinks_Click(object sender, EventArgs e)
        {
            //Save the information from the listbox
            int runs = lB2.SelectedIndices.Count;
            int[] list1 = new Int32[runs];
            int[] list2 = new Int32[runs];
            for (int i = 0; i < runs; i++)
            {
                //Save index + number
                int index = lB2.SelectedIndex;
                list1[i] = index + i;
                list2[i] = Int32.Parse(Convert.ToString(lB2.Items[index]));

                //Delete the value
                lB2.Items.RemoveAt(index);
            }

            //Remove the selected items
            while (lB2.SelectedItems.Count > 0)
            {
                lB2.Items.Remove(lB2.SelectedItems[0]);
            }

            //Insert these values on the other site
            for (int i = 0; i < list1.Length; i++)
            {
                int howlarge = lB1.Items.Count;
                if (howlarge > list1[i] + i)
                {
                    lB1.Items.Insert(list1[i], list2[i]);
                }
                else
                {
                    lB1.Items.Add(list2[i]);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Remove the selected items for lB1
            while (lB1.SelectedItems.Count > 0)
            {
                lB1.Items.Remove(lB1.SelectedItems[0]);
            }

            //Remove the selected items for lB2
            while (lB2.SelectedItems.Count > 0)
            {
                lB2.Items.Remove(lB2.SelectedItems[0]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create Random variables
            Random random = new Random();

            //for-Loop to get the values in the boxes
            for (int i = 0; i < 10; i++)
            {
                lB1.Items.Add(random.Next(1, 20));
            }
        }

        private void btn_alldelete_Click(object sender, EventArgs e)
        {
            //Alles aus den Listboxes entfernen
            lB1.Items.Clear();
            lB2.Items.Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Speichern der ersten Listbox
            FileStream fs = new FileStream("text.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            for(int i = 0; i < lB1.Items.Count; i++)
            {
                sw.WriteLine(lB1.Items[i]);
            }

            sw.Close();
            fs.Close();

            //Speichern der zweiten Listbox
            FileStream fs2 = new FileStream("text2.txt", FileMode.Create);
            StreamWriter sw2 = new StreamWriter(fs2);

            for (int i = 0; i < lB2.Items.Count; i++)
            {
                sw2.WriteLine(lB2.Items[i]);
            }

            sw2.Close();
            fs2.Close();
        }

        private void btn_Laden_Click(object sender, EventArgs e)
        {
            //Laden der ersten ListBox
            FileStream zeichen = new FileStream("text.txt", FileMode.Open);
            StreamReader lesen = new StreamReader(zeichen);

            lB1.Items.Clear();

            string zeilen = lesen.ReadLine();
            while (zeilen != null)
            {
                lB1.Items.Add(zeilen);
                zeilen = lesen.ReadLine();
            }

            lesen.Close();

            //Laden der zweite ListBox
            FileStream zeichen2 = new FileStream("text2.txt", FileMode.Open);
            StreamReader lesen2 = new StreamReader(zeichen2);

            lB2.Items.Clear();

            string zeilen2 = lesen2.ReadLine();
            while (zeilen2 != null)
            {
                lB2.Items.Add(zeilen2);
                zeilen2 = lesen2.ReadLine();
            }

            lesen2.Close();
        }

        private void btn_SaveBinaer_Click(object sender, EventArgs e)
        {
            //Speichern der ersten Listbox
            FileStream fs = new FileStream("text.dat", FileMode.Create);
            BinaryWriter sw = new BinaryWriter(fs);

            for (int i = 0; i < lB1.Items.Count; i++)
            {
                string u = Convert.ToString(lB1.Items[i]);
                sw.Write(u);
            }

            sw.Close();
            fs.Close();

            //Speichern der zweiten Listbox
            FileStream fs2 = new FileStream("text2.dat", FileMode.Create);
            BinaryWriter sw2 = new BinaryWriter(fs2);

            for (int i = 0; i < lB2.Items.Count; i++)
            {
                string u = Convert.ToString(lB2.Items[i]);
                sw2.Write(u);
            }

            sw2.Close();
            fs2.Close();
        }

        private void btn_LoadBinaer_Click(object sender, EventArgs e)
        {
            //Laden der ersten ListBox
            FileStream zeichen = new FileStream("text.dat", FileMode.Open);
            BinaryReader lesen = new BinaryReader(zeichen);

            lB1.Items.Clear();

            while (lesen.PeekChar() > -1)
            {
                string z = lesen.ReadString();
                lB1.Items.Add(z);
            }

            lesen.Close();

            //Laden der zweite ListBox
            FileStream zeichen2 = new FileStream("text2.dat", FileMode.Open);
            BinaryReader lesen2 = new BinaryReader(zeichen2);

            lB2.Items.Clear();

            while (lesen2.PeekChar() > -1)
            {
                string z = lesen2.ReadString();
                lB2.Items.Add(z);
            }

            lesen2.Close();
        }
    }
}
