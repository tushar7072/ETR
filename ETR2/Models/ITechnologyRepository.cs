using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETR2.Models
{
    public interface ITechnologyRepository
    {
        Technology GetTechnology(int techID);
        IEnumerable<Technology> GetAllTechnologies();
    }
}
