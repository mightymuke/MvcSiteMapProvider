namespace Controllers.Controllers
{
    using System.Web.Mvc;

    public class PersonnelController : Controller
    {
        public ActionResult Create()
        {
            ViewBag.Message = "New Employee";

            return View();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Employee Page";

            return View();
        }
    }
}