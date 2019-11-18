using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETR2.Models
{
    public interface ITechnologyRepository
    {
        Technology GetTechnology(int TechID);
        IEnumerable<Technology> GetAllTechnologies();

        Technology AddTechnology(Technology NewTech);
        Technology UpdateTechnology(Technology TechChanges);
        Technology DeleteTechnology(int TechID);
    }
}
