namespace RockPaperScissors
{
    partial class RockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RockPaperScissors));
            this.rockBtn = new System.Windows.Forms.Button();
            this.paperBtn = new System.Windows.Forms.Button();
            this.scissorBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.player1NameLabel = new System.Windows.Forms.Label();
            this.computerNameLabel = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.winLoseCntLabel = new System.Windows.Forms.Label();
            this.timerCntLabel = new System.Windows.Forms.Label();
            this.roundNumLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.enterPlayerDataLinkLabel = new System.Windows.Forms.LinkLabel();
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rockBtn
            // 
            this.rockBtn.Location = new System.Drawing.Point(6, 131);
            this.rockBtn.Margin = new System.Windows.Forms.Padding(6);
            this.rockBtn.Name = "rockBtn";
            this.rockBtn.Size = new System.Drawing.Size(138, 44);
            this.rockBtn.TabIndex = 2;
            this.rockBtn.Text = "Rock";
            this.rockBtn.UseVisualStyleBackColor = true;
            this.rockBtn.Click += new System.EventHandler(this.rockBtn_Click);
            // 
            // paperBtn
            // 
            this.paperBtn.Location = new System.Drawing.Point(6, 203);
            this.paperBtn.Margin = new System.Windows.Forms.Padding(6);
            this.paperBtn.Name = "paperBtn";
            this.paperBtn.Size = new System.Drawing.Size(138, 44);
            this.paperBtn.TabIndex = 3;
            this.paperBtn.Text = "Paper";
            this.paperBtn.UseVisualStyleBackColor = true;
            this.paperBtn.Click += new System.EventHandler(this.paperBtn_Click);
            // 
            // scissorBtn
            // 
            this.scissorBtn.Location = new System.Drawing.Point(6, 278);
            this.scissorBtn.Margin = new System.Windows.Forms.Padding(6);
            this.scissorBtn.Name = "scissorBtn";
            this.scissorBtn.Size = new System.Drawing.Size(138, 44);
            this.scissorBtn.TabIndex = 4;
            this.scissorBtn.Text = "Scissor";
            this.scissorBtn.UseVisualStyleBackColor = true;
            this.scissorBtn.Click += new System.EventHandler(this.scissorBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(690, 366);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(6);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(138, 44);
            this.helpBtn.TabIndex = 5;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // player1NameLabel
            // 
            this.player1NameLabel.AutoSize = true;
            this.player1NameLabel.Location = new System.Drawing.Point(323, 100);
            this.player1NameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.player1NameLabel.Name = "player1NameLabel";
            this.player1NameLabel.Size = new System.Drawing.Size(111, 25);
            this.player1NameLabel.TabIndex = 6;
            this.player1NameLabel.Text = "Your Name";
            // 
            // computerNameLabel
            // 
            this.computerNameLabel.AutoSize = true;
            this.computerNameLabel.Location = new System.Drawing.Point(627, 100);
            this.computerNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.computerNameLabel.Name = "computerNameLabel";
            this.computerNameLabel.Size = new System.Drawing.Size(102, 25);
            this.computerNameLabel.TabIndex = 7;
            this.computerNameLabel.Text = "Computer";
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Location = new System.Drawing.Point(479, 150);
            this.winnerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(106, 25);
            this.winnerLabel.TabIndex = 8;
            this.winnerLabel.Text = "Win / Lose";
            // 
            // winLoseCntLabel
            // 
            this.winLoseCntLabel.AutoSize = true;
            this.winLoseCntLabel.Location = new System.Drawing.Point(524, 203);
            this.winLoseCntLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.winLoseCntLabel.Name = "winLoseCntLabel";
            this.winLoseCntLabel.Size = new System.Drawing.Size(23, 25);
            this.winLoseCntLabel.TabIndex = 9;
            this.winLoseCntLabel.Text = "0";
            // 
            // timerCntLabel
            // 
            this.timerCntLabel.AutoSize = true;
            this.timerCntLabel.Location = new System.Drawing.Point(33, 394);
            this.timerCntLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timerCntLabel.Name = "timerCntLabel";
            this.timerCntLabel.Size = new System.Drawing.Size(55, 25);
            this.timerCntLabel.TabIndex = 10;
            this.timerCntLabel.Text = "Time";
            // 
            // roundNumLabel
            // 
            this.roundNumLabel.AutoSize = true;
            this.roundNumLabel.Location = new System.Drawing.Point(121, 394);
            this.roundNumLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.roundNumLabel.Name = "roundNumLabel";
            this.roundNumLabel.Size = new System.Drawing.Size(23, 25);
            this.roundNumLabel.TabIndex = 11;
            this.roundNumLabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enterPlayerDataLinkLabel
            // 
            this.enterPlayerDataLinkLabel.AutoSize = true;
            this.enterPlayerDataLinkLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPlayerDataLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.enterPlayerDataLinkLabel.Location = new System.Drawing.Point(313, 267);
            this.enterPlayerDataLinkLabel.Name = "enterPlayerDataLinkLabel";
            this.enterPlayerDataLinkLabel.Size = new System.Drawing.Size(130, 20);
            this.enterPlayerDataLinkLabel.TabIndex = 12;
            this.enterPlayerDataLinkLabel.TabStop = true;
            this.enterPlayerDataLinkLabel.Text = "Enter Player Data";
            this.enterPlayerDataLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.enterPlayerDataLinkLabel_LinkClicked);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(324, 45);
            this.Title.TabIndex = 13;
            this.Title.Text = "Rock Paper Scissors!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RockPaperScissors.Properties.Resources.question;
            this.pictureBox2.Location = new System.Drawing.Point(614, 131);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RockPaperScissors.Properties.Resources.question;
            this.pictureBox1.Location = new System.Drawing.Point(313, 131);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 461);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.enterPlayerDataLinkLabel);
            this.Controls.Add(this.roundNumLabel);
            this.Controls.Add(this.timerCntLabel);
            this.Controls.Add(this.winLoseCntLabel);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.computerNameLabel);
            this.Controls.Add(this.player1NameLabel);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.scissorBtn);
            this.Controls.Add(this.paperBtn);
            this.Controls.Add(this.rockBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RockPaperScissors";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button rockBtn;
        private System.Windows.Forms.Button paperBtn;
        private System.Windows.Forms.Button scissorBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Label player1NameLabel;
        private System.Windows.Forms.Label computerNameLabel;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label winLoseCntLabel;
        private System.Windows.Forms.Label timerCntLabel;
        private System.Windows.Forms.Label roundNumLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel enterPlayerDataLinkLabel;
        private System.Windows.Forms.Label Title;
    }
}

