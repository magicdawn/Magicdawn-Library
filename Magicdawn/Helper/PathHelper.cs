using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Magicdawn
{
    //TODO: 测试类
    public class PathHelper
    {
        #region 文件名
        /// <summary>
        /// 从文件完整路径获取 文件名
        /// </summary>
        /// <param name="path"></param>
        public static string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }
        #endregion

        #region 扩展名
        //从一个文件名获取,包括点号
        public static string GetExtensionFromFilename(string filename)
        {
            return filename.Substring(filename.LastIndexOf('.'));
        }
        //从一个路径获取扩展名
        public static string GetExtensionFromPath(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }
        #endregion
    }
}
