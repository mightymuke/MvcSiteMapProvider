namespace Controllers.Controllers
{
    using System.Web.Mvc;

    public class HolidaysController : Controller
    {
        public ActionResult HolidayNew()
        {
            ViewBag.Message = "New Holiday";

            return View();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Holidays Page";

            return View();
        }
    }
}