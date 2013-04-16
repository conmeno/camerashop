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
    public class TinTucController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        //
        // GET: /TinTuc/

 
        public ActionResult Index()
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                var tintucs = db.TinTucs.Include(t => t.TaiKhoan);
                return View(tintucs.ToList());
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // GET: /TinTuc/Details/5

        public ViewResult Details(int id)
        {
            TinTuc tintuc = db.TinTucs.Find(id);
            ViewBag.listTT = db.TinTucs.ToList();
            return View(tintuc);
        }

        //
        // GET: /TinTuc/Create

 
        public ActionResult Create()
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                ViewBag.Username = new SelectList(db.TaiKhoans, "Username", "Password");
                return View();
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // POST: /TinTuc/Create

        [HttpPost]
        public ActionResult Create(TinTuc tintuc)
        {

            if (ModelState.IsValid)
            {
                tintuc.NgayDang = DateTime.Now.Date;
                tintuc.TaiKhoan =db.TaiKhoans.Find("phuongnt");
                db.TinTucs.Add(tintuc);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            
            ViewBag.Username = new SelectList(db.TaiKhoans, "Username", "Password", tintuc.Username);
            return View(tintuc);
        }
        
        //
        // GET: /TinTuc/Edit/5
 
        public ActionResult Edit(int id)
        {
            TinTuc tintuc = db.TinTucs.Find(id);
           
            ViewBag.Username = new SelectList(db.TaiKhoans, "Username", "Password", tintuc.Username);
            return View(tintuc);
        }

        //
        // POST: /TinTuc/Edit/5

        [HttpPost]
        public ActionResult Edit(TinTuc tintuc)
        {
            if (ModelState.IsValid)
            {
                tintuc.NgayDang = DateTime.Now.Date;
                tintuc.TaiKhoan = db.TaiKhoans.Find("phuongnt");
                db.Entry(tintuc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            ViewBag.Username = new SelectList(db.TaiKhoans, "Username", "Password", tintuc.Username);
            return View(tintuc);
        }

        //
        // GET: /TinTuc/Delete/5
 
        public ActionResult Delete(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                TinTuc tintuc = db.TinTucs.Find(id);
                return View(tintuc);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // POST: /TinTuc/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            TinTuc tintuc = db.TinTucs.Find(id);
            db.TinTucs.Remove(tintuc);
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