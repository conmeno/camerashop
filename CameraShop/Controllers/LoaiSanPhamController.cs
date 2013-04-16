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
    public class LoaiSanPhamController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        //
        // GET: /LoaiSanPham/
 
        public ActionResult Index()
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                return View(db.LoaiSanPhams.ToList());
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // GET: /LoaiSanPham/Details/5

        public ViewResult Details(int id)
        {
            LoaiSanPham loaisanpham = db.LoaiSanPhams.Find(id);
            return View(loaisanpham);
        }

        //
        // GET: /LoaiSanPham/Create
 
        public ActionResult Create()
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                return View();
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // POST: /LoaiSanPham/Create

        [HttpPost]
        public ActionResult Create(LoaiSanPham loaisanpham)
        {
            if (ModelState.IsValid)
            {
                db.LoaiSanPhams.Add(loaisanpham);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(loaisanpham);
        }
        
        //
        // GET: /LoaiSanPham/Edit/5
 
        public ActionResult Edit(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                LoaiSanPham loaisanpham = db.LoaiSanPhams.Find(id);
                return View(loaisanpham);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // POST: /LoaiSanPham/Edit/5

        [HttpPost]
        public ActionResult Edit(LoaiSanPham loaisanpham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaisanpham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaisanpham);
        }

        //
        // GET: /LoaiSanPham/Delete/5
 
        public ActionResult Delete(int id)
        {
            LoaiSanPham loaisanpham = db.LoaiSanPhams.Find(id);
            return View(loaisanpham);
        }

        //
        // POST: /LoaiSanPham/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            LoaiSanPham loaisanpham = db.LoaiSanPhams.Find(id);
            db.LoaiSanPhams.Remove(loaisanpham);
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