using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinXP.Elements
{
    public class Clock : Label
    {
        readonly Timer clockTick = new Timer() { Enabled = true, Interval = 10 };

        public override Color BackColor { get => Color.Transparent; }
        public override bool AutoSize { get => true; }
        public override Font Font { get => new Font("Tahoma", 8.4F); }

        public Clock()
        {
            clockTick.Tick += (_, __) =>
            {
                var time = DateTime.Now.ToString("h:mm tt");
                if (this.Text != time)
                    this.Text = time;
            };
        }
    }
}
