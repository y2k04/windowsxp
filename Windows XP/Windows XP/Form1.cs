using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.UserActivityMonitor;

namespace Windows_XP
{
    public partial class Form1 : Form
    {
        public int h = Screen.PrimaryScreen.Bounds.Height;
        public int w = Screen.PrimaryScreen.Bounds.Width;
        public int tempHeight = 0, tempWidth = 0;
        public int FixHeight = 1080, FixWidth = 1920;
        public Screen Srn;
        public int opacity = 0;
        public int shutdownsizex;
        public int shutdownsizey;
        public GifImage gifImage = null;
        public WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public int starttoggle = 0;
        public string time;
        public Timer clock_tick = new Timer();
        public string cdrive = @"C:\WinXP_Drive\";
        public string userprofile = @"C:\WinXP_Drive\Users\" + Environment.UserName + @"\";
        public Random rand = new Random();
        public PictureBox bootscreen = new PictureBox()
        {
            Name = "bootscreen",
            Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height),
            BackColor = Color.Black,
            BackgroundImageLayout = ImageLayout.Stretch,
        };
        public PictureBox loginscreen = new PictureBox()
        {
            Name = "loginscreen",
            Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height + 50),
            BackgroundImage = Image.FromFile("Resources/icons/login.jpg"),
            BackgroundImageLayout = ImageLayout.Stretch,
        };
        public PictureBox loginlogo = new PictureBox()
        {
            Name = "loginlogo",
            Size = new Size((Image.FromFile("Resources/icons/logo.png").Size.Width / 4), (Image.FromFile("Resources/icons/logo.png").Size.Height / 4)),
            Location = new Point(1000, 450),
            BackgroundImage = Image.FromFile("Resources/icons/logo.png"),
            BackgroundImageLayout = ImageLayout.Stretch,
            BackColor = Color.Transparent,
        };
        public Label loginactiontext = new Label()
        {
            Name = "loginactiontext",
            AutoSize = true,
            Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular),
            Text = "           Windows is starting up...",
            ForeColor = Color.White,
            BackColor = Color.Transparent,
        };
        public PictureBox loginshutdown = new PictureBox()
        {
            Name = "loginshutdown",
            Size = new Size(Image.FromFile("Resources/icons/login_shutdown.png").Size.Width, Image.FromFile("Resources/icons/login_shutdown.png").Size.Height),
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - 200, Image.FromFile("Resources/icons/login.jpg").Size.Height - 380),
            BackgroundImage = Image.FromFile("Resources/icons/login_shutdown.png"),
            BackgroundImageLayout = ImageLayout.Stretch,
        };
        public PictureBox welcometext = new PictureBox()
        {
            Name = "welcometext",
            BackColor = Color.Transparent,
            Image = Image.FromFile("Resources/icons/welcome.png"),
            Size = new Size(Image.FromFile("Resources/icons/welcome.png").Size.Width, Image.FromFile("Resources/icons/welcome.png").Size.Height),
            Location = new Point(Image.FromFile("Resources/icons/login.jpg").Size.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2)
        };
        public PictureBox loginline = new PictureBox()
        {
            Name = "loginline",
            BackColor = Color.Transparent,
            Image = Image.FromFile("Resources/verticallogin.png"),
            Size = new Size(Image.FromFile("Resources/verticallogin.png").Size.Width - 10, Image.FromFile("Resources/verticallogin.png").Size.Height - 200),         
        };
        public PictureBox defaultaccountpic = new PictureBox()
        {
            Name = "defaultaccountpic",
            BackColor = Color.Transparent,
            BackgroundImage = Image.FromFile("Resources/usraccountpic/drip.jpg"),
            BackgroundImageLayout = ImageLayout.Stretch,
            Size = new Size(Image.FromFile("Resources/usraccountpic/drip.jpg").Size.Width / 4, Image.FromFile("Resources/usraccountpic/drip.jpg").Size.Height / 4),
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - 700, Screen.PrimaryScreen.Bounds.Height - 480),
        };
        public Label defaultaccountlabel = new Label()
        {
            Name = "defaultaccountlabel",
            BackColor = Color.Transparent,
            Text = "Administrator",
            AutoSize = true,
            ForeColor = Color.White,
            Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular),
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - 570, Screen.PrimaryScreen.Bounds.Height - 440),
        };
        public PictureBox defaultbackground = new PictureBox()
        {
            Name = "defaultbackground",
            Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height + 50),
            Location = new Point(0, 0),
            BackgroundImageLayout = ImageLayout.Stretch,
            BackgroundImage = Image.FromFile("Resources/backgrounds/WO_SCN04.jpg"),
        };
        public PictureBox taskbar = new PictureBox()
        {
            Name = "taskbar",
            Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Image.FromFile("Resources/taskbar.png").Height + 200),
            Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height),
            BackgroundImageLayout = ImageLayout.Stretch,
            BackgroundImage = Image.FromFile("Resources/taskbar.png"),
        };
        public PictureBox start = new PictureBox()
        {
            Name = "start",
            Size = new Size(Image.FromFile("Resources/startbutton/start button.png").Width + 40, Image.FromFile("Resources/startbutton/start button.png").Height + 10),
            Location = new Point(0, 0),
            BackgroundImageLayout = ImageLayout.Stretch,
            BackgroundImage = Image.FromFile("Resources/startbutton/start button.png"),
            BackColor = Color.Transparent,
        };
        public PictureBox startmenu = new PictureBox()
        {
            Name = "startmenu",
            Size = new Size(Image.FromFile("Resources/startmenu/startmenu.png").Width + 150, Image.FromFile("Resources/startmenu/startmenu.png").Height + 180),
            Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height - 655),
            BackgroundImageLayout = ImageLayout.Stretch,
            BackgroundImage = Image.FromFile("Resources/startmenu/startmenu.png"),
            BackColor = Color.Transparent,
        };
        public Label clock = new Label()
        {
            Name = "clock",
            AutoSize = true,
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - 93, Image.FromFile("Resources/taskbar.png").Height - 20),
            Text = "0:00 AM",
            ForeColor = Color.White,
            BackColor = Color.Transparent,
            Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular),
        };
        public PictureBox startmenuaccountpic = new PictureBox()
        {
            Name = "defaultaccountpic",
            BackColor = Color.Transparent,
            BackgroundImage = Image.FromFile("Resources/usraccountpic/drip.jpg"),
            BackgroundImageLayout = ImageLayout.Stretch,
            Size = new Size(Image.FromFile("Resources/usraccountpic/drip.jpg").Size.Width / 4, Image.FromFile("Resources/usraccountpic/drip.jpg").Size.Height / 4),
            Location = new Point(Image.FromFile("Resources/startmenu/startmenu.png").Size.Width - 900, Image.FromFile("Resources/startmenu/startmenu.png").Size.Height - 720),
        };
        public Label startmenuaccountlabel = new Label()
        {
            Name = "defaultaccountlabel",
            BackColor = Color.Transparent,
            Text = "Administrator",
            AutoSize = true,
            ForeColor = Color.White,
            Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular),
            Location = new Point(Image.FromFile("Resources/startmenu/startmenu.png").Size.Width - 350, Image.FromFile("Resources/startmenu/startmenu.png").Size.Height - 450),
        };
        public PictureBox startmenu_shutdownbutton = new PictureBox()
        {
            Name = "startmenu_shutdownbutton",
            BackColor = Color.Transparent,
            BackgroundImage = Image.FromFile("Resources/startmenu/shutdown.png"),
            BackgroundImageLayout = ImageLayout.Stretch,
            Size = new Size(Image.FromFile("Resources/startmenu/shutdown.png").Size.Width + 60, Image.FromFile("Resources/startmenu/shutdown.png").Size.Height + 15),
            Location = new Point(Image.FromFile("Resources/startmenu/startmenu.png").Size.Width - 38, Image.FromFile("Resources/startmenu/startmenu.png").Size.Height + 128),
        };
        public PictureBox recyclebin_desktop_area = new PictureBox()
        {
            Name = "recyclebin_area",
            BackColor = Color.RoyalBlue,
            Size = new Size(100, 100),
        };
        public PictureBox recyclebin_desktop_icon = new PictureBox()
        {
            Name = "recyclebin_icon",
            BackColor = Color.Transparent,
            BackgroundImage = Image.FromFile("Resources/icons/ico/recyclebinempty.ico"),
            BackgroundImageLayout = ImageLayout.Stretch,
            Size = new Size(Image.FromFile("Resources/icons/ico/recyclebinempty.ico").Size.Width * 2 + 10, Image.FromFile("Resources/icons/ico/recyclebinempty.ico").Size.Height * 2 + 10),
            Location = new Point(50, 50),
        };
        public Label recyclebin_desktop_text = new Label()
        {
            Name = "recyclebin_text",
            BackColor = Color.Transparent,
            Text = "Recycle Bin",
            AutoSize = true,
            Font = new Font("Arial", 11, FontStyle.Regular),
            ForeColor = Color.White,
        };
        public PictureBox window = new PictureBox();
        public PictureBox windowcontrolclose = new PictureBox();
        public PictureBox windowcontrolmaximise = new PictureBox();
        public PictureBox windowcontrolminimise = new PictureBox();

        public Form1()
        {
            InitializeComponent();
            GlobalEventProvider actHook = new GlobalEventProvider();
            ClientSize = new Size(w, h);
            Srn = Screen.PrimaryScreen;
            tempHeight = Srn.Bounds.Width;
            tempWidth = Srn.Bounds.Height;
            Resolution.CResolution ChangeRes = new Resolution.CResolution(FixHeight, FixWidth);
            Cursor.Hide();
            folder_check();
            recyclebin_desktop_area.Visible = false;
            Rectangle r = new Rectangle(0, 0, defaultaccountpic.Width, defaultaccountpic.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 15;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            recyclebin_desktop_area.Location = new Point(recyclebin_desktop_icon.Size.Width - 20, recyclebin_desktop_icon.Size.Height - 10);
            recyclebin_desktop_text.Location = new Point(recyclebin_desktop_icon.Location.X / 2 + 5, recyclebin_desktop_icon.Location.Y + 50);
            defaultaccountpic.Region = new Region(gp);
            defaultaccountpic.Click += new EventHandler(loginUser);
            defaultaccountlabel.Click += new EventHandler(loginUser);
            start.Click += new EventHandler(start_Click);
            start.MouseHover += new EventHandler(start_Hover);
            start.MouseLeave += new EventHandler(start_MouseLeave);
            taskbar.Click += new EventHandler(start_close);
            defaultbackground.Click += new EventHandler(start_clickoff);
            clock_tick.Tick += new EventHandler(clock_Tick);
            clock_tick.Interval = 1;
            startmenu_shutdownbutton.Click += new EventHandler(startmenu_shutdownbutton_Click);
            startmenu_shutdownbutton.MouseEnter += new EventHandler(startmenu_shutdownbutton_MouseEnter);
            startmenu_shutdownbutton.MouseLeave += new EventHandler(startmenu_shutdownbutton_MouseLeave);
            actHook.KeyDown += new KeyEventHandler(hotkey_handler);
            recyclebin_desktop_area.Click += new EventHandler(recyclebin_desktop_Click);
            recyclebin_desktop_area.DoubleClick += new EventHandler(recyclebin_desktop_DoubleClick);
            recyclebin_desktop_icon.Click += new EventHandler(recyclebin_desktop_Click);
            recyclebin_desktop_icon.DoubleClick += new EventHandler(recyclebin_desktop_DoubleClick);
            recyclebin_desktop_text.Click += new EventHandler(recyclebin_desktop_Click);
            recyclebin_desktop_text.DoubleClick += new EventHandler(recyclebin_desktop_DoubleClick);
            defaultbackground.Click += new EventHandler(deselect_desktop_icons);
            loginshutdown.Click += new EventHandler(login_shutdownbutton_Click);
            loginshutdown.Visible = false;
            boot();
        }

        public async void boot()
        {
            Controls.Add(bootscreen);
            bootscreen_timer.Enabled = true;
            gifImage = new GifImage("Resources/icons/bootfade.gif");
            gifImage.ReverseAtEnd = false;
            await Wait(1300);
            gifImage = new GifImage("Resources/icons/load.gif");
            gifImage.ReverseAtEnd = false;
            await Wait(8000);
            Controls.Remove(bootscreen);
            bootscreen_timer.Enabled = false;
            login();
        }

        private void bootscreen_timer_Tick(object sender, EventArgs e)
        {
            bootscreen.BackgroundImage = gifImage.GetNextFrame();
        }

        public async void login()
        {
            loginlogo.Location = new Point(w / 2 - 210, h - (ActiveForm.Size.Height / 2) - 80);
            loginactiontext.Location = new Point(loginlogo.Location.X - 150, loginlogo.Location.Y + 140);
            loginshutdown.BringToFront();
            loginline.Location = new Point(w / 2, h / 2 - 300);
            clock_tick.Enabled = true;
            clock_tick.Start();
            await Wait(4000);
            Controls.Add(loginscreen);
            loginscreen.BringToFront();
            loginscreen.Controls.Add(loginlogo);
            loginlogo.BringToFront();
            loginscreen.Controls.Add(loginactiontext);
            loginactiontext.BringToFront();
            await Wait(6000);
            loginactiontext.Visible = false;
            loginshutdown.Visible = true;
            loginactiontext.Text = "To begin, click your username";
            loginactiontext.Visible = true;
            loginscreen.Controls.Add(loginline);
            loginscreen.Controls.Add(defaultaccountpic);
            loginscreen.Controls.Add(defaultaccountlabel);
            loginscreen.Controls.Add(loginshutdown);
            loginshutdown.Visible = true;
            Cursor.Show();
        }

        public async void loginUser(object sender, EventArgs e)
        {
            welcometext.BringToFront();
            loginshutdown.Visible = false;
            loginscreen.Controls.Remove(loginline);
            loginscreen.Controls.Remove(defaultaccountlabel);
            loginscreen.Controls.Remove(defaultaccountpic);
            loginscreen.Controls.Remove(loginlogo);
            loginscreen.Controls.Remove(loginactiontext);
            loginscreen.Controls.Add(welcometext);
            await Wait(2000);
            wplayer.URL = "Resources/Media/Windows Startup.mp3";
            wplayer.controls.play();
            await Wait(2000);
            loginscreen.Controls.Remove(loginactiontext);
            loginscreen.Controls.Remove(loginlogo);
            loginscreen.Controls.Remove(welcometext);
            Controls.Add(defaultbackground);
            Controls.Remove(loginscreen);
            defaultbackground.Controls.Add(recyclebin_desktop_area);
            defaultbackground.Controls.Add(recyclebin_desktop_icon);
            defaultbackground.Controls.Add(recyclebin_desktop_text);
            recyclebin_desktop_area.BringToFront();
            recyclebin_desktop_icon.BringToFront();
            recyclebin_desktop_text.BringToFront();
            Controls.Add(taskbar);
            taskbar.BringToFront();
            taskbar.Controls.Add(start);
            start.BringToFront();
            taskbar.Controls.Add(clock);
            clock.BringToFront();
            startmenu.Visible = false;
            defaultbackground.Controls.Add(startmenu);
            startmenu.BringToFront();
            startmenuaccountpic.Visible = false;
            startmenu.Controls.Add(startmenuaccountpic);
            startmenuaccountpic.BringToFront();
            startmenuaccountlabel.Visible = false;
            startmenu.Controls.Add(startmenuaccountlabel);
            startmenuaccountlabel.BringToFront();
            startmenu.Controls.Add(startmenu_shutdownbutton);
            startmenu_shutdownbutton.Visible = false;
            startmenu_shutdownbutton.BringToFront();
        }

        async Task Wait(int milliseconds)
        {
            await Task.Delay(milliseconds);
        }

        public void start_Click(object sender, EventArgs e)
        {
            starttoggle++;
            if (starttoggle == 1)
            {
                start.BackgroundImage = Image.FromFile("Resources/startbutton/start button pressed.png");
                startmenu.Visible = true;
                startmenu_items(1);
            }
            else if (starttoggle >= 1)
            {
                starttoggle = 0;
                start.BackgroundImage = Image.FromFile("Resources/startbutton/start button.png");
                startmenu.Visible = false;
                startmenu_items(0);
            }
        }

        public void start_clickoff(object sender, EventArgs e)
        {
            if (starttoggle >= 1)
            {
                starttoggle = 0;
                start.BackgroundImage = Image.FromFile("Resources/startbutton/start button.png");
                startmenu.Visible = false;
                startmenu_items(0);
            }
        }

        public void start_Hover(object sender, EventArgs e)
        {
            start.BackgroundImage = Image.FromFile("Resources/startbutton/start button hover.png");
        }

        public void start_MouseLeave(object sender, EventArgs e)
        {
            start.BackgroundImage = Image.FromFile("Resources/startbutton/start button.png");
        }

        public void start_close(object sender, EventArgs e)
        {
            starttoggle = 0;
            start.BackgroundImage = Image.FromFile("Resources/startbutton/start button.png");
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Minute == 0 || DateTime.Now.Minute == 1 || DateTime.Now.Minute == 2 || DateTime.Now.Minute == 3 || DateTime.Now.Minute == 4 || DateTime.Now.Minute == 5 || DateTime.Now.Minute == 6 || DateTime.Now.Minute == 7 || DateTime.Now.Minute == 8 || DateTime.Now.Minute == 9)
            {
                if (DateTime.Now.Hour >= 12)
                {
                    time = (DateTime.Now.Hour - 12).ToString() + ":0" + DateTime.Now.Minute.ToString() + " " + DateTime.Now.ToString("tt", CultureInfo.InvariantCulture);
                }
                else
                {
                    time = DateTime.Now.Hour.ToString() + ":0" + DateTime.Now.Minute.ToString() + " " + DateTime.Now.ToString("tt", CultureInfo.InvariantCulture);
                }
            }
            else
            {
                if (DateTime.Now.Hour >= 12)
                {
                    time = (DateTime.Now.Hour - 12).ToString() + ":" + DateTime.Now.Minute.ToString() + " " + DateTime.Now.ToString("tt", CultureInfo.InvariantCulture);
                }
                else
                {
                    time = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + " " + DateTime.Now.ToString("tt", CultureInfo.InvariantCulture);
                }
            }
            clock.Text = time;
            toolTip1.SetToolTip(clock, DateTime.Now.DayOfWeek + ", " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
        }

        public void startmenu_items(int visibility)
        {
            if (visibility == 1)
            {
                startmenuaccountpic.Visible = true;
                startmenuaccountlabel.Visible = true;
                startmenu_shutdownbutton.Visible = true;
            }
            else if (visibility == 0)
            {
                startmenuaccountpic.Visible = false;
                startmenuaccountlabel.Visible = false;
                startmenu_shutdownbutton.Visible = false;
            }
        }

        public async void startmenu_shutdownbutton_Click(object sender, EventArgs e)
        {
            startmenu_shutdownbutton.BackgroundImage = Image.FromFile("Resources/startmenu/shutdown_clicked.png");
            await Wait(2);
            start_Click(sender, e);
            await Wait(2000);
            startmenu.Controls.Remove(startmenuaccountpic);
            startmenu.Controls.Remove(startmenuaccountlabel);
            startmenu.Controls.Add(startmenu_shutdownbutton);
            defaultbackground.Controls.Remove(startmenu);
            defaultbackground.Controls.Remove(recyclebin_desktop_area);
            defaultbackground.Controls.Remove(recyclebin_desktop_icon);
            defaultbackground.Controls.Remove(recyclebin_desktop_text);
            taskbar.Controls.Remove(start);
            taskbar.Controls.Remove(clock);
            Controls.Remove(taskbar);
            loginlogo.Location = new Point(w / 2 + 50, h - (ActiveForm.Size.Height / 2) - 80);
            loginactiontext.Location = new Point(loginlogo.Location.X - 120, (loginlogo.Location.Y + 140));
            await Wait(2000);
            Controls.Add(loginscreen);
            loginscreen.Controls.Add(loginlogo);
            Controls.Remove(defaultbackground);
            loginactiontext.Text = "                      Logging out...";
            loginscreen.Controls.Add(loginactiontext);
            wplayer.URL = "Resources/Media/Windows Shutdown.mp3";
            wplayer.controls.play();
            await Wait(3000);
            loginactiontext.Text = "            Saving your settings...";
            await Wait(1000);
            loginactiontext.Text = "Windows is shutting down...";
            await Wait(5000);
            loginscreen.Controls.Remove(loginactiontext);
            loginscreen.Controls.Remove(loginlogo);
            Controls.Remove(loginscreen);
            await Wait(2000);
            Environment.Exit(0);
        }

        public async void login_shutdownbutton_Click(object sender, EventArgs e)
        {
            loginlogo.Location = new Point(w / 2 + 50, h - (ActiveForm.Size.Height / 2) - 80);
            loginactiontext.Location = new Point(loginlogo.Location.X - 120, (loginlogo.Location.Y + 140));
            loginscreen.Controls.Remove(loginline);
            loginscreen.Controls.Remove(loginshutdown);
            loginscreen.Controls.Remove(defaultaccountlabel);
            loginscreen.Controls.Remove(defaultaccountpic);
            loginactiontext.Text = "                      Logging out...";
            loginscreen.Controls.Add(loginactiontext);
            wplayer.URL = "Resources/Media/Windows Shutdown.mp3";
            wplayer.controls.play();
            await Wait(3000);
            loginactiontext.Text = "            Saving your settings...";
            await Wait(1000);
            loginactiontext.Text = "Windows is shutting down...";
            await Wait(5000);
            loginscreen.Controls.Remove(loginactiontext);
            loginscreen.Controls.Remove(loginlogo);
            Controls.Remove(loginscreen);
            await Wait(2000);
            Environment.Exit(0);
        }

        public void startmenu_shutdownbutton_MouseEnter(object sender, EventArgs e)
        {
            startmenu_shutdownbutton.BackgroundImage = Image.FromFile("Resources/startmenu/shutdown_hovered.png");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Resolution.CResolution ChangeRes = new Resolution.CResolution(tempHeight, tempWidth);
        }

        public void startmenu_shutdownbutton_MouseLeave(object sender, EventArgs e)
        {
            startmenu_shutdownbutton.BackgroundImage = Image.FromFile("Resources/startmenu/shutdown.png");
        }

        public void hotkey_handler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LWin || e.KeyCode == Keys.RWin)
            {
                start_Click(sender, e);
            }
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.Delete)
            {
                MessageBox.Show("Alt-Delete was pressed!");
            }
            else
            {
                try
                {
                    SendKeys.Send(e.KeyValue.ToString());
                }
                catch (System.InvalidOperationException){}
            }
            e.Handled = true;
        }

        public void deselect_desktop_icons(object sender, EventArgs e)
        {
            recyclebin_desktop_area.Visible = false;
        }

        public void recyclebin_desktop_Click(object sender, EventArgs e)
        {
            recyclebin_desktop_area.Visible = true;
        }

        public void recyclebin_desktop_DoubleClick(object sender, EventArgs e)
        {
            recyclebin_desktop_area.Visible = false;
            createExplorerWindow(cdrive + @"$Recycle.Bin\");
        }

        public void folder_check()
        {
            if (!Directory.Exists(cdrive))
            {
                Directory.CreateDirectory(cdrive);
            }
            if (!Directory.Exists(cdrive + "Users"))
            {
                Directory.CreateDirectory(cdrive + "Users");
            }
            if (!Directory.Exists(cdrive + "Temp"))
            {
                Directory.CreateDirectory(cdrive + "Temp");
            }
            if (!Directory.Exists(cdrive + "Program Files"))
            {
                Directory.CreateDirectory(cdrive + "Program Files");
            }
            if (!Directory.Exists(cdrive + "$Recycle.Bin"))
            {
                Directory.CreateDirectory(cdrive + "$Recycle.Bin");
            }
            if (!Directory.Exists(userprofile))
            {
                Directory.CreateDirectory(userprofile);
            }
            if (!Directory.Exists(userprofile + "Desktop"))
            {
                Directory.CreateDirectory(userprofile + "Desktop");
            }
            if (!Directory.Exists(userprofile + "Downloads"))
            {
                Directory.CreateDirectory(userprofile + "Downloads");
            }
            if (!Directory.Exists(userprofile + "Documents"))
            {
                Directory.CreateDirectory(userprofile + "Documents");
            }
            if (!Directory.Exists(userprofile + "Pictures"))
            {
                Directory.CreateDirectory(userprofile + "Pictures");
            }
            if (!Directory.Exists(userprofile + "Music"))
            {
                Directory.CreateDirectory(userprofile + "Music");
            }
            if (!Directory.Exists(userprofile + "Videos"))
            {
                Directory.CreateDirectory(userprofile + "Videos");
            }
        }

        public void createExplorerWindow(string directory)
        {
            int height = rand.Next(50, 500);
            int width = rand.Next(50, 1500);
            window = new PictureBox()
            {
                Name = "explorer.exe",
                BackgroundImage = Image.FromFile("Resources/icons/window.png"),
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.Transparent,
                Size = new Size(Image.FromFile("Resources/icons/window.png").Size.Width, Image.FromFile("Resources/icons/window.png").Size.Height),
                Location = new Point(width, height),
            };
            windowcontrolclose = new PictureBox()
            {
                Name = "close",
                BackgroundImage = Image.FromFile("Resources/icons/close.png"),
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.Transparent,
                Size = new Size(Image.FromFile("Resources/icons/close.png").Size.Width, Image.FromFile("Resources/icons/close.png").Size.Height),
                Location = new Point(Image.FromFile("Resources/icons/window.png").Size.Width - 25, 0),
            };
            windowcontrolmaximise = new PictureBox()
            {
                Name = "maximise",
                BackgroundImage = Image.FromFile("Resources/icons/maximise.png"),
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.Transparent,
                Size = new Size(Image.FromFile("Resources/icons/maximise.png").Size.Width, Image.FromFile("Resources/icons/maximise.png").Size.Height),
                Location = new Point(Image.FromFile("Resources/icons/window.png").Size.Width - 50, 0),
            };
            windowcontrolminimise = new PictureBox()
            {
                Name = "close",
                BackgroundImage = Image.FromFile("Resources/icons/minimise.png"),
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.Transparent,
                Size = new Size(Image.FromFile("Resources/icons/minimise.png").Size.Width, Image.FromFile("Resources/icons/minimise.png").Size.Height),
                Location = new Point(Image.FromFile("Resources/icons/window.png").Size.Width - 70, 0),
            };
            Controls.Add(window);
            window.BringToFront();
            window.Controls.Add(windowcontrolclose);
            windowcontrolclose.BringToFront();
            window.Controls.Add(windowcontrolmaximise);
            windowcontrolmaximise.BringToFront();
            window.Controls.Add(windowcontrolminimise);
            windowcontrolminimise.BringToFront();
            var listing = new TreeView()
            {
                Name = "directorylist",
                Size = new Size(Image.FromFile("Resources/icons/window.png").Size.Width - 10, Image.FromFile("Resources/icons/window.png").Size.Height - 50),
                Dock = DockStyle.Bottom,
                Scrollable = true,
            };
            window.Controls.Add(listing);
            listing.BringToFront();
            listing.BeginUpdate();
            int itemlength = Directory.GetDirectories(directory).Length;
            for (int i = 0; i < itemlength; i++)
            {
                var namefix = Directory.GetDirectories(directory)[i];
                namefix = namefix.Replace(@"C:\WinXP_Drive\", @"C:\");
                listing.Nodes.Add(namefix);
            }
            itemlength = Directory.GetFiles(directory).Length;
            for (int i = 0; i < itemlength; i++)
            {
                var namefix = Directory.GetFiles(directory)[i];
                namefix = namefix.Replace(@"C:\WinXP_Drive\", @"C:\");
                listing.Nodes.Add(namefix);
            }
            listing.EndUpdate();
            listing.Refresh();
            window.MouseMove += Window_MouseMove;
            windowcontrolclose.Click += Windowcontrolclose_Click;
        }

        private void Windowcontrolclose_Click(object sender, EventArgs e)
        {
            window.Controls.Remove(windowcontrolclose);
            window.Controls.Remove(windowcontrolmaximise);
            window.Controls.Remove(windowcontrolminimise);
            Controls.Remove(window);
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                window.Location = Cursor.Position;
            }
        }
    }
}
