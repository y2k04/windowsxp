using System.Drawing;
using System.Drawing.Drawing2D;

namespace WinXP
{
    public static class Colors
    {
        public static Color Hex(string code) => ColorTranslator.FromHtml(code);

        public static ColorBlend Taskbar = new ColorBlend()
        {
            Colors = new Color[] { Hex("#14A5F4"), Hex("#081BCB"), Hex("#0062EA"), Hex("#0062EA"), Hex("#14A5F4"), Hex("#14A5F4") },
            Positions = new[] { 0f, 0.01f, 0.1f, 0.9f, 0.97f, 1f }
        };

        public static ColorBlend NotificationArea = new ColorBlend()
        {
            Colors = new Color[] { Hex("#8EB6D9"), Hex("#4977B4"), Hex("#14A5F4"), Hex("#14A5F4"), Hex("#5DB3FF"), Hex("#5DB3FF") },
            Positions = new[] { 0f, 0.01f, 0.1f, 0.9f, 0.97f, 1f }
        };

        public static ColorBlend StartButton_Normal = new ColorBlend()
        {
            Colors = new Color[] { Hex("#9BEA9C"), Hex("#008D00"), Hex("#31A431"), Hex("#5EDB5E"), Hex("#9BEA9C"), Hex("#9BEA9C") },
            Positions = new[] { 0f, 0.01f, 0.1f, 0.9f, 0.97f, 1f }
        };

        public static ColorBlend StartButton_Hover = new ColorBlend()
        {
            Colors = new Color[] { Hex("#5EDB5E"), Hex("#008D00"), Hex("#22C020"), Hex("#22C020"), Hex("#5EDB5E"), Hex("#5EDB5E") },
            Positions = new[] { 0f, 0.01f, 0.1f, 0.9f, 0.97f, 1f }
        };

        public static ColorBlend StartButton_Active = new ColorBlend()
        {
            Colors = new Color[] { Hex("#267C08"), Hex("#008D00"), Hex("#008D00"), Hex("#22C020"), Hex("#267C08"), Hex("#267C08") },
            Positions = new[] { 0f, 0.01f, 0.1f, 0.9f, 0.97f, 1f }
        };
    }
}
