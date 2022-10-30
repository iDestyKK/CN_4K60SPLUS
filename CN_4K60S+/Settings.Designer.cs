namespace CN_4K60S_
{
    partial class Settings
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
            this.tab_settings = new System.Windows.Forms.TabControl();
            this.tabPage_paths = new System.Windows.Forms.TabPage();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_path_ffmpeg = new System.Windows.Forms.TextBox();
            this.bttn_locate_ffmpeg = new System.Windows.Forms.Button();
            this.openFileDialog_ffmpeg = new System.Windows.Forms.OpenFileDialog();
            this.tab_settings.SuspendLayout();
            this.tabPage_paths.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.tabPage_paths);
            this.tab_settings.Location = new System.Drawing.Point(12, 12);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.SelectedIndex = 0;
            this.tab_settings.Size = new System.Drawing.Size(420, 488);
            this.tab_settings.TabIndex = 0;
            // 
            // tabPage_paths
            // 
            this.tabPage_paths.Controls.Add(this.bttn_locate_ffmpeg);
            this.tabPage_paths.Controls.Add(this.textBox_path_ffmpeg);
            this.tabPage_paths.Controls.Add(this.label1);
            this.tabPage_paths.Location = new System.Drawing.Point(4, 22);
            this.tabPage_paths.Name = "tabPage_paths";
            this.tabPage_paths.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_paths.Size = new System.Drawing.Size(412, 462);
            this.tabPage_paths.TabIndex = 0;
            this.tabPage_paths.Text = "Paths";
            this.tabPage_paths.UseVisualStyleBackColor = true;
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(353, 506);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 1;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(272, 506);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(191, 506);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 3;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "FFmpeg Path";
            // 
            // textBox_path_ffmpeg
            // 
            this.textBox_path_ffmpeg.Location = new System.Drawing.Point(85, 11);
            this.textBox_path_ffmpeg.Name = "textBox_path_ffmpeg";
            this.textBox_path_ffmpeg.Size = new System.Drawing.Size(240, 19);
            this.textBox_path_ffmpeg.TabIndex = 1;
            // 
            // bttn_locate_ffmpeg
            // 
            this.bttn_locate_ffmpeg.Location = new System.Drawing.Point(331, 9);
            this.bttn_locate_ffmpeg.Name = "bttn_locate_ffmpeg";
            this.bttn_locate_ffmpeg.Size = new System.Drawing.Size(75, 23);
            this.bttn_locate_ffmpeg.TabIndex = 2;
            this.bttn_locate_ffmpeg.Text = "Locate";
            this.bttn_locate_ffmpeg.UseVisualStyleBackColor = true;
            this.bttn_locate_ffmpeg.Click += new System.EventHandler(this.bttn_locate_ffmpeg_Click);
            // 
            // openFileDialog_ffmpeg
            // 
            this.openFileDialog_ffmpeg.Filter = "Executable Files|*.exe|All Files|*.*";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 541);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.tab_settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Text = "Settings";
            this.tab_settings.ResumeLayout(false);
            this.tabPage_paths.ResumeLayout(false);
            this.tabPage_paths.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_settings;
        private System.Windows.Forms.TabPage tabPage_paths;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button bttn_locate_ffmpeg;
        private System.Windows.Forms.TextBox textBox_path_ffmpeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ffmpeg;
    }
}