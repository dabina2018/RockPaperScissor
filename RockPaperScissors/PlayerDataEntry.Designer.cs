namespace RockPaperScissors
{
    partial class playerDataEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerDataEntry));
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.playerEmailLabel = new System.Windows.Forms.Label();
            this.playerNameText = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.playerEmailText = new System.Windows.Forms.TextBox();
            this.submitPlayerDataBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(39, 117);
            this.playerNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(124, 25);
            this.playerNameLabel.TabIndex = 0;
            this.playerNameLabel.Text = "Player Name";
            // 
            // playerEmailLabel
            // 
            this.playerEmailLabel.AutoSize = true;
            this.playerEmailLabel.Location = new System.Drawing.Point(39, 175);
            this.playerEmailLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.playerEmailLabel.Name = "playerEmailLabel";
            this.playerEmailLabel.Size = new System.Drawing.Size(59, 25);
            this.playerEmailLabel.TabIndex = 1;
            this.playerEmailLabel.Text = "Email";
            // 
            // playerNameText
            // 
            this.playerNameText.Location = new System.Drawing.Point(194, 109);
            this.playerNameText.Name = "playerNameText";
            this.playerNameText.Size = new System.Drawing.Size(211, 33);
            this.playerNameText.TabIndex = 4;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(192, 45);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Player Data";
            // 
            // playerEmailText
            // 
            this.playerEmailText.Location = new System.Drawing.Point(194, 172);
            this.playerEmailText.Name = "playerEmailText";
            this.playerEmailText.Size = new System.Drawing.Size(211, 33);
            this.playerEmailText.TabIndex = 6;
            this.playerEmailText.Text = "you@domain.com";
            // 
            // submitPlayerDataBtn
            // 
            this.submitPlayerDataBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.submitPlayerDataBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.submitPlayerDataBtn.Location = new System.Drawing.Point(168, 245);
            this.submitPlayerDataBtn.Name = "submitPlayerDataBtn";
            this.submitPlayerDataBtn.Size = new System.Drawing.Size(118, 35);
            this.submitPlayerDataBtn.TabIndex = 7;
            this.submitPlayerDataBtn.Text = "Submit";
            this.submitPlayerDataBtn.UseVisualStyleBackColor = true;
            this.submitPlayerDataBtn.Click += new System.EventHandler(this.submitPlayerDataBtn_Click);
            // 
            // playerDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 306);
            this.Controls.Add(this.submitPlayerDataBtn);
            this.Controls.Add(this.playerEmailText);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.playerNameText);
            this.Controls.Add(this.playerEmailLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "playerDataEntry";
            this.Text = "Player Data Entry";
            this.Load += new System.EventHandler(this.playerDataEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label playerEmailLabel;
        private System.Windows.Forms.TextBox playerNameText;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox playerEmailText;
        private System.Windows.Forms.Button submitPlayerDataBtn;
    }
}