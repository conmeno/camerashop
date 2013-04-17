using System.Linq;
using System.Web.Mvc;
using CameraShop.Models;

namespace CameraShop.Controllers
{
    public class HomeController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View(db.SanPhams.OrderByDescending(x => x.NgayDang).ToList());
        }

        public ActionResult About()
        {
            return View();
        }
    }
}