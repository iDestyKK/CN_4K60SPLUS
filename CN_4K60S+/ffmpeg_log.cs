using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CN_4K60S_ {
    public partial class ffmpeg_log : Form {

        string ffmpeg_args;
        string concat_txt;
        string concat_path;

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

        private app_settings _settings;

        public void write_concatenation_file(string path) {
            StreamWriter fp = new StreamWriter(path);
            fp.Write(concat_txt);
            fp.Close();
        }

        public void write_to_console(RichTextBox output, string data) {
            output.AppendText(data);
            output.ScrollToCaret();
        }

        public void run_ffmpeg(string arguments, RichTextBox output, string concat_path) {
            Process ffmpeg = new Process();

            ffmpeg.StartInfo.FileName = _settings.paths["FFmpeg"];
            ffmpeg.StartInfo.Arguments = arguments;

            ffmpeg.StartInfo.CreateNoWindow = true;
            ffmpeg.StartInfo.RedirectStandardOutput = true;
            ffmpeg.StartInfo.RedirectStandardError = true;
            ffmpeg.StartInfo.UseShellExecute = false;
            ffmpeg.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            ffmpeg.EnableRaisingEvents = true;

            ffmpeg.OutputDataReceived += (s, ea) => {
                this.Invoke(new MethodInvoker(() => write_to_console(
                    output, 
                    ea.Data + "\n"
                )));
            };

            ffmpeg.ErrorDataReceived += (s, ea) => {
                this.Invoke(new MethodInvoker(() => write_to_console(
                    output,
                    ea.Data + "\n"
                )));
            };

            ffmpeg.Exited += (s, ea) => {
                this.Invoke(new MethodInvoker(() => {
                    // Indicate we are done
                    write_to_console(
                        output,
                        "FFmpeg is done. You may now close this window." + "\n"
                    );

                    // Delete the temporary concatenation file
                    File.Delete(concat_path);

                    //Unlock dialog options
                    saveLogToFileToolStripMenuItem.Enabled = true;
                    closeToolStripMenuItem.Enabled = true;
                }));
            };

            ffmpeg.Start();
            ffmpeg.BeginOutputReadLine();
            ffmpeg.BeginErrorReadLine();
        }

        public ffmpeg_log(string _ffmpeg_args, string _concat_txt) {
            string valid_chars;
            char[] random_chars;
            Random rng;

            InitializeComponent();

            // Load settings
            _settings = new app_settings();
            _settings.load_if_possible("settings.xml");

            // Copy over parameters to the class variables
            ffmpeg_args = _ffmpeg_args;
            concat_txt = _concat_txt;

            // Generate unique concatenation filename
            valid_chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            random_chars = new char[16];
            rng = new Random();
            do {
                for (int i = 0; i < 16; i++)
                    random_chars[i] = valid_chars[rng.Next(valid_chars.Length)];

                concat_path = new String(random_chars);
                concat_path = "concat_" + concat_path + ".txt";
            } while (File.Exists(concat_path));

            // Create the concatenation file for FFmpeg to parse
            write_concatenation_file(concat_path);

            // Finalise FFmpeg command
            ffmpeg_args = ffmpeg_args.Replace("CONCAT_FILE", "\"" + concat_path + "\"");

            // Fire up FFmpeg with the configuration
            run_ffmpeg(ffmpeg_args, richTextBox_log, concat_path);
        }

        private void saveLogToFileToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog sav_log_dialog;
            StreamWriter fp;

            // Get filename first
            sav_log_dialog = new SaveFileDialog();

            sav_log_dialog.Title = "Save log as";
            sav_log_dialog.Filter = "Log File|*.log|Text File|*.txt|All Files|*.*";

            if (sav_log_dialog.ShowDialog() != DialogResult.OK)
                return;

            // Write log file
            fp = new StreamWriter(sav_log_dialog.FileName);

            foreach (string line in richTextBox_log.Lines)
                fp.Write(line);

            fp.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
