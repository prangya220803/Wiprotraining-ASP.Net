using Core_MVC_Wipro_demo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_MVC_Wipro_demo1.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Registration model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Registration Successful!";
                return View("Success", model);
            }
            return View(model);
        }
    }
}
