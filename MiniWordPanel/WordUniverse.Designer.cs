namespace MiniWordPanel
{
    partial class WordUniverse
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
            this.WordPhTextBox = new System.Windows.Forms.TextBox();
            this.TranslateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WordPhTextBox
            // 
            this.WordPhTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WordPhTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.WordPhTextBox.Location = new System.Drawing.Point(-2, -2);
            this.WordPhTextBox.Name = "WordPhTextBox";
            this.WordPhTextBox.Size = new System.Drawing.Size(387, 32);
            this.WordPhTextBox.TabIndex = 0;
            this.WordPhTextBox.Text = "加载中,请稍后......";
            // 
            // TranslateTextBox
            // 
            this.TranslateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TranslateTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.TranslateTextBox.Location = new System.Drawing.Point(-2, 30);
            this.TranslateTextBox.Name = "TranslateTextBox";
            this.TranslateTextBox.Size = new System.Drawing.Size(387, 23);
            this.TranslateTextBox.TabIndex = 1;
            this.TranslateTextBox.Text = "Loading, please wait.";
            // 
            // WordUniverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 51);
            this.Controls.Add(this.TranslateTextBox);
            this.Controls.Add(this.WordPhTextBox);
            this.Name = "WordUniverse";
            this.Text = "Word Universe";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WordUniverse_FormClosing);
            this.Load += new System.EventHandler(this.WordUniverse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox WordPhTextBox;
        private System.Windows.Forms.TextBox TranslateTextBox;

    }
}