namespace Blue_Ward
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
            this.button1 = new System.Windows.Forms.Button();
            this.summonerNameTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // summonerNameTxtBox
            // 
            this.summonerNameTxtBox.Location = new System.Drawing.Point(281, 214);
            this.summonerNameTxtBox.Name = "summonerNameTxtBox";
            this.summonerNameTxtBox.Size = new System.Drawing.Size(210, 20);
            this.summonerNameTxtBox.TabIndex = 1;
            this.summonerNameTxtBox.Text = "Add New Summoner";
            this.summonerNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.summonerNameTxtBox.TextChanged += new System.EventHandler(this.summonerNameTxtBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.summonerNameTxtBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Add New Summoner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox summonerNameTxtBox;
    }
}

