using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinXP.Elements
{
    public class Taskbar : Panel
    {
        public Taskbar()
        {
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(
                new LinearGradientBrush(this.ClientRectangle, Color.Empty, Color.Empty, -90f)
                { InterpolationColors = Colors.Taskbar },
                this.ClientRectangle
            );
        }
    }
}
