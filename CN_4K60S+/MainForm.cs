﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CN_4K60S_
{
    public partial class MainForm : Form
    {
        private class app_settings {
            public app_settings() {
                // Default Values
                paths["FFmpeg"] = "";
            }

            public void load_if_possible(string path) {
                // If the configuration file doesn't exist, no worries.
                if (!File.Exists("settings.xml")) {
                    return;
                }

                // Load in the XML file
                XDocument xdoc = XDocument.Load("settings.xml");

                paths["FFmpeg"] = xdoc.Element("Paths").Element("FFmpeg").Value;
            }

            public void save(string path) {
                // Scrapped. No reason for this to existing(?)
            }

            public Dictionary<string, string> paths = new Dictionary<string, string>();
        }

        private app_settings _settings = new app_settings();

        public string bytes_to_friendly(long value) {
            string[] tier_s = {
                "bytes", "KiB", "MiB", "GiB",
                "TiB", "PiB", "EiB", "ZiB",
                "YiB" 
            };

            int tier;
            double v;

            tier = 0;
            v = value;

            while (v >= 1024) {
                tier++;
                v /= 1024;
            }

            return (Math.Round(v * 100) / 100).ToString() + " " + tier_s[tier];
        }

        public MainForm()
        {
            InitializeComponent();
            _settings.load_if_possible("settings.xml");
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settings = new Settings();
            settings.ShowDialog();

            // Once done, refresh settings
            _settings.load_if_possible("settings.xml");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void bttn_drive_refresh_Click(object sender, EventArgs e) {
            // Wipe out all items
            comboBox_drives.Items.Clear();

            // Go through all drives
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives) {
                // If not a USB/SD drive, it can't be it
                if (d.DriveType != DriveType.Removable)
                    continue;

                // If the /Elgato/Videos directory doesn't exist, invalid
                if (!Directory.Exists(d.Name + "Elgato\\Videos"))
                    continue;

                comboBox_drives.Items.Add(
                    d.ToString() + " - " + bytes_to_friendly(d.TotalSize)
                );
            }
        }
    }
}
