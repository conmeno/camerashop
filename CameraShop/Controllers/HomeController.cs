using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
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
            return View(db.SanPhams.ToList());
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
