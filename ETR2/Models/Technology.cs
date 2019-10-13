using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETR2.Models
{
    public class Technology
    {
        public int TechID { get; set; }
        public string TechnologyName { get; set; }
        public string TechnologyDescription { get; set; }
        public int LandingZone { get; set; }
    }
}
