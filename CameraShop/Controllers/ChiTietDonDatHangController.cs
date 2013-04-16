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
    public class ChiTietDonDatHangController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        //
        // GET: /ChiTietDonDatHang/
 
        public ActionResult Index(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                var chitietdondathangs = db.ChiTietDonDatHangs.Include(c => c.DonDatHang).Include(c => c.SanPham).Where(c => c.MaDonDatHang == id);
                return View(chitietdondathangs.ToList());
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");

        }
        
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}