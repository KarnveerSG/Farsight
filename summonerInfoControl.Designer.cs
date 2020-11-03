namespace Farsight
{
    partial class summonerInfoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.summonerNameLabel = new System.Windows.Forms.Label();
            this.summonerRankLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.summonerProfileIconPictureBox = new Farsight.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.summonerProfileIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // summonerNameLabel
            // 
            this.summonerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summonerNameLabel.ForeColor = System.Drawing.Color.White;
            this.summonerNameLabel.Location = new System.Drawing.Point(8, 160);
            this.summonerNameLabel.Name = "summonerNameLabel";
            this.summonerNameLabel.Size = new System.Drawing.Size(184, 26);
            this.summonerNameLabel.TabIndex = 0;
            this.summonerNameLabel.Text = "Name";
            this.summonerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.summonerNameLabel.Click += new System.EventHandler(this.summonerNameLabel_Click);
            // 
            // summonerRankLabel
            // 
            this.summonerRankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summonerRankLabel.ForeColor = System.Drawing.Color.White;
            this.summonerRankLabel.Location = new System.Drawing.Point(90, 111);
            this.summonerRankLabel.Name = "summonerRankLabel";
            this.summonerRankLabel.Size = new System.Drawing.Size(18, 20);
            this.summonerRankLabel.TabIndex = 2;
            this.summonerRankLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(8, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 2);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // summonerProfileIconPictureBox
            // 
            this.summonerProfileIconPictureBox.Location = new System.Drawing.Point(48, 8);
            this.summonerProfileIconPictureBox.Name = "summonerProfileIconPictureBox";
            this.summonerProfileIconPictureBox.Size = new System.Drawing.Size(100, 100);
            this.summonerProfileIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.summonerProfileIconPictureBox.TabIndex = 1;
            this.summonerProfileIconPictureBox.TabStop = false;
            // 
            // summonerInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.summonerRankLabel);
            this.Controls.Add(this.summonerProfileIconPictureBox);
            this.Controls.Add(this.summonerNameLabel);
            this.Name = "summonerInfoControl";
            this.Size = new System.Drawing.Size(208, 696);
            ((System.ComponentModel.ISupportInitialize)(this.summonerProfileIconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label summonerNameLabel;
        public RoundPictureBox summonerProfileIconPictureBox;
        public System.Windows.Forms.Label summonerRankLabel;
        private System.Windows.Forms.Label label1;
    }
}
