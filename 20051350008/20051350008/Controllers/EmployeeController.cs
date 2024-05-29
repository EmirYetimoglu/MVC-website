using Microsoft.AspNetCore.Mvc;
using _20051350008.Models;

namespace _20051350008.Controllers
{

    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            var model = new VolunteerViewModel(); 
            return View(model); 
        }

        [HttpPost]
        public IActionResult Register(VolunteerViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                
                return RedirectToAction("Index");
            }
            else
            {
                
                return View(model);
            }

        }

    }
}