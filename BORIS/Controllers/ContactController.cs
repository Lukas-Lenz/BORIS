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
        public IActionResult ContactForm(ContactViewModel contactData)
        {

            if(!ModelState.IsValid)
                return View(contactData);
            /*
             * Save: 
             * - submitted data
             * - date and time
             */

            return RedirectToAction("FormSent");
        }

        public IActionResult FormSent()
        {
            return View();
        }
        
    }
}
