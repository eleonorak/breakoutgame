namespace BreakOutGame
{
    partial class GameEndedForm
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
            this.gameName = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.infoGame = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnGoToMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.Location = new System.Drawing.Point(23, 26);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(350, 33);
            this.gameName.TabIndex = 2;
            this.gameName.Text = "THE BREAKOUT GAME";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(96, 252);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(227, 31);
            this.labelScore.TabIndex = 9;
            this.labelScore.Text = "Освоени поени : ";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(142, 181);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(32, 24);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "lbl";
            // 
            // infoGame
            // 
            this.infoGame.AutoSize = true;
            this.infoGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGame.Location = new System.Drawing.Point(94, 108);
            this.infoGame.Name = "infoGame";
            this.infoGame.Size = new System.Drawing.Size(216, 31);
            this.infoGame.TabIndex = 7;
            this.infoGame.Text = "Играта заврши";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(221, 325);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(126, 42);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.Text = "Нова игра";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnGoToMainForm
            // 
            this.btnGoToMainForm.Location = new System.Drawing.Point(48, 325);
            this.btnGoToMainForm.Name = "btnGoToMainForm";
            this.btnGoToMainForm.Size = new System.Drawing.Size(126, 42);
            this.btnGoToMainForm.TabIndex = 10;
            this.btnGoToMainForm.Text = "Оди на почеток";
            this.btnGoToMainForm.UseVisualStyleBackColor = true;
            this.btnGoToMainForm.Click += new System.EventHandler(this.btnGoToMainForm_Click);
            // 
            // GameEndedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(416, 390);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnGoToMainForm);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.infoGame);
            this.Controls.Add(this.gameName);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameEndedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The BreakOut Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label infoGame;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnGoToMainForm;
    }
}