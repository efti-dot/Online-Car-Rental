using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Project
{
    internal class Processor : Product
    {
        public string generation { get; set; }
        public string pin { get; set; }
        public string floorSpeed { get; set; }
        public string ceilingSpeed { get; set; }
        public string ramGeneration { get; set; }

    }
}
