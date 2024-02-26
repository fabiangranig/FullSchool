using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20240226_DemoThreads
{
    public partial class DemoThreads : Form
    {
        private Thread _thread1;
        private Thread _thread2;

        public DemoThreads()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateUI(string text, bool isFirst)
        {
            if(InvokeRequired)
            {
                BeginInvoke(new Action<string, bool>(UpdateUI), text, isFirst);
            }
            else
            {
                if(isFirst)
                {
                    this.label_Text1.Text += text + "\n";
                }
                else
                {
                    this.label_Text2.Text += text + "\n";
                }
            }
        }

        private void WorkerThread(object parameter)
        {
            bool isFirst = (bool)parameter;
            for(int i = 0; i < 10; i++)
            {
                UpdateUI($"Schleifendurchlauf: {i + 1}", isFirst);
                Thread.Sleep(1000);
            }
            UpdateUI("Thread beendet.", isFirst);
        }

        private void button_Start1_Click(object sender, EventArgs e)
        {
            button_Start1.Enabled = false;
            _thread1 = new Thread(WorkerThread);
            _thread1.Start(true);
        }

        private void DemoThreads_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this._thread1 != null && this._thread1.IsAlive)
            {
                _thread1.Abort();
            }
            if (this._thread2 != null && this._thread2.IsAlive)
            {
                _thread2.Abort();
            }
        }

        private void button_thread2_Click(object sender, EventArgs e)
        {
            button_thread2.Enabled = false;
            _thread2 = new Thread(WorkerThread);
            _thread2.Start(false);
        }
    }
}
