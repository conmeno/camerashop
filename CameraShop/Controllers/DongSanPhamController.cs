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
    public class DongSanPhamController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        //
        // GET: /DongSanPham/

 
        public ActionResult Index()
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                var dongsanphams = db.DongSanPhams.Include(d => d.NhaSanXuat);
                return View(dongsanphams.ToList());
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // GET: /DongSanPham/Details/5

 
        public ActionResult Details(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                DongSanPham dongsanpham = db.DongSanPhams.Find(id);
                return View(dongsanpham);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // GET: /DongSanPham/Create

        public ActionResult Create()
        {
            ViewBag.MaNhaSanXuat = new SelectList(db.NhaSanXuats, "MaNhaSanXuat", "TenNhaSanXuat");
            return View();
        } 

        //
        // POST: /DongSanPham/Create

        [HttpPost]
        public ActionResult Create(DongSanPham dongsanpham)
        {
            if (ModelState.IsValid)
            {
                db.DongSanPhams.Add(dongsanpham);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.MaNhaSanXuat = new SelectList(db.NhaSanXuats, "MaNhaSanXuat", "TenNhaSanXuat", dongsanpham.MaNhaSanXuat);
            return View(dongsanpham);
        }
        
        //
        // GET: /DongSanPham/Edit/5
 
        public ActionResult Edit(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                DongSanPham dongsanpham = db.DongSanPhams.Find(id);
                ViewBag.MaNhaSanXuat = new SelectList(db.NhaSanXuats, "MaNhaSanXuat", "TenNhaSanXuat", dongsanpham.MaNhaSanXuat);
                return View(dongsanpham);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // POST: /DongSanPham/Edit/5

        [HttpPost]
        public ActionResult Edit(DongSanPham dongsanpham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dongsanpham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNhaSanXuat = new SelectList(db.NhaSanXuats, "MaNhaSanXuat", "TenNhaSanXuat", dongsanpham.MaNhaSanXuat);
            return View(dongsanpham);
        }

        //
        // GET: /DongSanPham/Delete/5
 
 
        public ActionResult Delete(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                DongSanPham dongsanpham = db.DongSanPhams.Find(id);
                return View(dongsanpham);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // POST: /DongSanPham/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            DongSanPham dongsanpham = db.DongSanPhams.Find(id);
            db.DongSanPhams.Remove(dongsanpham);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}