using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETR2.Models
{
    public class SQLTechnologyRepository : ITechnologyRepository
    {
        public SQLTechnologyRepository(AppDbContext context)
        {
            Context = context;
        }
        public AppDbContext Context { get; }

        public Technology AddTechnology(Technology NewTech)
        {
            Context.TechnologyMaster.Add(NewTech);
            Context.SaveChanges();
            return NewTech;
        }

        public Technology DeleteTechnology(int TechID)
        {
            Technology Tech = Context.TechnologyMaster.Find(TechID);

            if (Tech != null)
            {
                Context.TechnologyMaster.Remove(Tech);
                Context.SaveChanges();
            }
            return Tech;
        }

        public IEnumerable<Technology> GetAllTechnologies()
        {
            return Context.TechnologyMaster;
        }

        public Technology GetTechnology(int TechID)
        {
            return Context.TechnologyMaster.FirstOrDefault(t => t.TechID == TechID);
        }

        public Technology UpdateTechnology(Technology TechChanges)
        {
            var Technologies = Context.TechnologyMaster.Attach(TechChanges);
            Technologies.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
            return TechChanges;
        }
    }
}
