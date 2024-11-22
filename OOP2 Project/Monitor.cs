using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Project
{
    internal class Monitor : Product
    {
        public string resolution { get; set; }
        public string refreshRate { get; set; }
        public string panel { get; set; }
        public string responseTime { get; set; }
        public string screenSize { get; set; }
    }
}
