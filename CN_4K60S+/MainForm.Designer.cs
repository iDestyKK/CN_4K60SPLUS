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
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
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
            this.splitContainer1.Size = new System.Drawing.Size(844, 417);
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
            this.splitContainer2.Size = new System.Drawing.Size(265, 417);
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
            this.dtlv_filelist.Size = new System.Drawing.Size(265, 388);
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
            this.tabControl_main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(575, 417);
            this.tabControl_main.TabIndex = 0;
            // 
            // tabPage_overview
            // 
            this.tabPage_overview.Controls.Add(this.textBox_filepath);
            this.tabPage_overview.Location = new System.Drawing.Point(4, 22);
            this.tabPage_overview.Name = "tabPage_overview";
            this.tabPage_overview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_overview.Size = new System.Drawing.Size(523, 391);
            this.tabPage_overview.TabIndex = 0;
            this.tabPage_overview.Text = "Overview";
            this.tabPage_overview.UseVisualStyleBackColor = true;
            // 
            // textBox_filepath
            // 
            this.textBox_filepath.Location = new System.Drawing.Point(6, 7);
            this.textBox_filepath.Name = "textBox_filepath";
            this.textBox_filepath.Size = new System.Drawing.Size(509, 19);
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
            this.olvColumn_inner_duration.AspectName = "duration";
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
            this.tabPage_encoding_settings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_encoding_settings.Name = "tabPage_encoding_settings";
            this.tabPage_encoding_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_encoding_settings.Size = new System.Drawing.Size(523, 391);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 441);
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
    }
}

