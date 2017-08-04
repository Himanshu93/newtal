namespace newtal
{
    partial class openForm
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
            this.tscMainContainer = new System.Windows.Forms.ToolStripContainer();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.filToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsStrip = new System.Windows.Forms.StatusStrip();
            this.tsProgressStatusBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlBackgroundMain = new System.Windows.Forms.Panel();
            this.tscMainContainer.BottomToolStripPanel.SuspendLayout();
            this.tscMainContainer.ContentPanel.SuspendLayout();
            this.tscMainContainer.TopToolStripPanel.SuspendLayout();
            this.tscMainContainer.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.stsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscMainContainer
            // 
            // 
            // tscMainContainer.BottomToolStripPanel
            // 
            this.tscMainContainer.BottomToolStripPanel.Controls.Add(this.stsStrip);
            // 
            // tscMainContainer.ContentPanel
            // 
            this.tscMainContainer.ContentPanel.Controls.Add(this.pnlBackgroundMain);
            this.tscMainContainer.ContentPanel.Size = new System.Drawing.Size(1297, 668);
            this.tscMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscMainContainer.Location = new System.Drawing.Point(0, 0);
            this.tscMainContainer.Name = "tscMainContainer";
            this.tscMainContainer.Size = new System.Drawing.Size(1297, 714);
            this.tscMainContainer.TabIndex = 0;
            this.tscMainContainer.Text = "Newtal";
            // 
            // tscMainContainer.TopToolStripPanel
            // 
            this.tscMainContainer.TopToolStripPanel.Controls.Add(this.menuStripMain);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1297, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // filToolStripMenuItem
            // 
            this.filToolStripMenuItem.Name = "filToolStripMenuItem";
            this.filToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.filToolStripMenuItem.Text = "File";
            this.filToolStripMenuItem.Click += new System.EventHandler(this.filToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // stsStrip
            // 
            this.stsStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.stsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgressStatusBar,
            this.tsslblStatus});
            this.stsStrip.Location = new System.Drawing.Point(0, 0);
            this.stsStrip.Name = "stsStrip";
            this.stsStrip.Size = new System.Drawing.Size(1297, 22);
            this.stsStrip.TabIndex = 0;
            // 
            // tsProgressStatusBar
            // 
            this.tsProgressStatusBar.Name = "tsProgressStatusBar";
            this.tsProgressStatusBar.Size = new System.Drawing.Size(100, 16);
            // 
            // tsslblStatus
            // 
            this.tsslblStatus.Name = "tsslblStatus";
            this.tsslblStatus.Size = new System.Drawing.Size(62, 17);
            this.tsslblStatus.Text = "*Running*";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // pnlBackgroundMain
            // 
            this.pnlBackgroundMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackgroundMain.Location = new System.Drawing.Point(0, 0);
            this.pnlBackgroundMain.Name = "pnlBackgroundMain";
            this.pnlBackgroundMain.Size = new System.Drawing.Size(1297, 668);
            this.pnlBackgroundMain.TabIndex = 0;
            this.pnlBackgroundMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // openForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1297, 714);
            this.Controls.Add(this.tscMainContainer);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "openForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Newtal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tscMainContainer.BottomToolStripPanel.ResumeLayout(false);
            this.tscMainContainer.BottomToolStripPanel.PerformLayout();
            this.tscMainContainer.ContentPanel.ResumeLayout(false);
            this.tscMainContainer.TopToolStripPanel.ResumeLayout(false);
            this.tscMainContainer.TopToolStripPanel.PerformLayout();
            this.tscMainContainer.ResumeLayout(false);
            this.tscMainContainer.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.stsStrip.ResumeLayout(false);
            this.stsStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscMainContainer;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem filToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stsStrip;
        private System.Windows.Forms.ToolStripProgressBar tsProgressStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslblStatus;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel pnlBackgroundMain;
    }
}

