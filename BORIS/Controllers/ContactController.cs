using Microsoft.AspNetCore.Mvc;

namespace BORIS.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ContactForm()
        {
            var model = new ContactController()
        }
    }
}
