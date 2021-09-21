namespace Chiyung_Miniproject2
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.historylogLabel = new System.Windows.Forms.Label();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.readButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.exitButton2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.scoreListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.logoutButton = new System.Windows.Forms.Button();
            this.msgLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.useonlyLabel = new System.Windows.Forms.Label();
            this.adminLabel = new System.Windows.Forms.Label();
            this.adminpasswordTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // historylogLabel
            // 
            this.historylogLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.historylogLabel.AutoSize = true;
            this.historylogLabel.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historylogLabel.Location = new System.Drawing.Point(393, 17);
            this.historylogLabel.Name = "historylogLabel";
            this.historylogLabel.Size = new System.Drawing.Size(355, 55);
            this.historylogLabel.TabIndex = 0;
            this.historylogLabel.Text = "History Logs";
            // 
            // displayListBox
            // 
            this.displayListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.ItemHeight = 29;
            this.displayListBox.Location = new System.Drawing.Point(38, 181);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(814, 352);
            this.displayListBox.TabIndex = 2;
            this.displayListBox.Visible = false;
            // 
            // readButton
            // 
            this.readButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.readButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.readButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.readButton.Location = new System.Drawing.Point(878, 181);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(171, 81);
            this.readButton.TabIndex = 3;
            this.readButton.Text = "Refresh";
            this.readButton.UseVisualStyleBackColor = false;
            this.readButton.Visible = false;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.exitButton.Location = new System.Drawing.Point(878, 452);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(171, 81);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Close";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1120, 579);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.exitButton2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.refreshButton);
            this.tabPage2.Controls.Add(this.scoreListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1112, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // exitButton2
            // 
            this.exitButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.exitButton2.Location = new System.Drawing.Point(875, 411);
            this.exitButton2.Name = "exitButton2";
            this.exitButton2.Size = new System.Drawing.Size(171, 81);
            this.exitButton2.TabIndex = 6;
            this.exitButton2.Text = "Close";
            this.exitButton2.UseVisualStyleBackColor = false;
            this.exitButton2.Click += new System.EventHandler(this.exitButton2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 55);
            this.label2.TabIndex = 5;
            this.label2.Text = "Game History";
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.refreshButton.Location = new System.Drawing.Point(875, 90);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(171, 81);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // scoreListView
            // 
            this.scoreListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.scoreListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreListView.HideSelection = false;
            this.scoreListView.Location = new System.Drawing.Point(35, 90);
            this.scoreListView.Name = "scoreListView";
            this.scoreListView.Size = new System.Drawing.Size(817, 402);
            this.scoreListView.TabIndex = 0;
            this.scoreListView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.logoutButton);
            this.tabPage1.Controls.Add(this.msgLabel);
            this.tabPage1.Controls.Add(this.loginButton);
            this.tabPage1.Controls.Add(this.useonlyLabel);
            this.tabPage1.Controls.Add(this.adminLabel);
            this.tabPage1.Controls.Add(this.adminpasswordTextBox);
            this.tabPage1.Controls.Add(this.userLabel);
            this.tabPage1.Controls.Add(this.userComboBox);
            this.tabPage1.Controls.Add(this.displayListBox);
            this.tabPage1.Controls.Add(this.exitButton);
            this.tabPage1.Controls.Add(this.readButton);
            this.tabPage1.Controls.Add(this.historylogLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1112, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "History Logs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.logoutButton.Location = new System.Drawing.Point(878, 380);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(171, 52);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "&Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // msgLabel
            // 
            this.msgLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msgLabel.BackColor = System.Drawing.Color.White;
            this.msgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.msgLabel.ForeColor = System.Drawing.Color.Red;
            this.msgLabel.Location = new System.Drawing.Point(159, 296);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(811, 29);
            this.msgLabel.TabIndex = 11;
            this.msgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.loginButton.Location = new System.Drawing.Point(799, 232);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(171, 52);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "&Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // useonlyLabel
            // 
            this.useonlyLabel.AutoSize = true;
            this.useonlyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.useonlyLabel.Location = new System.Drawing.Point(511, 72);
            this.useonlyLabel.Name = "useonlyLabel";
            this.useonlyLabel.Size = new System.Drawing.Size(135, 20);
            this.useonlyLabel.TabIndex = 9;
            this.useonlyLabel.Text = "(Admin use only)";
            // 
            // adminLabel
            // 
            this.adminLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.adminLabel.Location = new System.Drawing.Point(152, 239);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(282, 39);
            this.adminLabel.TabIndex = 8;
            this.adminLabel.Text = "Admin Password:";
            this.adminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminpasswordTextBox
            // 
            this.adminpasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminpasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.adminpasswordTextBox.Location = new System.Drawing.Point(454, 236);
            this.adminpasswordTextBox.Name = "adminpasswordTextBox";
            this.adminpasswordTextBox.Size = new System.Drawing.Size(323, 45);
            this.adminpasswordTextBox.TabIndex = 7;
            // 
            // userLabel
            // 
            this.userLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userLabel.Location = new System.Drawing.Point(33, 130);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(73, 29);
            this.userLabel.TabIndex = 6;
            this.userLabel.Text = "User:";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userLabel.Visible = false;
            // 
            // userComboBox
            // 
            this.userComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userComboBox.CausesValidation = false;
            this.userComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(122, 127);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(266, 37);
            this.userComboBox.TabIndex = 5;
            this.userComboBox.Text = "Select User";
            this.userComboBox.Visible = false;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 589);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HistoryForm";
            this.Text = "History";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label historylogLabel;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView scoreListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button exitButton2;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.TextBox adminpasswordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label useonlyLabel;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Button logoutButton;
    }
}