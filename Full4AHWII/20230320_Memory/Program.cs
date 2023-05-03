using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _20230320_Memory
{
    class MemoryForm : Form
    {
        //Size of the field
        private int _size;
        private int _sizeWidth;
        private int _sizeHeight;

        //Temporary variables
        private int _opened = 0;
        private int _last_index = -1;

        //Memory cards
        private C_MemoryCards[] _memoryCards;

        //Rankings
        private C_Ranking _rankings = new C_Ranking();

        //Score
        private int _score;
        private int _count;
        private Label _lb_score;
        private MenuStrip _Menu;
        private ToolStripMenuItem textToolStripMenuItem;
        private ToolStripMenuItem neustartenToolStripMenuItem;
        private ToolStripMenuItem beendenToolStripMenuItem;
        private ToolStripMenuItem ranglisteToolStripMenuItem;
        private ToolStripMenuItem mapToolStripMenuItem;
        private ToolStripMenuItem mapKleinerToolStripMenuItem;
        private ToolStripMenuItem mapGrößerToolStripMenuItem;
        private Label _lb_count;

        public MemoryForm()
        {
            //Get all elements added by forms
            InitializeComponent();

            //Add Score Label
            _lb_score = new Label();
            _lb_score.Location = new Point(30, 30);
            _lb_score.Text = "Score: " + _score;
            this.Controls.Add(_lb_score);

            //Add Count Label
            _lb_count = new Label();
            _lb_count.Location = new Point(130, 30);
            _lb_count.Text = "Count: " + _count;
            this.Controls.Add(_lb_count);

            //Default Size
            _sizeHeight = 4;
            _sizeWidth = 4;

            //Get the map
            CreateMap();
        }

        public void CreateMap()
        {
            //Size of window and memory
            _size = _sizeWidth * _sizeHeight;
            this.Size = new Size(_sizeWidth * 120, _sizeHeight * 120 + 75);

            //When there is already an map remove it
            if (_memoryCards != null)
            {
                //Remove all parts of the map
                for(int i = 0; i < _memoryCards.Length; i++)
                {
                    this.Controls.Remove(_memoryCards[i]._picturebox);
                }
            }

            //Create memory cards
            _memoryCards = new C_MemoryCards[_size];

            //Build the memory card
            int image = 1;
            int count = 0;
            for (int i = 0; i < _size; i++)
            {
                if (count % 2 == 0)
                {
                    image++;
                }

                string path = @"images\Symbol" + image + ".png";
                _memoryCards[i] = new C_MemoryCards(new PictureBox(), new Bitmap(path), image);
                count++;
            }

            //Randomise the list
            Randomise();

            //Place and activate the boxes accordingly
            int o = 0;
            for (int x = 0; x < _sizeHeight; x++)
            {
                for (int y = 0; y < _sizeWidth; y++)
                {
                    _memoryCards[o]._picturebox.Location = new Point(100 * x + 20, 100 * y + 65);
                    _memoryCards[o]._picturebox.Name = "PictureBox" + o;
                    _memoryCards[o]._picturebox.Click += new EventHandler(Check);
                    this.Controls.Add(_memoryCards[o]._picturebox);
                    o++;
                }
            }

            //Edit number labels
            _score = 0;
            _lb_score.Text = "Score: " + _score.ToString();
            _count = 0;
            _lb_count.Text = "Count: " + _count.ToString();
        }

        private void Check(object sender, EventArgs e)
        {
            //When action is finsihed 
            if(_opened == 0)
            {
                FlushAllNotFound();
            }

            //Make the picture visible
            PictureBox pictureBox = (PictureBox)sender;
            int index = Int32.Parse(pictureBox.Name.Substring(10));
            _memoryCards[index]._picturebox.Image = _memoryCards[index]._image;
            _memoryCards[index]._picturebox.BackColor = Color.Empty;
            
            _opened++;

            if (_opened == 2)
            {
                if(_memoryCards[index]._id == _memoryCards[_last_index]._id && index != _last_index)
                {
                    _memoryCards[index]._found = true;
                    _memoryCards[_last_index]._found = true;
                    _score++;
                    _lb_score.Text = "Score: " + _score;
                }

                _opened = 0;

                //Set count
                _count++;
                _lb_count.Text = "Count: " + _count;

                //Show winning window
                if(AllCardsOpened())
                {
                    FinishedWindow FW = new FinishedWindow(ref _rankings, _score * _count);
                    FW.ShowDialog();
                }
            }

            _last_index = index;
        }

        private void FlushAllNotFound()
        {
            //Reset all not found cards
            for(int i = 0; i < _memoryCards.Length; i++)
            {
                if(_memoryCards[i]._found == false)
                {
                    _memoryCards[i]._picturebox.Image = null;
                    _memoryCards[i]._picturebox.BackColor = Color.Red;
                }
            }
        }

        private void Randomise()
        {
            //Randomise the list
            Random r1 = new Random();
            for (int i = 0; i < _memoryCards.Length; i++)
            {
                C_MemoryCards sample = _memoryCards[i];
                int r = r1.Next(0, _memoryCards.Length - 1);
                _memoryCards[i] = _memoryCards[r];
                _memoryCards[r] = sample;
            }
        }

        private bool AllCardsOpened()
        {
            //Check if there is an card that is not opened
            for(int i = 0; i < _memoryCards.Length; i++)
            {
                if(_memoryCards[i]._found == false)
                {
                    return false;
                }
            }

            //When all cards are opened return true
            return true;
        }

        private void InitializeComponent()
        {
            this._Menu = new System.Windows.Forms.MenuStrip();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neustartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapKleinerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapGrößerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ranglisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _Menu
            // 
            this._Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.mapToolStripMenuItem,
            this.ranglisteToolStripMenuItem});
            this._Menu.Location = new System.Drawing.Point(0, 0);
            this._Menu.Name = "_Menu";
            this._Menu.Size = new System.Drawing.Size(472, 24);
            this._Menu.TabIndex = 2;
            this._Menu.Text = "Menü";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neustartenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.textToolStripMenuItem.Text = "Spiel";
            // 
            // neustartenToolStripMenuItem
            // 
            this.neustartenToolStripMenuItem.Name = "neustartenToolStripMenuItem";
            this.neustartenToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.neustartenToolStripMenuItem.Text = "Neustarten";
            this.neustartenToolStripMenuItem.Click += new System.EventHandler(this.neustartenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapKleinerToolStripMenuItem,
            this.mapGrößerToolStripMenuItem});
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.mapToolStripMenuItem.Text = "Map";
            // 
            // mapKleinerToolStripMenuItem
            // 
            this.mapKleinerToolStripMenuItem.Name = "mapKleinerToolStripMenuItem";
            this.mapKleinerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mapKleinerToolStripMenuItem.Text = "Map kleiner";
            this.mapKleinerToolStripMenuItem.Click += new System.EventHandler(this.mapKleinerToolStripMenuItem_Click);
            // 
            // mapGrößerToolStripMenuItem
            // 
            this.mapGrößerToolStripMenuItem.Name = "mapGrößerToolStripMenuItem";
            this.mapGrößerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mapGrößerToolStripMenuItem.Text = "Map größer";
            this.mapGrößerToolStripMenuItem.Click += new System.EventHandler(this.mapGrößerToolStripMenuItem_Click);
            // 
            // ranglisteToolStripMenuItem
            // 
            this.ranglisteToolStripMenuItem.Name = "ranglisteToolStripMenuItem";
            this.ranglisteToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ranglisteToolStripMenuItem.Text = "Rangliste";
            this.ranglisteToolStripMenuItem.Click += new System.EventHandler(this.ranglisteToolStripMenuItem_Click);
            // 
            // MemoryForm
            // 
            this.ClientSize = new System.Drawing.Size(472, 396);
            this.Controls.Add(this._Menu);
            this.MainMenuStrip = this._Menu;
            this.Name = "MemoryForm";
            this.Text = "Memory";
            this._Menu.ResumeLayout(false);
            this._Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void neustartenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMap();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ranglisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RankingWindow RW = new RankingWindow(ref _rankings);
            RW.Show();
        }

        private void mapKleinerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sizeHeight -= 2;
            _sizeWidth -= 2;
            CreateMap();
        }

        private void mapGrößerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sizeHeight += 2;
            _sizeWidth += 2;
            CreateMap();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MemoryForm MemoryForm1 = new MemoryForm();
            MemoryForm1.ShowDialog();
        }
    }
}
