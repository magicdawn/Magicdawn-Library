using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Magicdawn
{
    public class ProcessHelper
    {
        public static int GetIdByName(string processName)
        {
            if (processName.EndsWith(".exe"))
            {
                processName = processName.Remove(processName.LastIndexOf(".exe"));
            }

            //找 这句不会抛异常,不过length为0
            var processes = Process.GetProcessesByName(processName);
            if (processes.Length != 0)
            {
                return processes[0].Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
