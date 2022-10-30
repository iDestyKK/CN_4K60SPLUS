using System;
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
    public partial class Settings : Form {

        private void assume_default_settings() {
            textBox_path_ffmpeg.Text = "";
        }

        private void load_settings_if_possible() {
            // Assume defaults just in case XML lacks some values.
            assume_default_settings();

            // If the configuration file doesn't exist, no worries.
            if (!File.Exists("settings.xml")) {
                return;
            }

            // Load in the XML file
            XDocument xdoc = XDocument.Load("settings.xml");

            textBox_path_ffmpeg.Text = xdoc.Element("Paths").Element("FFmpeg").Value;
        }

        private void save_settings() {
            XDocument xdoc = new XDocument();

            xdoc.Add(new XElement("Paths"));
            xdoc.Element("Paths").Add(new XElement("FFmpeg"));
            xdoc.Element("Paths").Element("FFmpeg").Value = textBox_path_ffmpeg.Text;

            xdoc.Save("settings.xml");
        }

        public Settings()
        {
            InitializeComponent();
            load_settings_if_possible();
        }

        private void bttn_locate_ffmpeg_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog_ffmpeg.ShowDialog();

            if (res == DialogResult.OK) {
                textBox_path_ffmpeg.Text = openFileDialog_ffmpeg.FileName;
            }
        }
        private void button_ok_Click(object sender, EventArgs e) {
            save_settings();
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button_apply_Click(object sender, EventArgs e) {
            save_settings();
        }
    }
}
