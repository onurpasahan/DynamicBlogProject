using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DynamicBlogProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = cm.ListAllCategory();

            return View("~/Views/Shared/CategoryList.cshtml", values);
        }
    }
}
