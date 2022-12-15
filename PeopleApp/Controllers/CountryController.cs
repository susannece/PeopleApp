using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeopleApp.Models;
using PeopleApp.Models.Repos;
using PeopleApp.Models.Services;
using PeopleApp.Models.ViewModels;

namespace PeopleApp.Controllers
{
    public class CountryController : Controller
    {
        ICountryService _countryService;
        
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        // GET: CountriesController
        public ActionResult Index()
        {
            return View(_countryService.All());
        }

        // GET: CountriesController/Create
        public ActionResult Create()
        {
            return View(new CreateCountryViewModel());
        }

        // POST: CountriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateCountryViewModel createCountry)
        {
            if (ModelState.IsValid)
            { 
                try
                {
                    _countryService.Create(createCountry);
                }
                catch(ArgumentException ex)
                {
                    ModelState.AddModelError("Country", ex.Message);
                    return View(createCountry);
                }
                return RedirectToAction("Index");
            }
            return View(createCountry);
        }

        // GET: CountriesController/Details/5
        public ActionResult Details(int id)
        {
            Country country = _countryService.FindById(id);
            if(country == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }

        // GET: CountriesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CountriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CountriesController/Delete/5
        public ActionResult Delete(int id)
        {
            Country country = _countryService.FindById(id);
            if( country != null)
            {
                _countryService.Remove(id);
                return PartialView("_CountryList", _countryService.All());
            }
            return NotFound();
        }

        // POST: CountriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
