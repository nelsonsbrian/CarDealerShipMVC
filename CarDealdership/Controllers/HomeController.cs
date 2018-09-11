using Microsoft.AspNetCore.Mvc;

namespace CarList.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
          // List<Car> inventory = Car.GetAll();
          // return View("Index", inventory);
          return View();
        }
    }
}
