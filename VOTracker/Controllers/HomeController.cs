using Microsoft.AspNetCore.Mvc;

namespace TrackerApp.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}