using Microsoft.AspNetCore.Mvc;

namespace BORIS.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
