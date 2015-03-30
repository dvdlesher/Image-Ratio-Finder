using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// MAKE RESIZEABLE THUMBNAIL

namespace Wallpaper_Picker
{
    public partial class DisplayForm : Form
    {
        List<String> matchedImages;
        Form prevForm;

        public DisplayForm()
        {
            InitializeComponent();
        }

        public DisplayForm(List<String> matchedImages, Form prevForm, string previewSize)
        {
            InitializeComponent();
            this.matchedImages = matchedImages;
            populateGalleryLayout(Int32.Parse(previewSize.Split('x')[0]));

            trackBar1.Value = Int32.Parse(previewSize.Split('x')[0]);

            //this.matchedImages = matchedImages;
            this.prevForm = prevForm;
        }

        private void DisplayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            prevForm.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            populateGalleryLayout(trackBar1.Value);
        }

        private void populateGalleryLayout(int thumbnailSize)
        {
            flowGalleryLayout.Controls.Clear();
            for (int i = 0; i < matchedImages.Count; i++)
            {
                flowGalleryLayout.Controls.Add(new ThumbnailLayout(ThumbnailMaker.makeThumb(Image.FromFile(matchedImages[i]), thumbnailSize, thumbnailSize, true)));
            }
        }

        private void displayForm_Resize(object sender, EventArgs e)
        {
            flowGalleryLayout.Size = new Size(this.Size.Width - 32, this.Size.Height - 32);
            trackBar1.Location = new Point(this.Size.Width - trackBar1.Size.Width - 16,0);
        }
    }
}
