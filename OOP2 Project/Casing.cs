using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Project
{
    internal class Casing : Product
    {
        public string formFactor { get; set; }
        public int includedFan { get; set; }
        public int totalFanSlot { get; set; }
    }
}
