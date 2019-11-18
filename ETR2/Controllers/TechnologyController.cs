using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETR2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace ETR2.Controllers
{
    [Route("[controller]")]
    public class TechnologyController : Controller
    {
        private ITechnologyRepository _techRepository;
        public TechnologyController(ITechnologyRepository TechRepository)
        {
            _techRepository = TechRepository;
        }

        public ViewResult Index()
        {
            //return _techRepository.GetTechnology(1).TechnologyName;
            return View();
        }

        [Route("~/")]
        public ViewResult GetTechnologyList()
        {
            return View(_techRepository.GetAllTechnologies());
        }

        [Route("[action]/{TechID}")]
        public ViewResult GetTechnologyDetails(int TechID)
        {
            Technology TechnologyData = _techRepository.GetAllTechnologies().FirstOrDefault(t => t.TechID == TechID);

            return View(TechnologyData);

        }

        [Route("[action]")]
        [HttpGet]
        public ViewResult CreateTechnology()
        {

            return View();
        }

        [Route("[action]")]
        [HttpPost]
        public IActionResult CreateTechnology(Technology NewTech)
        {
            if (ModelState.IsValid)
            {
                NewTech = _techRepository.AddTechnology(NewTech);
                // return RedirectToAction("GetTechnologyDetails", new { TechID = NewTech.TechID });
                return View();
            }
            else
                return View();
        }

    }
}