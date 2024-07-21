namespace GNS.Games.WackAMole
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moderateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playTimedGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halfMinuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneMinuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoMinutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unlimitedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLives = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerMole = new System.Windows.Forms.Timer(this.components);
            this.grpGardenArea = new System.Windows.Forms.GroupBox();
            this.btnMole9 = new System.Windows.Forms.Button();
            this.btnMole8 = new System.Windows.Forms.Button();
            this.btnMole7 = new System.Windows.Forms.Button();
            this.btnMole4 = new System.Windows.Forms.Button();
            this.btnMole5 = new System.Windows.Forms.Button();
            this.btnMole6 = new System.Windows.Forms.Button();
            this.btnMole3 = new System.Windows.Forms.Button();
            this.btnMole2 = new System.Windows.Forms.Button();
            this.btnMole1 = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timerElapsedTime = new System.Windows.Forms.Timer(this.components);
            this.mnuMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.grpGardenArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackgroundImage = global::GNS.Games.WackAMole.Properties.Resources.grass;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.endToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.highScoresToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(394, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyToolStripMenuItem,
            this.playTimedGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "&File ";
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginnerToolStripMenuItem,
            this.easyToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.moderateToolStripMenuItem,
            this.hardToolStripMenuItem,
            this.expertToolStripMenuItem,
            this.insaneToolStripMenuItem});
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.difficultyToolStripMenuItem.Text = "&Difficulty";
            // 
            // beginnerToolStripMenuItem
            // 
            this.beginnerToolStripMenuItem.CheckOnClick = true;
            this.beginnerToolStripMenuItem.Name = "beginnerToolStripMenuItem";
            this.beginnerToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.beginnerToolStripMenuItem.Tag = "";
            this.beginnerToolStripMenuItem.Text = "Beginner";
            this.beginnerToolStripMenuItem.Click += new System.EventHandler(this.SetDifficultyLevel);
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.CheckOnClick = true;
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.easyToolStripMenuItem.Tag = "1000";
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.SetDifficultyLevel);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.CheckOnClick = true;
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.normalToolStripMenuItem.Tag = "750";
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.SetDifficultyLevel);
            // 
            // moderateToolStripMenuItem
            // 
            this.moderateToolStripMenuItem.CheckOnClick = true;
            this.moderateToolStripMenuItem.Name = "moderateToolStripMenuItem";
            this.moderateToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.moderateToolStripMenuItem.Tag = "500";
            this.moderateToolStripMenuItem.Text = "Moderate";
            this.moderateToolStripMenuItem.Click += new System.EventHandler(this.SetDifficultyLevel);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.CheckOnClick = true;
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.hardToolStripMenuItem.Tag = "250";
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.SetDifficultyLevel);
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.CheckOnClick = true;
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.expertToolStripMenuItem.Tag = "125";
            this.expertToolStripMenuItem.Text = "Expert";
            this.expertToolStripMenuItem.Click += new System.EventHandler(this.SetDifficultyLevel);
            // 
            // insaneToolStripMenuItem
            // 
            this.insaneToolStripMenuItem.CheckOnClick = true;
            this.insaneToolStripMenuItem.Name = "insaneToolStripMenuItem";
            this.insaneToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.insaneToolStripMenuItem.Tag = "50";
            this.insaneToolStripMenuItem.Text = "Insane!";
            this.insaneToolStripMenuItem.Click += new System.EventHandler(this.SetDifficultyLevel);
            // 
            // playTimedGameToolStripMenuItem
            // 
            this.playTimedGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.halfMinuteToolStripMenuItem,
            this.oneMinuteToolStripMenuItem,
            this.twoMinutesToolStripMenuItem,
            this.unlimitedToolStripMenuItem});
            this.playTimedGameToolStripMenuItem.Name = "playTimedGameToolStripMenuItem";
            this.playTimedGameToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.playTimedGameToolStripMenuItem.Text = "Play Timed &Game";
            // 
            // halfMinuteToolStripMenuItem
            // 
            this.halfMinuteToolStripMenuItem.CheckOnClick = true;
            this.halfMinuteToolStripMenuItem.Name = "halfMinuteToolStripMenuItem";
            this.halfMinuteToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.halfMinuteToolStripMenuItem.Text = "&30 Seconds";
            this.halfMinuteToolStripMenuItem.Click += new System.EventHandler(this.gameTimerSetter);
            // 
            // oneMinuteToolStripMenuItem
            // 
            this.oneMinuteToolStripMenuItem.CheckOnClick = true;
            this.oneMinuteToolStripMenuItem.Name = "oneMinuteToolStripMenuItem";
            this.oneMinuteToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.oneMinuteToolStripMenuItem.Text = "&1 Minute";
            this.oneMinuteToolStripMenuItem.Click += new System.EventHandler(this.gameTimerSetter);
            // 
            // twoMinutesToolStripMenuItem
            // 
            this.twoMinutesToolStripMenuItem.CheckOnClick = true;
            this.twoMinutesToolStripMenuItem.Name = "twoMinutesToolStripMenuItem";
            this.twoMinutesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.twoMinutesToolStripMenuItem.Text = "&2 Minutes";
            this.twoMinutesToolStripMenuItem.Click += new System.EventHandler(this.gameTimerSetter);
            // 
            // unlimitedToolStripMenuItem
            // 
            this.unlimitedToolStripMenuItem.CheckOnClick = true;
            this.unlimitedToolStripMenuItem.Name = "unlimitedToolStripMenuItem";
            this.unlimitedToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.unlimitedToolStripMenuItem.Text = "&Unlimited";
            this.unlimitedToolStripMenuItem.Click += new System.EventHandler(this.gameTimerSetter);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "&Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pauseToolStripMenuItem.Text = "&Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.endToolStripMenuItem.Text = "End";
            this.endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "&Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click_1);
            // 
            // highScoresToolStripMenuItem
            // 
            this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.highScoresToolStripMenuItem.Text = "&High Scores";
            this.highScoresToolStripMenuItem.Click += new System.EventHandler(this.highScoresToolStripMenuItem_Click);
            // 
            // ssMain
            // 
            this.ssMain.BackgroundImage = global::GNS.Games.WackAMole.Properties.Resources.grass;
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslScore,
            this.tsslLives,
            this.tsslLevel,
            this.tsslCounter});
            this.ssMain.Location = new System.Drawing.Point(0, 352);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(394, 22);
            this.ssMain.SizingGrip = false;
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslScore
            // 
            this.tsslScore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsslScore.Name = "tsslScore";
            this.tsslScore.Size = new System.Drawing.Size(94, 17);
            this.tsslScore.Spring = true;
            this.tsslScore.Text = "Score:";
            this.tsslScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslLives
            // 
            this.tsslLives.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsslLives.Name = "tsslLives";
            this.tsslLives.Size = new System.Drawing.Size(94, 17);
            this.tsslLives.Spring = true;
            this.tsslLives.Text = "Lives left: ";
            this.tsslLives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslLevel
            // 
            this.tsslLevel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsslLevel.Name = "tsslLevel";
            this.tsslLevel.Size = new System.Drawing.Size(94, 17);
            this.tsslLevel.Spring = true;
            this.tsslLevel.Text = "Level x";
            // 
            // tsslCounter
            // 
            this.tsslCounter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsslCounter.Name = "tsslCounter";
            this.tsslCounter.Size = new System.Drawing.Size(94, 17);
            this.tsslCounter.Spring = true;
            this.tsslCounter.Text = "...";
            this.tsslCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerMole
            // 
            this.timerMole.Tick += new System.EventHandler(this.timerMole_Tick);
            // 
            // grpGardenArea
            // 
            this.grpGardenArea.BackColor = System.Drawing.Color.Transparent;
            this.grpGardenArea.Controls.Add(this.btnMole9);
            this.grpGardenArea.Controls.Add(this.btnMole8);
            this.grpGardenArea.Controls.Add(this.btnMole7);
            this.grpGardenArea.Controls.Add(this.btnMole4);
            this.grpGardenArea.Controls.Add(this.btnMole5);
            this.grpGardenArea.Controls.Add(this.btnMole6);
            this.grpGardenArea.Controls.Add(this.btnMole3);
            this.grpGardenArea.Controls.Add(this.btnMole2);
            this.grpGardenArea.Controls.Add(this.btnMole1);
            this.grpGardenArea.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpGardenArea.Location = new System.Drawing.Point(12, 27);
            this.grpGardenArea.Name = "grpGardenArea";
            this.grpGardenArea.Size = new System.Drawing.Size(370, 322);
            this.grpGardenArea.TabIndex = 0;
            this.grpGardenArea.TabStop = false;
            this.grpGardenArea.Text = "Difficulty: X";
            // 
            // btnMole9
            // 
            this.btnMole9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMole9.BackgroundImage")));
            this.btnMole9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMole9.ForeColor = System.Drawing.Color.Maroon;
            this.btnMole9.Image = ((System.Drawing.Image)(resources.GetObject("btnMole9.Image")));
            this.btnMole9.Location = new System.Drawing.Point(252, 227);
            this.btnMole9.Name = "btnMole9";
            this.btnMole9.Size = new System.Drawing.Size(65, 65);
            this.btnMole9.TabIndex = 8;
            this.btnMole9.TabStop = false;
            this.btnMole9.UseVisualStyleBackColor = true;
            this.btnMole9.Visible = false;
            this.btnMole9.Click += new System.EventHandler(this.Whack);
            // 
            // btnMole8
            // 
            this.btnMole8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMole8.BackgroundImage")));
            this.btnMole8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMole8.ForeColor = System.Drawing.Color.Maroon;
            this.btnMole8.Image = ((System.Drawing.Image)(resources.GetObject("btnMole8.Image")));
            this.btnMole8.Location = new System.Drawing.Point(153, 227);
            this.btnMole8.Name = "btnMole8";
            this.btnMole8.Size = new System.Drawing.Size(65, 65);
            this.btnMole8.TabIndex = 7;
            this.btnMole8.TabStop = false;
            this.btnMole8.UseVisualStyleBackColor = true;
            this.btnMole8.Visible = false;
            this.btnMole8.Click += new System.EventHandler(this.Whack);
            // 
            // btnMole7
            // 
            this.btnMole7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMole7.BackgroundImage")));
            this.btnMole7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMole7.ForeColor = System.Drawing.Color.Maroon;
            this.btnMole7.Image = ((System.Drawing.Image)(resources.GetObject("btnMole7.Image")));
            this.btnMole7.Location = new System.Drawing.Point(54, 227);
            this.btnMole7.Name = "btnMole7";
            this.btnMole7.Size = new System.Drawing.Size(65, 65);
            this.btnMole7.TabIndex = 6;
            this.btnMole7.TabStop = false;
            this.btnMole7.UseVisualStyleBackColor = true;
            this.btnMole7.Visible = false;
            this.btnMole7.Click += new System.EventHandler(this.Whack);
            // 
            // btnMole4
            // 
            this.btnMole4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMole4.BackgroundImage")));
            this.btnMole4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMole4.ForeColor = System.Drawing.Color.Maroon;
            this.btnMole4.Image = ((System.Drawing.Image)(resources.GetObject("btnMole4.Image")));
            this.btnMole4.Location = new System.Drawing.Point(252, 129);
            this.btnMole4.Name = "btnMole4";
            this.btnMole4.Size = new System.Drawing.Size(65, 65);
            this.btnMole4.TabIndex = 5;
            this.btnMole4.TabStop = false;
            this.btnMole4.UseVisualStyleBackColor = true;
            this.btnMole4.Visible = false;
            this.btnMole4.Click += new System.EventHandler(this.Whack);
            // 
            // btnMole5
            // 
            this.btnMole5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMole5.BackgroundImage")));
            this.btnMole5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMole5.ForeColor = System.Drawing.Color.Maroon;
            this.btnMole5.Image = ((System.Drawing.Image)(resources.GetObject("btnMole5.Image")));
            this.btnMole5.Location = new System.Drawing.Point(153, 129);
            this.btnMole5.Name = "btnMole5";
            this.btnMole5.Size = new System.Drawing.Size(65, 65);
            this.btnMole5.TabIndex = 4;
            this.btnMole5.TabStop = false;
            this.btnMole5.UseVisualStyleBackColor = true;
            this.btnMole5.Visible = false;
            this.btnMole5.Click += new System.EventHandler(this.Whack);
            // 
            // btnMole6
            // 
            this.btnMole6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMole6.BackgroundImage")));
            this.btnMole6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMole6.ForeColor = System.Drawing.Color.Maroon;
            this.btnMole6.Image = ((System.Drawing.Image)(resources.GetObject("btnMole6.Image")));
            this.btnMole6.Location = new System.Drawing.Point(54, 129);
            this.btnMole6.Name = "btnMole6";
            this.btnMole6.Size = new System.Drawing.Size(65, 65);
            this.btnMole6.TabIndex = 3;
            this.btnMole6.TabStop = false;
            this.btnMole6.UseVisualStyleBackColor = true;
            this.btnMole6.Visible = false;
            this.btnMole6.Click += new System.EventHandler(this.Whack);
            // 
            // btnMole3
            // 
            this.btnMole3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMole3.BackgroundImage")));
            this.btnMole3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMole3.ForeColor = System.Drawing.Color.Maroon;
            this.btnMole3.Image = ((System.Drawing.Image)(resources.GetObject("btnMole3.Image")));
            this.btnMole3.Location = new System.Drawing.Point(252, 31);
            this.btnMole3.Name = "btnMole3";
            this.btnMole3.Size = new System.Drawing.Size(65, 65);
            this.btnMole3.TabIndex = 2;
            this.btnMole3.TabStop = false;
            this.btnMole3.UseVisualStyleBackColor = true;
            this.btnMole3.Visible = false;
            this.btnMole3.Click += new System.EventHandler(this.Whack);
            // 
            // btnMole2
            // 
            this.btnMole2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMole2.BackgroundImage")));
            this.btnMole2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMole2.ForeColor = System.Drawing.Color.Maroon;
            this.btnMole2.Image = global::GNS.Games.WackAMole.Properties.Resources.mole_btn;
            this.btnMole2.Location = new System.Drawing.Point(153, 31);
            this.btnMole2.Name = "btnMole2";
            this.btnMole2.Size = new System.Drawing.Size(65, 65);
            this.btnMole2.TabIndex = 1;
            this.btnMole2.TabStop = false;
            this.btnMole2.UseVisualStyleBackColor = true;
            this.btnMole2.Visible = false;
            this.btnMole2.Click += new System.EventHandler(this.Whack);
            // 
            // btnMole1
            // 
            this.btnMole1.BackgroundImage = global::GNS.Games.WackAMole.Properties.Resources.grass;
            this.btnMole1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMole1.ForeColor = System.Drawing.Color.Maroon;
            this.btnMole1.Image = global::GNS.Games.WackAMole.Properties.Resources.mole_btn;
            this.btnMole1.Location = new System.Drawing.Point(54, 31);
            this.btnMole1.Name = "btnMole1";
            this.btnMole1.Size = new System.Drawing.Size(65, 65);
            this.btnMole1.TabIndex = 0;
            this.btnMole1.TabStop = false;
            this.btnMole1.UseVisualStyleBackColor = true;
            this.btnMole1.Visible = false;
            this.btnMole1.Click += new System.EventHandler(this.Whack);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // timerElapsedTime
            // 
            this.timerElapsedTime.Interval = 1000;
            this.timerElapsedTime.Tick += new System.EventHandler(this.timerElapsedTime_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GNS.Games.WackAMole.Properties.Resources.grass;
            this.ClientSize = new System.Drawing.Size(394, 374);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.grpGardenArea);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.grpGardenArea.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGardenArea;
        private System.Windows.Forms.Button btnMole9;
        private System.Windows.Forms.Button btnMole8;
        private System.Windows.Forms.Button btnMole7;
        private System.Windows.Forms.Button btnMole4;
        private System.Windows.Forms.Button btnMole5;
        private System.Windows.Forms.Button btnMole6;
        private System.Windows.Forms.Button btnMole3;
        private System.Windows.Forms.Button btnMole2;
        private System.Windows.Forms.Button btnMole1;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timerMole;
        private System.Windows.Forms.ToolStripStatusLabel tsslScore;
        private System.Windows.Forms.ToolStripStatusLabel tsslLevel;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moderateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsslLives;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playTimedGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halfMinuteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneMinuteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoMinutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unlimitedToolStripMenuItem;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer timerElapsedTime;
        private System.Windows.Forms.ToolStripStatusLabel tsslCounter;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
    }
}

