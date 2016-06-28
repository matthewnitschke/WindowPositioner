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
            foreach(Window window in windows)
            {
                Process.Start(@"C:\Users\Matthew\AppData\Roaming\Spotify\Spotify.exe", null);
            }
        }

        public static List<Window> GetInstalledPrograms()
        {
            string displayName;
            RegistryKey key;

            List<Window> retWindows = new List<Window>();

            // search in: CurrentUser
            key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            foreach (String keyName in key.GetSubKeyNames())
            {
                RegistryKey subkey = key.OpenSubKey(keyName);
                displayName = subkey.GetValue("DisplayName") as string;
                if (displayName != null)
                {
                    retWindows.Add(new Window()
                    {
                        ProcessName = displayName
                    });
                }
               
            }

            // search in: LocalMachine_32
            key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            foreach (String keyName in key.GetSubKeyNames())
            {
                RegistryKey subkey = key.OpenSubKey(keyName);
                displayName = subkey.GetValue("DisplayName") as string;
                if (displayName != null)
                {
                    retWindows.Add(new Window()
                    {
                        ProcessName = displayName
                    });
                }
            }

            // search in: LocalMachine_64
            key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall");
            foreach (String keyName in key.GetSubKeyNames())
            {
                RegistryKey subkey = key.OpenSubKey(keyName);
                displayName = subkey.GetValue("DisplayName") as string;
                if (displayName != null)
                {
                    retWindows.Add(new Window()
                    {
                        ProcessName = displayName
                    });
                }
            }

            // NOT FOUND
            return retWindows;
        }

        public static string GetApplicationPath(string ExeName)
        {
            try
            {
                RegistryKey OurKey = Registry.LocalMachine;
                OurKey = OurKey.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\App Paths\" + ExeName, true);
                if (OurKey != null)
                    return OurKey.GetValue("").ToString();
                else
                    return "";
            }
            catch (Exception ex)
            {
                return "";
            }
        }

    }
}
