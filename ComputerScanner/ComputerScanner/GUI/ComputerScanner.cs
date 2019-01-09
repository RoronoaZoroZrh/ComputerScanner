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
            String statusText = MessageManager.Get();
            if (!String.IsNullOrWhiteSpace(statusText))
            {
                ProgressBar.Text = statusText;
            }
        }

        //扫描磁盘
        private void ButtonSearchDisk_Click(object sender, EventArgs e) { SearchDiskAction.Instance.Excute(); }
    }
}