using System;
using System.Collections.Generic;
using System.IO;

namespace ComputerScanner
{
    //扫描磁盘
    public class SearchDiskAction
    {
        private static SearchDiskAction mInstance; //实例
        private delegate void SearchDiskDelegate(); //委托
        private List<String> mErrDirs = new List<String>(); //出错目录

        //获取实例
        public static SearchDiskAction Instance { get { return mInstance ?? (mInstance = new SearchDiskAction()); } }

        //获取出错目录
        public List<String> GetErrDirs() { return mErrDirs; }

        //执行
        public void Excute()
        {
            SearchDiskDelegate searchDiskDelegate = new SearchDiskDelegate(ExcuteImpl);
            searchDiskDelegate.BeginInvoke((callback) =>
            {
                MessageManager.Add(String.Format("{0} {1}", DateTime.Now.ToLocalTime(), "结束扫描磁盘"));
                searchDiskDelegate.EndInvoke(callback);
            }, null);
        }

        //执行
        private void ExcuteImpl()
        {
            MessageManager.Add(String.Format("{0} {1}", DateTime.Now.ToLocalTime(), "开始扫描磁盘"));
            foreach (String disk in FileSystemUtil.GetDisks())
            {
                MessageManager.Add(String.Format("{0} {1}{2}", DateTime.Now.ToLocalTime(), "开始扫描磁盘", disk));
                Queue<DirectoryInfo> searchQueue = new Queue<DirectoryInfo>(new List<DirectoryInfo> { new DirectoryInfo(disk) });
                while (searchQueue.Count > 0)
                {
                    DirectoryInfo searchDirInfo = searchQueue.Dequeue();
                    try
                    {
                        foreach (DirectoryInfo dirInfo in FileSystemUtil.GetSubDirectories(searchDirInfo.FullName)) searchQueue.Enqueue(dirInfo);
                    }
                    catch (Exception exception)
                    {
                        mErrDirs.Add(searchDirInfo.FullName);
                        MessageManager.Add(String.Format("访问目录{0}出错，出错信息{1}", searchDirInfo.FullName, exception.Message));
                    }
                }
            }
        }
    }
}