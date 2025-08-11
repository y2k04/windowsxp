namespace WinXP
{
    partial class Desktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desktop));
            this.buildString = new System.Windows.Forms.Label();
            this.startMenu = new System.Windows.Forms.Panel();
            this.background = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.profilePicture = new WinXP.Elements.ProfilePicture();
            this.taskbar = new WinXP.Elements.Taskbar();
            this.startButton = new WinXP.Elements.StartButton();
            this.notificationArea = new WinXP.Elements.NotificationArea();
            this.clock = new WinXP.Elements.Clock();
            this.userName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.startMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.taskbar.SuspendLayout();
            this.notificationArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // buildString
            // 
            this.buildString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buildString.AutoSize = true;
            this.buildString.BackColor = System.Drawing.Color.Black;
            this.buildString.Font = new System.Drawing.Font("Tahoma", 7F);
            this.buildString.ForeColor = System.Drawing.Color.White;
            this.buildString.Location = new System.Drawing.Point(459, 488);
            this.buildString.Name = "buildString";
            this.buildString.Size = new System.Drawing.Size(323, 28);
            this.buildString.TabIndex = 3;
            this.buildString.Text = "Windows XP Professional\r\nFor testing purposes. Build 2600.5512.xpsp.080413-2111";
            this.buildString.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buildString.Visible = false;
            // 
            // startMenu
            // 
            this.startMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startMenu.Controls.Add(this.splitContainer1);
            this.startMenu.Controls.Add(this.panel2);
            this.startMenu.Controls.Add(this.panel1);
            this.startMenu.Location = new System.Drawing.Point(0, 19);
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(430, 500);
            this.startMenu.TabIndex = 4;
            this.startMenu.Visible = false;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Black;
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Image = global::WinXP.Properties.Resources.Bliss;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(782, 553);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 1;
            this.background.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(120)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.profilePicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 64);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(139)))), ((int)(((byte)(231)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 48);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 64);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.splitContainer1.Size = new System.Drawing.Size(430, 388);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.Transparent;
            this.profilePicture.Image = global::WinXP.Properties.Resources.chess;
            this.profilePicture.Location = new System.Drawing.Point(8, 5);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(56, 56);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // taskbar
            // 
            this.taskbar.Controls.Add(this.startButton);
            this.taskbar.Controls.Add(this.notificationArea);
            this.taskbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.taskbar.Location = new System.Drawing.Point(0, 519);
            this.taskbar.Name = "taskbar";
            this.taskbar.Size = new System.Drawing.Size(782, 34);
            this.taskbar.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.startButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.4F, System.Drawing.FontStyle.Italic);
            this.startButton.Icon = global::WinXP.Properties.Resources.icon;
            this.startButton.Location = new System.Drawing.Point(0, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(98, 34);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "start";
            // 
            // notificationArea
            // 
            this.notificationArea.AutoSize = true;
            this.notificationArea.Controls.Add(this.clock);
            this.notificationArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.notificationArea.Location = new System.Drawing.Point(689, 0);
            this.notificationArea.Name = "notificationArea";
            this.notificationArea.Size = new System.Drawing.Size(93, 34);
            this.notificationArea.TabIndex = 0;
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.BackColor = System.Drawing.Color.Transparent;
            this.clock.Dock = System.Windows.Forms.DockStyle.Right;
            this.clock.Font = new System.Drawing.Font("Tahoma", 8.4F);
            this.clock.ForeColor = System.Drawing.Color.White;
            this.clock.Location = new System.Drawing.Point(0, 0);
            this.clock.Name = "clock";
            this.clock.Padding = new System.Windows.Forms.Padding(14, 6, 14, 6);
            this.clock.Size = new System.Drawing.Size(93, 34);
            this.clock.TabIndex = 0;
            this.clock.Text = "12:53 PM";
            this.clock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clock.UseCompatibleTextRendering = true;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.Transparent;
            this.userName.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(70, 20);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(54, 25);
            this.userName.TabIndex = 1;
            this.userName.Text = "User";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button1.Location = new System.Drawing.Point(263, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Turn Off Computer";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button2.Location = new System.Drawing.Point(166, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Log Off";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.startMenu);
            this.Controls.Add(this.buildString);
            this.Controls.Add(this.taskbar);
            this.Controls.Add(this.background);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Desktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows XP Desktop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.startMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.taskbar.ResumeLayout(false);
            this.taskbar.PerformLayout();
            this.notificationArea.ResumeLayout(false);
            this.notificationArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private Elements.Taskbar taskbar;
        private Elements.NotificationArea notificationArea;
        private Elements.Clock clock;
        private Elements.StartButton startButton;
        private System.Windows.Forms.Label buildString;
        private System.Windows.Forms.Panel startMenu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Elements.ProfilePicture profilePicture;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

