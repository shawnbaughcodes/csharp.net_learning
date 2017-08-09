using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {   
            return View("Index");
        }

        [HttpGet]
        [Route("displayInt")]
        public JsonResult DisplayInt()
        {
            var AnonObject = new
            {
                FirstName = "James",
                LastName = "Blake",
                Age = 10
            };
            return Json(AnonObject);
        }
    }
}