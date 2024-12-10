using Microsoft.AspNetCore.Mvc;

namespace Uniqlo_2.Areas.Manage.Common
{
    [Area("Manage")]
    public abstract class BaseController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
