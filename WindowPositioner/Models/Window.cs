using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowPositioner.Models
{
    public class Window
    {
        public string ProcessName { get; set; }
        public int HWND { get; set; }

        override
        public string ToString()
        {
            return ProcessName;
        }
    }
}
