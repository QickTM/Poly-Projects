namespace Chiyung_Miniproject2
{
    partial class TopicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopicForm));
            this.dishButton = new System.Windows.Forms.Button();
            this.furnitureButton = new System.Windows.Forms.Button();
            this.countrybutton = new System.Windows.Forms.Button();
            this.colourButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dishButton
            // 
            this.dishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dishButton.Location = new System.Drawing.Point(148, 166);
            this.dishButton.Name = "dishButton";
            this.dishButton.Size = new System.Drawing.Size(264, 130);
            this.dishButton.TabIndex = 0;
            this.dishButton.Text = "Food";
            this.dishButton.UseVisualStyleBackColor = false;
            this.dishButton.Click += new System.EventHandler(this.dishButton_Click);
            // 
            // furnitureButton
            // 
            this.furnitureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.furnitureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.furnitureButton.Location = new System.Drawing.Point(148, 341);
            this.furnitureButton.Name = "furnitureButton";
            this.furnitureButton.Size = new System.Drawing.Size(264, 130);
            this.furnitureButton.TabIndex = 1;
            this.furnitureButton.Text = "Furniture";
            this.furnitureButton.UseVisualStyleBackColor = false;
            this.furnitureButton.Click += new System.EventHandler(this.furnitureButton_Click);
            // 
            // countrybutton
            // 
            this.countrybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.countrybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.countrybutton.Location = new System.Drawing.Point(475, 166);
            this.countrybutton.Name = "countrybutton";
            this.countrybutton.Size = new System.Drawing.Size(264, 130);
            this.countrybutton.TabIndex = 2;
            this.countrybutton.Text = "Countries";
            this.countrybutton.UseVisualStyleBackColor = false;
            this.countrybutton.Click += new System.EventHandler(this.countrybutton_Click);
            // 
            // colourButton
            // 
            this.colourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.colourButton.Location = new System.Drawing.Point(475, 341);
            this.colourButton.Name = "colourButton";
            this.colourButton.Size = new System.Drawing.Size(264, 130);
            this.colourButton.TabIndex = 3;
            this.colourButton.Text = "Colours";
            this.colourButton.UseVisualStyleBackColor = false;
            this.colourButton.Click += new System.EventHandler(this.colourButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 40F);
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(809, 75);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Hangman Topic";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.backButton.Location = new System.Drawing.Point(242, 521);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(393, 87);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Go Back To Login Page";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // TopicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 642);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colourButton);
            this.Controls.Add(this.countrybutton);
            this.Controls.Add(this.furnitureButton);
            this.Controls.Add(this.dishButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TopicForm";
            this.Text = "Topic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dishButton;
        private System.Windows.Forms.Button furnitureButton;
        private System.Windows.Forms.Button countrybutton;
        private System.Windows.Forms.Button colourButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
    }
}