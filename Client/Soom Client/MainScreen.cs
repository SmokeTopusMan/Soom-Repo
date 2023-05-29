﻿using Soom_Client.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Soom_Client
{
    public partial class MainScreen : Form
    {
        public Socket Socket { get; set; }
        public int ID { get; set; }
        
        public MainScreen(Socket socket, int id)
        {
            Socket = socket;
            ID = id;
            InitializeComponent();
        }

        #region ButtonsHoverSettings
        private void createMeetingButton_MouseEnter(object sender, EventArgs e)
        {
            createMeetingButton.ForeColor = Color.FromArgb(227,220,50);
            createMeetingButton.Font = new Font(createMeetingButton.Font.Name, createMeetingButton.Font.SizeInPoints, FontStyle.Underline);
        }
        private void createMeetingButton_MouseLeave(object sender, EventArgs e)
        {
            createMeetingButton.ForeColor = Color.FromArgb(110, 0, 17);
            createMeetingButton.Font = new Font(createMeetingButton.Font.Name, createMeetingButton.Font.SizeInPoints, FontStyle.Regular);
        }
        private void joinMeetingButton_MouseEnter(object sender, EventArgs e)
        {
            joinMeetingButton.ForeColor = Color.FromArgb(227, 220, 50);
            joinMeetingButton.Font = new Font(joinMeetingButton.Font.Name, joinMeetingButton.Font.SizeInPoints, FontStyle.Underline);
        }
        private void joinMeetingButton_MouseLeave(object sender, EventArgs e)
        {
            joinMeetingButton.ForeColor = Color.FromArgb(110, 0, 17);
            joinMeetingButton.Font = new Font(joinMeetingButton.Font.Name, joinMeetingButton.Font.SizeInPoints, FontStyle.Regular);
        }
        private void friendsButton_MouseEnter(object sender, EventArgs e)
        {
            friendsButton.ForeColor = Color.FromArgb(227, 220, 50);
            friendsButton.Font = new Font(friendsButton.Font.Name, friendsButton.Font.SizeInPoints, FontStyle.Underline);
        }
        private void friendsButton_MouseLeave(object sender, EventArgs e)
        {
            friendsButton.ForeColor = Color.FromArgb(110, 0, 17);
            friendsButton.Font = new Font(friendsButton.Font.Name, friendsButton.Font.SizeInPoints, FontStyle.Regular);
        }
        private void settingsWheelButton_MouseEnter(object sender, EventArgs e)
        {
            settingsWheelButton.Image = Resources.HoverredSettingsGear;
        }
        private void settingsWheelButton_MouseLeave(object sender, EventArgs e)
        {
            settingsWheelButton.Image = Resources.SettingsGear;
        }

        #endregion

        #region ButtonsClick
        private void settingsWheelButton_Click(object sender, EventArgs e)
        {
            HideAllComponents();
            SettingsScreen settingsScreen = new SettingsScreen(Socket, ID);
            settingsScreen.Location = new Point(0, 0);
            settingsScreen.Name = "settingsScreen";
            settingsScreen.Size = new Size(this.Size.Width-16, this.Size.Height-39);
            this.Controls.Add(settingsScreen);
            settingsScreen.Event += ReturnToMainScreen_Event;

        }

        private void ReturnToMainScreen_Event(object sender, ExitEventArgs e)
        {
            ShowAllComponents();
            if(e.Name == "settingsScreen")
            {
                SettingsScreen screen = e.Screen as SettingsScreen;
                this.Controls.Remove(screen);
                screen.Dispose();
            }
            else if(e.Name == "friendsScreen")
            {
                FriendsScreen screen = e.Screen as FriendsScreen;
                this.Controls.Remove(screen);
                screen.Dispose();
            }
            if (e.Screen.IsFinished == true)
                this.Close();

        }

        private void createMeetingButton_Click(object sender, EventArgs e)
        {
            HideAllComponents();
        }
        private void joinMeetingButton_Click(object sender, EventArgs e)
        {
            HideAllComponents();
        }
        private void friendsButton_Click(object sender, EventArgs e)
        {
            HideAllComponents();
            FriendsScreen friendsScreen = new FriendsScreen(Socket, ID);
            friendsScreen.Location = new Point(0, 0);
            friendsScreen.Name = "friendsScreen";
            friendsScreen.Size = new Size(this.Size.Width - 16, this.Size.Height - 39);
            this.Controls.Add(friendsScreen);
            friendsScreen.Event += ReturnToMainScreen_Event;
        }
        #endregion

        private void HideAllComponents(Component button = null)
        {
            title.Hide();
            if (button == null)
            {
                settingsWheelButton.Hide();
                createMeetingButton.Hide();
                joinMeetingButton.Hide();
                friendsButton.Hide();
            }
            else
            {
                if (button != settingsWheelButton) settingsWheelButton.Hide();
                if (button != createMeetingButton) createMeetingButton.Hide();
                if (button != joinMeetingButton) joinMeetingButton.Hide();
                if (button != friendsButton) friendsButton.Hide();
            }
        }
        private void ShowAllComponents()
        {
            title.Show();
            settingsWheelButton.Show();
            createMeetingButton.Show();
            joinMeetingButton.Show();
            friendsButton.Show();
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var settingsScreen = (SettingsScreen)this.Controls.Find("settingsScreen", false)[0];
            }
            catch (IndexOutOfRangeException)
            {
                ;// Do Nothing Since the Screen Isn't Exist Anymore.
            }
            DisableMaximizeButton();
        }

        #region Disable The Maximize Button
        private const int GWL_STYLE = -16;
        private const int WS_MAXIMIZEBOX = 0x00010000;

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        private void DisableMaximizeButton()
        {
            IntPtr handle = this.Handle;
            int style = GetWindowLong(handle, GWL_STYLE);
            SetWindowLong(handle, GWL_STYLE, style & ~WS_MAXIMIZEBOX);
        }
        #endregion
    }
    public class ExitEventArgs : EventArgs
    {
        public IMainScreenComponents Screen { get; private set; }
        public string Name { get;private set; }

        public ExitEventArgs(IMainScreenComponents screen, string name)
        {
            Screen = screen;
            Name = name;
        }
    }
    public delegate void FinishedEvent(object sender, ExitEventArgs e);
}
