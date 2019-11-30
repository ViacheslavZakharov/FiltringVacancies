using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiltringVacancies.Models;
using FiltringVacancies.services;

namespace FiltringVacancies.Controllers
{
    public class HomeController : Controller
    {
        private IGetterVacanciesService _getterVacanciesService;

        public HomeController(IGetterVacanciesService getterVacanciesService)
        {
            _getterVacanciesService = getterVacanciesService;
        }

        public IActionResult Index()
        {
            var vacancies = _getterVacanciesService.GetVacancies();
            return View(vacancies);
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
    }
}
