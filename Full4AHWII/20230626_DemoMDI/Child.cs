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
    public partial class Child : Form
    {
        public Child(string FensterName)
        {
            InitializeComponent();
            this.MainMenuStrip = menuStrip1;
            this.menuStrip1.AllowMerge = true;
            this.Text = FensterName;
            this.dialogToolStripMenuItem.MergeAction = MergeAction.MatchOnly;

            this.dialogToolStripMenuItem.MergeIndex = 10;
            this.schließenToolStripMenuItem.MergeIndex = 14;
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
