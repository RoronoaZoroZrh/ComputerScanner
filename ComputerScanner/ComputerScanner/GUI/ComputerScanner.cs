/**
 *  @作者 Tiger
 *  @创建 2019-01-09 21:15:34
 *  @说明 主窗口
 **/
using System;
using System.Windows.Forms;

namespace ComputerScanner
{
    //窗口类
    public partial class ComputerScanner : Form
    {
        //构造函数
        public ComputerScanner() { InitializeComponent(); }

        //定时器
        private void MainFormTimer_Tick(object sender, EventArgs e)
        {
            String tarMsg = MessageManager.Get();
            if (!String.IsNullOrWhiteSpace(tarMsg)) ProgressBar.Text = tarMsg;
            ProgressBar.Value = ProgressManager.GetValue();
            ProgressBar.Maximum = ProgressManager.GetMaxValue();
        }

        //扫描磁盘
        private void ButtonSearchDisk_Click(object sender, EventArgs e) { SearchDiskAction.Instance.Excute(); }

        //比较文件
        private void ButtonCompareFiles_Click(object sender, EventArgs e) { CompareFileAction.Ins.Excute(); }

        //显示错误列表
        private void ToolStripMenuItemShowErrDirs_Click(object sender, EventArgs e)
        {
            ListBoxResult.DataSource = SearchDiskAction.Instance.GetErrDirs();
            ListBoxResult.Refresh();
        }

        //显示新增文件
        private void ToolStripMenuItemShowNewFiles_Click(object sender, EventArgs e)
        {
            ListBoxResult.DataSource = CompareFileAction.Ins.New;
            ListBoxResult.Refresh();
        }

        //显示修改文件
        private void ToolStripMenuItemShowModifyFiles_Click(object sender, EventArgs e)
        {
            ListBoxResult.DataSource = CompareFileAction.Ins.Modify;
            ListBoxResult.Refresh();
        }
    }
}