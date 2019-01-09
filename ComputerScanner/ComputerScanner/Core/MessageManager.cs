/**
 *  @作者 Tiger
 *  @创建 2019-01-09 21:16:13
 *  @说明 消息管理
 **/
using System;
using System.Collections.Generic;

namespace ComputerScanner
{
    //消息管理
    public class MessageManager
    {
        private static Queue<String> mMessages = new Queue<String>(); //消息列表

        //添加消息
        public static void Add(String message) { lock (mMessages) mMessages.Enqueue(message); }

        //获取消息
        public static String Get()
        {
            lock (mMessages)
            {
                if (mMessages.Count > 0)
                    return mMessages.Dequeue();
                return default(String);
            }
        }
    }
}