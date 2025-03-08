using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCore02.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
