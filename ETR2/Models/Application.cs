using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETR2.Models
{
    public class Application
    {
        [Required]
        public int ApplicationID { get; set; }

        [Required]
        public string ApplicationName { get; set; }

        public int NumberofUsers { get; set; }

    }
}
