using Microsoft.AspNetCore.Mvc;

namespace ProjectName.Controllers // CHANGE PROJECT NAME!!!
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