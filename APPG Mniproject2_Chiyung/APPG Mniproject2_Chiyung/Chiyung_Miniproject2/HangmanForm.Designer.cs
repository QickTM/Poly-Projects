namespace Chiyung_Miniproject2
{
    partial class HangmanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangmanForm));
            this.label1 = new System.Windows.Forms.Label();
            this.topicLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.hangmanPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gamesNumLabel = new System.Windows.Forms.Label();
            this.chooseButton = new System.Windows.Forms.Button();
            this.guessListBox = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.winLabel = new System.Windows.Forms.Label();
            this.lossLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.scoreGroupBox = new System.Windows.Forms.GroupBox();
            this.historyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.scoreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(165, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hangman Topic:";
            // 
            // topicLabel
            // 
            this.topicLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.topicLabel.BackColor = System.Drawing.Color.White;
            this.topicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.topicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.topicLabel.Location = new System.Drawing.Point(438, 38);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(256, 39);
            this.topicLabel.TabIndex = 1;
            this.topicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputTextBox.BackColor = System.Drawing.Color.White;
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputTextBox.Location = new System.Drawing.Point(81, 544);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(150, 45);
            this.inputTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(74, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Letter To Guess:";
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.startButton.Location = new System.Drawing.Point(45, 228);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(126, 74);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.exitButton.Location = new System.Drawing.Point(925, 710);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 74);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.submitButton.Location = new System.Drawing.Point(257, 544);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(126, 49);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(598, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Letters guessed:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wordLabel
            // 
            this.wordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wordLabel.AutoSize = true;
            this.wordLabel.BackColor = System.Drawing.Color.White;
            this.wordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.wordLabel.Location = new System.Drawing.Point(81, 671);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(316, 41);
            this.wordLabel.TabIndex = 11;
            this.wordLabel.Text = "                                 ";
            this.wordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hangmanPictureBox
            // 
            this.hangmanPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hangmanPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hangmanPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hangmanPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("hangmanPictureBox.Image")));
            this.hangmanPictureBox.Location = new System.Drawing.Point(197, 101);
            this.hangmanPictureBox.Name = "hangmanPictureBox";
            this.hangmanPictureBox.Size = new System.Drawing.Size(294, 354);
            this.hangmanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hangmanPictureBox.TabIndex = 13;
            this.hangmanPictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(74, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 39);
            this.label4.TabIndex = 14;
            this.label4.Text = "Word:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(620, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 39);
            this.label5.TabIndex = 15;
            this.label5.Text = "Games played:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gamesNumLabel
            // 
            this.gamesNumLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gamesNumLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gamesNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamesNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.gamesNumLabel.Location = new System.Drawing.Point(895, 401);
            this.gamesNumLabel.Name = "gamesNumLabel";
            this.gamesNumLabel.Size = new System.Drawing.Size(156, 175);
            this.gamesNumLabel.TabIndex = 16;
            this.gamesNumLabel.Text = "0";
            this.gamesNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chooseButton
            // 
            this.chooseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chooseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chooseButton.Location = new System.Drawing.Point(715, 22);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(205, 75);
            this.chooseButton.TabIndex = 17;
            this.chooseButton.Text = "Choose Another Topic";
            this.chooseButton.UseVisualStyleBackColor = false;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // guessListBox
            // 
            this.guessListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guessListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.guessListBox.FormattingEnabled = true;
            this.guessListBox.ItemHeight = 38;
            this.guessListBox.Location = new System.Drawing.Point(895, 113);
            this.guessListBox.Name = "guessListBox";
            this.guessListBox.Size = new System.Drawing.Size(156, 270);
            this.guessListBox.TabIndex = 18;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(81, 13);
            this.axWindowsMediaPlayer1.TabIndex = 19;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // winLabel
            // 
            this.winLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.winLabel.BackColor = System.Drawing.Color.Lime;
            this.winLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.winLabel.ForeColor = System.Drawing.Color.Black;
            this.winLabel.Location = new System.Drawing.Point(24, 91);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(105, 74);
            this.winLabel.TabIndex = 20;
            this.winLabel.Text = "0";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lossLabel
            // 
            this.lossLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lossLabel.BackColor = System.Drawing.Color.Red;
            this.lossLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lossLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossLabel.ForeColor = System.Drawing.Color.Black;
            this.lossLabel.Location = new System.Drawing.Point(157, 91);
            this.lossLabel.Name = "lossLabel";
            this.lossLabel.Size = new System.Drawing.Size(105, 74);
            this.lossLabel.TabIndex = 21;
            this.lossLabel.Text = "0";
            this.lossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(19, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Wins:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(152, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "Losses:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scoreGroupBox
            // 
            this.scoreGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scoreGroupBox.Controls.Add(this.historyButton);
            this.scoreGroupBox.Controls.Add(this.label7);
            this.scoreGroupBox.Controls.Add(this.label6);
            this.scoreGroupBox.Controls.Add(this.lossLabel);
            this.scoreGroupBox.Controls.Add(this.winLabel);
            this.scoreGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.scoreGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreGroupBox.Location = new System.Drawing.Point(556, 487);
            this.scoreGroupBox.Name = "scoreGroupBox";
            this.scoreGroupBox.Size = new System.Drawing.Size(287, 297);
            this.scoreGroupBox.TabIndex = 24;
            this.scoreGroupBox.TabStop = false;
            this.scoreGroupBox.Text = "Score";
            // 
            // historyButton
            // 
            this.historyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.historyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.Location = new System.Drawing.Point(49, 184);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(190, 75);
            this.historyButton.TabIndex = 25;
            this.historyButton.Text = "View Logs";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // HangmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 841);
            this.Controls.Add(this.scoreGroupBox);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.guessListBox);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.gamesNumLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hangmanPictureBox);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.topicLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HangmanForm";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.scoreGroupBox.ResumeLayout(false);
            this.scoreGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.PictureBox hangmanPictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label gamesNumLabel;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.ListBox guessListBox;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label lossLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox scoreGroupBox;
        private System.Windows.Forms.Button historyButton;
    }
}