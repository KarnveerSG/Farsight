namespace Blue_Ward
{
    partial class mainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainScreen));
            this.summonerAccounts = new System.Windows.Forms.ComboBox();
            this.addNewSummonerButton = new System.Windows.Forms.Button();
            this.addMatchHistoryButton = new System.Windows.Forms.Button();
            this.activeGameButton = new System.Windows.Forms.Button();
            this.matchHistoryFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // summonerAccounts
            // 
            this.summonerAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summonerAccounts.FormattingEnabled = true;
            this.summonerAccounts.Location = new System.Drawing.Point(12, 12);
            this.summonerAccounts.Name = "summonerAccounts";
            this.summonerAccounts.Size = new System.Drawing.Size(185, 28);
            this.summonerAccounts.TabIndex = 0;
            this.summonerAccounts.Text = "Choose Account";
            // 
            // addNewSummonerButton
            // 
            this.addNewSummonerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewSummonerButton.Location = new System.Drawing.Point(203, 12);
            this.addNewSummonerButton.Name = "addNewSummonerButton";
            this.addNewSummonerButton.Size = new System.Drawing.Size(185, 28);
            this.addNewSummonerButton.TabIndex = 1;
            this.addNewSummonerButton.Text = "Add New Summoner";
            this.addNewSummonerButton.UseVisualStyleBackColor = true;
            this.addNewSummonerButton.Click += new System.EventHandler(this.addNewSummonerButton_Click);
            // 
            // addMatchHistoryButton
            // 
            this.addMatchHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addMatchHistoryButton.Location = new System.Drawing.Point(203, 46);
            this.addMatchHistoryButton.Name = "addMatchHistoryButton";
            this.addMatchHistoryButton.Size = new System.Drawing.Size(185, 29);
            this.addMatchHistoryButton.TabIndex = 2;
            this.addMatchHistoryButton.Text = "Match History";
            this.addMatchHistoryButton.UseVisualStyleBackColor = true;
            this.addMatchHistoryButton.Click += new System.EventHandler(this.addMatchHistoryButton_Click);
            // 
            // activeGameButton
            // 
            this.activeGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.activeGameButton.Location = new System.Drawing.Point(203, 81);
            this.activeGameButton.Name = "activeGameButton";
            this.activeGameButton.Size = new System.Drawing.Size(185, 31);
            this.activeGameButton.TabIndex = 3;
            this.activeGameButton.Text = "Active Game";
            this.activeGameButton.UseVisualStyleBackColor = true;
            this.activeGameButton.Click += new System.EventHandler(this.activeGameButton_Click);
            // 
            // matchHistoryFlowLayoutPanel
            // 
            this.matchHistoryFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.matchHistoryFlowLayoutPanel.Location = new System.Drawing.Point(394, 12);
            this.matchHistoryFlowLayoutPanel.Name = "matchHistoryFlowLayoutPanel";
            this.matchHistoryFlowLayoutPanel.Size = new System.Drawing.Size(805, 689);
            this.matchHistoryFlowLayoutPanel.TabIndex = 4;
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 706);
            this.Controls.Add(this.matchHistoryFlowLayoutPanel);
            this.Controls.Add(this.activeGameButton);
            this.Controls.Add(this.addMatchHistoryButton);
            this.Controls.Add(this.addNewSummonerButton);
            this.Controls.Add(this.summonerAccounts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainScreen";
            this.Text = "mainScreen";
            this.Load += new System.EventHandler(this.mainScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox summonerAccounts;
        private System.Windows.Forms.Button addNewSummonerButton;
        private System.Windows.Forms.Button addMatchHistoryButton;
        private System.Windows.Forms.Button activeGameButton;
        private System.Windows.Forms.FlowLayoutPanel matchHistoryFlowLayoutPanel;
    }
}