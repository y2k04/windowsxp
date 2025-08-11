using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinXP.Elements
{
    public class NotificationArea : Panel
    {
        public NotificationArea()
        {
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(
                new LinearGradientBrush(this.ClientRectangle, Color.Empty, Color.Empty, -90f)
                { InterpolationColors = Colors.NotificationArea },
                this.ClientRectangle
            );
            e.Graphics.DrawLine(new Pen(Colors.Hex("#003CA5"), 2), new Point(0, 0), new Point(0, this.Height));
        }
    }
}
