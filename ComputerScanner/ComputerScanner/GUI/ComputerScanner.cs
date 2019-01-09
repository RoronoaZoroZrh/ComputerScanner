using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ComputerScanner
{
    //窗口类
    public partial class ComputerScanner : Form
    {
        //构造函数
        public ComputerScanner() { InitializeComponent(); }

        //扫描磁盘
        private void ToolStripSearchDisk_Click(object sender, EventArgs e)
        {
            List<String> disks = FileSystemUtil.GetDisks();
        }
    }
}