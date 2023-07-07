using Microsoft.AspNetCore.Mvc;
using MyPieShop.Models;
using MyPieShop.ViewModels;

namespace MyPieShop.Controllers
{
    public class PieController : Controller
    {
       
            public readonly ICategoryRepository _categoryRepository;
            public readonly IPieRepository _pieRepository;

            public PieController(ICategoryRepository categoryRepository, IPieRepository pieRepository)
            {
                _categoryRepository = categoryRepository;
                _pieRepository = pieRepository;
            }

            public IActionResult List()
            {
                PieListViewModel pieList = new PieListViewModel
                (_pieRepository.AllPies, "All Pies");
                return View(pieList);
            }

            public IActionResult Details(int id)
            {
                var pie = _pieRepository.GetPieById(id);
                if(pie==null)
                    return NotFound();
                return View(pie);
            }
   
    }
}
