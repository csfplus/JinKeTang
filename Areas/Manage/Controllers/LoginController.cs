using Microsoft.AspNetCore.Mvc;

namespace JinKeTang.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
