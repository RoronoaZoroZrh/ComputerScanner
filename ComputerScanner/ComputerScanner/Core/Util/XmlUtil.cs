/**
 *  @作者 Tiger
 *  @创建 2019-01-09 21:04:25
 *  @说明 封装标记语言操作
 *  @更新 2019-01-09 21:04:56 增加接口CreateChild
 **/
using System;
using System.Xml;

namespace ComputerScanner
{
    //标记语言帮助类
    public class XmlUtil
    {
        //生成子节点
        public static void CreateChild(XmlNode pNode, String childNodeName, String childNodeInnerText = "")
        {
            if (pNode != null)
            {
                XmlNode tarNode = pNode.OwnerDocument.CreateElement(childNodeName);
                if (!String.IsNullOrWhiteSpace(childNodeInnerText))
                {
                    tarNode.InnerText = childNodeInnerText;
                }
                pNode.AppendChild(tarNode);
            }
        }
    }
}