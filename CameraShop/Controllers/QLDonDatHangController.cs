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
    public class QLDonDatHangController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        //
        // GET: /QLDonDatHang/

        public ActionResult Index()
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                var dondathangs = db.DonDatHangs.Include(d => d.NguoiDung);
                return View(dondathangs.ToList());
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");

        }



        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult Duyet(int id, Boolean Duyet)
        {


            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                DonDatHang ddh = db.DonDatHangs.Find(id);
                if (Duyet)
                {
                    ddh.TinhTrang = true;
                    foreach (var item in ddh.ChiTietDonDatHangs.ToList())
                    {
                        item.SanPham.SoLuong-=item.SoLuong;
                    }
                }
                else
                {
                    ddh.TinhTrang = false;
                    foreach (var item in ddh.ChiTietDonDatHangs.ToList())
                    {
                        item.SanPham.SoLuong += item.SoLuong;
                    }
                }
                ddh.TinhTrang = true;
                db.Entry(ddh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");



        }
        public ActionResult DeleteOrder(int id)
        { 
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                DonDatHang ddh = db.DonDatHangs.Find(id);
                db.DonDatHangs.Remove(ddh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
    }
}