using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Select_Option_Relations.DAL;
using Select_Option_Relations.Models;
using Select_Option_Relations.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Select_Option_Relations.Controllers
{
    public class HomeController : Controller
    {
         private readonly Context _context;
         public HomeController(Context context)
         {
            _context = context;
         }
         
         public IActionResult Index()
        {
            List<Modelss> Model = _context.Models.ToList();
            List<Brands> brands = _context.Brands.Include(b=>b.Modelss).ToList();
            HomeVM homeVm = new HomeVM();

            homeVm.Models = Model;
            homeVm.Brands = brands;
            return View(homeVm);
        }

        public IActionResult Change(int modelId)
        {
            IEnumerable<Brands> Brands = _context.Brands
               .Where(x => x.ModelId == modelId)
               .ToList();
            return PartialView("_ChangePartial",Brands);
        }
    }
}
