namespace Controllers.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }
    }
}
