using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Project
{
    internal class PowerSupply : Product
    {
        public string formFactor { get; set; }
        public string wattage { get; set; }
        public string certification { get; set; }
    }
}
