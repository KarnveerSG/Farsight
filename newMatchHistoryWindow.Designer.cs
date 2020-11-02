namespace Farsight
{
    partial class newMatchHistoryWindow
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
            this.matchNumberBox = new System.Windows.Forms.ComboBox();
            this.matchHistoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // matchNumberBox
            // 
            this.matchNumberBox.FormattingEnabled = true;
            this.matchNumberBox.Location = new System.Drawing.Point(12, 26);
            this.matchNumberBox.Name = "matchNumberBox";
            this.matchNumberBox.Size = new System.Drawing.Size(121, 21);
            this.matchNumberBox.TabIndex = 0;
            // 
            // matchHistoryButton
            // 
            this.matchHistoryButton.Location = new System.Drawing.Point(140, 26);
            this.matchHistoryButton.Name = "matchHistoryButton";
            this.matchHistoryButton.Size = new System.Drawing.Size(75, 23);
            this.matchHistoryButton.TabIndex = 1;
            this.matchHistoryButton.Text = "Go!";
            this.matchHistoryButton.UseVisualStyleBackColor = true;
            this.matchHistoryButton.Click += new System.EventHandler(this.matchHistoryButton_Click);
            // 
            // newMatchHistoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 250);
            this.Controls.Add(this.matchHistoryButton);
            this.Controls.Add(this.matchNumberBox);
            this.Name = "newMatchHistoryWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox matchNumberBox;
        private System.Windows.Forms.Button matchHistoryButton;
    }
}