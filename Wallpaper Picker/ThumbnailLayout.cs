using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wallpaper_Picker
{
    public partial class ThumbnailLayout : UserControl
    {
        public ThumbnailLayout()
        {
            InitializeComponent();
        }
        public ThumbnailLayout(Image thumbnail)
        {
            InitializeComponent();
            pictureBox1.Image = thumbnail;
            resize(thumbnail.Height);
        }

        public void resize(int size){
            this.Size = new Size(size, size);
            pictureBox1.Size = new Size(size, size);
        }
    }
}
