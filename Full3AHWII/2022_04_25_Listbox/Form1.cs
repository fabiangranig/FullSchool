using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220425_Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AnfangAdd_Click(object sender, EventArgs e)
        {
            //Get the Items into an array
            string[] array = new String[lB_1.Items.Count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToString(lB_1.Items[i]);
            }

            //Clear the ListBox
            lB_1.Items.Clear();

            //Add new item to the beginning
            lB_1.Items.Add(txtB_1.Text);
            for(int i = 0; i < array.Length; i++)
            {
                lB_1.Items.Add(array[i]); 
            }

            //Textbox Clear
            txtB_1.Text = "";
        }

        private void btn_EndeAdd_Click(object sender, EventArgs e)
        {
            //Add the item
            lB_1.Items.Add(txtB_1.Text);

            //Textbox Clear
            txtB_1.Text = "";
        }

        private void btn_Entfernen_Click(object sender, EventArgs e)
        {
            //Get the selected Index
            int number = lB_1.SelectedIndex;

            //Remove the selected Item
            if (-1 != number)
            {
                lB_1.Items.RemoveAt(number);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Clear the listbox
            lB_1.Items.Clear();
        }

        private void btn_Aendern_Click(object sender, EventArgs e)
        {
            //Get the selected Index
            int number = lB_1.SelectedIndex;

            //Remove the selected Item
            if (-1 != number)
            {
                lB_1.Items[number] = txtB_1.Text;
            }

            //Clear the textbox
            txtB_1.Text = "";
        }

        private void btn_Beenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
