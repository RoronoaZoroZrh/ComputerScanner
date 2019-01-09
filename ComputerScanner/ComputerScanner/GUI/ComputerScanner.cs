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
            String newMsg = String.Format("{0}{1}", String.Join(Environment.NewLine, MessageManager.Get().ToArray()), Environment.NewLine);
            if (!String.IsNullOrWhiteSpace(newMsg))
            {
                RichTextBoxOutputResult.Text += newMsg;
                RichTextBoxOutputResult.Focus();
                RichTextBoxOutputResult.Select(RichTextBoxOutputResult.Text.Length, 0);
                RichTextBoxOutputResult.ScrollToCaret();
            }
        }

        //扫描磁盘
        private void ToolStripSearchDisk_Click(object sender, EventArgs e) { SearchDiskAction.Instance.Excute(); }
    }
}