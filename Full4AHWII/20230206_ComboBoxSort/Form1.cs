using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxSort
{
    public partial class Form1 : Form
    {
        public int[] numbers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add an list
            numbers = new Int32[]{50,6,1,2,45,4,87,9};

            //Add them to the Combobox
            for(int i = 0; i < numbers.Length; i++) { comboBox1.Items.Add(numbers[i]); }
        }

        public void QuickSort()
        {
            QuickSort1(0, comboBox1.Items.Count - 1);
        }

        private void QuickSort1(int unten, int oben)
        {
            if (unten < oben)
            {
                int u = unten - 1;
                int o = oben;
                int elem = Int32.Parse(comboBox1.Items[oben].ToString());

                do
                {
                    while (u < oben && Int32.Parse(comboBox1.Items[++u].ToString()) < elem) ;
                    while (o > 0 && Int32.Parse(comboBox1.Items[--o].ToString()) >= elem) ;
                    if (u >= o)
                        break;

                    tauschen(u, o);
                } while (u < o);

                tauschen(u, oben);

                QuickSort1(unten, u - 1);
                QuickSort1(u + 1, oben);
            }
        }

        private void tauschen(int index1, int index2)
        {
            int temp = Int32.Parse(comboBox1.Items[index1].ToString());
            comboBox1.Items[index1] = Int32.Parse(comboBox1.Items[index2].ToString());
            comboBox1.Items[index2] = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuickSort();
        }
    }
}
