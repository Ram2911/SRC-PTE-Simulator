namespace Timer_Mic_PTE
{
    partial class frmPTEMock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPTEMock));
            this.tabSpeaking = new System.Windows.Forms.TabControl();
            this.tabDescribeImage = new System.Windows.Forms.TabPage();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.chkDIPlayMode = new System.Windows.Forms.CheckBox();
            this.chkPlayMode = new System.Windows.Forms.CheckBox();
            this.groupDIAudio = new System.Windows.Forms.GroupBox();
            this.cmbDIRecordings = new System.Windows.Forms.ComboBox();
            this.buttonDIPause = new System.Windows.Forms.Button();
            this.buttonDIPlay = new System.Windows.Forms.Button();
            this.groupAudio = new System.Windows.Forms.GroupBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.cmbDIPlayRecord = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.butNextImage = new System.Windows.Forms.Button();
            this.progressDIRecord = new System.Windows.Forms.ProgressBar();
            this.progressRecord = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRead = new System.Windows.Forms.Label();
            this.textRecordTime = new System.Windows.Forms.TextBox();
            this.progressDIRead = new System.Windows.Forms.ProgressBar();
            this.progressRead = new System.Windows.Forms.ProgressBar();
            this.textReadTime = new System.Windows.Forms.TextBox();
            this.imageHolder = new System.Windows.Forms.PictureBox();
            this.tabRetellLecture = new System.Windows.Forms.TabPage();
            this.txtLectureRecordStopTime = new System.Windows.Forms.TextBox();
            this.txtLectureRecordStartTime = new System.Windows.Forms.TextBox();
            this.btnBrowseLecture = new System.Windows.Forms.Button();
            this.txtLecturePath = new System.Windows.Forms.TextBox();
            this.lblLecture = new System.Windows.Forms.Label();
            this.progressLecture = new System.Windows.Forms.ProgressBar();
            this.chkPlayLecture = new System.Windows.Forms.CheckBox();
            this.groupLecture = new System.Windows.Forms.GroupBox();
            this.btnStopLecture = new System.Windows.Forms.Button();
            this.btnPlayLecture = new System.Windows.Forms.Button();
            this.cmbLectureList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressLectureStop = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.progressLectureStart = new System.Windows.Forms.ProgressBar();
            this.imageLecture = new System.Windows.Forms.PictureBox();
            this.btnLoadLecture = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.timerRead = new System.Windows.Forms.Timer(this.components);
            this.timerRecord = new System.Windows.Forms.Timer(this.components);
            this.timerTextUpdate = new System.Windows.Forms.Timer(this.components);
            this.timerLecture = new System.Windows.Forms.Timer(this.components);
            this.timerReadLecture = new System.Windows.Forms.Timer(this.components);
            this.timerRecordLecture = new System.Windows.Forms.Timer(this.components);
            this.timerTextUpdateLecture = new System.Windows.Forms.Timer(this.components);
            this.tabSpeaking.SuspendLayout();
            this.tabDescribeImage.SuspendLayout();
            this.groupDIAudio.SuspendLayout();
            this.groupAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageHolder)).BeginInit();
            this.tabRetellLecture.SuspendLayout();
            this.groupLecture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLecture)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSpeaking
            // 
            this.tabSpeaking.Controls.Add(this.tabDescribeImage);
            this.tabSpeaking.Controls.Add(this.tabRetellLecture);
            this.tabSpeaking.Location = new System.Drawing.Point(1, -2);
            this.tabSpeaking.Name = "tabSpeaking";
            this.tabSpeaking.SelectedIndex = 0;
            this.tabSpeaking.Size = new System.Drawing.Size(942, 653);
            this.tabSpeaking.TabIndex = 0;
            this.tabSpeaking.TabIndexChanged += new System.EventHandler(this.tabSpeaking_TabIndexChanged);
            // 
            // tabDescribeImage
            // 
            this.tabDescribeImage.Controls.Add(this.txtPath);
            this.tabDescribeImage.Controls.Add(this.buttonBrowse);
            this.tabDescribeImage.Controls.Add(this.chkDIPlayMode);
            this.tabDescribeImage.Controls.Add(this.chkPlayMode);
            this.tabDescribeImage.Controls.Add(this.groupDIAudio);
            this.tabDescribeImage.Controls.Add(this.groupAudio);
            this.tabDescribeImage.Controls.Add(this.label2);
            this.tabDescribeImage.Controls.Add(this.lblRecord);
            this.tabDescribeImage.Controls.Add(this.butNextImage);
            this.tabDescribeImage.Controls.Add(this.progressDIRecord);
            this.tabDescribeImage.Controls.Add(this.progressRecord);
            this.tabDescribeImage.Controls.Add(this.label1);
            this.tabDescribeImage.Controls.Add(this.lblRead);
            this.tabDescribeImage.Controls.Add(this.textRecordTime);
            this.tabDescribeImage.Controls.Add(this.progressDIRead);
            this.tabDescribeImage.Controls.Add(this.progressRead);
            this.tabDescribeImage.Controls.Add(this.textReadTime);
            this.tabDescribeImage.Controls.Add(this.imageHolder);
            this.tabDescribeImage.Location = new System.Drawing.Point(4, 22);
            this.tabDescribeImage.Name = "tabDescribeImage";
            this.tabDescribeImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabDescribeImage.Size = new System.Drawing.Size(934, 627);
            this.tabDescribeImage.TabIndex = 0;
            this.tabDescribeImage.Text = "Describe Image";
            this.tabDescribeImage.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPath.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(121, 8);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(514, 26);
            this.txtPath.TabIndex = 2;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(12, 8);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Set Path";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // chkDIPlayMode
            // 
            this.chkDIPlayMode.AutoSize = true;
            this.chkDIPlayMode.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDIPlayMode.Location = new System.Drawing.Point(743, 319);
            this.chkDIPlayMode.Name = "chkDIPlayMode";
            this.chkDIPlayMode.Size = new System.Drawing.Size(118, 26);
            this.chkDIPlayMode.TabIndex = 10;
            this.chkDIPlayMode.Text = "Play Mode";
            this.chkDIPlayMode.UseVisualStyleBackColor = true;
            this.chkDIPlayMode.CheckedChanged += new System.EventHandler(this.chkDIPlayMode_CheckedChanged);
            // 
            // chkPlayMode
            // 
            this.chkPlayMode.AutoSize = true;
            this.chkPlayMode.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPlayMode.Location = new System.Drawing.Point(743, 319);
            this.chkPlayMode.Name = "chkPlayMode";
            this.chkPlayMode.Size = new System.Drawing.Size(118, 26);
            this.chkPlayMode.TabIndex = 10;
            this.chkPlayMode.Text = "Play Mode";
            this.chkPlayMode.UseVisualStyleBackColor = true;
            this.chkPlayMode.CheckedChanged += new System.EventHandler(this.chkDIPlayMode_CheckedChanged);
            // 
            // groupDIAudio
            // 
            this.groupDIAudio.Controls.Add(this.cmbDIRecordings);
            this.groupDIAudio.Controls.Add(this.buttonDIPause);
            this.groupDIAudio.Controls.Add(this.buttonDIPlay);
            this.groupDIAudio.Location = new System.Drawing.Point(651, 366);
            this.groupDIAudio.Name = "groupDIAudio";
            this.groupDIAudio.Size = new System.Drawing.Size(277, 152);
            this.groupDIAudio.TabIndex = 9;
            this.groupDIAudio.TabStop = false;
            this.groupDIAudio.Text = "Play Recordings...";
            // 
            // cmbDIRecordings
            // 
            this.cmbDIRecordings.FormattingEnabled = true;
            this.cmbDIRecordings.Location = new System.Drawing.Point(9, 21);
            this.cmbDIRecordings.Name = "cmbDIRecordings";
            this.cmbDIRecordings.Size = new System.Drawing.Size(259, 21);
            this.cmbDIRecordings.TabIndex = 11;
            // 
            // buttonDIPause
            // 
            this.buttonDIPause.AutoSize = true;
            this.buttonDIPause.FlatAppearance.BorderSize = 0;
            this.buttonDIPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDIPause.Image = ((System.Drawing.Image)(resources.GetObject("buttonDIPause.Image")));
            this.buttonDIPause.Location = new System.Drawing.Point(140, 48);
            this.buttonDIPause.Name = "buttonDIPause";
            this.buttonDIPause.Size = new System.Drawing.Size(94, 95);
            this.buttonDIPause.TabIndex = 10;
            this.buttonDIPause.UseVisualStyleBackColor = true;
            this.buttonDIPause.Click += new System.EventHandler(this.buttonDIPause_Click);
            // 
            // buttonDIPlay
            // 
            this.buttonDIPlay.AutoSize = true;
            this.buttonDIPlay.FlatAppearance.BorderSize = 0;
            this.buttonDIPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDIPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonDIPlay.Image")));
            this.buttonDIPlay.Location = new System.Drawing.Point(47, 48);
            this.buttonDIPlay.Name = "buttonDIPlay";
            this.buttonDIPlay.Size = new System.Drawing.Size(94, 95);
            this.buttonDIPlay.TabIndex = 9;
            this.buttonDIPlay.UseVisualStyleBackColor = true;
            this.buttonDIPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // groupAudio
            // 
            this.groupAudio.Controls.Add(this.buttonPause);
            this.groupAudio.Controls.Add(this.buttonPlay);
            this.groupAudio.Controls.Add(this.cmbDIPlayRecord);
            this.groupAudio.Location = new System.Drawing.Point(651, 366);
            this.groupAudio.Name = "groupAudio";
            this.groupAudio.Size = new System.Drawing.Size(277, 152);
            this.groupAudio.TabIndex = 9;
            this.groupAudio.TabStop = false;
            this.groupAudio.Text = "Play Recordings...";
            // 
            // buttonPause
            // 
            this.buttonPause.AutoSize = true;
            this.buttonPause.FlatAppearance.BorderSize = 0;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Image = ((System.Drawing.Image)(resources.GetObject("buttonPause.Image")));
            this.buttonPause.Location = new System.Drawing.Point(140, 48);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(94, 95);
            this.buttonPause.TabIndex = 10;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonDIPause_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.AutoSize = true;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.Location = new System.Drawing.Point(47, 48);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(94, 95);
            this.buttonPlay.TabIndex = 9;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // cmbDIPlayRecord
            // 
            this.cmbDIPlayRecord.FormattingEnabled = true;
            this.cmbDIPlayRecord.Location = new System.Drawing.Point(9, 18);
            this.cmbDIPlayRecord.Name = "cmbDIPlayRecord";
            this.cmbDIPlayRecord.Size = new System.Drawing.Size(259, 21);
            this.cmbDIPlayRecord.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(647, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your voice recording will stop in...";
            // 
            // lblRecord
            // 
            this.lblRecord.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(647, 183);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(177, 48);
            this.lblRecord.TabIndex = 7;
            this.lblRecord.Text = "Your voice recording will stop in...";
            // 
            // butNextImage
            // 
            this.butNextImage.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNextImage.Location = new System.Drawing.Point(670, 533);
            this.butNextImage.Name = "butNextImage";
            this.butNextImage.Size = new System.Drawing.Size(237, 32);
            this.butNextImage.TabIndex = 5;
            this.butNextImage.Text = "Load Random Image";
            this.butNextImage.UseVisualStyleBackColor = true;
            this.butNextImage.Click += new System.EventHandler(this.butNextImage_Click);
            // 
            // progressDIRecord
            // 
            this.progressDIRecord.Location = new System.Drawing.Point(651, 249);
            this.progressDIRecord.Name = "progressDIRecord";
            this.progressDIRecord.Size = new System.Drawing.Size(277, 23);
            this.progressDIRecord.TabIndex = 6;
            // 
            // progressRecord
            // 
            this.progressRecord.Location = new System.Drawing.Point(651, 249);
            this.progressRecord.Name = "progressRecord";
            this.progressRecord.Size = new System.Drawing.Size(277, 23);
            this.progressRecord.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(653, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your voice recording will start in...";
            // 
            // lblRead
            // 
            this.lblRead.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRead.Location = new System.Drawing.Point(653, 37);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(177, 48);
            this.lblRead.TabIndex = 4;
            this.lblRead.Text = "Your voice recording will start in...";
            // 
            // textRecordTime
            // 
            this.textRecordTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textRecordTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRecordTime.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRecordTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textRecordTime.Location = new System.Drawing.Point(855, 183);
            this.textRecordTime.Name = "textRecordTime";
            this.textRecordTime.ReadOnly = true;
            this.textRecordTime.Size = new System.Drawing.Size(67, 42);
            this.textRecordTime.TabIndex = 5;
            // 
            // progressDIRead
            // 
            this.progressDIRead.Location = new System.Drawing.Point(651, 103);
            this.progressDIRead.Name = "progressDIRead";
            this.progressDIRead.Size = new System.Drawing.Size(277, 23);
            this.progressDIRead.TabIndex = 3;
            // 
            // progressRead
            // 
            this.progressRead.Location = new System.Drawing.Point(651, 103);
            this.progressRead.Name = "progressRead";
            this.progressRead.Size = new System.Drawing.Size(277, 23);
            this.progressRead.TabIndex = 3;
            // 
            // textReadTime
            // 
            this.textReadTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textReadTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textReadTime.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReadTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textReadTime.Location = new System.Drawing.Point(848, 37);
            this.textReadTime.Name = "textReadTime";
            this.textReadTime.ReadOnly = true;
            this.textReadTime.Size = new System.Drawing.Size(69, 42);
            this.textReadTime.TabIndex = 2;
            // 
            // imageHolder
            // 
            this.imageHolder.Location = new System.Drawing.Point(7, 59);
            this.imageHolder.Name = "imageHolder";
            this.imageHolder.Size = new System.Drawing.Size(638, 506);
            this.imageHolder.TabIndex = 1;
            this.imageHolder.TabStop = false;
            // 
            // tabRetellLecture
            // 
            this.tabRetellLecture.Controls.Add(this.txtLectureRecordStopTime);
            this.tabRetellLecture.Controls.Add(this.txtLectureRecordStartTime);
            this.tabRetellLecture.Controls.Add(this.btnBrowseLecture);
            this.tabRetellLecture.Controls.Add(this.txtLecturePath);
            this.tabRetellLecture.Controls.Add(this.lblLecture);
            this.tabRetellLecture.Controls.Add(this.progressLecture);
            this.tabRetellLecture.Controls.Add(this.chkPlayLecture);
            this.tabRetellLecture.Controls.Add(this.groupLecture);
            this.tabRetellLecture.Controls.Add(this.label3);
            this.tabRetellLecture.Controls.Add(this.progressLectureStop);
            this.tabRetellLecture.Controls.Add(this.label4);
            this.tabRetellLecture.Controls.Add(this.progressLectureStart);
            this.tabRetellLecture.Controls.Add(this.imageLecture);
            this.tabRetellLecture.Controls.Add(this.btnLoadLecture);
            this.tabRetellLecture.Location = new System.Drawing.Point(4, 22);
            this.tabRetellLecture.Name = "tabRetellLecture";
            this.tabRetellLecture.Padding = new System.Windows.Forms.Padding(3);
            this.tabRetellLecture.Size = new System.Drawing.Size(934, 627);
            this.tabRetellLecture.TabIndex = 1;
            this.tabRetellLecture.Text = "Retell Lecture";
            this.tabRetellLecture.UseVisualStyleBackColor = true;
            // 
            // txtLectureRecordStopTime
            // 
            this.txtLectureRecordStopTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLectureRecordStopTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLectureRecordStopTime.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLectureRecordStopTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLectureRecordStopTime.Location = new System.Drawing.Point(861, 184);
            this.txtLectureRecordStopTime.Name = "txtLectureRecordStopTime";
            this.txtLectureRecordStopTime.ReadOnly = true;
            this.txtLectureRecordStopTime.Size = new System.Drawing.Size(67, 42);
            this.txtLectureRecordStopTime.TabIndex = 24;
            // 
            // txtLectureRecordStartTime
            // 
            this.txtLectureRecordStartTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLectureRecordStartTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLectureRecordStartTime.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLectureRecordStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLectureRecordStartTime.Location = new System.Drawing.Point(859, 38);
            this.txtLectureRecordStartTime.Name = "txtLectureRecordStartTime";
            this.txtLectureRecordStartTime.ReadOnly = true;
            this.txtLectureRecordStartTime.Size = new System.Drawing.Size(69, 42);
            this.txtLectureRecordStartTime.TabIndex = 23;
            // 
            // btnBrowseLecture
            // 
            this.btnBrowseLecture.Location = new System.Drawing.Point(7, 22);
            this.btnBrowseLecture.Name = "btnBrowseLecture";
            this.btnBrowseLecture.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLecture.TabIndex = 22;
            this.btnBrowseLecture.Text = "Set Path";
            this.btnBrowseLecture.UseVisualStyleBackColor = true;
            this.btnBrowseLecture.Click += new System.EventHandler(this.btnBrowseLecture_Click);
            // 
            // txtLecturePath
            // 
            this.txtLecturePath.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtLecturePath.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLecturePath.Location = new System.Drawing.Point(99, 20);
            this.txtLecturePath.Name = "txtLecturePath";
            this.txtLecturePath.Size = new System.Drawing.Size(514, 26);
            this.txtLecturePath.TabIndex = 21;
            this.txtLecturePath.TextChanged += new System.EventHandler(this.txtLecturePath_TextChanged);
            // 
            // lblLecture
            // 
            this.lblLecture.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecture.Location = new System.Drawing.Point(3, 510);
            this.lblLecture.Name = "lblLecture";
            this.lblLecture.Size = new System.Drawing.Size(433, 32);
            this.lblLecture.TabIndex = 20;
            this.lblLecture.Text = "Lecture is in progress... Pay attention...";
            // 
            // progressLecture
            // 
            this.progressLecture.Location = new System.Drawing.Point(4, 551);
            this.progressLecture.Name = "progressLecture";
            this.progressLecture.Size = new System.Drawing.Size(571, 23);
            this.progressLecture.TabIndex = 19;
            // 
            // chkPlayLecture
            // 
            this.chkPlayLecture.AutoSize = true;
            this.chkPlayLecture.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPlayLecture.Location = new System.Drawing.Point(743, 320);
            this.chkPlayLecture.Name = "chkPlayLecture";
            this.chkPlayLecture.Size = new System.Drawing.Size(118, 26);
            this.chkPlayLecture.TabIndex = 18;
            this.chkPlayLecture.Text = "Play Mode";
            this.chkPlayLecture.UseVisualStyleBackColor = true;
            this.chkPlayLecture.CheckedChanged += new System.EventHandler(this.chkPlayLecture_CheckedChanged);
            // 
            // groupLecture
            // 
            this.groupLecture.Controls.Add(this.btnStopLecture);
            this.groupLecture.Controls.Add(this.btnPlayLecture);
            this.groupLecture.Controls.Add(this.cmbLectureList);
            this.groupLecture.Location = new System.Drawing.Point(651, 367);
            this.groupLecture.Name = "groupLecture";
            this.groupLecture.Size = new System.Drawing.Size(277, 152);
            this.groupLecture.TabIndex = 17;
            this.groupLecture.TabStop = false;
            this.groupLecture.Text = "Play Recordings...";
            // 
            // btnStopLecture
            // 
            this.btnStopLecture.AutoSize = true;
            this.btnStopLecture.FlatAppearance.BorderSize = 0;
            this.btnStopLecture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopLecture.Image = ((System.Drawing.Image)(resources.GetObject("btnStopLecture.Image")));
            this.btnStopLecture.Location = new System.Drawing.Point(140, 48);
            this.btnStopLecture.Name = "btnStopLecture";
            this.btnStopLecture.Size = new System.Drawing.Size(94, 95);
            this.btnStopLecture.TabIndex = 10;
            this.btnStopLecture.UseVisualStyleBackColor = true;
            this.btnStopLecture.Click += new System.EventHandler(this.btnStopLecture_Click);
            // 
            // btnPlayLecture
            // 
            this.btnPlayLecture.AutoSize = true;
            this.btnPlayLecture.FlatAppearance.BorderSize = 0;
            this.btnPlayLecture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayLecture.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayLecture.Image")));
            this.btnPlayLecture.Location = new System.Drawing.Point(47, 48);
            this.btnPlayLecture.Name = "btnPlayLecture";
            this.btnPlayLecture.Size = new System.Drawing.Size(94, 95);
            this.btnPlayLecture.TabIndex = 9;
            this.btnPlayLecture.UseVisualStyleBackColor = true;
            this.btnPlayLecture.Click += new System.EventHandler(this.btnPlayLecture_Click);
            // 
            // cmbLectureList
            // 
            this.cmbLectureList.FormattingEnabled = true;
            this.cmbLectureList.Location = new System.Drawing.Point(9, 18);
            this.cmbLectureList.Name = "cmbLectureList";
            this.cmbLectureList.Size = new System.Drawing.Size(259, 21);
            this.cmbLectureList.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(647, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 48);
            this.label3.TabIndex = 16;
            this.label3.Text = "Your voice recording will stop in...";
            // 
            // progressLectureStop
            // 
            this.progressLectureStop.Location = new System.Drawing.Point(651, 250);
            this.progressLectureStop.Name = "progressLectureStop";
            this.progressLectureStop.Size = new System.Drawing.Size(277, 23);
            this.progressLectureStop.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(653, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 48);
            this.label4.TabIndex = 13;
            this.label4.Text = "Your voice recording will start in...";
            // 
            // progressLectureStart
            // 
            this.progressLectureStart.Location = new System.Drawing.Point(651, 104);
            this.progressLectureStart.Name = "progressLectureStart";
            this.progressLectureStart.Size = new System.Drawing.Size(277, 23);
            this.progressLectureStart.TabIndex = 12;
            // 
            // imageLecture
            // 
            this.imageLecture.Location = new System.Drawing.Point(7, 73);
            this.imageLecture.Name = "imageLecture";
            this.imageLecture.Size = new System.Drawing.Size(568, 434);
            this.imageLecture.TabIndex = 11;
            this.imageLecture.TabStop = false;
            // 
            // btnLoadLecture
            // 
            this.btnLoadLecture.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadLecture.Location = new System.Drawing.Point(670, 534);
            this.btnLoadLecture.Name = "btnLoadLecture";
            this.btnLoadLecture.Size = new System.Drawing.Size(237, 32);
            this.btnLoadLecture.TabIndex = 14;
            this.btnLoadLecture.Text = "Load Random Lecture";
            this.btnLoadLecture.UseVisualStyleBackColor = true;
            this.btnLoadLecture.Click += new System.EventHandler(this.btnLoadLecture_Click);
            // 
            // timerRead
            // 
            this.timerRead.Interval = 25000;
            this.timerRead.Tick += new System.EventHandler(this.timerRead_Tick);
            // 
            // timerRecord
            // 
            this.timerRecord.Interval = 40000;
            this.timerRecord.Tick += new System.EventHandler(this.timerRecord_Tick);
            // 
            // timerTextUpdate
            // 
            this.timerTextUpdate.Interval = 1000;
            this.timerTextUpdate.Tick += new System.EventHandler(this.timerTextUpdate_Tick);
            // 
            // timerLecture
            // 
            this.timerLecture.Interval = 1000;
            this.timerLecture.Tick += new System.EventHandler(this.timerLecture_Tick);
            // 
            // timerReadLecture
            // 
            this.timerReadLecture.Interval = 10000;
            this.timerReadLecture.Tick += new System.EventHandler(this.timerReadLecture_Tick);
            // 
            // timerRecordLecture
            // 
            this.timerRecordLecture.Interval = 40000;
            this.timerRecordLecture.Tick += new System.EventHandler(this.timerRecordLecture_Tick);
            // 
            // timerTextUpdateLecture
            // 
            this.timerTextUpdateLecture.Interval = 1000;
            this.timerTextUpdateLecture.Tick += new System.EventHandler(this.timerTextUpdateLecture_Tick);
            // 
            // frmPTEMock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 651);
            this.Controls.Add(this.tabSpeaking);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPTEMock";
            this.Text = "PTE Speaking Module Simulator";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmPTEMock_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPTEMock_FormClosing);
            this.tabSpeaking.ResumeLayout(false);
            this.tabDescribeImage.ResumeLayout(false);
            this.tabDescribeImage.PerformLayout();
            this.groupDIAudio.ResumeLayout(false);
            this.groupDIAudio.PerformLayout();
            this.groupAudio.ResumeLayout(false);
            this.groupAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageHolder)).EndInit();
            this.tabRetellLecture.ResumeLayout(false);
            this.tabRetellLecture.PerformLayout();
            this.groupLecture.ResumeLayout(false);
            this.groupLecture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLecture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSpeaking;
        private System.Windows.Forms.TabPage tabDescribeImage;
        private System.Windows.Forms.TabPage tabRetellLecture;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.PictureBox imageHolder;
        private System.Windows.Forms.ProgressBar progressRead;
        private System.Windows.Forms.TextBox textReadTime;
        private System.Windows.Forms.Label lblRead;
        private System.Windows.Forms.Button butNextImage;
        private System.Windows.Forms.Timer timerRead;
        private System.Windows.Forms.Timer timerRecord;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.ProgressBar progressRecord;
        private System.Windows.Forms.TextBox textRecordTime;
        private System.Windows.Forms.CheckBox chkPlayMode;
        private System.Windows.Forms.GroupBox groupAudio;
        private System.Windows.Forms.ComboBox cmbDIPlayRecord;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Timer timerTextUpdate;
        private System.Windows.Forms.CheckBox chkDIPlayMode;
        private System.Windows.Forms.GroupBox groupDIAudio;
        private System.Windows.Forms.Button buttonDIPause;
        private System.Windows.Forms.Button buttonDIPlay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressDIRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressDIRead;
        private System.Windows.Forms.CheckBox chkPlayLecture;
        private System.Windows.Forms.GroupBox groupLecture;
        private System.Windows.Forms.Button btnStopLecture;
        private System.Windows.Forms.Button btnPlayLecture;
        private System.Windows.Forms.ComboBox cmbLectureList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressLectureStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressLectureStart;
        private System.Windows.Forms.PictureBox imageLecture;
        private System.Windows.Forms.Button btnLoadLecture;
        private System.Windows.Forms.Label lblLecture;
        private System.Windows.Forms.ProgressBar progressLecture;
        private System.Windows.Forms.Button btnBrowseLecture;
        private System.Windows.Forms.TextBox txtLecturePath;
        private System.Windows.Forms.TextBox txtLectureRecordStopTime;
        private System.Windows.Forms.TextBox txtLectureRecordStartTime;
        private System.Windows.Forms.Timer timerLecture;
        private System.Windows.Forms.Timer timerReadLecture;
        private System.Windows.Forms.Timer timerRecordLecture;
        private System.Windows.Forms.Timer timerTextUpdateLecture;
        private System.Windows.Forms.ComboBox cmbDIRecordings;
    }
}

