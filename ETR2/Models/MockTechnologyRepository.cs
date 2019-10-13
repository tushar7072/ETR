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
                new Technology {TechID =1, TechnologyName = ".NET Core 2.1", LandingZone = 1, TechnologyDescription= "Technology Details for Core 2.1"},
                new Technology {TechID =2, TechnologyName = ".NET Core 2.2", LandingZone = 1, TechnologyDescription= "Technology Details for Core 2.2"}
            };
        }

        public IEnumerable<Technology> GetAllTechnologies()
        {
            return _technologies;
        }

        public Technology GetTechnology(int techID)
        {
            return _technologies.FirstOrDefault(t => t.TechID == techID);
        }
    }
}
