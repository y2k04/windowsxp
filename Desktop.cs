using System.Drawing;
using System.Windows.Forms;
using WinXP.Elements;

namespace WinXP
{
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
            startButton.ToggleChanged += StartButton_ToggleChanged;
        }

        private void StartButton_ToggleChanged(object sender, ToggleChangedEventArgs e)
        {
            startMenu.Visible = e.Value;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
#if DEBUG
            buildString.Parent = background;
            buildString.BackColor = Color.Transparent;
            buildString.Visible = true;
#endif
        }
    }
}
