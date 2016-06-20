using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowPositioner
{
    public static class WindowAccessor
    {

        public static List<ProgramProcess> GetOpenWindows()
        {
            IntPtr shellWindow = GetShellWindow();
            List<ProgramProcess> processes = new List<ProgramProcess>();

            EnumWindows(delegate (IntPtr hWnd, int lParam)
            {
                if (hWnd == shellWindow) return true;
                if (!IsWindowVisible(hWnd)) return true;

                int length = GetWindowTextLength(hWnd);
                if (length == 0) return true;

                StringBuilder builder = new StringBuilder(length);
                GetWindowText(hWnd, builder, length + 1);

                processes.Add(new ProgramProcess()
                {
                    HWND = hWnd,
                    ProcessName = builder.ToString()
                });
                return true;

            }, 0);



            return processes;
        }


        [DllImport("USER32.DLL")]
        private static extern IntPtr GetShellWindow();

        private delegate bool EnumWindowsProc(IntPtr hWnd, int lParam);

        [DllImport("USER32.DLL")]
        private static extern bool EnumWindows(EnumWindowsProc enumFunc, int lParam);

        [DllImport("USER32.DLL")]
        private static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("USER32.DLL")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("USER32.DLL")]
        private static extern int GetWindowTextLength(IntPtr hWnd);
    }
}
