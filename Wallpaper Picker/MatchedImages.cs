using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallpaper_Picker
{
    public class MatchedImages
    {
        public String fullPath;
        public String ratio;
        public String size;
        public String testBased;

        public String getfullPath()
        {
            return fullPath;
        }

        public String getratio()
        {
            return ratio;
        }

        public String getsize()
        {
            return size;
        }

        public void setfullPath(String value)
        {
            fullPath = value;
        }

        public void setratio(String value)
        {
            ratio = value;
        }

        public void setsize(String value)
        {
            size = value;
        }
        

        public MatchedImages(String fullPath, String ratio, String size, String testBased)
        {
            this.fullPath = fullPath;
            this.ratio = ratio;
            this.size = size;
            this.testBased = testBased;
        }
    }
}
