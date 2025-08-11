using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinXP.Elements
{
    public class ProfilePicture : PictureBox
    {
        public ProfilePicture()
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rect = this.ClientRectangle;

            GraphicsPath path = new GraphicsPath();
            int diameter = 10;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rect.Location, size);

            path.AddArc(arc, 180, 90);
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);
            
            path.CloseFigure();

            this.Region = new Region(path);

            e.Graphics.DrawPath(new Pen(Colors.Hex("#D2ECFF"), 4), path);
        }
    }
}
