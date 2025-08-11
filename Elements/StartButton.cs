using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinXP.Elements
{
    public class StartButton : Control
    {
        private Image iconImage;
        private bool isHovering;

        private bool _isToggled;
        private bool isToggled
        {
            get => _isToggled;
            set
            {
                if (_isToggled != value)
                {
                    _isToggled = value;
                    OnToggle(value);
                }
            }
        }
        public event EventHandler<ToggleChangedEventArgs> ToggleChanged;
        
        public override Color BackColor { get => Color.Transparent; }
        public override Font Font { get => new Font("Franklin Gothic Medium", 12.4F, FontStyle.Italic); }

        public Image Icon
        {
            get => iconImage;
            set
            {
                iconImage = value;
                this.Invalidate();
            }
        }

        public StartButton()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.Font = new Font("Franklin Gothic Medium", 12.4F, FontStyle.Italic);
        }

        protected virtual void OnToggle(bool value)
        {
            ToggleChanged?.Invoke(this, new ToggleChangedEventArgs(value));
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.isHovering = true;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.isHovering = false;
            this.Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.isToggled = !this.isToggled;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            new SetTransparent(this, e);

            Rectangle rect = this.ClientRectangle;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath path = new GraphicsPath();
            int rectWidth = rect.Width - (rect.Height / 5);
            Rectangle mainRect = new Rectangle(rect.X, rect.Y, rectWidth, rect.Height);
            path.AddRectangle(mainRect);
            path.AddBezier(
                new Point(rect.X + rectWidth, rect.Y),
                new Point(rect.X + rect.Width, rect.Y + rect.Height / 4),
                new Point(rect.X + rect.Width, rect.Y + rect.Height * 3 / 4),
                new Point(rect.X + rectWidth, rect.Y + rect.Height)
            );
            
            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(rect, Color.Transparent, Color.Transparent, -90))
            {
                gradientBrush.InterpolationColors =
                    isToggled ? Colors.StartButton_Active :
                    isHovering ? Colors.StartButton_Hover :
                    Colors.StartButton_Normal;
                e.Graphics.FillPath(gradientBrush, path);
            }

            Rectangle textRect = rect;

            if (iconImage != null)
            {
                int iconSize = (int)(rect.Height * 0.64);
                Rectangle iconRect = new Rectangle(rect.X + 10, (int)(rect.Y + (rect.Height - iconSize) / 2f), iconSize, iconSize);
                e.Graphics.DrawImage(iconImage, iconRect);

                textRect.X += iconRect.Width - 6;
                textRect.Width -= iconRect.Width - 6;
            }

            if (!string.IsNullOrEmpty(this.Text))
            {
                using (StringFormat sf = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                })
                {
                    e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(Colors.Hex("#267C08")), new RectangleF(textRect.X + 1, textRect.Y + 1, textRect.Width, textRect.Height), sf);
                    e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(Color.White), textRect, sf);
                }
            }
        }
    }

    public class ToggleChangedEventArgs : EventArgs
    {
        public bool Value { get; }

        public ToggleChangedEventArgs(bool newValue)
        {
            Value = newValue;
        }
    }
}
