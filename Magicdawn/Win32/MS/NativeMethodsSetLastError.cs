using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;

namespace Magicdawn.Win32.MS
{
    [SuppressUnmanagedCodeSecurity, SecurityCritical(SecurityCriticalScope.Everything)]
    internal static class NativeMethodsSetLastError
    {
        // Fields
        private const string COMPLUS_InstallRoot = "COMPLUS_InstallRoot";
        private const string COMPLUS_Version = "COMPLUS_Version";
        private const string DOTNET_Install_RegValue = "InstallRoot";
        private const string DOTNET_RegKey = @"Software\Microsoft\.NETFramework";
        private const string EnvironmentVariables = "COMPLUS_Version;COMPLUS_InstallRoot";
        private const string FRAMEWORK_InstallPath_RegValue = "InstallPath";
        private const string FRAMEWORK_RegKey = @"Software\Microsoft\Net Framework Setup\NDP\v4\Client\";
        private const string FRAMEWORK_RegKey_FullPath = @"HKEY_LOCAL_MACHINE\Software\Microsoft\Net Framework Setup\NDP\v4\Client\";
        private const string PresentationNativeDll = "PresentationNative_v0400.dll";
        private const string WPF_SUBDIR = "WPF";

        // Methods
        static NativeMethodsSetLastError()
        {
            EnsureLoaded();
        }

        [DllImport("PresentationNative_v0400.dll", EntryPoint = "EnableWindowWrapper", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern bool EnableWindow(HandleRef hWnd, bool enable);
        private static void EnsureLoaded()
        {
            LoadLibrary(Path.Combine(GetWPFInstallPath(), "PresentationNative_v0400.dll"));
        }

        [DllImport("PresentationNative_v0400.dll", EntryPoint = "GetAncestorWrapper", CharSet = CharSet.Auto)]
        public static extern IntPtr GetAncestor(IntPtr hwnd, int gaFlags);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "GetKeyboardLayoutListWrapper", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int GetKeyboardLayoutList(int size, [Out, MarshalAs(UnmanagedType.LPArray)] IntPtr[] hkls);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "GetParentWrapper", SetLastError = true)]
        public static extern IntPtr GetParent(HandleRef hWnd);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "GetWindowWrapper", SetLastError = true, ExactSpelling = true)]
        public static extern IntPtr GetWindow(IntPtr hWnd, int uCmd);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "GetWindowLongWrapper", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "GetWindowLongWrapper", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowLong(HandleRef hWnd, int nIndex);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "GetWindowLongPtrWrapper", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "GetWindowLongPtrWrapper", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetWindowLongPtr(HandleRef hWnd, int nIndex);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "GetWindowLongPtrWrapper", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern NativeMethods.WndProc GetWindowLongPtrWndProc(HandleRef hWnd, int nIndex);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "GetWindowLongWrapper", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern NativeMethods.WndProc GetWindowLongWndProc(HandleRef hWnd, int nIndex);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "GetWindowTextWrapper", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(HandleRef hWnd, [Out] StringBuilder lpString, int nMaxCount);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "GetWindowTextLengthWrapper", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowTextLength(HandleRef hWnd);
        private static string GetWPFInstallPath()
        {
            string str = null;
            new EnvironmentPermission(EnvironmentPermissionAccess.Read, "COMPLUS_Version;COMPLUS_InstallRoot").Assert();
            try
            {
                string environmentVariable = Environment.GetEnvironmentVariable("COMPLUS_Version");
                if (!string.IsNullOrEmpty(environmentVariable))
                {
                    str = Environment.GetEnvironmentVariable("COMPLUS_InstallRoot");
                    if (string.IsNullOrEmpty(str))
                    {
                        str = ReadLocalMachineString(@"Software\Microsoft\.NETFramework", "InstallRoot");
                    }
                    if (!string.IsNullOrEmpty(str))
                    {
                        str = Path.Combine(str, environmentVariable);
                    }
                }
            }
            finally
            {
                CodeAccessPermission.RevertAssert();
            }
            if (string.IsNullOrEmpty(str))
            {
                str = ReadLocalMachineString(@"Software\Microsoft\Net Framework Setup\NDP\v4\Client\", "InstallPath");
            }
            return Path.Combine(str, "WPF");
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr LoadLibrary(string lpFileName);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "MapWindowPointsWrapper", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int MapWindowPoints(HandleRef hWndFrom, HandleRef hWndTo, [In, Out] ref NativeMethods.RECT rect, int cPoints);
        private static string ReadLocalMachineString(string key, string valueName)
        {
            string pathList = @"HKEY_LOCAL_MACHINE\" + key;
            new RegistryPermission(RegistryPermissionAccess.Read, pathList).Assert();
            return (Registry.GetValue(pathList, valueName, null) as string);
        }

        [DllImport("PresentationNative_v0400.dll", EntryPoint = "SetFocusWrapper", SetLastError = true)]
        public static extern IntPtr SetFocus(HandleRef hWnd);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "SetWindowLongWrapper", CharSet = CharSet.Auto)]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "SetWindowLongWrapper", CharSet = CharSet.Auto)]
        public static extern int SetWindowLong(HandleRef hWnd, int nIndex, int dwNewLong);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "SetWindowLongPtrWrapper", CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, IntPtr dwNewLong);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "SetWindowLongPtrWrapper", CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLongPtr(HandleRef hWnd, int nIndex, IntPtr dwNewLong);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "SetWindowLongPtrWrapper", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SetWindowLongPtrWndProc(HandleRef hWnd, int nIndex, NativeMethods.WndProc dwNewLong);
        [DllImport("PresentationNative_v0400.dll", EntryPoint = "SetWindowLongWrapper", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SetWindowLongWndProc(HandleRef hWnd, int nIndex, NativeMethods.WndProc dwNewLong);
    }
}
