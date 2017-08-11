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
            this.stsStrip = new System.Windows.Forms.StatusStrip();
            this.tsProgressStatusBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlpHomeScreen = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTablePanelContainer = new System.Windows.Forms.Panel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.filToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tlpMainMenuContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btn1SelectCompany = new System.Windows.Forms.Button();
            this.btn2CreateCompany = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5Quit = new System.Windows.Forms.Button();
            this.lblMenu1Header = new System.Windows.Forms.Label();
            this.pnlSelectCompany = new System.Windows.Forms.Panel();
            this.tscMainContainer.BottomToolStripPanel.SuspendLayout();
            this.tscMainContainer.ContentPanel.SuspendLayout();
            this.tscMainContainer.TopToolStripPanel.SuspendLayout();
            this.tscMainContainer.SuspendLayout();
            this.stsStrip.SuspendLayout();
            this.tlpHomeScreen.SuspendLayout();
            this.pnlTablePanelContainer.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.tlpMainMenuContainer.SuspendLayout();
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
            this.tscMainContainer.ContentPanel.Controls.Add(this.tlpHomeScreen);
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
            // tlpHomeScreen
            // 
            this.tlpHomeScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tlpHomeScreen.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpHomeScreen.ColumnCount = 4;
            this.tlpHomeScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpHomeScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpHomeScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpHomeScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpHomeScreen.Controls.Add(this.pnlTablePanelContainer, 2, 1);
            this.tlpHomeScreen.Controls.Add(this.pnlSelectCompany, 1, 1);
            this.tlpHomeScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHomeScreen.Location = new System.Drawing.Point(0, 0);
            this.tlpHomeScreen.Name = "tlpHomeScreen";
            this.tlpHomeScreen.RowCount = 2;
            this.tlpHomeScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.247376F));
            this.tlpHomeScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.75262F));
            this.tlpHomeScreen.Size = new System.Drawing.Size(1297, 668);
            this.tlpHomeScreen.TabIndex = 0;
            this.tlpHomeScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpHomeScreen_Paint);
            // 
            // pnlTablePanelContainer
            // 
            this.pnlTablePanelContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTablePanelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTablePanelContainer.Controls.Add(this.tlpMainMenuContainer);
            this.pnlTablePanelContainer.Location = new System.Drawing.Point(788, 176);
            this.pnlTablePanelContainer.Name = "pnlTablePanelContainer";
            this.pnlTablePanelContainer.Size = new System.Drawing.Size(300, 350);
            this.pnlTablePanelContainer.TabIndex = 0;
            this.pnlTablePanelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTablePanelContainer_Paint);
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
            this.filToolStripMenuItem.Text = "&File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
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
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // tlpMainMenuContainer
            // 
            this.tlpMainMenuContainer.ColumnCount = 1;
            this.tlpMainMenuContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainMenuContainer.Controls.Add(this.btn1SelectCompany, 0, 1);
            this.tlpMainMenuContainer.Controls.Add(this.btn3, 0, 3);
            this.tlpMainMenuContainer.Controls.Add(this.btn4, 0, 4);
            this.tlpMainMenuContainer.Controls.Add(this.btn5Quit, 0, 5);
            this.tlpMainMenuContainer.Controls.Add(this.btn2CreateCompany, 0, 2);
            this.tlpMainMenuContainer.Controls.Add(this.lblMenu1Header, 0, 0);
            this.tlpMainMenuContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainMenuContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpMainMenuContainer.Name = "tlpMainMenuContainer";
            this.tlpMainMenuContainer.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.tlpMainMenuContainer.RowCount = 7;
            this.tlpMainMenuContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpMainMenuContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMainMenuContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMainMenuContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMainMenuContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMainMenuContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMainMenuContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpMainMenuContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainMenuContainer.Size = new System.Drawing.Size(298, 348);
            this.tlpMainMenuContainer.TabIndex = 0;
            this.tlpMainMenuContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btn1SelectCompany
            // 
            this.btn1SelectCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1SelectCompany.Location = new System.Drawing.Point(40, 56);
            this.btn1SelectCompany.Name = "btn1SelectCompany";
            this.btn1SelectCompany.Padding = new System.Windows.Forms.Padding(50, 5, 50, 5);
            this.btn1SelectCompany.Size = new System.Drawing.Size(220, 35);
            this.btn1SelectCompany.TabIndex = 0;
            this.btn1SelectCompany.Text = "Select Company";
            this.btn1SelectCompany.UseVisualStyleBackColor = true;
            this.btn1SelectCompany.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2CreateCompany
            // 
            this.btn2CreateCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2CreateCompany.Location = new System.Drawing.Point(40, 108);
            this.btn2CreateCompany.Name = "btn2CreateCompany";
            this.btn2CreateCompany.Padding = new System.Windows.Forms.Padding(50, 5, 50, 5);
            this.btn2CreateCompany.Size = new System.Drawing.Size(220, 35);
            this.btn2CreateCompany.TabIndex = 1;
            this.btn2CreateCompany.Text = "Create Company";
            this.btn2CreateCompany.UseVisualStyleBackColor = true;
            this.btn2CreateCompany.Click += new System.EventHandler(this.btn2CreateCompany_Click);
            // 
            // btn3
            // 
            this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3.Enabled = false;
            this.btn3.Location = new System.Drawing.Point(40, 161);
            this.btn3.Name = "btn3";
            this.btn3.Padding = new System.Windows.Forms.Padding(50, 5, 50, 5);
            this.btn3.Size = new System.Drawing.Size(220, 35);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "    ";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Visible = false;
            // 
            // btn4
            // 
            this.btn4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn4.Enabled = false;
            this.btn4.Location = new System.Drawing.Point(40, 213);
            this.btn4.Name = "btn4";
            this.btn4.Padding = new System.Windows.Forms.Padding(50, 5, 50, 5);
            this.btn4.Size = new System.Drawing.Size(220, 35);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "   ";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Visible = false;
            // 
            // btn5Quit
            // 
            this.btn5Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn5Quit.Location = new System.Drawing.Point(40, 264);
            this.btn5Quit.Name = "btn5Quit";
            this.btn5Quit.Padding = new System.Windows.Forms.Padding(50, 5, 50, 5);
            this.btn5Quit.Size = new System.Drawing.Size(220, 35);
            this.btn5Quit.TabIndex = 4;
            this.btn5Quit.Text = "Quit";
            this.btn5Quit.UseVisualStyleBackColor = true;
            // 
            // lblMenu1Header
            // 
            this.lblMenu1Header.AutoSize = true;
            this.lblMenu1Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenu1Header.Location = new System.Drawing.Point(55, 19);
            this.lblMenu1Header.Name = "lblMenu1Header";
            this.lblMenu1Header.Size = new System.Drawing.Size(175, 25);
            this.lblMenu1Header.TabIndex = 0;
            this.lblMenu1Header.Text = "Gateway of Company";
            this.lblMenu1Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenu1Header.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlSelectCompany
            // 
            this.pnlSelectCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSelectCompany.BackColor = System.Drawing.Color.Gray;
            this.pnlSelectCompany.Location = new System.Drawing.Point(104, 128);
            this.pnlSelectCompany.Name = "pnlSelectCompany";
            this.pnlSelectCompany.Size = new System.Drawing.Size(504, 447);
            this.pnlSelectCompany.TabIndex = 1;
            this.pnlSelectCompany.Visible = false;
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
            this.stsStrip.ResumeLayout(false);
            this.stsStrip.PerformLayout();
            this.tlpHomeScreen.ResumeLayout(false);
            this.pnlTablePanelContainer.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tlpMainMenuContainer.ResumeLayout(false);
            this.tlpMainMenuContainer.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tlpHomeScreen;
        private System.Windows.Forms.Panel pnlTablePanelContainer;
        private System.Windows.Forms.TableLayoutPanel tlpMainMenuContainer;
        private System.Windows.Forms.Button btn1SelectCompany;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5Quit;
        private System.Windows.Forms.Button btn2CreateCompany;
        private System.Windows.Forms.Label lblMenu1Header;
        private System.Windows.Forms.Panel pnlSelectCompany;
    }
}

