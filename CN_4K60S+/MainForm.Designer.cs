namespace CN_4K60S_
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_drive_refresh = new System.Windows.Forms.Button();
            this.comboBox_drives = new System.Windows.Forms.ComboBox();
            this.dtlv_filelist = new BrightIdeasSoftware.DataTreeListView();
            this.olvColumn_name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_size = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_overview = new System.Windows.Forms.TabPage();
            this.textBox_filepath = new System.Windows.Forms.TextBox();
            this.tabPage_video_summary = new System.Windows.Forms.TabPage();
            this.dlv_inner_detail = new BrightIdeasSoftware.DataListView();
            this.olvColumn_inner_name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_inner_duration = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_inner_vcodec = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_inner_acodec = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_inner_size = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPage_encoding_settings = new System.Windows.Forms.TabPage();
            this.olvColumn_inner_res = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_segment_count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_total_size = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_vcodec = new System.Windows.Forms.Label();
            this.label_acodec = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_duration = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_colour_space = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_subsampling = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_bitdepth = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_audio_bitrate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_channels = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label_sample_rate = new System.Windows.Forms.Label();
            this.label_fps = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_resolution = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_format = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton_mkv = new System.Windows.Forms.RadioButton();
            this.radioButton_mp4 = new System.Windows.Forms.RadioButton();
            this.radioButton_avi = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton_video_x264 = new System.Windows.Forms.RadioButton();
            this.radioButton_video_x265 = new System.Windows.Forms.RadioButton();
            this.radioButton_video_copy = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton_audio_wav_separate = new System.Windows.Forms.RadioButton();
            this.radioButton_audio_flac = new System.Windows.Forms.RadioButton();
            this.radioButton_audio_copy = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_format = new System.Windows.Forms.TabPage();
            this.tabPage_video_advanced = new System.Windows.Forms.TabPage();
            this.tabPage_metadata = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_vid_title = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label_video_codec = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox_preset = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.numericUpDown_crf = new System.Windows.Forms.NumericUpDown();
            this.button_encode_video = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractAndConcatAllSDCardVideosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCN4K60SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtlv_filelist)).BeginInit();
            this.tabControl_main.SuspendLayout();
            this.tabPage_overview.SuspendLayout();
            this.tabPage_video_summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlv_inner_detail)).BeginInit();
            this.tabPage_encoding_settings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_format.SuspendLayout();
            this.tabPage_video_advanced.SuspendLayout();
            this.tabPage_metadata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_crf)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.utilityToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutCN4K60SToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl_main);
            this.splitContainer1.Size = new System.Drawing.Size(844, 458);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.bttn_drive_refresh);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox_drives);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dtlv_filelist);
            this.splitContainer2.Size = new System.Drawing.Size(265, 458);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drive:";
            // 
            // bttn_drive_refresh
            // 
            this.bttn_drive_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_drive_refresh.Location = new System.Drawing.Point(208, 3);
            this.bttn_drive_refresh.Name = "bttn_drive_refresh";
            this.bttn_drive_refresh.Size = new System.Drawing.Size(57, 21);
            this.bttn_drive_refresh.TabIndex = 1;
            this.bttn_drive_refresh.Text = "Refresh";
            this.bttn_drive_refresh.UseVisualStyleBackColor = true;
            this.bttn_drive_refresh.Click += new System.EventHandler(this.bttn_drive_refresh_Click);
            // 
            // comboBox_drives
            // 
            this.comboBox_drives.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_drives.FormattingEnabled = true;
            this.comboBox_drives.Location = new System.Drawing.Point(43, 3);
            this.comboBox_drives.Name = "comboBox_drives";
            this.comboBox_drives.Size = new System.Drawing.Size(159, 20);
            this.comboBox_drives.TabIndex = 0;
            this.comboBox_drives.SelectedIndexChanged += new System.EventHandler(this.comboBox_drives_SelectedIndexChanged);
            // 
            // dtlv_filelist
            // 
            this.dtlv_filelist.AllColumns.Add(this.olvColumn_name);
            this.dtlv_filelist.AllColumns.Add(this.olvColumn_size);
            this.dtlv_filelist.CellEditUseWholeCell = false;
            this.dtlv_filelist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_name,
            this.olvColumn_size});
            this.dtlv_filelist.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtlv_filelist.DataSource = null;
            this.dtlv_filelist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtlv_filelist.HideSelection = false;
            this.dtlv_filelist.Location = new System.Drawing.Point(0, 0);
            this.dtlv_filelist.Name = "dtlv_filelist";
            this.dtlv_filelist.RootKeyValueString = "";
            this.dtlv_filelist.ShowGroups = false;
            this.dtlv_filelist.Size = new System.Drawing.Size(265, 429);
            this.dtlv_filelist.TabIndex = 0;
            this.dtlv_filelist.UseCompatibleStateImageBehavior = false;
            this.dtlv_filelist.View = System.Windows.Forms.View.Details;
            this.dtlv_filelist.VirtualMode = true;
            this.dtlv_filelist.SelectedIndexChanged += new System.EventHandler(this.dtlv_filelist_SelectedIndexChanged);
            // 
            // olvColumn_name
            // 
            this.olvColumn_name.AspectName = "name";
            this.olvColumn_name.Text = "Name";
            this.olvColumn_name.Width = 180;
            // 
            // olvColumn_size
            // 
            this.olvColumn_size.AspectName = "size_friendly";
            this.olvColumn_size.Text = "Size";
            this.olvColumn_size.Width = 84;
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_overview);
            this.tabControl_main.Controls.Add(this.tabPage_video_summary);
            this.tabControl_main.Controls.Add(this.tabPage_encoding_settings);
            this.tabControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_main.Enabled = false;
            this.tabControl_main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(575, 458);
            this.tabControl_main.TabIndex = 0;
            // 
            // tabPage_overview
            // 
            this.tabPage_overview.Controls.Add(this.groupBox3);
            this.tabPage_overview.Controls.Add(this.groupBox2);
            this.tabPage_overview.Controls.Add(this.groupBox1);
            this.tabPage_overview.Controls.Add(this.label2);
            this.tabPage_overview.Controls.Add(this.textBox_filepath);
            this.tabPage_overview.Location = new System.Drawing.Point(4, 22);
            this.tabPage_overview.Name = "tabPage_overview";
            this.tabPage_overview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_overview.Size = new System.Drawing.Size(567, 391);
            this.tabPage_overview.TabIndex = 0;
            this.tabPage_overview.Text = "Overview";
            this.tabPage_overview.UseVisualStyleBackColor = true;
            // 
            // textBox_filepath
            // 
            this.textBox_filepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_filepath.Location = new System.Drawing.Point(71, 6);
            this.textBox_filepath.Name = "textBox_filepath";
            this.textBox_filepath.Size = new System.Drawing.Size(488, 19);
            this.textBox_filepath.TabIndex = 0;
            // 
            // tabPage_video_summary
            // 
            this.tabPage_video_summary.Controls.Add(this.dlv_inner_detail);
            this.tabPage_video_summary.Location = new System.Drawing.Point(4, 22);
            this.tabPage_video_summary.Name = "tabPage_video_summary";
            this.tabPage_video_summary.Size = new System.Drawing.Size(567, 391);
            this.tabPage_video_summary.TabIndex = 2;
            this.tabPage_video_summary.Text = "Video Information";
            this.tabPage_video_summary.UseVisualStyleBackColor = true;
            // 
            // dlv_inner_detail
            // 
            this.dlv_inner_detail.AllColumns.Add(this.olvColumn_inner_name);
            this.dlv_inner_detail.AllColumns.Add(this.olvColumn_inner_duration);
            this.dlv_inner_detail.AllColumns.Add(this.olvColumn_inner_res);
            this.dlv_inner_detail.AllColumns.Add(this.olvColumn_inner_vcodec);
            this.dlv_inner_detail.AllColumns.Add(this.olvColumn_inner_acodec);
            this.dlv_inner_detail.AllColumns.Add(this.olvColumn_inner_size);
            this.dlv_inner_detail.CellEditUseWholeCell = false;
            this.dlv_inner_detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_inner_name,
            this.olvColumn_inner_duration,
            this.olvColumn_inner_res,
            this.olvColumn_inner_vcodec,
            this.olvColumn_inner_acodec,
            this.olvColumn_inner_size});
            this.dlv_inner_detail.Cursor = System.Windows.Forms.Cursors.Default;
            this.dlv_inner_detail.DataSource = null;
            this.dlv_inner_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dlv_inner_detail.HideSelection = false;
            this.dlv_inner_detail.Location = new System.Drawing.Point(0, 0);
            this.dlv_inner_detail.Name = "dlv_inner_detail";
            this.dlv_inner_detail.ShowGroups = false;
            this.dlv_inner_detail.Size = new System.Drawing.Size(567, 391);
            this.dlv_inner_detail.TabIndex = 0;
            this.dlv_inner_detail.UseCompatibleStateImageBehavior = false;
            this.dlv_inner_detail.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn_inner_name
            // 
            this.olvColumn_inner_name.AspectName = "name";
            this.olvColumn_inner_name.Text = "Name";
            this.olvColumn_inner_name.Width = 150;
            // 
            // olvColumn_inner_duration
            // 
            this.olvColumn_inner_duration.AspectName = "duration_s";
            this.olvColumn_inner_duration.Text = "Duration";
            this.olvColumn_inner_duration.Width = 72;
            // 
            // olvColumn_inner_vcodec
            // 
            this.olvColumn_inner_vcodec.AspectName = "vcodec";
            this.olvColumn_inner_vcodec.Text = "Video Codec";
            this.olvColumn_inner_vcodec.Width = 84;
            // 
            // olvColumn_inner_acodec
            // 
            this.olvColumn_inner_acodec.AspectName = "acodec";
            this.olvColumn_inner_acodec.Text = "Audio Codec";
            this.olvColumn_inner_acodec.Width = 84;
            // 
            // olvColumn_inner_size
            // 
            this.olvColumn_inner_size.AspectName = "size_friendly";
            this.olvColumn_inner_size.Text = "Size";
            this.olvColumn_inner_size.Width = 84;
            // 
            // tabPage_encoding_settings
            // 
            this.tabPage_encoding_settings.Controls.Add(this.panel1);
            this.tabPage_encoding_settings.Controls.Add(this.tabControl1);
            this.tabPage_encoding_settings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_encoding_settings.Name = "tabPage_encoding_settings";
            this.tabPage_encoding_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_encoding_settings.Size = new System.Drawing.Size(567, 432);
            this.tabPage_encoding_settings.TabIndex = 1;
            this.tabPage_encoding_settings.Text = "Encoding Settings";
            this.tabPage_encoding_settings.UseVisualStyleBackColor = true;
            // 
            // olvColumn_inner_res
            // 
            this.olvColumn_inner_res.AspectName = "resolution";
            this.olvColumn_inner_res.Text = "Resolution";
            this.olvColumn_inner_res.Width = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Video File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segments:";
            // 
            // label_segment_count
            // 
            this.label_segment_count.AutoSize = true;
            this.label_segment_count.Location = new System.Drawing.Point(126, 20);
            this.label_segment_count.Name = "label_segment_count";
            this.label_segment_count.Size = new System.Drawing.Size(11, 12);
            this.label_segment_count.TabIndex = 3;
            this.label_segment_count.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Size:";
            // 
            // label_total_size
            // 
            this.label_total_size.AutoSize = true;
            this.label_total_size.Location = new System.Drawing.Point(126, 60);
            this.label_total_size.Name = "label_total_size";
            this.label_total_size.Size = new System.Drawing.Size(11, 12);
            this.label_total_size.TabIndex = 5;
            this.label_total_size.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Video Codec:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Audio Codec:";
            // 
            // label_vcodec
            // 
            this.label_vcodec.AutoSize = true;
            this.label_vcodec.Location = new System.Drawing.Point(126, 20);
            this.label_vcodec.Name = "label_vcodec";
            this.label_vcodec.Size = new System.Drawing.Size(11, 12);
            this.label_vcodec.TabIndex = 8;
            this.label_vcodec.Text = "-";
            // 
            // label_acodec
            // 
            this.label_acodec.AutoSize = true;
            this.label_acodec.Location = new System.Drawing.Point(126, 20);
            this.label_acodec.Name = "label_acodec";
            this.label_acodec.Size = new System.Drawing.Size(11, 12);
            this.label_acodec.TabIndex = 9;
            this.label_acodec.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label_resolution);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label_fps);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label_bitdepth);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label_subsampling);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label_colour_space);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label_vcodec);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(8, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 142);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "Duration:";
            // 
            // label_duration
            // 
            this.label_duration.AutoSize = true;
            this.label_duration.Location = new System.Drawing.Point(126, 40);
            this.label_duration.Name = "label_duration";
            this.label_duration.Size = new System.Drawing.Size(11, 12);
            this.label_duration.TabIndex = 11;
            this.label_duration.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label_sample_rate);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label_channels);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label_audio_bitrate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label_acodec);
            this.groupBox2.Location = new System.Drawing.Point(8, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 102);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audio Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label_format);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label_duration);
            this.groupBox3.Controls.Add(this.label_total_size);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label_segment_count);
            this.groupBox3.Location = new System.Drawing.Point(8, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 104);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General Information";
            // 
            // label_colour_space
            // 
            this.label_colour_space.AutoSize = true;
            this.label_colour_space.Location = new System.Drawing.Point(126, 80);
            this.label_colour_space.Name = "label_colour_space";
            this.label_colour_space.Size = new System.Drawing.Size(11, 12);
            this.label_colour_space.TabIndex = 10;
            this.label_colour_space.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "Colour Space:";
            // 
            // label_subsampling
            // 
            this.label_subsampling.AutoSize = true;
            this.label_subsampling.Location = new System.Drawing.Point(126, 100);
            this.label_subsampling.Name = "label_subsampling";
            this.label_subsampling.Size = new System.Drawing.Size(11, 12);
            this.label_subsampling.TabIndex = 12;
            this.label_subsampling.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "Chroma Subsampling:";
            // 
            // label_bitdepth
            // 
            this.label_bitdepth.AutoSize = true;
            this.label_bitdepth.Location = new System.Drawing.Point(126, 120);
            this.label_bitdepth.Name = "label_bitdepth";
            this.label_bitdepth.Size = new System.Drawing.Size(11, 12);
            this.label_bitdepth.TabIndex = 14;
            this.label_bitdepth.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "Bit Depth:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "Bitrate:";
            // 
            // label_audio_bitrate
            // 
            this.label_audio_bitrate.AutoSize = true;
            this.label_audio_bitrate.Location = new System.Drawing.Point(126, 40);
            this.label_audio_bitrate.Name = "label_audio_bitrate";
            this.label_audio_bitrate.Size = new System.Drawing.Size(11, 12);
            this.label_audio_bitrate.TabIndex = 11;
            this.label_audio_bitrate.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "Channels:";
            // 
            // label_channels
            // 
            this.label_channels.AutoSize = true;
            this.label_channels.Location = new System.Drawing.Point(126, 60);
            this.label_channels.Name = "label_channels";
            this.label_channels.Size = new System.Drawing.Size(11, 12);
            this.label_channels.TabIndex = 13;
            this.label_channels.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 12);
            this.label15.TabIndex = 14;
            this.label15.Text = "Sample Rate:";
            // 
            // label_sample_rate
            // 
            this.label_sample_rate.AutoSize = true;
            this.label_sample_rate.Location = new System.Drawing.Point(126, 80);
            this.label_sample_rate.Name = "label_sample_rate";
            this.label_sample_rate.Size = new System.Drawing.Size(11, 12);
            this.label_sample_rate.TabIndex = 15;
            this.label_sample_rate.Text = "-";
            // 
            // label_fps
            // 
            this.label_fps.AutoSize = true;
            this.label_fps.Location = new System.Drawing.Point(126, 60);
            this.label_fps.Name = "label_fps";
            this.label_fps.Size = new System.Drawing.Size(11, 12);
            this.label_fps.TabIndex = 16;
            this.label_fps.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 12);
            this.label14.TabIndex = 15;
            this.label14.Text = "Frame Rate:";
            // 
            // label_resolution
            // 
            this.label_resolution.AutoSize = true;
            this.label_resolution.Location = new System.Drawing.Point(126, 40);
            this.label_resolution.Name = "label_resolution";
            this.label_resolution.Size = new System.Drawing.Size(11, 12);
            this.label_resolution.TabIndex = 18;
            this.label_resolution.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 12);
            this.label16.TabIndex = 17;
            this.label16.Text = "Resolution:";
            // 
            // label_format
            // 
            this.label_format.AutoSize = true;
            this.label_format.Location = new System.Drawing.Point(126, 80);
            this.label_format.Name = "label_format";
            this.label_format.Size = new System.Drawing.Size(11, 12);
            this.label_format.TabIndex = 13;
            this.label_format.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 12);
            this.label17.TabIndex = 12;
            this.label17.Text = "Format:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.radioButton_avi);
            this.groupBox4.Controls.Add(this.radioButton_mp4);
            this.groupBox4.Controls.Add(this.radioButton_mkv);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(533, 109);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output Container";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "Choose a container to store the final file in:";
            // 
            // radioButton_mkv
            // 
            this.radioButton_mkv.AutoSize = true;
            this.radioButton_mkv.Checked = true;
            this.radioButton_mkv.Location = new System.Drawing.Point(8, 40);
            this.radioButton_mkv.Name = "radioButton_mkv";
            this.radioButton_mkv.Size = new System.Drawing.Size(47, 16);
            this.radioButton_mkv.TabIndex = 1;
            this.radioButton_mkv.TabStop = true;
            this.radioButton_mkv.Text = "MKV";
            this.radioButton_mkv.UseVisualStyleBackColor = true;
            this.radioButton_mkv.CheckedChanged += new System.EventHandler(this.radioButton_mkv_CheckedChanged);
            // 
            // radioButton_mp4
            // 
            this.radioButton_mp4.AutoSize = true;
            this.radioButton_mp4.Location = new System.Drawing.Point(8, 60);
            this.radioButton_mp4.Name = "radioButton_mp4";
            this.radioButton_mp4.Size = new System.Drawing.Size(45, 16);
            this.radioButton_mp4.TabIndex = 2;
            this.radioButton_mp4.Text = "MP4";
            this.radioButton_mp4.UseVisualStyleBackColor = true;
            this.radioButton_mp4.CheckedChanged += new System.EventHandler(this.radioButton_mp4_CheckedChanged);
            // 
            // radioButton_avi
            // 
            this.radioButton_avi.AutoSize = true;
            this.radioButton_avi.Location = new System.Drawing.Point(8, 80);
            this.radioButton_avi.Name = "radioButton_avi";
            this.radioButton_avi.Size = new System.Drawing.Size(42, 16);
            this.radioButton_avi.TabIndex = 3;
            this.radioButton_avi.Text = "AVI";
            this.radioButton_avi.UseVisualStyleBackColor = true;
            this.radioButton_avi.CheckedChanged += new System.EventHandler(this.radioButton_avi_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.radioButton_video_x264);
            this.groupBox5.Controls.Add(this.radioButton_video_x265);
            this.groupBox5.Controls.Add(this.radioButton_video_copy);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Location = new System.Drawing.Point(6, 121);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(533, 109);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Video Options";
            // 
            // radioButton_video_x264
            // 
            this.radioButton_video_x264.AutoSize = true;
            this.radioButton_video_x264.Location = new System.Drawing.Point(8, 80);
            this.radioButton_video_x264.Name = "radioButton_video_x264";
            this.radioButton_video_x264.Size = new System.Drawing.Size(159, 16);
            this.radioButton_video_x264.TabIndex = 3;
            this.radioButton_video_x264.Text = "Encode via libx264 (H.264)";
            this.radioButton_video_x264.UseVisualStyleBackColor = true;
            this.radioButton_video_x264.CheckedChanged += new System.EventHandler(this.radioButton_video_x264_CheckedChanged);
            // 
            // radioButton_video_x265
            // 
            this.radioButton_video_x265.AutoSize = true;
            this.radioButton_video_x265.Location = new System.Drawing.Point(8, 60);
            this.radioButton_video_x265.Name = "radioButton_video_x265";
            this.radioButton_video_x265.Size = new System.Drawing.Size(162, 16);
            this.radioButton_video_x265.TabIndex = 2;
            this.radioButton_video_x265.Text = "Encode via libx265 (HEVC)";
            this.radioButton_video_x265.UseVisualStyleBackColor = true;
            this.radioButton_video_x265.CheckedChanged += new System.EventHandler(this.radioButton_video_x265_CheckedChanged);
            // 
            // radioButton_video_copy
            // 
            this.radioButton_video_copy.AutoSize = true;
            this.radioButton_video_copy.Checked = true;
            this.radioButton_video_copy.Location = new System.Drawing.Point(8, 40);
            this.radioButton_video_copy.Name = "radioButton_video_copy";
            this.radioButton_video_copy.Size = new System.Drawing.Size(187, 16);
            this.radioButton_video_copy.TabIndex = 1;
            this.radioButton_video_copy.TabStop = true;
            this.radioButton_video_copy.Text = "Copy losslessly. No quality lost.";
            this.radioButton_video_copy.UseVisualStyleBackColor = true;
            this.radioButton_video_copy.CheckedChanged += new System.EventHandler(this.radioButton_video_copy_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(207, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "Choose what to do to the video stream:";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.radioButton_audio_wav_separate);
            this.groupBox6.Controls.Add(this.radioButton_audio_flac);
            this.groupBox6.Controls.Add(this.radioButton_audio_copy);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Location = new System.Drawing.Point(6, 236);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(533, 109);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Audio Options";
            // 
            // radioButton_audio_wav_separate
            // 
            this.radioButton_audio_wav_separate.AutoSize = true;
            this.radioButton_audio_wav_separate.Location = new System.Drawing.Point(8, 80);
            this.radioButton_audio_wav_separate.Name = "radioButton_audio_wav_separate";
            this.radioButton_audio_wav_separate.Size = new System.Drawing.Size(196, 16);
            this.radioButton_audio_wav_separate.TabIndex = 3;
            this.radioButton_audio_wav_separate.Text = "Export as a WAV alongside video.";
            this.radioButton_audio_wav_separate.UseVisualStyleBackColor = true;
            this.radioButton_audio_wav_separate.CheckedChanged += new System.EventHandler(this.radioButton_audio_wav_separate_CheckedChanged);
            // 
            // radioButton_audio_flac
            // 
            this.radioButton_audio_flac.AutoSize = true;
            this.radioButton_audio_flac.Location = new System.Drawing.Point(8, 60);
            this.radioButton_audio_flac.Name = "radioButton_audio_flac";
            this.radioButton_audio_flac.Size = new System.Drawing.Size(204, 16);
            this.radioButton_audio_flac.TabIndex = 2;
            this.radioButton_audio_flac.Text = "Compress to FLAC. No quality lost.";
            this.radioButton_audio_flac.UseVisualStyleBackColor = true;
            this.radioButton_audio_flac.CheckedChanged += new System.EventHandler(this.radioButton_audio_flac_CheckedChanged);
            // 
            // radioButton_audio_copy
            // 
            this.radioButton_audio_copy.AutoSize = true;
            this.radioButton_audio_copy.Checked = true;
            this.radioButton_audio_copy.Location = new System.Drawing.Point(8, 40);
            this.radioButton_audio_copy.Name = "radioButton_audio_copy";
            this.radioButton_audio_copy.Size = new System.Drawing.Size(187, 16);
            this.radioButton_audio_copy.TabIndex = 1;
            this.radioButton_audio_copy.TabStop = true;
            this.radioButton_audio_copy.Text = "Copy losslessly. No quality lost.";
            this.radioButton_audio_copy.UseVisualStyleBackColor = true;
            this.radioButton_audio_copy.CheckedChanged += new System.EventHandler(this.radioButton_audio_copy_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(207, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "Choose what to do to the audio stream:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_metadata);
            this.tabControl1.Controls.Add(this.tabPage_format);
            this.tabControl1.Controls.Add(this.tabPage_video_advanced);
            this.tabControl1.Location = new System.Drawing.Point(6, 7);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 380);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage_format
            // 
            this.tabPage_format.Controls.Add(this.groupBox4);
            this.tabPage_format.Controls.Add(this.groupBox6);
            this.tabPage_format.Controls.Add(this.groupBox5);
            this.tabPage_format.Location = new System.Drawing.Point(4, 22);
            this.tabPage_format.Name = "tabPage_format";
            this.tabPage_format.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_format.Size = new System.Drawing.Size(545, 354);
            this.tabPage_format.TabIndex = 0;
            this.tabPage_format.Text = "Format and Codecs";
            this.tabPage_format.UseVisualStyleBackColor = true;
            // 
            // tabPage_video_advanced
            // 
            this.tabPage_video_advanced.Controls.Add(this.numericUpDown_crf);
            this.tabPage_video_advanced.Controls.Add(this.label23);
            this.tabPage_video_advanced.Controls.Add(this.comboBox_preset);
            this.tabPage_video_advanced.Controls.Add(this.label22);
            this.tabPage_video_advanced.Controls.Add(this.label_video_codec);
            this.tabPage_video_advanced.Controls.Add(this.label21);
            this.tabPage_video_advanced.Location = new System.Drawing.Point(4, 22);
            this.tabPage_video_advanced.Name = "tabPage_video_advanced";
            this.tabPage_video_advanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_video_advanced.Size = new System.Drawing.Size(545, 354);
            this.tabPage_video_advanced.TabIndex = 1;
            this.tabPage_video_advanced.Text = "Video Settings";
            this.tabPage_video_advanced.UseVisualStyleBackColor = true;
            // 
            // tabPage_metadata
            // 
            this.tabPage_metadata.Controls.Add(this.textBox_vid_title);
            this.tabPage_metadata.Controls.Add(this.label20);
            this.tabPage_metadata.Location = new System.Drawing.Point(4, 22);
            this.tabPage_metadata.Name = "tabPage_metadata";
            this.tabPage_metadata.Size = new System.Drawing.Size(545, 354);
            this.tabPage_metadata.TabIndex = 2;
            this.tabPage_metadata.Text = "Information";
            this.tabPage_metadata.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 12);
            this.label20.TabIndex = 0;
            this.label20.Text = "Video Title:";
            // 
            // textBox_vid_title
            // 
            this.textBox_vid_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_vid_title.Location = new System.Drawing.Point(70, 6);
            this.textBox_vid_title.Name = "textBox_vid_title";
            this.textBox_vid_title.Size = new System.Drawing.Size(472, 19);
            this.textBox_vid_title.TabIndex = 1;
            this.textBox_vid_title.TextChanged += new System.EventHandler(this.textBox_vid_title_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 12);
            this.label21.TabIndex = 0;
            this.label21.Text = "Codec:";
            // 
            // label_video_codec
            // 
            this.label_video_codec.AutoSize = true;
            this.label_video_codec.Location = new System.Drawing.Point(51, 10);
            this.label_video_codec.Name = "label_video_codec";
            this.label_video_codec.Size = new System.Drawing.Size(11, 12);
            this.label_video_codec.TabIndex = 1;
            this.label_video_codec.Text = "-";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 12);
            this.label22.TabIndex = 2;
            this.label22.Text = "Preset:";
            // 
            // comboBox_preset
            // 
            this.comboBox_preset.Enabled = false;
            this.comboBox_preset.FormattingEnabled = true;
            this.comboBox_preset.Items.AddRange(new object[] {
            "placebo",
            "veryslow",
            "slower",
            "slow",
            "medium",
            "fast",
            "faster",
            "veryfast",
            "superfast",
            "ultrafast"});
            this.comboBox_preset.Location = new System.Drawing.Point(52, 31);
            this.comboBox_preset.Name = "comboBox_preset";
            this.comboBox_preset.Size = new System.Drawing.Size(121, 20);
            this.comboBox_preset.TabIndex = 3;
            this.comboBox_preset.SelectedIndexChanged += new System.EventHandler(this.comboBox_preset_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 58);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 12);
            this.label23.TabIndex = 4;
            this.label23.Text = "CRF:";
            // 
            // numericUpDown_crf
            // 
            this.numericUpDown_crf.Enabled = false;
            this.numericUpDown_crf.Location = new System.Drawing.Point(52, 56);
            this.numericUpDown_crf.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.numericUpDown_crf.Name = "numericUpDown_crf";
            this.numericUpDown_crf.Size = new System.Drawing.Size(121, 19);
            this.numericUpDown_crf.TabIndex = 5;
            this.numericUpDown_crf.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numericUpDown_crf.ValueChanged += new System.EventHandler(this.numericUpDown_crf_ValueChanged);
            // 
            // button_encode_video
            // 
            this.button_encode_video.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_encode_video.BackColor = System.Drawing.Color.Red;
            this.button_encode_video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_encode_video.ForeColor = System.Drawing.Color.White;
            this.button_encode_video.Location = new System.Drawing.Point(456, 8);
            this.button_encode_video.Name = "button_encode_video";
            this.button_encode_video.Size = new System.Drawing.Size(105, 23);
            this.button_encode_video.TabIndex = 5;
            this.button_encode_video.Text = "Encode Video";
            this.button_encode_video.UseVisualStyleBackColor = false;
            this.button_encode_video.Click += new System.EventHandler(this.button_encode_video_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.button_encode_video);
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 39);
            this.panel1.TabIndex = 6;
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractAndConcatAllSDCardVideosToolStripMenuItem});
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.utilityToolStripMenuItem.Text = "Utility";
            // 
            // extractAndConcatAllSDCardVideosToolStripMenuItem
            // 
            this.extractAndConcatAllSDCardVideosToolStripMenuItem.Name = "extractAndConcatAllSDCardVideosToolStripMenuItem";
            this.extractAndConcatAllSDCardVideosToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.extractAndConcatAllSDCardVideosToolStripMenuItem.Text = "Extract and Concat all SD card videos";
            // 
            // aboutCN4K60SToolStripMenuItem
            // 
            this.aboutCN4K60SToolStripMenuItem.Name = "aboutCN4K60SToolStripMenuItem";
            this.aboutCN4K60SToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutCN4K60SToolStripMenuItem.Text = "About CN_4K60S+";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 482);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CN_4K60S+";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtlv_filelist)).EndInit();
            this.tabControl_main.ResumeLayout(false);
            this.tabPage_overview.ResumeLayout(false);
            this.tabPage_overview.PerformLayout();
            this.tabPage_video_summary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dlv_inner_detail)).EndInit();
            this.tabPage_encoding_settings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_format.ResumeLayout(false);
            this.tabPage_video_advanced.ResumeLayout(false);
            this.tabPage_video_advanced.PerformLayout();
            this.tabPage_metadata.ResumeLayout(false);
            this.tabPage_metadata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_crf)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage_overview;
        private System.Windows.Forms.TabPage tabPage_encoding_settings;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button bttn_drive_refresh;
        private System.Windows.Forms.ComboBox comboBox_drives;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.DataTreeListView dtlv_filelist;
        private BrightIdeasSoftware.OLVColumn olvColumn_name;
        private BrightIdeasSoftware.OLVColumn olvColumn_size;
        private System.Windows.Forms.TextBox textBox_filepath;
        private System.Windows.Forms.TabPage tabPage_video_summary;
        private BrightIdeasSoftware.DataListView dlv_inner_detail;
        private BrightIdeasSoftware.OLVColumn olvColumn_inner_name;
        private BrightIdeasSoftware.OLVColumn olvColumn_inner_duration;
        private BrightIdeasSoftware.OLVColumn olvColumn_inner_vcodec;
        private BrightIdeasSoftware.OLVColumn olvColumn_inner_acodec;
        private BrightIdeasSoftware.OLVColumn olvColumn_inner_size;
        private BrightIdeasSoftware.OLVColumn olvColumn_inner_res;
        private System.Windows.Forms.Label label_total_size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_segment_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_acodec;
        private System.Windows.Forms.Label label_vcodec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_duration;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_colour_space;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_subsampling;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_bitdepth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_sample_rate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_channels;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_audio_bitrate;
        private System.Windows.Forms.Label label_fps;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_resolution;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_format;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton_audio_wav_separate;
        private System.Windows.Forms.RadioButton radioButton_audio_flac;
        private System.Windows.Forms.RadioButton radioButton_audio_copy;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton_video_x264;
        private System.Windows.Forms.RadioButton radioButton_video_x265;
        private System.Windows.Forms.RadioButton radioButton_video_copy;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton_avi;
        private System.Windows.Forms.RadioButton radioButton_mp4;
        private System.Windows.Forms.RadioButton radioButton_mkv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_format;
        private System.Windows.Forms.TabPage tabPage_video_advanced;
        private System.Windows.Forms.TabPage tabPage_metadata;
        private System.Windows.Forms.TextBox textBox_vid_title;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown numericUpDown_crf;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBox_preset;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label_video_codec;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_encode_video;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractAndConcatAllSDCardVideosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCN4K60SToolStripMenuItem;
    }
}

