using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230626_DemoMDI
{
    public partial class Form1 : Form
    {
        private int intCounter;

        public Form1()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.menuStrip1.AllowMerge = true;

            this.dialogToolStripMenuItem.MergeIndex = 10;
            this.öffnenToolStripMenuItem.MergeIndex = 12;

            this.fensterToolStripMenuItem.MergeIndex = 20;
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.intCounter++;
            string FensterName = String.Concat("Child ", this.intCounter.ToString());
            Child child = new Child(FensterName);
            child.MdiParent = this;
            child.MainMenuStrip.Visible = false;
            child.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
