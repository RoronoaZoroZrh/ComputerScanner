/**
 *  @作者 Tiger
 *  @创建 2019-01-09 21:17:45
 *  @说明 扫描磁盘
 **/
using System;
using System.Collections.Generic;
using System.IO;

namespace ComputerScanner
{
    //扫描磁盘
    public class SearchDiskAction
    {
        private static SearchDiskAction mInstance; //实例
        private List<String> mErrDirs = new List<String>(); //出错目录
        private List<DirectoryInfo> mDirs = new List<DirectoryInfo>(); //所有目录
        private delegate void SearchDiskDelegate(); //委托

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
                MessageManager.Add(String.Format("完成磁盘扫描"));
                searchDiskDelegate.EndInvoke(callback);
            }, null);
        }

        //执行
        private void ExcuteImpl()
        {
            foreach (String disk in FileSystemUtil.GetDisks())
            {
                MessageManager.Add(String.Format("扫描{0}中...", disk.TrimEnd('\\').TrimEnd(':')));
                Queue<DirectoryInfo> searchQueue = new Queue<DirectoryInfo>(new List<DirectoryInfo> { new DirectoryInfo(disk) });
                while (searchQueue.Count > 0)
                {
                    DirectoryInfo searchDirInfo = searchQueue.Dequeue();
                    try
                    {
                        foreach (DirectoryInfo dirInfo in FileSystemUtil.GetSubDirectories(searchDirInfo.FullName)) searchQueue.Enqueue(dirInfo);
                        mDirs.Add(searchDirInfo);
                    }
                    catch (Exception) { mErrDirs.Add(searchDirInfo.FullName); }
                }
            }
        }
    }
}