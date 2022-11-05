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

        public enum container {
            mkv,
            mp4,
            avi
        }

        public enum video_select {
            copy,
            x265,
            x264
        }

        public enum audio_select {
            copy,
            flac,
            wav_separate
        }

        public enum video_preset {
            placebo,
            veryslow,
            slower,
            slow,
            medium,
            fast,
            faster,
            veryfast,
            superfast,
            ultrafast
        }

        public class vid_file_info {
            public vid_file_info(string _path, MainForm form, bool segmented = false) {
                string stem, npath;
                int i;

                // Basic file information
                path = _path;
                fi = new FileInfo(path);
                name = Path.GetFileName(path);
                is_segment = segmented;

                // More video information
                MediaInfo.MediaInfo mi = new MediaInfo.MediaInfo();
                mi.Open(path);

                // General
                file_format = fi.Extension.Substring(1).ToUpper()
                    + " (" + mi.Get(MediaInfo.StreamKind.General, 0, "Format") + ")";

                // Video Metadata
                resolution = mi.Get(MediaInfo.StreamKind.Video, 0, "Width").ToString()
                    + "x" + mi.Get(MediaInfo.StreamKind.Video, 0, "Height").ToString();
                vcodec = mi.Get(MediaInfo.StreamKind.Video, 0, "Format");
                duration = Convert.ToDouble(mi.Get(MediaInfo.StreamKind.Video, 0, "Duration"));
                duration_s = mi.Get(MediaInfo.StreamKind.Video, 0, "Duration/String3");
                colour_space = mi.Get(MediaInfo.StreamKind.Video, 0, "ColorSpace");
                chroma_subsampling = mi.Get(MediaInfo.StreamKind.Video, 0, "ChromaSubsampling");
                bit_depth = mi.Get(MediaInfo.StreamKind.Video, 0, "BitDepth");
                fps = mi.Get(MediaInfo.StreamKind.Video, 0, "FrameRate");

                // Audio Metadata
                acodec = mi.Get(MediaInfo.StreamKind.Audio, 0, "Format");
                a_bitrate = mi.Get(MediaInfo.StreamKind.Audio, 0, "BitRate/String");
                sample_rate = mi.Get(MediaInfo.StreamKind.Audio, 0, "SamplingRate");
                channels = mi.Get(MediaInfo.StreamKind.Audio, 0, "Channels");

                mi.Close();

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
                    duration = 0;

                    foreach (vid_file_info segment in segments) {
                        size += segment.size;
                        duration += segment.duration;
                    }
                }
                else {
                    size = fi.Length;
                }

                size_friendly = form.bytes_to_friendly(size);

                // Video encoding settings set to default
                setting_container    = container.mkv;
                setting_video        = video_select.copy;
                setting_audio        = audio_select.copy;
                setting_crf          = 17;
                setting_video_preset = video_preset.medium;

                // Metadata too
                title = "";
            }

            // Stream information
            public string name { get; set; }
            public long size { get; set; }
            public string path { get; set; }
            public string size_friendly { get; set; }
            public bool is_segment { get; set; }
            public string resolution { get; set; }
            public double duration { get; set; }
            public string duration_s { get; set; }
            public string vcodec { get; set; }
            public string colour_space { get; set; }
            public string chroma_subsampling { get; set; }
            public string bit_depth { get; set; }
            public string acodec { get; set; }
            public string a_bitrate { get; set; }
            public string sample_rate { get; set; }
            public string channels { get; set; }
            public string fps { get; set; }
            public string file_format { get; set; }
            public string title { get; set; }

            // Video encoding information
            public container setting_container { get; set; }
            public video_select setting_video { get; set; }
            public audio_select setting_audio { get; set; }
            public int setting_crf { get; set; }
            public video_preset setting_video_preset { get; set;}

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

        public void populate_details_area(List<vid_file_info> segments) {
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("Segments");
            dt.Columns.Add("name");
            dt.Columns.Add("duration_s");
            dt.Columns.Add("resolution");
            dt.Columns.Add("vcodec");
            dt.Columns.Add("acodec");
            dt.Columns.Add("size_friendly");

            foreach (vid_file_info segment in segments) {
                dt.Rows.Add(new string[] {
                    segment.name,
                    segment.duration_s,
                    segment.resolution,
                    segment.vcodec,
                    segment.acodec,
                    segment.size_friendly
                });
            }
            
            dlv_inner_detail.DataSource = new DataView(ds.Tables["Segments"]);
        }

        private void dtlv_filelist_SelectedIndexChanged(object sender, EventArgs e) {
            if (dtlv_filelist.SelectedIndex == -1) {
                tabControl_main.Enabled = false;
                return;
            }

            vid_file_info obj = (vid_file_info) dtlv_filelist.SelectedObject;

            tabControl_main.Enabled = true;

            // Update info in visual tab
            textBox_filepath.Text = obj.path;
            label_segment_count.Text = obj.segments.Count.ToString();
            label_total_size.Text = obj.size_friendly + " (" + obj.size.ToString() + " bytes)";
            label_vcodec.Text = obj.vcodec;
            label_acodec.Text = obj.acodec;
            label_colour_space.Text = obj.colour_space;
            label_subsampling.Text = obj.chroma_subsampling;
            label_bitdepth.Text = obj.bit_depth;
            label_resolution.Text = obj.resolution;
            label_fps.Text = obj.fps;
            label_channels.Text = obj.channels;
            label_audio_bitrate.Text = obj.a_bitrate;
            label_sample_rate.Text = obj.sample_rate + " Hz";
            label_format.Text = obj.file_format;

            // Duration in 2 separate ways
            TimeSpan t = TimeSpan.FromMilliseconds(obj.duration);

            label_duration.Text = String.Format(
                "{0:D2}:{1:D2}:{2:D2}:{3:D3}", t.Hours, t.Minutes, t.Seconds, t.Milliseconds
            );
            label_duration.Text += " (" + (obj.duration / 1000).ToString() + " seconds)";

            textBox_vid_title.Text = obj.title;

            // If not a segment, update the details tab
            if (!obj.is_segment)
                populate_details_area(obj.segments);

            // Update radio buttons and video encoding settings
            numericUpDown_crf.Value = obj.setting_crf;
            comboBox_preset.SelectedIndex = (int) obj.setting_video_preset;

            RadioButton[] container_arr = {
                radioButton_mkv,
                radioButton_mp4,
                radioButton_avi
            };

            RadioButton[] vsetting_arr = {
                radioButton_video_copy,
                radioButton_video_x265,
                radioButton_video_x264
            };

            RadioButton[] asetting_arr = {
                radioButton_audio_copy,
                radioButton_audio_flac,
                radioButton_audio_wav_separate
            };

            for (int i = 0; i < 3; i++) {
                container_arr[i].Checked = ((int) obj.setting_container) == i;
                vsetting_arr [i].Checked = ((int) obj.setting_video) == i;
                asetting_arr [i].Checked = ((int) obj.setting_audio) == i;
            }
        }

        private void radioButton_mkv_CheckedChanged(object sender, EventArgs e) {
            if (!radioButton_mkv.Checked)
                return;

            vid_file_info obj = (vid_file_info)dtlv_filelist.SelectedObject;
            obj.setting_container = container.mkv;
        }

        private void radioButton_mp4_CheckedChanged(object sender, EventArgs e) {
            if (!radioButton_mp4.Checked)
                return;

            vid_file_info obj = (vid_file_info)dtlv_filelist.SelectedObject;
            obj.setting_container = container.mp4;
        }

        private void radioButton_avi_CheckedChanged(object sender, EventArgs e) {
            if (!radioButton_avi.Checked)
                return;

            vid_file_info obj = (vid_file_info)dtlv_filelist.SelectedObject;
            obj.setting_container = container.avi;
        }

        private void radioButton_video_copy_CheckedChanged(object sender, EventArgs e) {
            if (!radioButton_video_copy.Checked)
                return;

            vid_file_info obj = (vid_file_info)dtlv_filelist.SelectedObject;
            obj.setting_video = video_select.copy;
            label_video_codec.Text = "-";
            comboBox_preset.Enabled = false;
            numericUpDown_crf.Enabled = false;
        }

        private void radioButton_video_x265_CheckedChanged(object sender, EventArgs e) {
            if (!radioButton_video_x265.Checked)
                return;

            vid_file_info obj = (vid_file_info)dtlv_filelist.SelectedObject;
            obj.setting_video = video_select.x265;
            label_video_codec.Text = "libx265";
            comboBox_preset.Enabled = true;
            numericUpDown_crf.Enabled = true;
        }

        private void radioButton_video_x264_CheckedChanged(object sender, EventArgs e) {
            if (!radioButton_video_x264.Checked)
                return;

            vid_file_info obj = (vid_file_info)dtlv_filelist.SelectedObject;
            obj.setting_video = video_select.x264;
            label_video_codec.Text = "libx264";
            comboBox_preset.Enabled = true;
            numericUpDown_crf.Enabled = true;
        }

        private void radioButton_audio_copy_CheckedChanged(object sender, EventArgs e) {
            if (!radioButton_audio_copy.Checked)
                return;

            vid_file_info obj = (vid_file_info)dtlv_filelist.SelectedObject;
            obj.setting_audio = audio_select.copy;
        }

        private void radioButton_audio_flac_CheckedChanged(object sender, EventArgs e) {
            if (!radioButton_audio_flac.Checked)
                return;

            vid_file_info obj = (vid_file_info)dtlv_filelist.SelectedObject;
            obj.setting_audio = audio_select.flac;
        }

        private void radioButton_audio_wav_separate_CheckedChanged(object sender, EventArgs e) {
            if (!radioButton_audio_wav_separate.Checked)
                return;

            vid_file_info obj = (vid_file_info)dtlv_filelist.SelectedObject;
            obj.setting_audio = audio_select.wav_separate;
        }

        private void numericUpDown_crf_ValueChanged(object sender, EventArgs e) {
            vid_file_info obj = (vid_file_info)dtlv_filelist.SelectedObject;
            obj.setting_crf = (int) numericUpDown_crf.Value;
        }

        private void comboBox_preset_SelectedIndexChanged(object sender, EventArgs e) {
            vid_file_info obj = (vid_file_info)dtlv_filelist.SelectedObject;
            obj.setting_video_preset = (video_preset) comboBox_preset.SelectedIndex;
        }

        string ffmpeg_cmd_generate(string output_path) {
            string cmd;
            vid_file_info obj = (vid_file_info)dtlv_filelist.SelectedObject;
            string[] preset_vals = {
                "placebo",
                "veryslow",
                "slower",
                "slow",
                "medium",
                "fast",
                "faster",
                "veryfast",
                "superfast",
                "ultrafast"
            };

            // Start off with the path to FFmpeg
            // cmd = _settings.paths["FFmpeg"];
            cmd = "";

            // Go based on input, but make "CONCAT_FILE" replacable
            cmd += "-f concat -safe 0 -i CONCAT_FILE";

            if (obj.setting_audio == audio_select.wav_separate)
                cmd += " -map 0:v";
            else
                cmd += " -map 0";

            // Codec selection
            switch (obj.setting_video) {
                default:
                case video_select.copy:
                    cmd += " -c:v copy";
                    break;

                case video_select.x265:
                    cmd += " -c:v libx265";
                    cmd += " -crf " + obj.setting_crf.ToString();
                    cmd += " -preset " + preset_vals[(int) obj.setting_video_preset];
                    break;

                case video_select.x264:
                    cmd += " -c:v libx264";
                    cmd += " -crf " + obj.setting_crf.ToString();
                    cmd += " -preset " + preset_vals[(int)obj.setting_video_preset];
                    break;
            }

            // Audio selection
            switch (obj.setting_audio) {
                default:
                case audio_select.copy:
                    cmd += " -c:a copy";
                    break;

                case audio_select.flac:
                    cmd += " -c:a flac -compression_level 12";
                    break;

                case audio_select.wav_separate:
                    // Deal with it after final file is created
                    break;
            }

            // Metadata if possible
            if (obj.title != "") {
                cmd += " -metadata title=\"" + obj.title.Replace("\"", "\\\"") + "\"";
            }

            // Closing command, file to write
            cmd += " -y \"" + output_path + "\"";

            // But if "separate WAV" is selected, account a second simultaneous output
            if (obj.setting_audio == audio_select.wav_separate) {
                cmd += " -map 0:a:0 -c:a copy \"";
                cmd += output_path.Replace(Path.GetExtension(output_path), ".wav");
                cmd += "\"";
            }

            return cmd;
        }

        private void button_encode_video_Click(object sender, EventArgs e) {
            vid_file_info obj = (vid_file_info)dtlv_filelist.SelectedObject;
            string concat_txt;
            string ffmpeg_cmd;
            SaveFileDialog sav_obj;

            // Idiot-proof the encoding if FFmpeg doesn't exist at all
            if (_settings.paths["FFmpeg"] == "") {
                MessageBox.Show(
                    "FFmpeg path is not configured. Set it up before " +
                    "running a render job.",
                    "FFmpeg not configured",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // Construct the concatenation file information
            concat_txt = "";
            foreach (vid_file_info segment in obj.segments)
                concat_txt += "file '" + segment.path + "'\n";

            // Get the filename for the output file
            sav_obj = new SaveFileDialog();

            switch (obj.setting_container) {
                case container.mkv:
                    sav_obj.Title = "Save MKV as";
                    sav_obj.Filter = "Matroska Video (*.mkv)|*.mkv|All Files|*.*";
                    break;

                case container.mp4:
                    sav_obj.Title = "Save MP4 as";
                    sav_obj.Filter = "MP4 Video (*.mp4)|*.mp4|All Files|*.*";
                    break;

                case container.avi:
                    sav_obj.Title = "Save AVI as";
                    sav_obj.Filter = "Audio Video Interleave (*.avi)|*.avi|All Files|*.*";
                    break;
            }

            // If the file procedure is cancelled, don't do anything
            if (sav_obj.ShowDialog() != DialogResult.OK)
                return;

            // Construct the FFmpeg command
            ffmpeg_cmd = ffmpeg_cmd_generate(sav_obj.FileName);

            Form log_win = new ffmpeg_log(ffmpeg_cmd, concat_txt);
            log_win.Show();
        }

        private void textBox_vid_title_TextChanged(object sender, EventArgs e) {
            vid_file_info obj = (vid_file_info)dtlv_filelist.SelectedObject;

            obj.title = textBox_vid_title.Text;
        }
    }
}
