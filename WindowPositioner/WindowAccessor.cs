using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WindowPositioner.Models;

namespace WindowPositioner
{
    public static class WindowAccessor
    {

        public static void OpenPrograms(List<Window> windows)
        {
            foreach (Window window in windows)
            {
                Process.Start(window.ExecutablePath, null);
            }
        }

    }
}
