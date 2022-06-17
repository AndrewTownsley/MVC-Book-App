using Microsoft.AspNetCore.Mvc;

namespace BookMVCNew.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
