/**
 *  @作者 Tiger
 *  @创建 2019-01-08 22:58:51
 *  @说明 封装.Net文件操作
 *  @更新 2019-1-9 09:53:43 增加接口GetDisks
 *  @更新 2019-1-9 16:46:22 增加接口GetSubDirectories
 **/
using System;
using System.Collections.Generic;
using System.IO;

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

        //获取子目录
        public static DirectoryInfo[] GetSubDirectories(String dirPath)
        {
            if (Directory.Exists(dirPath))
            {
                return new DirectoryInfo(dirPath).GetDirectories();
            }
            return null;
        }

        //获取子文件
        public static FileInfo[] GetSubFileInfos(String dirPath)
        {
            if (Directory.Exists(dirPath))
            {
                return new DirectoryInfo(dirPath).GetFiles();
            }
            return null;
        }
    }
}