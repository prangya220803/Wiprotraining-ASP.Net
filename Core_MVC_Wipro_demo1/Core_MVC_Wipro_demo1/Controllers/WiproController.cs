using Microsoft.AspNetCore.Mvc;

namespace Core_MVC_Wipro_demo1.Controllers
{
    public class WiproController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult taghelpers_demo()
        {
            return View();
        }

        public IActionResult std_htmlhelpers_demo()
        {
            return View();
        }
        public IActionResult std_helpers_using_model()
        {
            return View();
        }
        public IActionResult clientside_scripting_demo()
        {
            return View();
        }

    }
}
