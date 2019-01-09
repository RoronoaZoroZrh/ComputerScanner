/**
 *  @作者 Tiger
 *  @创建 2019-01-08 22:58:51
 *  @说明 封装.Net文件操作
 *  @更新 2019-1-9 09:53:43 增加接口GetDisks
 **/
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ComputerScanner
{
    //文件帮助类
    public class FileSystemUtil
    {
        //获取所有磁盘
        public static List<String> GetDisks()
        {
            List<String> searchResult = new List<String>();
            foreach (String diskPath in Environment.GetLogicalDrives())
            {
                searchResult.Add(diskPath);
            }
            return searchResult;
        }

        //获取指定目录文件信息
        public static Dictionary<String, FileInfo> GetDirInfo(String dirPath, List<String> errDirs)
        {
            Dictionary<String, FileInfo> searchResult = new Dictionary<String, FileInfo>();
            if (Directory.Exists(dirPath))
            {
                Queue<DirectoryInfo> searchQueue = new Queue<DirectoryInfo>();
                searchQueue.Enqueue(new DirectoryInfo(dirPath));
                while (searchQueue.Count > 0)
                {
                    DirectoryInfo searchDirInfo = searchQueue.Dequeue();
                    try
                    {
                        foreach (DirectoryInfo subDirInfo in searchDirInfo.GetDirectories()) searchQueue.Enqueue(subDirInfo);
                        foreach (FileInfo fileInfo in searchDirInfo.GetFiles()) searchResult.Add(fileInfo.FullName, fileInfo);
                    }
                    catch (Exception) { errDirs.Add(searchDirInfo.FullName); }
                }
            }
            return searchResult;
        }
    }
}