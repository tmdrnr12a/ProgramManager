using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramManager.Controls
{
    public class ImageButton : Panel
    {
        public Image IMAGE_DEFAULT = null;
        public Image IMAGE_FOCUS = null;
        public Image IMAGE_CLICK = null;
        
        public ImageButton()
        {
            this.MouseDown += (sender, e) => { this.BackgroundImage = this.IMAGE_CLICK; };
            this.MouseUp += (sender, e) => { this.BackgroundImage = this.IMAGE_DEFAULT; };
            this.MouseHover += (sender, e) => { this.BackgroundImage = this.IMAGE_FOCUS; };
            this.MouseLeave += (sender, e) => { this.BackgroundImage = this.IMAGE_DEFAULT; };

            this.BackgroundImage = this.IMAGE_DEFAULT;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
