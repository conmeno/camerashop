using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CameraShop.Models;

namespace CameraShop.Controllers
{
    public class LichSuMuaHangController : Controller
    {
        //
        // GET: /LichSuMuaHang/
        private CameraShopEntities db = new CameraShopEntities();
        public ActionResult Index(int uid)
        {
              //var dondathangs = db.DonDatHangs.Include(d => d.NguoiDung);
              //  return View(dondathangs.ToList());
            return View();
        }

    }
}
