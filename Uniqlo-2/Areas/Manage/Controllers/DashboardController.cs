using Microsoft.AspNetCore.Mvc;
using Uniqlo_2.Areas.Manage.Common;

namespace Uniqlo_2.Areas.Manage.Controllers
{
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
