using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _20230320_Memory
{
    class C_MemoryCards
    {
        public PictureBox _picturebox;
        public Image _image;
        public int _id;
        public bool _found;

        public C_MemoryCards(PictureBox pictureBox, Image image, int id)
        {
            _found = false;
            _id = id;

            _picturebox = pictureBox;
            _image = image;
            _picturebox.BackColor = Color.Red;
            _picturebox.Size = new Size(85, 85);
            _picturebox.SizeMode = PictureBoxSizeMode.Zoom;
            //_picturebox.Image = _image;
        }
    }
}
