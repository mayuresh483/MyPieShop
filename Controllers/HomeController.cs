using Microsoft.AspNetCore.Mvc;
using MyPieShop.Models;
using MyPieShop.ViewModels;

namespace MyPieShop.Controllers
{
    public class HomeController : Controller
    {
        public readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var piesOfTheWeek = _pieRepository.PiesOfTheWeek;
            HomeViewModel model = new HomeViewModel(piesOfTheWeek);
         
            return View(model);
        }
    }
}
