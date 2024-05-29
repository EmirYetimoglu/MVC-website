using _20051350008.Data;
using _20051350008.Models;
using Microsoft.AspNetCore.Mvc;

namespace _20051350008.Controllers
{
    public class VolunteerController : Controller
    {
        [HttpGet]
        public IActionResult VolunteerForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VolunteerSave(VolunteerModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ThankYou"); // Redirect to a thank you page
            }
            return View("VolunteerForm", model); // If validation fails, return to the form with validation errors
        }

        public IActionResult ThankYou()
        {
            return View();
        }
        private readonly VolunteerContext _context;

        public VolunteerController(VolunteerContext context)
        {
            this._context = context;
        }

        public ActionResult List()
        {
            var volunteers = _context.Volunteer.ToList();
            return View(volunteers);
        }
    }
}
    