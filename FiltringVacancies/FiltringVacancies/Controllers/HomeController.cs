using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiltringVacancies.Models;
using FiltringVacancies.services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FiltringVacancies.Controllers
{
    public class HomeController : Controller
    {
        private IGetterVacanciesService _getterVacanciesService;

        private IFilterVacanciesService _filterVacanciesService;

        private static List<Vacancy> _vacancies;

        

        public HomeController(IGetterVacanciesService getterVacanciesService, IFilterVacanciesService filterVacanciesService)
        {
            _getterVacanciesService = getterVacanciesService;
            _filterVacanciesService = filterVacanciesService;
            _vacancies = _vacancies ?? _getterVacanciesService.GetVacancies();
        }

        public IActionResult Index()
        {

            TransferDataInView(Vacancy.DEFAULT_CITY, RangeSalary.DEFAULT_SALARY);
            return View(_vacancies);
        }

        [HttpPost]
        public IActionResult Index(Filter filter)
        {
            TransferDataInView(filter.City, filter.RangeSalary);
            var filteredVacancies = _filterVacanciesService.Filter(filter, _vacancies);
            return View(filteredVacancies);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void TransferDataInView(string selectedCity, string selectedSalary)
        {
            var citiesVacancies = new List<string> { Vacancy.DEFAULT_CITY };
            citiesVacancies.AddRange(_getterVacanciesService.GetCitiesVacancies(_vacancies));
            citiesVacancies.Remove(selectedCity);
            citiesVacancies.Insert(0, selectedCity);
            ViewBag.Cities = new SelectList(citiesVacancies, "Name");

            var rangeSalary = new List<string>
            {
                RangeSalary.DEFAULT_SALARY,
                RangeSalary.SMALL_SALARY,
                RangeSalary.MIDDLE_SALARY,
                RangeSalary.HIGHT_SALARY
            };
            rangeSalary.Remove(selectedSalary);
            rangeSalary.Insert(0, selectedSalary);
            ViewBag.RangeSalaries = new SelectList(rangeSalary, "Name");
        }
    }
}
