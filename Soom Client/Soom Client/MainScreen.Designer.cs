﻿namespace Soom_Client
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.title = new System.Windows.Forms.Label();
            this.createMeetingButton = new System.Windows.Forms.Label();
            this.joinMeetingButton = new System.Windows.Forms.Label();
            this.addFriendButton = new System.Windows.Forms.Label();
            this.sponsorLabel = new System.Windows.Forms.Label();
            this.settingsWheelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Matura MT Script Capitals", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(64)))), ((int)(((byte)(181)))));
            this.title.Location = new System.Drawing.Point(268, 59);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(353, 89);
            this.title.TabIndex = 1;
            this.title.Text = "SOOM";
            // 
            // createMeetingButton
            // 
            this.createMeetingButton.AutoSize = true;
            this.createMeetingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createMeetingButton.Font = new System.Drawing.Font("Microsoft JhengHei Light", 17.3F);
            this.createMeetingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.createMeetingButton.Location = new System.Drawing.Point(326, 222);
            this.createMeetingButton.Margin = new System.Windows.Forms.Padding(3, 17, 3, 17);
            this.createMeetingButton.Name = "createMeetingButton";
            this.createMeetingButton.Size = new System.Drawing.Size(238, 30);
            this.createMeetingButton.TabIndex = 2;
            this.createMeetingButton.Text = "Create New Meeting";
            this.createMeetingButton.Click += new System.EventHandler(this.createMeetingButton_Click);
            this.createMeetingButton.MouseEnter += new System.EventHandler(this.createMeetingButton_MouseEnter);
            this.createMeetingButton.MouseLeave += new System.EventHandler(this.createMeetingButton_MouseLeave);
            // 
            // joinMeetingButton
            // 
            this.joinMeetingButton.AutoSize = true;
            this.joinMeetingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.joinMeetingButton.Font = new System.Drawing.Font("Microsoft JhengHei Light", 17.3F);
            this.joinMeetingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.joinMeetingButton.Location = new System.Drawing.Point(306, 286);
            this.joinMeetingButton.Margin = new System.Windows.Forms.Padding(3, 17, 3, 17);
            this.joinMeetingButton.Name = "joinMeetingButton";
            this.joinMeetingButton.Size = new System.Drawing.Size(277, 30);
            this.joinMeetingButton.TabIndex = 3;
            this.joinMeetingButton.Text = "Join An Existing Meeting";
            this.joinMeetingButton.Click += new System.EventHandler(this.joinMeetingButton_Click);
            this.joinMeetingButton.MouseEnter += new System.EventHandler(this.joinMeetingButton_MouseEnter);
            this.joinMeetingButton.MouseLeave += new System.EventHandler(this.joinMeetingButton_MouseLeave);
            // 
            // addFriendButton
            // 
            this.addFriendButton.AutoSize = true;
            this.addFriendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFriendButton.Font = new System.Drawing.Font("Microsoft JhengHei Light", 17.3F);
            this.addFriendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.addFriendButton.Location = new System.Drawing.Point(378, 350);
            this.addFriendButton.Margin = new System.Windows.Forms.Padding(3, 17, 3, 17);
            this.addFriendButton.Name = "addFriendButton";
            this.addFriendButton.Size = new System.Drawing.Size(134, 30);
            this.addFriendButton.TabIndex = 4;
            this.addFriendButton.Text = "Add Friend";
            this.addFriendButton.Click += new System.EventHandler(this.addFriendButton_Click);
            this.addFriendButton.MouseEnter += new System.EventHandler(this.addFriendButton_MouseEnter);
            this.addFriendButton.MouseLeave += new System.EventHandler(this.addFriendButton_MouseLeave);
            // 
            // sponsorLabel
            // 
            this.sponsorLabel.AutoSize = true;
            this.sponsorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sponsorLabel.Font = new System.Drawing.Font("Microsoft JhengHei Light", 6F, System.Drawing.FontStyle.Bold);
            this.sponsorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.sponsorLabel.Location = new System.Drawing.Point(0, 501);
            this.sponsorLabel.Name = "sponsorLabel";
            this.sponsorLabel.Size = new System.Drawing.Size(115, 10);
            this.sponsorLabel.TabIndex = 5;
            this.sponsorLabel.Text = "Sponsored By SP Online";
            // 
            // settingsWheelButton
            // 
            this.settingsWheelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsWheelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.settingsWheelButton.FlatAppearance.BorderSize = 0;
            this.settingsWheelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.settingsWheelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(224)))));
            this.settingsWheelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsWheelButton.Image = global::Soom_Client.Properties.Resources.SettingsGear;
            this.settingsWheelButton.Location = new System.Drawing.Point(12, 12);
            this.settingsWheelButton.Name = "settingsWheelButton";
            this.settingsWheelButton.Size = new System.Drawing.Size(41, 41);
            this.settingsWheelButton.TabIndex = 0;
            this.settingsWheelButton.UseVisualStyleBackColor = true;
            this.settingsWheelButton.Click += new System.EventHandler(this.settingsWheelButton_Click);
            this.settingsWheelButton.MouseEnter += new System.EventHandler(this.settingsWheelButton_MouseEnter);
            this.settingsWheelButton.MouseLeave += new System.EventHandler(this.settingsWheelButton_MouseLeave);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(874, 511);
            this.Controls.Add(this.sponsorLabel);
            this.Controls.Add(this.addFriendButton);
            this.Controls.Add(this.joinMeetingButton);
            this.Controls.Add(this.createMeetingButton);
            this.Controls.Add(this.title);
            this.Controls.Add(this.settingsWheelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsWheelButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label createMeetingButton;
        private System.Windows.Forms.Label joinMeetingButton;
        private System.Windows.Forms.Label addFriendButton;
        private System.Windows.Forms.Label sponsorLabel;
    }
}