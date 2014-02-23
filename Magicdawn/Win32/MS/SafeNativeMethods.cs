using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Magicdawn.Win32.MS
{
    public static class SafeNativeMethods
    {
        // Fields
        public const ushort C1_BLANK = 0x40;
        public const ushort C1_PUNCT = 0x10;
        public const ushort C1_SPACE = 8;
        public const ushort C3_DIACRITIC = 2;
        public const ushort C3_FULLWIDTH = 0x80;
        public const ushort C3_HALFWIDTH = 0x40;
        public const ushort C3_HIRAGANA = 0x20;
        public const ushort C3_IDEOGRAPH = 0x100;
        public const ushort C3_KASHIDA = 0x200;
        public const ushort C3_KATAKANA = 0x10;
        public const ushort C3_NONSPACING = 1;
        public const ushort C3_VOWELMARK = 4;
        public const uint CT_CTYPE1 = 1;
        public const uint CT_CTYPE2 = 2;
        public const uint CT_CTYPE3 = 4;

        // Methods
        [SecurityCritical, SecurityTreatAsSafe]
        public static IntPtr ActivateKeyboardLayout(HandleRef hkl, int uFlags)
        {
            return SafeNativeMethodsPrivate.ActivateKeyboardLayout(hkl, uFlags);
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static bool AdjustWindowRectEx(ref NativeMethods.RECT lpRect, int dwStyle, bool bMenu, int dwExStyle)
        {
            bool flag = SafeNativeMethodsPrivate.IntAdjustWindowRectEx(ref lpRect, dwStyle, bMenu, dwExStyle);
            if (!flag)
            {
                throw new Win32Exception();
            }
            return flag;
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static bool DestroyCaret()
        {
            return SafeNativeMethodsPrivate.DestroyCaret();
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static IntPtr GetCapture()
        {
            return SafeNativeMethodsPrivate.GetCapture();
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static int GetCaretBlinkTime()
        {
            return SafeNativeMethodsPrivate.GetCaretBlinkTime();
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static void GetClientRect(HandleRef hWnd, [In, Out] ref NativeMethods.RECT rect)
        {
            if (!SafeNativeMethodsPrivate.IntGetClientRect(hWnd, ref rect))
            {
                throw new Win32Exception();
            }
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static int GetCurrentProcessId()
        {
            return SafeNativeMethodsPrivate.GetCurrentProcessId();
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static int GetCurrentThreadId()
        {
            return SafeNativeMethodsPrivate.GetCurrentThreadId();
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static IntPtr GetCursor()
        {
            return SafeNativeMethodsPrivate.GetCursor();
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static int GetDoubleClickTime()
        {
            return SafeNativeMethodsPrivate.GetDoubleClickTime();
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static IntPtr GetKeyboardLayout(int dwLayout)
        {
            return SafeNativeMethodsPrivate.GetKeyboardLayout(dwLayout);
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static int GetKeyboardLayoutList(int size, [Out, MarshalAs(UnmanagedType.LPArray)] IntPtr[] hkls)
        {
            int keyboardLayoutList = NativeMethodsSetLastError.GetKeyboardLayoutList(size, hkls);
            if (keyboardLayoutList == 0)
            {
                int error = Marshal.GetLastWin32Error();
                if (error != 0)
                {
                    throw new Win32Exception(error);
                }
            }
            return keyboardLayoutList;
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static int GetMessagePos()
        {
            return SafeNativeMethodsPrivate.GetMessagePos();
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static int GetMessageTime()
        {
            return SafeNativeMethodsPrivate.GetMessageTime();
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static void GetMonitorInfo(HandleRef hmonitor, [In, Out] NativeMethods.MONITORINFOEX info)
        {
            if (!SafeNativeMethodsPrivate.IntGetMonitorInfo(hmonitor, info))
            {
                throw new Win32Exception();
            }
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static bool GetStringTypeEx(uint locale, uint infoType, char[] sourceString, int count, ushort[] charTypes)
        {
            bool flag = SafeNativeMethodsPrivate.GetStringTypeEx(locale, infoType, sourceString, count, charTypes);
            int error = Marshal.GetLastWin32Error();
            if (!flag)
            {
                throw new Win32Exception(error);
            }
            return flag;
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static int GetSysColor(int nIndex)
        {
            return SafeNativeMethodsPrivate.GetSysColor(nIndex);
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static int GetTickCount()
        {
            return SafeNativeMethodsPrivate.GetTickCount();
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static void GetWindowRect(HandleRef hWnd, [In, Out] ref NativeMethods.RECT rect)
        {
            if (!SafeNativeMethodsPrivate.IntGetWindowRect(hWnd, ref rect))
            {
                throw new Win32Exception();
            }
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static int GetWindowStyle(HandleRef hWnd, bool exStyle)
        {
            int nIndex = exStyle ? -20 : -16;
            return UnsafeNativeMethods.GetWindowLong(hWnd, nIndex);
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static bool InSendMessage()
        {
            return SafeNativeMethodsPrivate.InSendMessage();
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static bool IsClipboardFormatAvailable(int format)
        {
            return SafeNativeMethodsPrivate.IsClipboardFormatAvailable(format);
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static bool IsDebuggerPresent()
        {
            return SafeNativeMethodsPrivate.IsDebuggerPresent();
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static bool IsUxThemeActive()
        {
            return (SafeNativeMethodsPrivate.IsThemeActive() != 0);
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static bool IsWindowEnabled(HandleRef hWnd)
        {
            return SafeNativeMethodsPrivate.IsWindowEnabled(hWnd);
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static bool IsWindowUnicode(HandleRef hWnd)
        {
            return SafeNativeMethodsPrivate.IsWindowUnicode(hWnd);
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static bool IsWindowVisible(HandleRef hWnd)
        {
            return SafeNativeMethodsPrivate.IsWindowVisible(hWnd);
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static bool KillTimer(HandleRef hwnd, int idEvent)
        {
            return SafeNativeMethodsPrivate.KillTimer(hwnd, idEvent);
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static NativeMethods.CursorHandle LoadCursor(HandleRef hInst, IntPtr iconId)
        {
            NativeMethods.CursorHandle handle = SafeNativeMethodsPrivate.LoadCursor(hInst, iconId);
            if ((handle == null) || handle.IsInvalid)
            {
                throw new Win32Exception();
            }
            return handle;
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static int MapVirtualKey(int nVirtKey, int nMapType)
        {
            return SafeNativeMethodsPrivate.MapVirtualKey(nVirtKey, nMapType);
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static int MessageBeep(int uType)
        {
            return SafeNativeMethodsPrivate.MessageBeep(uType);
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static IntPtr MonitorFromPoint(NativeMethods.POINTSTRUCT pt, int flags)
        {
            return SafeNativeMethodsPrivate.MonitorFromPoint(pt, flags);
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static IntPtr MonitorFromRect(ref NativeMethods.RECT rect, int flags)
        {
            return SafeNativeMethodsPrivate.MonitorFromRect(ref rect, flags);
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static IntPtr MonitorFromWindow(HandleRef handle, int flags)
        {
            return SafeNativeMethodsPrivate.MonitorFromWindow(handle, flags);
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static void QueryPerformanceCounter(out long lpPerformanceCount)
        {
            if (!SafeNativeMethodsPrivate.QueryPerformanceCounter(out lpPerformanceCount))
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static void QueryPerformanceFrequency(out long lpFrequency)
        {
            if (!SafeNativeMethodsPrivate.QueryPerformanceFrequency(out lpFrequency))
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static bool ReleaseCapture()
        {
            bool flag = SafeNativeMethodsPrivate.IntReleaseCapture();
            if (!flag)
            {
                throw new Win32Exception();
            }
            return flag;
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static void ScreenToClient(HandleRef hWnd, [In, Out] NativeMethods.POINT pt)
        {
            if (SafeNativeMethodsPrivate.IntScreenToClient(hWnd, pt) == 0)
            {
                throw new Win32Exception();
            }
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static IntPtr SetCapture(HandleRef hwnd)
        {
            return SafeNativeMethodsPrivate.SetCapture(hwnd);
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static bool SetCaretPos(int x, int y)
        {
            return SafeNativeMethodsPrivate.SetCaretPos(x, y);
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static IntPtr SetCursor(HandleRef hcursor)
        {
            return SafeNativeMethodsPrivate.SetCursor(hcursor);
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static IntPtr SetCursor(SafeHandle hcursor)
        {
            return SafeNativeMethodsPrivate.SetCursor(hcursor);
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static void SetTimer(HandleRef hWnd, int nIDEvent, int uElapse)
        {
            if (SafeNativeMethodsPrivate.SetTimer(hWnd, nIDEvent, uElapse, null) == IntPtr.Zero)
            {
                throw new Win32Exception();
            }
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static int ShowCursor(bool show)
        {
            return SafeNativeMethodsPrivate.ShowCursor(show);
        }

        [SecurityCritical, SecurityTreatAsSafe]
        public static bool TrackMouseEvent(NativeMethods.TRACKMOUSEEVENT tme)
        {
            bool flag = SafeNativeMethodsPrivate.TrackMouseEvent(tme);
            int error = Marshal.GetLastWin32Error();
            if (!flag && (error != 0))
            {
                throw new Win32Exception(error);
            }
            return flag;
        }

        [SecurityTreatAsSafe, SecurityCritical]
        public static bool TrySetTimer(HandleRef hWnd, int nIDEvent, int uElapse)
        {
            if (SafeNativeMethodsPrivate.TrySetTimer(hWnd, nIDEvent, uElapse, null) == IntPtr.Zero)
            {
                return false;
            }
            return true;
        }

        // Nested Types
        [Flags]
        public enum PlaySoundFlags
        {
            SND_ALIAS = 0x10000,
            SND_APPLICATION = 0x80,
            SND_ASYNC = 1,
            SND_FILENAME = 0x20000,
            SND_LOOP = 8,
            SND_MEMORY = 4,
            SND_NODEFAULT = 2,
            SND_NOSTOP = 0x10,
            SND_NOWAIT = 0x2000,
            SND_PURGE = 0x40,
            SND_RESOURCE = 0x40000,
            SND_SYNC = 0
        }

        [SuppressUnmanagedCodeSecurity, SuppressUnmanagedCodeSecurity, SecurityCritical(SecurityCriticalScope.Everything)]
        private static class SafeNativeMethodsPrivate
        {
            // Methods
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern IntPtr ActivateKeyboardLayout(HandleRef hkl, int uFlags);
            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool DestroyCaret();
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern IntPtr GetCapture();
            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern int GetCaretBlinkTime();
            [DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern int GetCurrentProcessId();
            [DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern int GetCurrentThreadId();
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern IntPtr GetCursor();
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern int GetDoubleClickTime();
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern IntPtr GetKeyboardLayout(int dwLayout);
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern int GetMessagePos();
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern int GetMessageTime();
            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool GetStringTypeEx(uint locale, uint infoType, char[] sourceString, int count, [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] charTypes);
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern int GetSysColor(int nIndex);
            [DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern int GetTickCount();
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern bool InSendMessage();
            [DllImport("user32.dll", EntryPoint = "AdjustWindowRectEx", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
            public static extern bool IntAdjustWindowRectEx(ref NativeMethods.RECT lpRect, int dwStyle, bool bMenu, int dwExStyle);
            [DllImport("user32.dll", EntryPoint = "GetClientRect", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
            public static extern bool IntGetClientRect(HandleRef hWnd, [In, Out] ref NativeMethods.RECT rect);
            [DllImport("user32.dll", EntryPoint = "GetMonitorInfo", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool IntGetMonitorInfo(HandleRef hmonitor, [In, Out] NativeMethods.MONITORINFOEX info);
            [DllImport("user32.dll", EntryPoint = "GetWindowRect", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
            public static extern bool IntGetWindowRect(HandleRef hWnd, [In, Out] ref NativeMethods.RECT rect);
            [DllImport("user32.dll", EntryPoint = "ReleaseCapture", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
            public static extern bool IntReleaseCapture();
            [DllImport("user32.dll", EntryPoint = "ScreenToClient", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
            public static extern int IntScreenToClient(HandleRef hWnd, [In, Out] NativeMethods.POINT pt);
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern bool IsClipboardFormatAvailable(int format);
            [DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern bool IsDebuggerPresent();
            [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
            public static extern int IsThemeActive();
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern bool IsWindowEnabled(HandleRef hWnd);
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern bool IsWindowUnicode(HandleRef hWnd);
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern bool IsWindowVisible(HandleRef hWnd);
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern bool KillTimer(HandleRef hwnd, int idEvent);
            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern NativeMethods.CursorHandle LoadCursor(HandleRef hInst, IntPtr iconId);
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern int MapVirtualKey(int nVirtKey, int nMapType);
            [DllImport("user32.dll")]
            public static extern int MessageBeep(int uType);
            [DllImport("user32.dll", ExactSpelling = true)]
            public static extern IntPtr MonitorFromPoint(NativeMethods.POINTSTRUCT pt, int flags);
            [DllImport("user32.dll", ExactSpelling = true)]
            public static extern IntPtr MonitorFromRect(ref NativeMethods.RECT rect, int flags);
            [DllImport("user32.dll", SetLastError = true, ExactSpelling = true)]
            public static extern IntPtr MonitorFromWindow(HandleRef handle, int flags);
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool QueryPerformanceCounter(out long lpPerformanceCount);
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool QueryPerformanceFrequency(out long lpFrequency);
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern IntPtr SetCapture(HandleRef hwnd);
            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool SetCaretPos(int x, int y);
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern IntPtr SetCursor(HandleRef hcursor);
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern IntPtr SetCursor(SafeHandle hcursor);
            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
            public static extern IntPtr SetTimer(HandleRef hWnd, int nIDEvent, int uElapse, NativeMethods.TimerProc lpTimerFunc);
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern int ShowCursor(bool show);
            [DllImport("user32.dll", SetLastError = true, ExactSpelling = true)]
            public static extern bool TrackMouseEvent(NativeMethods.TRACKMOUSEEVENT tme);
            [DllImport("user32.dll", EntryPoint = "SetTimer", CharSet = CharSet.Auto)]
            public static extern IntPtr TrySetTimer(HandleRef hWnd, int nIDEvent, int uElapse, NativeMethods.TimerProc lpTimerFunc);
        }
    }
}
