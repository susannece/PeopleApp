using Microsoft.AspNetCore.Mvc;
using PeopleApp.Models.Repos;
using PeopleApp.Models.Services;
using PeopleApp.Models.ViewModels;

namespace PeopleApp.Controllers
{
    public class PersonController : Controller
    {
        IPeopleService _peopleService;
        public PersonController()
        {
            _peopleService = new PeopleService(new InMemoryPeopleRepo());
        }
        public IActionResult Index()
        {
            return View(_peopleService.All());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreatePersonViewModel());
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(CreatePersonViewModel createPerson)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _peopleService.Create(createPerson);
                }
                catch(ArgumentException ex)
                {
                    ModelState.AddModelError("Person", ex.Message);
                    return View(createPerson);
                }  
                return RedirectToAction("Index");
            }
            return View(createPerson);
        }
    }
}
