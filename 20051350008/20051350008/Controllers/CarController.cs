using Microsoft.AspNetCore.Mvc;
using _20051350008.Models;

namespace _20051350008.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Car()
        {
            return View("NewCar");
        }
        public IActionResult NewCar(CarModel car)
        {
            if (ModelState.IsValid)
            {

            }
            ViewBag.Name = car.Name;
            return View("NewCar");
        }
    }
}
