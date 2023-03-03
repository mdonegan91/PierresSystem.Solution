using Microsoft.AspNetCore.Mvc;

namespace PierresSystem.Controllers
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