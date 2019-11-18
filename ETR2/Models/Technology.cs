using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETR2.Models
{
    public class Technology
    {
        [Required]
        [Key]
        public int TechID { get; set; }
        [Required]

        public string TechnologyName { get; set; }
        public string TechnologyDescription { get; set; }
        [Required]
        public LandingZones? LandingZone { get; set; }

    }
}
