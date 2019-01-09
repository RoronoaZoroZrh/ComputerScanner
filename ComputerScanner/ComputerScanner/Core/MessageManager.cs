using System;
using System.Collections.Generic;

namespace ComputerScanner
{
    //消息管理
    public class MessageManager
    {
        private static List<String> mMessages = new List<String>(); //消息列表

        //添加消息
        public static void Add(String message) { lock (mMessages) mMessages.Add(message); }

        //添加消息
        public static void Add(List<String> messages) { lock (mMessages) mMessages.AddRange(messages); }

        //获取消息
        public static List<String> Get()
        {
            lock (mMessages)
            {
                List<String> tar = new List<String>(mMessages);
                mMessages.Clear();
                return tar;
            }
        }
    }
}