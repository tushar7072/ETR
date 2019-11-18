using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETR2.Models
{
    public class MockTechnologyRepository : ITechnologyRepository
    {
        private List<Technology> _technologies; 
        public MockTechnologyRepository()
        {
            _technologies = new List<Technology>()
            {
                new Technology {TechID =1, TechnologyName = ".NET Core 2.1", LandingZone = LandingZones.CN, TechnologyDescription= "Technology Details for Core 2.1"},
                new Technology {TechID =2, TechnologyName = ".NET Core 2.2", LandingZone = LandingZones.CN, TechnologyDescription= "Technology Details for Core 2.2"}
            };
        }

        public Technology AddTechnology(Technology NewTech)
        {
            NewTech.TechID = _technologies.Max(t => t.TechID) + 1;
            _technologies.Add(NewTech);
            return NewTech;
        }

        public Technology DeleteTechnology(int TechID)
        {
            Technology Tech = _technologies.FirstOrDefault(t => t.TechID == TechID);
            
            if(Tech!=null)
            {
                _technologies.Remove(Tech);
            }
            return Tech;
        }

        public IEnumerable<Technology> GetAllTechnologies()
        {
            return _technologies;
        }

        public Technology GetTechnology(int techID)
        {
            return _technologies.FirstOrDefault(t => t.TechID == techID);
        }

        public Technology UpdateTechnology(Technology TechChanges)
        {
            Technology Tech = _technologies.FirstOrDefault(t => t.TechID == TechChanges.TechID);

            if (Tech != null)
            {
                Tech.TechnologyName = TechChanges.TechnologyName;
                Tech.TechnologyDescription = TechChanges.TechnologyDescription;
                Tech.LandingZone = TechChanges.LandingZone;
            }
            return Tech;
        }
    }
}
