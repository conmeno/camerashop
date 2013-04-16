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
    public class DanhSachHoaDonController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        //
        // GET: /DanhSachHoaDon/

 
        public ActionResult Index()
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                var hoadons = db.HoaDons.Include(h => h.DonDatHang).Include(h => h.NguoiDung);
                return View(hoadons.ToList());
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");

        }
        //
        // GET: /DanhSachHoaDon/Details/5

        public ActionResult Details(int id)
        {
           

            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                HoaDon hoadon = db.HoaDons.Find(id);
                return View(hoadon);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }

        
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult DeleteHD(int id)
        {
            


            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                HoaDon hoadon = db.HoaDons.Find(id);
                db.HoaDons.Remove(hoadon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
    }
}