/**
 *  @作者 Tiger
 *  @创建 2019-1-10 09:50:46
 *  @说明 存储进度信息
 **/
using System;

namespace ComputerScanner
{
    //进度管理
    public class ProgressManager
    {
        private static Int32 mValue; //当前值
        private static Int32 mMaxValue; //最大值

        //设置进度
        public static void Set(Int32 value, Int32 maxValue)
        {
            mValue = value;
            mMaxValue = maxValue;
        }

        //获取当前值
        public static Int32 GetValue() { return mValue; }

        //获取最大值
        public static Int32 GetMaxValue() { return mMaxValue; }
    }
}