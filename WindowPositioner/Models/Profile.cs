using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowPositioner.Models
{
    public class Profile
    {
        public List<Window> Windows { get; set; } = new List<Window>();
        public String ProfileName { get; set; }

        override
        public string ToString()
        {
            return ProfileName;
        }
    }
}
