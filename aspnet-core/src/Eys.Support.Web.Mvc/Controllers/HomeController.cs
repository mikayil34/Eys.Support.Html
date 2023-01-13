using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Eys.Support.Controllers;

namespace Eys.Support.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SupportControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
