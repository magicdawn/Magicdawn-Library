using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Magicdawn
{
    //Windows方面,内存
    /// <summary>
    /// Windows内存操作
    /// </summary>
    public static class MemoryHelper
    {
        //读写用到的进程名
        /// <summary>
        /// 读写用到的进程名
        /// </summary>
        public static string ProcessName { get; set; }

        #region 读
        static IntPtr Read(int address)
        {
            //四字节
            byte[] buffer = new byte[4];
            //获取数组头地址,因为API函数没有返回值,传的是引用
            var bufferHeadAddress = Marshal.UnsafeAddrOfPinnedArrayElement(buffer, 0);

            try
            {
                //打开进程
                var handle = Win32.Api.OpenProcess(Win32.Consts.PROCESS_ALL_ACCESS, false,
                    ProcessHelper.GetIdByName(MemoryHelper.ProcessName));
                //读取到buffer
                Win32.Api.ReadProcessMemory(handle, (IntPtr)address, buffer, 4, 0);
                //关闭进程
                Win32.Api.CloseHandle(handle);
            }
            catch (Exception)
            {
                Debug.WriteLine("读取内存发生错误...");
            }
            //返回buffer的地址
            return bufferHeadAddress;
        }
        //读取dword,四个字节
        /// <summary>
        /// 读取dword,四个字节
        /// </summary>
        /// <param name="address">首地址</param>
        /// <returns></returns>
        public static int ReadInt(int address)
        {
            return Marshal.ReadInt32(Read(address));
        }
        //读取一个字型,两个字节
        /// <summary>
        /// 读取一个字型,两个字节
        /// </summary>
        /// <param name="address">首地址</param>
        /// <returns></returns>
        public static int ReadWord(int address)
        {
            return Marshal.ReadInt16(Read(address));
        }
        //读取单个字节
        /// <summary>
        /// 读取单个字节
        /// </summary>
        /// <param name="address">首地址</param>
        /// <returns></returns>
        public static int ReadByte(int address)
        {
            return Marshal.ReadByte(Read(address));
        }
        #endregion

        #region 写
        static bool Write(int address, int value, int bits)
        {
            try
            {
                byte[] buffer = BitConverter.GetBytes(value);
                //打开进程
                var handle = Win32.Api.OpenProcess(Win32.Consts.PROCESS_ALL_ACCESS, false,
                        ProcessHelper.GetIdByName(MemoryHelper.ProcessName));
                //写入,必须以数组形式提供
                Win32.Api.WriteProcessMemory(handle, (IntPtr)address, buffer, bits, 0);
                //关闭进程
                Win32.Api.CloseHandle(handle);

                return true;//成功
            }
            catch (Exception)
            {
                return false;//失败
            }
        }
        //写入dword,即int32,四字节
        /// <summary>
        /// 写入dword,即int32,四字节
        /// </summary>
        /// <param name="address">首地址</param>
        /// <param name="value">要写入的值</param>
        /// <returns>是否成功写入</returns>
        public static bool WriteInt(int address, int value)
        {
            return Write(address, value, 4);
        }
        //写word,两个字节
        /// <summary>
        /// 写word,两个字节
        /// </summary>
        /// <param name="address">首地址</param>
        /// <param name="value">要写入的值</param>
        /// <returns>是否成功写入</returns>
        public static bool WriteWord(int address, int value)
        {
            return Write(address, value, 2);
        }
        //写单个字节
        /// <summary>
        /// 写单个字节
        /// </summary>
        /// <param name="address">首地址</param>
        /// <param name="value">要写入的值</param>
        /// <returns>是否成功希尔</returns>
        public static bool WriteByte(int address, int value)
        {
            return Write(address, value, 1);
        }
        #endregion
    }
}
