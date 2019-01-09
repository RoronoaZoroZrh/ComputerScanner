using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ComputerScanner
{
    //窗口类
    public partial class ComputerScanner : Form
    {
        //构造函数
        public ComputerScanner() { InitializeComponent(); }

        //添加显示信息
        private void AddOutputInfo(String info) { RichTextBoxOutputResult.Text = String.Format("{0}{1}{2}", RichTextBoxOutputResult.Text, info, Environment.NewLine); }

        //扫描磁盘
        private void ToolStripSearchDisk_Click(object sender, EventArgs e)
        {
            AddOutputInfo(String.Format("{0} 开始扫描磁盘", DateTime.Now.ToLocalTime()));
            List<String> disks = FileSystemUtil.GetDisks();
            foreach (String disk in disks)
            {
                AddOutputInfo(String.Format("{0} 扫描\"{1}\"", DateTime.Now.ToLocalTime(), disk));
                List<String> errDirs = new List<String>();
                Dictionary<String, FileInfo> dirInfo = FileSystemUtil.GetDirInfo(disk, errDirs);
                AddOutputInfo(String.Format("不可访问目录如下{0}{1}", Environment.NewLine, String.Format(Environment.NewLine, errDirs.ToArray())));

            }
            AddOutputInfo(String.Format("{0} 结束扫描磁盘", DateTime.Now.ToLocalTime()));
        }
    }
}