using Microsoft.AspNetCore.Mvc;
using BORIS.Models;
using BORIS.Data;

namespace BORIS.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

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
            contactData.ID = Guid.NewGuid();

            if(!ModelState.IsValid)
                return View(contactData);
            /*
             * Save: 
             * - submitted data
             * - date and time
             */
            _context.Add(contactData);
            _context.SaveChanges();
            
            return RedirectToAction("FormSent");
        }

        public IActionResult FormSent()
        {
            return View();
        }
        
    }
}
