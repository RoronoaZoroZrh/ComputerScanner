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
            this.PanelMain = new System.Windows.Forms.Panel();
            this.RichTextBoxOutputResult = new System.Windows.Forms.RichTextBox();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.MenuItemDisk = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSearchDisk = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormTimer = new System.Windows.Forms.Timer(this.components);
            this.PanelMain.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.RichTextBoxOutputResult);
            this.PanelMain.Controls.Add(this.MenuBar);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1130, 433);
            this.PanelMain.TabIndex = 0;
            // 
            // RichTextBoxOutputResult
            // 
            this.RichTextBoxOutputResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxOutputResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxOutputResult.Location = new System.Drawing.Point(0, 25);
            this.RichTextBoxOutputResult.Name = "RichTextBoxOutputResult";
            this.RichTextBoxOutputResult.ReadOnly = true;
            this.RichTextBoxOutputResult.Size = new System.Drawing.Size(1130, 408);
            this.RichTextBoxOutputResult.TabIndex = 0;
            this.RichTextBoxOutputResult.Text = "";
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDisk});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1130, 25);
            this.MenuBar.TabIndex = 1;
            this.MenuBar.Text = "MenuBar";
            // 
            // MenuItemDisk
            // 
            this.MenuItemDisk.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSearchDisk});
            this.MenuItemDisk.Name = "MenuItemDisk";
            this.MenuItemDisk.Size = new System.Drawing.Size(44, 21);
            this.MenuItemDisk.Text = "磁盘";
            // 
            // ToolStripSearchDisk
            // 
            this.ToolStripSearchDisk.Name = "ToolStripSearchDisk";
            this.ToolStripSearchDisk.Size = new System.Drawing.Size(180, 22);
            this.ToolStripSearchDisk.Text = "扫描磁盘";
            this.ToolStripSearchDisk.Click += new System.EventHandler(this.ToolStripSearchDisk_Click);
            // 
            // MainFormTimer
            // 
            this.MainFormTimer.Enabled = true;
            this.MainFormTimer.Tick += new System.EventHandler(this.MainFormTimer_Tick);
            // 
            // ComputerScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 433);
            this.Controls.Add(this.PanelMain);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "ComputerScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电脑扫描";
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.RichTextBox RichTextBoxOutputResult;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDisk;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSearchDisk;
        private System.Windows.Forms.Timer MainFormTimer;
    }
}

