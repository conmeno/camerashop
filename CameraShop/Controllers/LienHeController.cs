using CameraShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CameraShop.Controllers
{
    public class LienHeController : Controller
    {
        //
        // GET: /LienHe/
        private CameraShopEntities db = new CameraShopEntities();

        public ActionResult Index()
        {
            Parameter parameter = db.Parameters.Find(1);
            return View(parameter);


           
        }

    }
}
