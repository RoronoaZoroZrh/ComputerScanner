/**
 *  @作者 Tiger
 *  @创建 2019-01-08 22:58:51
 *  @说明 封装.Net文件操作
 *  @更新 
 **/
using System;
using System.Collections.Generic;
using System.IO;

namespace ComputerScanner
{
    //文件帮助类
    public class FileSystemUtil
    {
        //获取指定目录文件信息
        public static Dictionary<String, FileInfo> GetDirInfo(String dirPath)
        {
            Dictionary<String, FileInfo> searchResult = new Dictionary<String, FileInfo>();
            if (Directory.Exists(dirPath))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
                foreach (FileInfo fileInfo in dirInfo.GetFiles("*", SearchOption.AllDirectories))
                {
                    searchResult.Add(fileInfo.FullName, fileInfo);
                }
            }
            return searchResult;
        }
    }
}