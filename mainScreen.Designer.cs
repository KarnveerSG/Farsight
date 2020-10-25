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
            this.addNewSummonerButtton = new System.Windows.Forms.Button();
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
            // addNewSummonerButtton
            // 
            this.addNewSummonerButtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewSummonerButtton.Location = new System.Drawing.Point(203, 12);
            this.addNewSummonerButtton.Name = "addNewSummonerButtton";
            this.addNewSummonerButtton.Size = new System.Drawing.Size(185, 28);
            this.addNewSummonerButtton.TabIndex = 1;
            this.addNewSummonerButtton.Text = "Add New Summoner";
            this.addNewSummonerButtton.UseVisualStyleBackColor = true;
            this.addNewSummonerButtton.Click += new System.EventHandler(this.addNewSummonerButtton_Click);
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addNewSummonerButtton);
            this.Controls.Add(this.summonerAccounts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainScreen";
            this.Text = "mainScreen";
            this.Load += new System.EventHandler(this.mainScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox summonerAccounts;
        private System.Windows.Forms.Button addNewSummonerButtton;
    }
}