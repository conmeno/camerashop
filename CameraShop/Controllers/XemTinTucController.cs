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
    public class XemTinTucController : Controller
    {
        //
        // GET: /XemTinTuc/
        private CameraShopEntities db = new CameraShopEntities();
        public ActionResult Index()
        {
            TinTuc tintuc = db.TinTucs.Find(db.TinTucs.ToList()[db.TinTucs.ToList().Count - 1].MaTinTuc);
            ViewBag.listTT = db.TinTucs.ToList();
            return View(tintuc);
        }
        public ActionResult Detail(int id)
        {
            TinTuc tintuc = db.TinTucs.Find(id);
            ViewBag.listTT = db.TinTucs.ToList();
            return View(tintuc);
        }

    }
}
