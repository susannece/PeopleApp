using Microsoft.AspNetCore.Mvc;
using PeopleApp.Models;
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

        public IActionResult Details(int id)
        {
            Person person = _peopleService.FindById(id);
            if(person == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }

        public IActionResult PersonLastEntered()
        {
            Person? person = _peopleService.LastAdded();
            if(person != null)
            {
                return PartialView("_PersonRow", person);
            }
            return NotFound();
        }

    }
}
