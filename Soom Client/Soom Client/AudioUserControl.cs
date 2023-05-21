﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soom_Client
{
    public partial class AudioUserControl : UserControl, ISettingsScreenComponent 
    {
        private bool _isMuteWhenJoined;
        private int _volume;
        private string _inputDeviceName;
        private string _outputDeviceName;
        public AudioUserControl()//ToDO: need to trasfer the data from the server to settingsScreen to this constructor.
        {
            InitializeComponent();
        }

        public event ValuesChangedEvent ChangedEvent;

        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            volumeNumberBox.Text = $"{volumeBar.Value*10}";
        }

        private void AudioUserControl_Load(object sender, EventArgs e)
        {
            volumeNumberBox.Text = $"{volumeBar.Value * 100}";
        }
        public void IsChanged()
        {
            if (ChangedEvent != null)
            {
                ChangedEvent(new ValuesChangedEventArgs(CheckIfChanged()));
            }
        }
        public bool CheckIfChanged()
        {
            return (int.Parse(this.volumeNumberBox.Text) != _volume || this.inputCboBox.SelectedText != _inputDeviceName || this.outputCboBox.SelectedText != _outputDeviceName || this.enterCallBox.Checked != _isMuteWhenJoined);
        }
        public List<string> Convert2Str()
        {
            throw new NotImplementedException();
        }

        public void OrgenizeData(string data)
        {
            throw new NotImplementedException();
        }
    }
}
