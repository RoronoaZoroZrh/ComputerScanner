namespace ComputerScanner
{
    partial class ComputerScanner
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputerScanner));
            this.MainFormTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuBar = new DevComponents.DotNetBar.RibbonBar();
            this.ButtonSearchDisk = new DevComponents.DotNetBar.ButtonItem();
            this.PanelExcute = new DevComponents.DotNetBar.PanelEx();
            this.ProgressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.ListBoxResult = new System.Windows.Forms.ListBox();
            this.ContextMenuStripFresh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemShowErrDirs = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonCompareFiles = new DevComponents.DotNetBar.ButtonItem();
            this.ToolStripMenuItemShowNewFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemShowModifyFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripFresh.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormTimer
            // 
            this.MainFormTimer.Enabled = true;
            this.MainFormTimer.Tick += new System.EventHandler(this.MainFormTimer_Tick);
            // 
            // MenuBar
            // 
            this.MenuBar.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.MenuBar.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.MenuBar.BackgroundStyle.Class = "";
            this.MenuBar.ContainerControlProcessDialogKey = true;
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonSearchDisk,
            this.ButtonCompareFiles});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1141, 95);
            this.MenuBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.MenuBar.TabIndex = 0;
            // 
            // 
            // 
            this.MenuBar.TitleStyle.Class = "";
            // 
            // 
            // 
            this.MenuBar.TitleStyleMouseOver.Class = "";
            // 
            // ButtonSearchDisk
            // 
            this.ButtonSearchDisk.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonSearchDisk.Icon = ((System.Drawing.Icon)(resources.GetObject("ButtonSearchDisk.Icon")));
            this.ButtonSearchDisk.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonSearchDisk.Name = "ButtonSearchDisk";
            this.ButtonSearchDisk.SubItemsExpandWidth = 14;
            this.ButtonSearchDisk.Text = "扫描磁盘";
            this.ButtonSearchDisk.Click += new System.EventHandler(this.ButtonSearchDisk_Click);
            // 
            // PanelExcute
            // 
            this.PanelExcute.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelExcute.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelExcute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelExcute.Location = new System.Drawing.Point(0, 95);
            this.PanelExcute.Name = "PanelExcute";
            this.PanelExcute.Size = new System.Drawing.Size(1141, 528);
            this.PanelExcute.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelExcute.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelExcute.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelExcute.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelExcute.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelExcute.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelExcute.Style.GradientAngle = 90;
            this.PanelExcute.TabIndex = 4;
            // 
            // ProgressBar
            // 
            // 
            // 
            // 
            this.ProgressBar.BackgroundStyle.Class = "";
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProgressBar.Location = new System.Drawing.Point(0, 95);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(1141, 31);
            this.ProgressBar.TabIndex = 5;
            this.ProgressBar.TextVisible = true;
            // 
            // ListBoxResult
            // 
            this.ListBoxResult.ContextMenuStrip = this.ContextMenuStripFresh;
            this.ListBoxResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListBoxResult.FormattingEnabled = true;
            this.ListBoxResult.ItemHeight = 12;
            this.ListBoxResult.Location = new System.Drawing.Point(0, 126);
            this.ListBoxResult.Name = "ListBoxResult";
            this.ListBoxResult.Size = new System.Drawing.Size(880, 497);
            this.ListBoxResult.TabIndex = 6;
            // 
            // ContextMenuStripFresh
            // 
            this.ContextMenuStripFresh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemShowErrDirs,
            this.ToolStripMenuItemShowNewFiles,
            this.ToolStripMenuItemShowModifyFiles});
            this.ContextMenuStripFresh.Name = "ContextMenuStripFresh";
            this.ContextMenuStripFresh.Size = new System.Drawing.Size(181, 92);
            // 
            // ToolStripMenuItemShowErrDirs
            // 
            this.ToolStripMenuItemShowErrDirs.Name = "ToolStripMenuItemShowErrDirs";
            this.ToolStripMenuItemShowErrDirs.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemShowErrDirs.Text = "显示出错目录列表";
            this.ToolStripMenuItemShowErrDirs.Click += new System.EventHandler(this.ToolStripMenuItemShowErrDirs_Click);
            // 
            // ButtonCompareFiles
            // 
            this.ButtonCompareFiles.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonCompareFiles.Icon = ((System.Drawing.Icon)(resources.GetObject("ButtonCompareFiles.Icon")));
            this.ButtonCompareFiles.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonCompareFiles.Name = "ButtonCompareFiles";
            this.ButtonCompareFiles.SubItemsExpandWidth = 14;
            this.ButtonCompareFiles.Text = "比较文件";
            this.ButtonCompareFiles.Click += new System.EventHandler(this.ButtonCompareFiles_Click);
            // 
            // ToolStripMenuItemShowNewFiles
            // 
            this.ToolStripMenuItemShowNewFiles.Name = "ToolStripMenuItemShowNewFiles";
            this.ToolStripMenuItemShowNewFiles.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemShowNewFiles.Text = "显示新增文件";
            this.ToolStripMenuItemShowNewFiles.Click += new System.EventHandler(this.ToolStripMenuItemShowNewFiles_Click);
            // 
            // ToolStripMenuItemShowModifyFiles
            // 
            this.ToolStripMenuItemShowModifyFiles.Name = "ToolStripMenuItemShowModifyFiles";
            this.ToolStripMenuItemShowModifyFiles.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemShowModifyFiles.Text = "显示修改文件";
            this.ToolStripMenuItemShowModifyFiles.Click += new System.EventHandler(this.ToolStripMenuItemShowModifyFiles_Click);
            // 
            // ComputerScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 623);
            this.Controls.Add(this.ListBoxResult);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.PanelExcute);
            this.Controls.Add(this.MenuBar);
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComputerScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电脑清理大师";
            this.ContextMenuStripFresh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MainFormTimer;
        private DevComponents.DotNetBar.RibbonBar MenuBar;
        private DevComponents.DotNetBar.ButtonItem ButtonSearchDisk;
        private DevComponents.DotNetBar.PanelEx PanelExcute;
        private DevComponents.DotNetBar.Controls.ProgressBarX ProgressBar;
        private System.Windows.Forms.ListBox ListBoxResult;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripFresh;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowErrDirs;
        private DevComponents.DotNetBar.ButtonItem ButtonCompareFiles;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowNewFiles;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowModifyFiles;
    }
}

