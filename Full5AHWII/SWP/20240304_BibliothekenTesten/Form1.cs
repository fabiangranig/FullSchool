using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _20240304_MeineBibliothek;

namespace _20240304_BibliothekenTesten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_TestDLL_Click(object sender, EventArgs e)
        {
            //Get standart class
            Class1 MyClass = new Class1();

            //Get sorting class and sort some numbers
            Sort sort = new Sort(new int[]{ 2, 10, 3, 1 });
            sort.BubbleSort();
            MessageBox.Show(sort.Anzeigen());
        }
    }
}
