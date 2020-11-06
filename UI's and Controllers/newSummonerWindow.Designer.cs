namespace Farsight
{
    partial class newSummonerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newSummonerWindow));
            this.button1 = new System.Windows.Forms.Button();
            this.summonerNameTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(108, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // summonerNameTxtBox
            // 
            this.summonerNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summonerNameTxtBox.Location = new System.Drawing.Point(58, 12);
            this.summonerNameTxtBox.Name = "summonerNameTxtBox";
            this.summonerNameTxtBox.Size = new System.Drawing.Size(210, 26);
            this.summonerNameTxtBox.TabIndex = 1;
            this.summonerNameTxtBox.Text = "Add New Summoner";
            this.summonerNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.summonerNameTxtBox.Click += new System.EventHandler(this.summonerNameTxtBox_Click);
            this.summonerNameTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.summonerNameTxtBox_KeyDown);
            // 
            // newSummonerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 97);
            this.Controls.Add(this.summonerNameTxtBox);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newSummonerWindow";
            this.Text = "Add New Summoner";
            this.Load += new System.EventHandler(this.newSummonerWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox summonerNameTxtBox;
    }
}

