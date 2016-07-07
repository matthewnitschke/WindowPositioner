using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WindowPositioner.Models
{

    public class Window
    {
        public string ProcessName { get; set; }
        public string ExecutablePath { get; set; }
        public Bounds WindowBounds { get; set; }

        override
        public string ToString()
        {
            return ProcessName;
        }
    }
}
