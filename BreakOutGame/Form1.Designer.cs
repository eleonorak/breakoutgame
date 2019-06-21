namespace BreakOutGame
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameName = new System.Windows.Forms.Label();
            this.welcomeMessage = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbNickName = new System.Windows.Forms.Label();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbLevel = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeBallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OneColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoreColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.Location = new System.Drawing.Point(134, 52);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(446, 42);
            this.gameName.TabIndex = 0;
            this.gameName.Text = "THE BREAKOUT GAME";
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.AutoSize = true;
            this.welcomeMessage.BackColor = System.Drawing.Color.White;
            this.welcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMessage.Location = new System.Drawing.Point(258, 138);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(204, 31);
            this.welcomeMessage.TabIndex = 1;
            this.welcomeMessage.Text = "Добредојдовте";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(212, 450);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(122, 41);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Започни игра";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(414, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 41);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbNickName
            // 
            this.lbNickName.AutoSize = true;
            this.lbNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNickName.Location = new System.Drawing.Point(207, 230);
            this.lbNickName.Name = "lbNickName";
            this.lbNickName.Size = new System.Drawing.Size(86, 25);
            this.lbNickName.TabIndex = 4;
            this.lbNickName.Text = "Прекар";
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanguage.Location = new System.Drawing.Point(207, 294);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(69, 25);
            this.lbLanguage.TabIndex = 5;
            this.lbLanguage.Text = "Јазик";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(329, 230);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(145, 20);
            this.txtNickName.TabIndex = 6;
            this.txtNickName.Validating += new System.ComponentModel.CancelEventHandler(this.txtNickName_Validating);
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "Македонски",
            "Англиски"});
            this.cbLanguage.Location = new System.Drawing.Point(329, 294);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(145, 21);
            this.cbLanguage.TabIndex = 7;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.Location = new System.Drawing.Point(207, 351);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(62, 25);
            this.lbLevel.TabIndex = 8;
            this.lbLevel.Text = "Ниво";
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Македонски",
            "Англиски"});
            this.cbLevel.Location = new System.Drawing.Point(329, 355);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(145, 21);
            this.cbLevel.TabIndex = 9;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(754, 24);
            this.menu.TabIndex = 10;
            this.menu.Text = "menuStrip1";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeBallToolStripMenuItem,
            this.ChangeBlocksToolStripMenuItem,
            this.ChangeBackgroundToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.SettingsToolStripMenuItem.Text = "Подесување";
            // 
            // ChangeBallToolStripMenuItem
            // 
            this.ChangeBallToolStripMenuItem.Name = "ChangeBallToolStripMenuItem";
            this.ChangeBallToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ChangeBallToolStripMenuItem.Text = "Боја топче";
            this.ChangeBallToolStripMenuItem.Click += new System.EventHandler(this.ChangeBallToolStripMenuItem_Click);
            // 
            // ChangeBlocksToolStripMenuItem
            // 
            this.ChangeBlocksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OneColorToolStripMenuItem,
            this.MoreColorToolStripMenuItem});
            this.ChangeBlocksToolStripMenuItem.Name = "ChangeBlocksToolStripMenuItem";
            this.ChangeBlocksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ChangeBlocksToolStripMenuItem.Text = "Боја на блокови";
            // 
            // OneColorToolStripMenuItem
            // 
            this.OneColorToolStripMenuItem.Name = "OneColorToolStripMenuItem";
            this.OneColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OneColorToolStripMenuItem.Text = "Една боја";
            this.OneColorToolStripMenuItem.Click += new System.EventHandler(this.OneColorToolStripMenuItem_Click);
            // 
            // MoreColorToolStripMenuItem
            // 
            this.MoreColorToolStripMenuItem.Name = "MoreColorToolStripMenuItem";
            this.MoreColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MoreColorToolStripMenuItem.Text = "Различни бои";
            this.MoreColorToolStripMenuItem.Click += new System.EventHandler(this.MoreColorToolStripMenuItem_Click);
            // 
            // ChangeBackgroundToolStripMenuItem
            // 
            this.ChangeBackgroundToolStripMenuItem.Name = "ChangeBackgroundToolStripMenuItem";
            this.ChangeBackgroundToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ChangeBackgroundToolStripMenuItem.Text = "Позадинска боја";
            this.ChangeBackgroundToolStripMenuItem.Click += new System.EventHandler(this.ChangeBackgroundToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 527);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.lbLanguage);
            this.Controls.Add(this.lbNickName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.welcomeMessage);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The BreakOut Game";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Label welcomeMessage;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbNickName;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeBallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeBlocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OneColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoreColorToolStripMenuItem;
    }
}

