using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCore02.Controllers
{
    public class HomeController : Controller
    { //Main Actions :Index=> GetAllData || GetById=>GetSpecific object||create

        public IActionResult Index()
        {
            return View();//Razor view =>C# HTML as same as the name of action
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        
    }
}
