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

        public void refresh_drives() {
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
            refresh_drives();
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
            refresh_drives();
        }

        public class vid_file_info {
            public vid_file_info(string path, MainForm form, bool segmented = false) {
                string stem, npath;
                int i;

                // Basic file information
                fi = new FileInfo(path);
                name = Path.GetFileName(path);

                // Assume this is a segment
                segments = new List<vid_file_info>();
                if (!segmented) {
                    segments.Add(new vid_file_info(path, form, true));

                    // Look for other segments
                    stem = path.Substring(0, path.Length - fi.Extension.Length);

                    for (i = 2; i <= 999; i++) {
                        npath = stem + "-" + i.ToString("D3") + fi.Extension;
                        if (File.Exists(npath))
                            segments.Add(new vid_file_info(npath, form, true));
                        else
                            break;
                    }

                    // Size is total of all segments
                    size = 0;

                    foreach (vid_file_info segment in segments) {
                        size += segment.size;
                    }
                }
                else {
                    size = fi.Length;
                }

                size_friendly = form.bytes_to_friendly(size);
            }

            public string name { get; set; }
            public long size { get; set; }
            public string size_friendly { get; set; }
            public List<vid_file_info> segments;
            public FileInfo fi;
        }

        public void detect_videos_on_drive(string drive) {
            string[] files = Directory.GetFiles(drive + ":\\Elgato\\Videos");

            dtlv_filelist.CanExpandGetter = delegate (object x) {
                return ((vid_file_info) x).segments.Count > 1;
            };

            dtlv_filelist.ChildrenGetter = delegate (object x) {
                return ((vid_file_info) x).segments;
            };

            foreach (string file in files) {
                FileInfo fileInfo = new FileInfo(file);
                string ex = fileInfo.Extension.ToUpper();

                // Anything that isn't a video is invalid
                if (!(ex == ".MOV" || ex == ".MP4" || ex == ".MKV"))
                    continue;

                // Dot files invalid
                if (Path.GetFileName(file).Substring(0, 1) == ".")
                    continue;

                // Segmented files invalid
                if (Path.GetFileName(file).IndexOf("-") != -1)
                    continue;

                dtlv_filelist.AddObject(new vid_file_info(file, this));
            }

        }

        private void comboBox_drives_SelectedIndexChanged(object sender, EventArgs e) {
            int index;
            string name, drive;

            index = comboBox_drives.SelectedIndex;
            name = comboBox_drives.Items[index].ToString();
            
            drive = name.Substring(0, 1);

            detect_videos_on_drive(drive);
        }
    }
}
