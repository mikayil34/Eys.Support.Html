using Microsoft.AspNetCore.Mvc;

namespace Eys.Support.Web.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
