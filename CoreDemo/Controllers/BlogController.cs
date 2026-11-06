using Microsoft.AspNetCore.Mvc;

namespace DynamicBlogProject.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
