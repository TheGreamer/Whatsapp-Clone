using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Whatsapp
{
    public class OvalPictureBox : PictureBox
    {
        public OvalPictureBox()
        {
            BackColor = Color.DarkGray;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GraphicsPath graphics = new();
            graphics.AddEllipse(new(0, 0, Width - 1, Height - 1));
            Region = new(graphics);
        }
    }
}