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

        //Score
        private int _score;
        private int _count;
        private Label _lb_score;
        private Label _lb_count;

        public MemoryForm()
        {
            //Size of window and memory
            this.Size = new Size(700, 700);
            _sizeHeight = 4;
            _sizeWidth = 4;
            _size = _sizeWidth * _sizeHeight;

            //Create memory cards
            _memoryCards = new C_MemoryCards[_size];

            //Build the memory card
            int image = 1;
            int count = 0;
            for (int i = 0; i < _size; i++)
            {
                if(count % 2 == 0)
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
                    _memoryCards[o]._picturebox.Location = new Point(100 * x + 20, 100 * y + 100);
                    _memoryCards[o]._picturebox.Name = "PictureBox" + o;
                    _memoryCards[o]._picturebox.Click += new EventHandler(Check);
                    this.Controls.Add(_memoryCards[o]._picturebox);
                    o++;
                }
            }

            //Add Score Label
            _score = 0;
            _lb_score = new Label();
            _lb_score.Location = new Point(30, 30);
            _lb_score.Text = "Score: " + _score;
            this.Controls.Add(_lb_score);

            //Add Count Label
            _count = 0;
            _lb_count = new Label();
            _lb_count.Location = new Point(130, 30);
            _lb_count.Text = "Count: " + _count;
            this.Controls.Add(_lb_count);
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
