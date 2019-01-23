/**
 *  @作者 Tiger
 *  @创建 2019-1-23 15:09:39
 *  @说明 比较文件
 **/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace ComputerScanner
{
    public class CompareFileAction
    {
        private static CompareFileAction mIns; //实例
        private String mLastResult = "Last.result"; //存储上次扫描结果
        private Dictionary<String, String> mLast = new Dictionary<String, String>(); //上次扫描信息
        private Dictionary<String, String> mCur = new Dictionary<String, String>(); //本次扫描信息
        private List<String> mNew = new List<String>(); //新增文件
        private List<String> mModify = new List<String>(); //修改文件
        private delegate void CompareFileDelegate(); //委托

        //获取实例
        public static CompareFileAction Ins { get { return mIns ?? (mIns = new CompareFileAction()); } }

        //获取新增文件
        public List<String> New { get { return mNew; } }

        //获取修改文件
        public List<String> Modify { get { return mModify; } }

        //执行
        public void Excute()
        {
            CompareFileDelegate compareFileDelegate = new CompareFileDelegate(ExcuteImpl);
            compareFileDelegate.BeginInvoke((callback) =>
            {
                MessageManager.Add(String.Format("完成文件比较"));
                compareFileDelegate.EndInvoke(callback);
            }, null);
        }

        //执行
        private void ExcuteImpl()
        {
            MessageManager.Add(String.Format("加载上次扫描结果"));
            mLast.Clear();
            if (File.Exists(mLastResult))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(mLastResult);
                foreach (XmlNode nodeIter in xmlDoc.SelectNodes("//File"))
                {
                    mLast.Add(nodeIter.Attributes["Path"].Value, nodeIter.Attributes["Time"].Value);
                }
            }
            ProgressManager.Set(1, 4);

            MessageManager.Add(String.Format("扫描磁盘文件"));
            mCur.Clear();
            List<DirectoryInfo> dirs = SearchDiskAction.Instance.GetDirs();
            for (int i = 0; i < dirs.Count; ++i)
            {
                MessageManager.Add(String.Format("扫描目录{0}", dirs[i].FullName));
                ProgressManager.Set(i, dirs.Count);
                foreach (FileInfo fileInfoIter in dirs[i].GetFiles())
                {
                    mCur.Add(fileInfoIter.FullName, fileInfoIter.LastWriteTime.ToLocalTime().ToString());
                }
            }
            ProgressManager.Set(2, 4);

            MessageManager.Add(String.Format("比较磁盘文件"));
            mNew.Clear();
            mModify.Clear();
            List<String> lastFiles = mLast.Keys.ToList<String>();
            List<String> curFiles = mCur.Keys.ToList<String>();
            mNew = curFiles.Except(lastFiles).ToList();
            int index = 0;
            foreach (var iter in mCur)
            {
                if (mLast.ContainsKey(iter.Key) && mLast[iter.Key] != iter.Value)
                {
                    mModify.Add(iter.Key);
                }
                ProgressManager.Set(++index, mCur.Count);
            }
            ProgressManager.Set(3, 4);

            MessageManager.Add(String.Format("保存扫描结果"));
            XmlDocument saveXmlDoc = new XmlDocument();
            XmlUtil.CreateChild(saveXmlDoc, "Files");
            XmlNode tarNode = saveXmlDoc.SelectSingleNode("//Files");
            index = 0;
            foreach (var iter in mCur)
            {
                XmlUtil.CreateChild(tarNode, "File");
                XmlNode childNode = tarNode.LastChild;
                XmlUtil.CreateAttribute(tarNode, "Path", iter.Key);
                XmlUtil.CreateAttribute(tarNode, "Time", iter.Value);
            }
            ProgressManager.Set(4, 4);
        }
    }
}