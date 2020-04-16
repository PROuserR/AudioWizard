namespace AudioWizard
{
    partial class Form1
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
        /// 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textbox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioFromURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mergeMp3FilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToBLoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loopAudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.effectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toMonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftVolumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightVolumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signalMixerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.makeAWaveFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metaDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLyricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCoverArtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.editAudioInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideLyricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coverArtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showURLTextboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPlayBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Stop_button = new System.Windows.Forms.Button();
            this.URL_label = new System.Windows.Forms.Label();
            this.currentTime_label = new System.Windows.Forms.Label();
            this.ForwardTrack_button = new System.Windows.Forms.Button();
            this.backTrack_button = new System.Windows.Forms.Button();
            this.Play_button = new System.Windows.Forms.Button();
            this.coverArt = new System.Windows.Forms.PictureBox();
            this.Lyrics_richtextbox = new System.Windows.Forms.RichTextBox();
            this.positionTrackBar = new System.Windows.Forms.TrackBar();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.volumeSlider = new NAudio.Gui.VolumeSlider();
            this.soundVisualizer = new System.Windows.Forms.Timer(this.components);
            this.Record_button = new System.Windows.Forms.Button();
            this.playBox = new System.Windows.Forms.ListBox();
            this.downloadYoutubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox.ForeColor = System.Drawing.Color.Blue;
            this.textbox.Location = new System.Drawing.Point(56, 29);
            this.textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(509, 21);
            this.textbox.TabIndex = 0;
            this.textbox.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(572, 25);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.audioFromURLToolStripMenuItem,
            this.toolStripSeparator2,
            this.mergeMp3FilesToolStripMenuItem,
            this.aToBLoopToolStripMenuItem,
            this.loopAudioToolStripMenuItem,
            this.toolStripSeparator4,
            this.effectsToolStripMenuItem,
            this.toMonoToolStripMenuItem,
            this.toolStripSeparator5,
            this.convertToolStripMenuItem,
            this.downloadYoutubeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(58, 19);
            this.fileToolStripMenuItem.Text = "Media..";
            // 
            // audioFromURLToolStripMenuItem
            // 
            this.audioFromURLToolStripMenuItem.Name = "audioFromURLToolStripMenuItem";
            this.audioFromURLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.audioFromURLToolStripMenuItem.Text = "Audio from URL";
            this.audioFromURLToolStripMenuItem.Click += new System.EventHandler(this.audioFromURLToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // mergeMp3FilesToolStripMenuItem
            // 
            this.mergeMp3FilesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mergeMp3FilesToolStripMenuItem.Name = "mergeMp3FilesToolStripMenuItem";
            this.mergeMp3FilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mergeMp3FilesToolStripMenuItem.Text = "Merge Mp3 files";
            this.mergeMp3FilesToolStripMenuItem.Click += new System.EventHandler(this.mergeMp3FilesToolStripMenuItem_Click);
            // 
            // aToBLoopToolStripMenuItem
            // 
            this.aToBLoopToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aToBLoopToolStripMenuItem.Name = "aToBLoopToolStripMenuItem";
            this.aToBLoopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aToBLoopToolStripMenuItem.Text = "A to B loop";
            this.aToBLoopToolStripMenuItem.Click += new System.EventHandler(this.aToBLoopToolStripMenuItem_Click);
            // 
            // loopAudioToolStripMenuItem
            // 
            this.loopAudioToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loopAudioToolStripMenuItem.Name = "loopAudioToolStripMenuItem";
            this.loopAudioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loopAudioToolStripMenuItem.Text = "Looped audio";
            this.loopAudioToolStripMenuItem.Click += new System.EventHandler(this.loopAudioToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // effectsToolStripMenuItem
            // 
            this.effectsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.effectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.effectsToolStripMenuItem.Name = "effectsToolStripMenuItem";
            this.effectsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.effectsToolStripMenuItem.Text = "Effects";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(90, 22);
            this.toolStripMenuItem2.Text = "++";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(90, 22);
            this.toolStripMenuItem3.Text = "==";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(90, 22);
            this.toolStripMenuItem4.Text = "--";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toMonoToolStripMenuItem
            // 
            this.toMonoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toMonoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftVolumeToolStripMenuItem,
            this.rightVolumeToolStripMenuItem});
            this.toMonoToolStripMenuItem.Name = "toMonoToolStripMenuItem";
            this.toMonoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toMonoToolStripMenuItem.Text = "Mono";
            // 
            // leftVolumeToolStripMenuItem
            // 
            this.leftVolumeToolStripMenuItem.Name = "leftVolumeToolStripMenuItem";
            this.leftVolumeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.leftVolumeToolStripMenuItem.Text = "Left volume";
            this.leftVolumeToolStripMenuItem.Click += new System.EventHandler(this.leftVolumeToolStripMenuItem_Click);
            // 
            // rightVolumeToolStripMenuItem
            // 
            this.rightVolumeToolStripMenuItem.Name = "rightVolumeToolStripMenuItem";
            this.rightVolumeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.rightVolumeToolStripMenuItem.Text = "Right volume";
            this.rightVolumeToolStripMenuItem.Click += new System.EventHandler(this.rightVolumeToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.convertToolStripMenuItem.Text = "Convert";
            this.convertToolStripMenuItem.Click += new System.EventHandler(this.convertToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signalMixerToolStripMenuItem,
            this.toolStripSeparator1,
            this.makeAWaveFormToolStripMenuItem,
            this.metaDataToolStripMenuItem,
            this.saveLyricsToolStripMenuItem,
            this.saveCoverArtToolStripMenuItem,
            this.toolStripSeparator6,
            this.editAudioInfoToolStripMenuItem,
            this.audioInfoToolStripMenuItem,
            this.toolStripSeparator7,
            this.refreshToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.helpToolStripMenuItem.Text = "Tools..";
            // 
            // signalMixerToolStripMenuItem
            // 
            this.signalMixerToolStripMenuItem.Name = "signalMixerToolStripMenuItem";
            this.signalMixerToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.signalMixerToolStripMenuItem.Text = "Signal mixer";
            this.signalMixerToolStripMenuItem.Click += new System.EventHandler(this.signalMixerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // makeAWaveFormToolStripMenuItem
            // 
            this.makeAWaveFormToolStripMenuItem.Name = "makeAWaveFormToolStripMenuItem";
            this.makeAWaveFormToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.makeAWaveFormToolStripMenuItem.Text = "Make a wave form";
            this.makeAWaveFormToolStripMenuItem.Click += new System.EventHandler(this.makeAWaveFormToolStripMenuItem_Click);
            // 
            // metaDataToolStripMenuItem
            // 
            this.metaDataToolStripMenuItem.Name = "metaDataToolStripMenuItem";
            this.metaDataToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.metaDataToolStripMenuItem.Text = "Get lyrics";
            this.metaDataToolStripMenuItem.Click += new System.EventHandler(this.metaDataToolStripMenuItem_Click);
            // 
            // saveLyricsToolStripMenuItem
            // 
            this.saveLyricsToolStripMenuItem.Name = "saveLyricsToolStripMenuItem";
            this.saveLyricsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveLyricsToolStripMenuItem.Text = "Save Lyrics";
            this.saveLyricsToolStripMenuItem.Click += new System.EventHandler(this.saveLyricsToolStripMenuItem_Click);
            // 
            // saveCoverArtToolStripMenuItem
            // 
            this.saveCoverArtToolStripMenuItem.Name = "saveCoverArtToolStripMenuItem";
            this.saveCoverArtToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveCoverArtToolStripMenuItem.Text = "Save cover art";
            this.saveCoverArtToolStripMenuItem.Click += new System.EventHandler(this.saveCoverArtToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(168, 6);
            // 
            // editAudioInfoToolStripMenuItem
            // 
            this.editAudioInfoToolStripMenuItem.Name = "editAudioInfoToolStripMenuItem";
            this.editAudioInfoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.editAudioInfoToolStripMenuItem.Text = "Edit audio info";
            this.editAudioInfoToolStripMenuItem.Click += new System.EventHandler(this.editAudioInfoToolStripMenuItem_Click);
            // 
            // audioInfoToolStripMenuItem
            // 
            this.audioInfoToolStripMenuItem.Name = "audioInfoToolStripMenuItem";
            this.audioInfoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.audioInfoToolStripMenuItem.Text = "Audio info";
            this.audioInfoToolStripMenuItem.Click += new System.EventHandler(this.audioInfoToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(168, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.foreColorToolStripMenuItem,
            this.hideLyricsToolStripMenuItem,
            this.coverArtToolStripMenuItem,
            this.showURLTextboxToolStripMenuItem,
            this.showPlayBoxToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.viewToolStripMenuItem.Text = "View..";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // foreColorToolStripMenuItem
            // 
            this.foreColorToolStripMenuItem.Name = "foreColorToolStripMenuItem";
            this.foreColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.foreColorToolStripMenuItem.Text = "Font color";
            this.foreColorToolStripMenuItem.Click += new System.EventHandler(this.foreColorToolStripMenuItem_Click);
            // 
            // hideLyricsToolStripMenuItem
            // 
            this.hideLyricsToolStripMenuItem.Name = "hideLyricsToolStripMenuItem";
            this.hideLyricsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hideLyricsToolStripMenuItem.Text = "Show lyrics";
            this.hideLyricsToolStripMenuItem.Click += new System.EventHandler(this.hideLyricsToolStripMenuItem_Click);
            // 
            // coverArtToolStripMenuItem
            // 
            this.coverArtToolStripMenuItem.Name = "coverArtToolStripMenuItem";
            this.coverArtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coverArtToolStripMenuItem.Text = "Show cover art";
            this.coverArtToolStripMenuItem.Click += new System.EventHandler(this.coverArtToolStripMenuItem_Click);
            // 
            // showURLTextboxToolStripMenuItem
            // 
            this.showURLTextboxToolStripMenuItem.Name = "showURLTextboxToolStripMenuItem";
            this.showURLTextboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showURLTextboxToolStripMenuItem.Text = "Show URL textbox";
            this.showURLTextboxToolStripMenuItem.Click += new System.EventHandler(this.showURLTextboxToolStripMenuItem_Click);
            // 
            // showPlayBoxToolStripMenuItem
            // 
            this.showPlayBoxToolStripMenuItem.Name = "showPlayBoxToolStripMenuItem";
            this.showPlayBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showPlayBoxToolStripMenuItem.Text = "Show playBox";
            this.showPlayBoxToolStripMenuItem.Click += new System.EventHandler(this.showPlayBoxToolStripMenuItem_Click);
            // 
            // Stop_button
            // 
            this.Stop_button.BackColor = System.Drawing.Color.Yellow;
            this.Stop_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop_button.FlatAppearance.BorderSize = 0;
            this.Stop_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop_button.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_button.ForeColor = System.Drawing.Color.Blue;
            this.Stop_button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Stop_button.ImageIndex = 9;
            this.Stop_button.Location = new System.Drawing.Point(152, 331);
            this.Stop_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(46, 41);
            this.Stop_button.TabIndex = 6;
            this.Stop_button.Text = "■";
            this.Stop_button.UseVisualStyleBackColor = false;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // URL_label
            // 
            this.URL_label.AutoSize = true;
            this.URL_label.Location = new System.Drawing.Point(14, 33);
            this.URL_label.Name = "URL_label";
            this.URL_label.Size = new System.Drawing.Size(32, 14);
            this.URL_label.TabIndex = 9;
            this.URL_label.Text = "URL:";
            this.URL_label.Visible = false;
            // 
            // currentTime_label
            // 
            this.currentTime_label.AutoSize = true;
            this.currentTime_label.Location = new System.Drawing.Point(10, 289);
            this.currentTime_label.Name = "currentTime_label";
            this.currentTime_label.Size = new System.Drawing.Size(57, 14);
            this.currentTime_label.TabIndex = 14;
            this.currentTime_label.Text = "00:00:00";
            // 
            // ForwardTrack_button
            // 
            this.ForwardTrack_button.BackColor = System.Drawing.Color.Yellow;
            this.ForwardTrack_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForwardTrack_button.FlatAppearance.BorderSize = 0;
            this.ForwardTrack_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ForwardTrack_button.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForwardTrack_button.ForeColor = System.Drawing.Color.Blue;
            this.ForwardTrack_button.ImageIndex = 4;
            this.ForwardTrack_button.Location = new System.Drawing.Point(307, 331);
            this.ForwardTrack_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ForwardTrack_button.Name = "ForwardTrack_button";
            this.ForwardTrack_button.Size = new System.Drawing.Size(46, 41);
            this.ForwardTrack_button.TabIndex = 19;
            this.ForwardTrack_button.Text = ">>|";
            this.ForwardTrack_button.UseVisualStyleBackColor = false;
            this.ForwardTrack_button.Click += new System.EventHandler(this.ForwardTrack_button_Click);
            // 
            // backTrack_button
            // 
            this.backTrack_button.BackColor = System.Drawing.Color.Yellow;
            this.backTrack_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backTrack_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backTrack_button.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backTrack_button.ForeColor = System.Drawing.Color.Blue;
            this.backTrack_button.ImageIndex = 2;
            this.backTrack_button.Location = new System.Drawing.Point(203, 331);
            this.backTrack_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backTrack_button.Name = "backTrack_button";
            this.backTrack_button.Size = new System.Drawing.Size(46, 41);
            this.backTrack_button.TabIndex = 18;
            this.backTrack_button.Text = "|<<";
            this.backTrack_button.UseVisualStyleBackColor = false;
            this.backTrack_button.Click += new System.EventHandler(this.backTrack_button_Click);
            // 
            // Play_button
            // 
            this.Play_button.BackColor = System.Drawing.Color.Yellow;
            this.Play_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play_button.FlatAppearance.BorderSize = 0;
            this.Play_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Play_button.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_button.ForeColor = System.Drawing.Color.Blue;
            this.Play_button.Location = new System.Drawing.Point(255, 331);
            this.Play_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(46, 41);
            this.Play_button.TabIndex = 4;
            this.Play_button.Text = "►";
            this.Play_button.UseVisualStyleBackColor = false;
            this.Play_button.Click += new System.EventHandler(this.Play_button_Click);
            // 
            // coverArt
            // 
            this.coverArt.Location = new System.Drawing.Point(168, 58);
            this.coverArt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.coverArt.Name = "coverArt";
            this.coverArt.Size = new System.Drawing.Size(214, 217);
            this.coverArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverArt.TabIndex = 24;
            this.coverArt.TabStop = false;
            // 
            // Lyrics_richtextbox
            // 
            this.Lyrics_richtextbox.ForeColor = System.Drawing.Color.Blue;
            this.Lyrics_richtextbox.Location = new System.Drawing.Point(56, 58);
            this.Lyrics_richtextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lyrics_richtextbox.Name = "Lyrics_richtextbox";
            this.Lyrics_richtextbox.Size = new System.Drawing.Size(243, 219);
            this.Lyrics_richtextbox.TabIndex = 25;
            this.Lyrics_richtextbox.Text = "";
            this.Lyrics_richtextbox.Visible = false;
            // 
            // positionTrackBar
            // 
            this.positionTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.positionTrackBar.Location = new System.Drawing.Point(74, 285);
            this.positionTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.positionTrackBar.Name = "positionTrackBar";
            this.positionTrackBar.Size = new System.Drawing.Size(408, 45);
            this.positionTrackBar.TabIndex = 26;
            this.positionTrackBar.Scroll += new System.EventHandler(this.positionTrackBar_Scroll);
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Location = new System.Drawing.Point(488, 289);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(57, 14);
            this.totalTimeLabel.TabIndex = 27;
            this.totalTimeLabel.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 14);
            this.label1.TabIndex = 28;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "+";
            // 
            // volumeSlider
            // 
            this.volumeSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeSlider.Location = new System.Drawing.Point(451, 347);
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(96, 16);
            this.volumeSlider.TabIndex = 32;
            this.volumeSlider.VolumeChanged += new System.EventHandler(this.volumeSlider_VolumeChanged);
            // 
            // Record_button
            // 
            this.Record_button.BackColor = System.Drawing.Color.Yellow;
            this.Record_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Record_button.FlatAppearance.BorderSize = 0;
            this.Record_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Record_button.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Record_button.ForeColor = System.Drawing.Color.Red;
            this.Record_button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Record_button.ImageIndex = 9;
            this.Record_button.Location = new System.Drawing.Point(359, 331);
            this.Record_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Record_button.Name = "Record_button";
            this.Record_button.Size = new System.Drawing.Size(46, 41);
            this.Record_button.TabIndex = 41;
            this.Record_button.Text = "●";
            this.Record_button.UseVisualStyleBackColor = false;
            this.Record_button.Click += new System.EventHandler(this.Record_button_Click);
            // 
            // playBox
            // 
            this.playBox.FormattingEnabled = true;
            this.playBox.ItemHeight = 14;
            this.playBox.Location = new System.Drawing.Point(13, 381);
            this.playBox.Name = "playBox";
            this.playBox.Size = new System.Drawing.Size(547, 200);
            this.playBox.TabIndex = 43;
            this.playBox.Click += new System.EventHandler(this.playBox_Click);
            // 
            // downloadYoutubeToolStripMenuItem
            // 
            this.downloadYoutubeToolStripMenuItem.Name = "downloadYoutubeToolStripMenuItem";
            this.downloadYoutubeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.downloadYoutubeToolStripMenuItem.Text = "Download from youtube";
            this.downloadYoutubeToolStripMenuItem.Click += new System.EventHandler(this.downloadYoutubeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(572, 378);
            this.Controls.Add(this.playBox);
            this.Controls.Add(this.Record_button);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalTimeLabel);
            this.Controls.Add(this.positionTrackBar);
            this.Controls.Add(this.Lyrics_richtextbox);
            this.Controls.Add(this.coverArt);
            this.Controls.Add(this.ForwardTrack_button);
            this.Controls.Add(this.backTrack_button);
            this.Controls.Add(this.currentTime_label);
            this.Controls.Add(this.URL_label);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.Play_button);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AudioWizard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.Label URL_label;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.Label currentTime_label;
        private System.Windows.Forms.Button ForwardTrack_button;
        private System.Windows.Forms.Button backTrack_button;
        private System.Windows.Forms.Button Play_button;
        private System.Windows.Forms.ToolStripMenuItem signalMixerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioFromURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metaDataToolStripMenuItem;
        private System.Windows.Forms.PictureBox coverArt;
        private System.Windows.Forms.ToolStripMenuItem makeAWaveFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCoverArtToolStripMenuItem;
        private System.Windows.Forms.RichTextBox Lyrics_richtextbox;
        private System.Windows.Forms.ToolStripMenuItem foreColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeMp3FilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveLyricsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideLyricsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TrackBar positionTrackBar;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.ToolStripMenuItem effectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem toMonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftVolumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightVolumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coverArtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loopAudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem audioInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showURLTextboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAudioInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToBLoopToolStripMenuItem;
        private NAudio.Gui.VolumeSlider volumeSlider;
        private System.Windows.Forms.Timer soundVisualizer;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.Button Record_button;
        private System.Windows.Forms.ListBox playBox;
        private System.Windows.Forms.ToolStripMenuItem showPlayBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadYoutubeToolStripMenuItem;
    }
}

