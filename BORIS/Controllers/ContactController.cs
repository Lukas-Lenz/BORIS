using Microsoft.AspNetCore.Mvc;
using BORIS.Models;

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
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel contactData)
        {
            return View();
        }

        
    }
}
