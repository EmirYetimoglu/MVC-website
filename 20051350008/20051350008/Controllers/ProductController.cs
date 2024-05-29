using Microsoft.AspNetCore.Mvc;

namespace _20051350008.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductSave(String Name)
        {
            

            string Firstname;
            Firstname = HttpContext.Request.Form["Firstname"];
            ViewBag.FirstName = Firstname;
            
            string Lastname;
            Lastname = HttpContext.Request.Form["Lastname"];
            ViewBag.LastName = Lastname;

            string Adress;
            Adress = HttpContext.Request.Form["Adress"];
            ViewBag.Adress = Adress;

            string Birthday;
            Birthday = HttpContext.Request.Form["Birthday"];
            ViewBag.Birthday = Birthday;

            string Gender;
            Gender = HttpContext.Request.Form["Gender"];
            ViewBag.Gender = Gender;

            string email;
            email = HttpContext.Request.Form["email"];
            ViewBag.Email = email;

            string Country;
            Country = HttpContext.Request.Form["Country"];
            ViewBag.Country = Country;




            return View("ProductSave");

            
        }

        public IActionResult ProductForm()
        {
            return View("ProductForm");
        }
    }
}
