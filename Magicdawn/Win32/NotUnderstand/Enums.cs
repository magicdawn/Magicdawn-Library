using System;
using System.Text;
namespace Magicdawn.Win32
{
    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum ImageListDrawFlags : int
    {
        /// <summary>
        /// 
        /// </summary>
        ILD_NORMAL = 0x00000000,
        /// <summary>
        /// 
        /// </summary>
        ILD_TRANSPARENT = 0x00000001,
        /// <summary>
        /// 
        /// </summary>
        ILD_BLEND25 = 0x00000002,
        /// <summary>
        /// 
        /// </summary>
        ILD_FOCUS = 0x00000002,
        /// <summary>
        /// 
        /// </summary>
        ILD_BLEND50 = 0x00000004,
        /// <summary>
        /// 
        /// </summary>
        ILD_SELECTED = 0x00000004,
        /// <summary>
        /// 
        /// </summary>
        ILD_BLEND = 0x00000004,
        /// <summary>
        /// 
        /// </summary>
        ILD_MASK = 0x00000010,
        /// <summary>
        /// 
        /// </summary>
        ILD_IMAGE = 0x00000020,
        /// <summary>
        /// 
        /// </summary>
        ILD_ROP = 0x00000040,
        /// <summary>
        /// 
        /// </summary>
        ILD_OVERLAYMASK = 0x00000F00,
        /// <summary>
        /// 
        /// </summary>
        ILD_PRESERVEALPHA = 0x00001000,
        /// <summary>
        /// 
        /// </summary>
        ILD_SCALE = 0x00002000,
        /// <summary>
        /// 
        /// </summary>
        ILD_DPISCALE = 0x00004000,
        /// <summary>
        /// 
        /// </summary>
        ILD_ASYNC = 0x00008000
    }

    /// <summary>
    /// 
    /// </summary>
    public enum ImageListColorFlags : uint
    {
        /// <summary>
        /// 
        /// </summary>
        CLR_NONE = 0xFFFFFFFF,
        /// <summary>
        /// 
        /// </summary>
        CLR_DEFAULT = 0xFF000000,
        /// <summary>
        /// 
        /// </summary>
        CLR_HILIGHT = CLR_DEFAULT,
    }

    /// <summary>
    /// 挂钩处理过程的类型
    /// </summary>
    public enum HookType
    {
        /// <summary>
        /// 安装一个挂钩处理过程, 以监视由对话框、消息框、菜单条、或滚动条中的输入事件引发的消息
        /// </summary>
        WH_MSGFILTER = -1,
        /// <summary>
        /// 安装一个挂钩处理过程,对寄送至系统消息队列的输入消息进行纪录
        /// </summary>
        WH_JOURNALRECORD = 0,
        /// <summary>
        /// 安装一个挂钩处理过程,对此前由WH_JOURNALRECORD 挂钩处理过程纪录的消息进行寄送
        /// </summary>
        WH_JOURNALPLAYBACK = 1,
        /// <summary>
        /// 安装一个挂钩处理过程对击键消息进行监视
        /// </summary>
        WH_KEYBORARD = 2,
        /// <summary>
        /// 安装一个挂钩处理过程对寄送至消息队列的消息进行监视
        /// </summary>
        WH_GETMESSAGE = 3,
        /// <summary>
        /// 安装一个挂钩处理过程,在系统将消息发送至目标窗口处理过程之前,对该消息进行监视
        /// </summary>
        WH_CALLWNDPROC = 4,
        /// <summary>
        /// 安装一个挂钩处理过程,接受对CBT应用程序有用的消息
        /// </summary>
        WH_CBT = 5,
        /// <summary>
        /// <para>安装一个挂钩处理过程,以监视由对话框、消息框、菜单条、或滚动条中</para>
        /// <para>的输入事件引发的消息.这个挂钩处理过程对系统中所有应用程序的这类</para>
        /// <para>消息都进行监视</para>
        /// </summary>
        WH_SYSMSGFILTER = 6,
        /// <summary>
        /// 安装一个挂钩处理过程,对鼠标消息进行监视
        /// </summary>
        WH_MOUSE = 7,
        /// <summary>
        /// 安装一个挂钩处理过程以便对其他挂钩处理过程进行调试
        /// </summary>
        WH_DEBUG = 9,
        /// <summary>
        /// 安装一个挂钩处理过程以接受对外壳应用程序有用的通知
        /// </summary>
        WH_SHELL = 10,
        /// <summary>
        /// <para>安装一个挂钩处理过程,该挂钩处理过程当应用程序的前台线程即将</para>
        /// <para>进入空闲状态时被调用,它有助于在空闲时间内执行低优先级的任务</para>
        /// </summary>
        WH_FOREGROUNDIDLE = 11,
        /// <summary>
        /// 安装一个挂钩处理过程,它对已被目标窗口处理过程处理过了的消息进行监视
        /// </summary>
        WH_CALLWNDPROCRET = 12,
        /// <summary>
        /// 此挂钩只能在Windows NT中被安装,用来对底层的键盘输入事件进行监视
        /// </summary>
        WH_KEYBORARD_LL = 13,
        /// <summary>
        /// 此挂钩只能在Windows NT中被安装,用来对底层的鼠标输入事件进行监视
        /// </summary>
        WH_MOUSE_LL = 14,
    }

    /// <summary>
    /// 
    /// </summary>
    public enum SHGFI
    {
        /// <summary>
        /// 获取图标
        /// </summary>
        SHGFI_ICON = 0x000000100,
        /// <summary>
        /// 获取显示名
        /// </summary>
        SHGFI_DISPLAYNAM = 0x000000200,
        /// <summary>
        /// 获取类型名
        /// </summary>
        SHGFI_TYPENAME = 0x000000400,
        /// <summary>
        /// 获取属性
        /// </summary>
        SHGFI_ATTRIBUTES = 0x000000800,
        /// <summary>
        /// 获取图标位置
        /// </summary>
        SHGFI_ICONLOCATION = 0x000001000,
        /// <summary>
        /// 返回可执行文件的类型
        /// </summary>
        SHGFI_EXETYPE = 0x000002000,
        /// <summary>
        /// 获取系统图标索引
        /// </summary>
        SHGFI_SYSICONINDEX = 0x000004000,
        /// <summary>
        /// 把一个链接覆盖在图标
        /// </summary>
        SHGFI_LINKOVERLAY = 0x000008000,
        /// <summary>
        /// 显示图标在选中时的状态
        /// </summary>
        SHGFI_SELECTED = 0x000010000,
        /// <summary>
        /// 只能指定属性
        /// </summary>
        SHGFI_ATTR_SPECIFIED = 0x000020000,
        /// <summary>
        /// 获取大图标
        /// </summary>
        SHGFI_LARGEICON = 0x000000000,
        /// <summary>
        /// 获取小图标
        /// </summary>
        SHGFI_SMALLICON = 0x000000001,
        /// <summary>
        /// 修改SHGFI_ICON,导致函数来检索文件的打开图标
        /// </summary>
        SHGFI_OPENICON = 0x000000002,
        /// <summary>
        /// 修改SHGFI_ICON,导致函数来检索一个shell大小的图标。如果这个标志没有指定函数大小图标根据系统度量值。
        /// 注意：这个标志不支持Windows手机设备
        /// </summary>
        SHGFI_SHELLICONSIZE = 0x000000004,
        /// <summary>
        /// 
        /// </summary>
        SHGFI_PIDL = 0x000000008,
        /// <summary>
        /// 通过使用dwFileAttributes
        /// </summary>
        SHGFI_USEFILEATTRIBUTES = 0x000000010,
        /// <summary>
        /// 应用适当的覆盖
        /// </summary>
        SHGFI_ADDOVERLAYS = 0x000000020,
        /// <summary>
        /// 获得该指数的叠加
        /// </summary>
        SHGFI_OVERLAYINDEX = 0x000000040,
    }

    /// <summary>
    /// 发送到一个窗口，以确定鼠标在窗口的哪一部分，对应于一个特定的屏幕坐标
    /// </summary>
    public enum WM_NCHITTEST : int
    {
        /// <summary>
        /// 在屏幕背景或窗口之间的分界线
        /// </summary>
        HTERROR = -2,
        /// <summary>
        /// 在目前一个窗口，其他窗口覆盖在同一个线程
        /// （该消息将被发送到相关窗口在同一个线程，直到其中一个返回一个代码，是不是HTTRANSPARENT）
        /// </summary>
        HTTRANSPARENT = -1,
        /// <summary>
        /// 在屏幕背景或窗口之间的分界线上
        /// </summary>
        HTNOWHERE = 0,
        /// <summary>
        /// 在客户端区域
        /// </summary>
        HTCLIENT = 1,
        /// <summary>
        /// 在标题栏
        /// </summary>
        HTCAPTION = 2,
        /// <summary>
        /// 在窗口菜单中，或在一个子窗口的关闭按钮
        /// </summary>
        HTSYSMENU = 3,
        /// <summary>
        /// 在大小框（与HTGROWBO相同）
        /// </summary>
        HTSIZE = 4,
        /// <summary>
        /// 在大小框（与HTSIZE相同）
        /// </summary>
        HTGROWBOX = 4,
        /// <summary>
        /// 在一个菜单
        /// </summary>
        HTMENU = 5,
        /// <summary>
        /// 在水平滚动条
        /// </summary>
        HTHSCROLL = 6,
        /// <summary>
        /// 在垂直滚动条
        /// </summary>
        HTVSCROLL = 7,
        /// <summary>
        /// 在最小化按钮
        /// </summary>
        HTREDUCE = 8,
        /// <summary>
        /// 在最小化按钮
        /// </summary>
        HTMINBUTTON = 8,
        /// <summary>
        /// 在最大化按钮
        /// </summary>
        HTMAXBUTTON = 9,
        /// <summary>
        /// 在最大化按钮
        /// </summary>
        HTZOOM = 9,
        /// <summary>
        /// 在左边框可调整大小的窗口
        /// </summary>
        HTLEFT = 10,
        /// <summary>
        /// 在一个可调整大小的窗口的右边框
        /// </summary>
        HTRIGHT = 11,
        /// <summary>
        /// 在窗口的上边框水平线上
        /// </summary>
        HTTOP = 12,
        /// <summary>
        /// 在窗口的左上边框
        /// </summary>
        HTTOPLEFT = 13,
        /// <summary>
        /// 在窗口的右上边框
        /// </summary>
        HTTOPRIGHT = 14,
        /// <summary>
        /// （用户可以在较低的水平边界可调整大小的窗口单击鼠标，改变窗口的垂直大小）
        /// </summary>
        HTBOTTOM = 15,
        /// <summary>
        /// 在左下角的边框可调整大小的窗口（用户可以通过点击鼠标来调整窗口的大小，对角）
        /// </summary>
        HTBOTTOMLEFT = 16,
        /// <summary>
        /// 在右下角的边框可调整大小的窗口（用户可以通过点击鼠标来调整窗口的大小，对角）
        /// </summary>
        HTBOTTOMRIGHT = 17,
        /// <summary>
        /// 在一个不具有缩放边框的窗口
        /// </summary>
        HTBORDER = 18,
        /// <summary>
        /// 在关闭按钮
        /// </summary>
        HTCLOSE = 20,
        /// <summary>
        /// 在帮助按钮
        /// </summary>
        HTHELP = 21,
    }
}
