using System.Drawing;
using System.Windows.Forms;

namespace WinXP.Elements
{
    public class SetTransparent
    {
        public SetTransparent(object sender, PaintEventArgs e)
        {
            Control control = sender as Control;
            Control Parent = control.Parent;

            if (Parent != null)
            {
                Rectangle parentRect = new Rectangle(control.Location, control.Size);
                using (Bitmap parentBackground = new Bitmap(Parent.Width, Parent.Height))
                {
                    Parent.DrawToBitmap(parentBackground, new Rectangle(0, 0, Parent.Width, Parent.Height));
                    e.Graphics.DrawImage(parentBackground, new Rectangle(0, 0, control.Width, control.Height), parentRect, GraphicsUnit.Pixel);
                }
            }
        }
    }
}
