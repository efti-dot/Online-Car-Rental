using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Project
{
    internal class GraphicsCard : Product
    {
        public string memory { get; set; }
        public string generation { get; set; }
        public int wattageRequirement { get; set; }
        public string distributor { get; set; }
    }
}
