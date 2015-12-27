namespace MiniWordPanel
{
    partial class MiniwordPanelForm
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
            this.components = new System.ComponentModel.Container();
            this.ChooseCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.PaneMenuStrip = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explanationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WordPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.PaneMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseCheckedListBox
            // 
            this.ChooseCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChooseCheckedListBox.FormattingEnabled = true;
            this.ChooseCheckedListBox.Items.AddRange(new object[] {
            "TOEFL",
            "GRE",
            "Graduate Exam",
            "Other"});
            this.ChooseCheckedListBox.Location = new System.Drawing.Point(26, 31);
            this.ChooseCheckedListBox.Name = "ChooseCheckedListBox";
            this.ChooseCheckedListBox.Size = new System.Drawing.Size(142, 88);
            this.ChooseCheckedListBox.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartButton.Location = new System.Drawing.Point(174, 61);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 29);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PaneMenuStrip
            // 
            this.PaneMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.PaneMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PaneMenuStrip.Name = "PaneMenuStrip";
            this.PaneMenuStrip.Size = new System.Drawing.Size(292, 24);
            this.PaneMenuStrip.TabIndex = 2;
            this.PaneMenuStrip.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem1});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // ExitToolStripMenuItem1
            // 
            this.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
            this.ExitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.ExitToolStripMenuItem1.Text = "Exit";
            this.ExitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactToolStripMenuItem,
            this.explanationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // explanationToolStripMenuItem
            // 
            this.explanationToolStripMenuItem.Name = "explanationToolStripMenuItem";
            this.explanationToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.explanationToolStripMenuItem.Text = "Explanation";
            this.explanationToolStripMenuItem.Click += new System.EventHandler(this.explanationToolStripMenuItem_Click);
            // 
            // WordPanelTimer
            // 
            this.WordPanelTimer.Interval = 10000;
            this.WordPanelTimer.Tick += new System.EventHandler(this.WordPanelTimer_Tick);
            // 
            // MiniwordPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 151);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ChooseCheckedListBox);
            this.Controls.Add(this.PaneMenuStrip);
            this.MainMenuStrip = this.PaneMenuStrip;
            this.Name = "MiniwordPanelForm";
            this.Text = "MiniwordPanel";
            this.TopMost = true;
            this.PaneMenuStrip.ResumeLayout(false);
            this.PaneMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ChooseCheckedListBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.MenuStrip PaneMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explanationToolStripMenuItem;
        private System.Windows.Forms.Timer WordPanelTimer;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}

