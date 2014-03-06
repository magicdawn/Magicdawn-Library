using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public static class MessageExtension
{
    /// <summary>
    /// Message.Create().Send();
    /// </summary>
    /// <param name="m"></param>
    public static void Send(this Message m)
    {
        Magicdawn.Win32.Api.SendMessage(
            m.HWnd,
            m.Msg,
            (int)m.WParam,
            (int)m.LParam);
    }
}
