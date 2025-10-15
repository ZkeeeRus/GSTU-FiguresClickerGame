namespace InterGame
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

         #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.lPlayerText = new System.Windows.Forms.Label();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.bStart = new System.Windows.Forms.Button();
            this.pGameArea = new System.Windows.Forms.Panel();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuBarGameTab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarNewGameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarAboutTab = new System.Windows.Forms.ToolStripMenuItem();
            this.sStrip = new System.Windows.Forms.StatusStrip();
            this.tsScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.timerGameTime = new System.Windows.Forms.Timer(this.components);
            this.timerFrameUpdate = new System.Windows.Forms.Timer(this.components);
            this.pGameArea.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.sStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lPlayerText
            // 
            this.lPlayerText.AutoSize = true;
            this.lPlayerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPlayerText.Location = new System.Drawing.Point(325, 138);
            this.lPlayerText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPlayerText.Name = "lPlayerText";
            this.lPlayerText.Size = new System.Drawing.Size(56, 20);
            this.lPlayerText.TabIndex = 0;
            this.lPlayerText.Text = "Player:";
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPlayerName.Location = new System.Drawing.Point(389, 137);
            this.tbPlayerName.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(148, 24);
            this.tbPlayerName.TabIndex = 1;
            this.tbPlayerName.Text = "Player";
            // 
            // bStart
            // 
            this.bStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bStart.BackColor = System.Drawing.Color.LightGreen;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.Location = new System.Drawing.Point(367, 230);
            this.bStart.Margin = new System.Windows.Forms.Padding(4);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(154, 57);
            this.bStart.TabIndex = 4;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // pGameArea
            // 
            this.pGameArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pGameArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGameArea.Controls.Add(this.bStart);
            this.pGameArea.Controls.Add(this.lPlayerText);
            this.pGameArea.Controls.Add(this.tbPlayerName);
            this.pGameArea.Location = new System.Drawing.Point(12, 27);
            this.pGameArea.Name = "pGameArea";
            this.pGameArea.Size = new System.Drawing.Size(891, 477);
            this.pGameArea.TabIndex = 5;
            this.pGameArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pGameArea_MouseClick);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.Control;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBarGameTab,
            this.menuBarAboutTab});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(916, 24);
            this.menuBar.Stretch = false;
            this.menuBar.TabIndex = 6;
            // 
            // menuBarGameTab
            // 
            this.menuBarGameTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBarNewGameButton});
            this.menuBarGameTab.Name = "menuBarGameTab";
            this.menuBarGameTab.Size = new System.Drawing.Size(50, 20);
            this.menuBarGameTab.Text = "Game";
            // 
            // menuBarNewGameButton
            // 
            this.menuBarNewGameButton.Name = "menuBarNewGameButton";
            this.menuBarNewGameButton.Size = new System.Drawing.Size(132, 22);
            this.menuBarNewGameButton.Text = "New Game";
            this.menuBarNewGameButton.Click += new System.EventHandler(this.bStart_Click);
            // 
            // menuBarAboutTab
            // 
            this.menuBarAboutTab.Name = "menuBarAboutTab";
            this.menuBarAboutTab.Size = new System.Drawing.Size(52, 20);
            this.menuBarAboutTab.Text = "About";
            this.menuBarAboutTab.Click += new System.EventHandler(this.menuBarAboutTab_Click);
            // 
            // sStrip
            // 
            this.sStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsScore});
            this.sStrip.Location = new System.Drawing.Point(0, 504);
            this.sStrip.Name = "sStrip";
            this.sStrip.Size = new System.Drawing.Size(916, 25);
            this.sStrip.SizingGrip = false;
            this.sStrip.Stretch = false;
            this.sStrip.TabIndex = 7;
            this.sStrip.Text = "ssBottomInfo";
            // 
            // tsScore
            // 
            this.tsScore.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsScore.Name = "tsScore";
            this.tsScore.Size = new System.Drawing.Size(77, 20);
            this.tsScore.Text = "Score: 999";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 500;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // timerGameTime
            // 
            this.timerGameTime.Interval = 10000;
            this.timerGameTime.Tick += new System.EventHandler(this.timerGameTime_Tick);
            // 
            // timerFrameUpdate
            // 
            this.timerFrameUpdate.Interval = 16;
            this.timerFrameUpdate.Tick += new System.EventHandler(this.Update);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 529);
            this.Controls.Add(this.sStrip);
            this.Controls.Add(this.pGameArea);
            this.Controls.Add(this.menuBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.pGameArea.ResumeLayout(false);
            this.pGameArea.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.sStrip.ResumeLayout(false);
            this.sStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPlayerText;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Panel pGameArea;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuBarGameTab;
        private System.Windows.Forms.ToolStripMenuItem menuBarNewGameButton;
        private System.Windows.Forms.ToolStripMenuItem menuBarAboutTab;
        private System.Windows.Forms.StatusStrip sStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsScore;
        public System.Windows.Forms.Timer timerUpdate;
        public System.Windows.Forms.Timer timerGameTime;
        private System.Windows.Forms.Timer timerFrameUpdate;
    }
}

