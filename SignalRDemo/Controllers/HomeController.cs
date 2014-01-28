using System.Web.Mvc;

namespace SignalRDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sender()
        {
            return View();
        }

        public ActionResult Receiver()
        {
            return View();
        }
    }
}