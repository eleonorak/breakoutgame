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
            this.lblNickName = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.Location = new System.Drawing.Point(38, 23);
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
            this.welcomeMessage.Location = new System.Drawing.Point(152, 109);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(204, 31);
            this.welcomeMessage.TabIndex = 1;
            this.welcomeMessage.Text = "Добредојдовте";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(89, 358);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(122, 41);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Започни игра";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(278, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 41);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickName.Location = new System.Drawing.Point(67, 208);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(86, 25);
            this.lblNickName.TabIndex = 4;
            this.lblNickName.Text = "Прекар";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(67, 272);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(69, 25);
            this.lblLanguage.TabIndex = 5;
            this.lblLanguage.Text = "Јазик";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(189, 208);
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
            this.cbLanguage.Location = new System.Drawing.Point(189, 272);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(145, 21);
            this.cbLanguage.TabIndex = 7;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 447);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblNickName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.welcomeMessage);
            this.Controls.Add(this.gameName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The BreakOut Game";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Label welcomeMessage;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

