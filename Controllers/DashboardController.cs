using Microsoft.AspNetCore.Mvc;

namespace RentWise.Admins.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
