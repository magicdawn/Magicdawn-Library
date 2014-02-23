using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Magicdawn
{
    public static class Md5Helper
    {
        #region 字符串MD5加密
        /// <summary>
        /// 为字符串MD5加密
        /// </summary>
        /// <param name="text">输入字符串</param>
        /// <returns>MD5值</returns>
        public static string Md5Encrypt(string text)
        {
            //采用默认,GB2312编码
            byte[] buffer = MD5.Create().ComputeHash(System.Text.Encoding.Default.GetBytes(text));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < buffer.Length; i++)
            {
                sb.Append(buffer[i].ToString("x2"));
            }
            return sb.ToString();
        } 
        #endregion

        #region 文件加密
        /// <summary>
        /// 文件加密
        /// </summary>
        /// <param name="path">要加密的路径</param>
        /// <returns>MD5值</returns>
        static string Md5EncryptForFile(string path)
        {
            StringBuilder sb = new StringBuilder();
            using (var fs = System.IO.File.OpenRead(path))
            {
                //这个可以直接传流进去
                byte[] buffer = System.Security.Cryptography.MD5.Create().ComputeHash(fs);
                for (int i = 0; i < buffer.Length; i++)
                {
                    sb.Append(buffer[i].ToString("x2"));
                }
            }
            return sb.ToString();
        } 
        #endregion
    }
}