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
    public class ThongSoController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        //
        // GET: /ThongSo/
 
        public ActionResult Index()
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                return View(db.ThongSoes.ToList());
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // GET: /ThongSo/Details/5

        public ViewResult Details(int id)
        {
            ThongSo thongso = db.ThongSoes.Find(id);
            return View(thongso);
        }

        //
        // GET: /ThongSo/Create
 
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
        // POST: /ThongSo/Create

        [HttpPost]
        public ActionResult Create(ThongSo thongso)
        {
            if (ModelState.IsValid)
            {
                db.ThongSoes.Add(thongso);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(thongso);
        }
        
        //
        // GET: /ThongSo/Edit/5
 
 
        public ActionResult Edit(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                ThongSo thongso = db.ThongSoes.Find(id);
                return View(thongso);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // POST: /ThongSo/Edit/5

        [HttpPost]
        public ActionResult Edit(ThongSo thongso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thongso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thongso);
        }

        //
        // GET: /ThongSo/Delete/5
 
 
        public ActionResult Delete(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                ThongSo thongso = db.ThongSoes.Find(id);
                return View(thongso);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // POST: /ThongSo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            ThongSo thongso = db.ThongSoes.Find(id);
            db.ThongSoes.Remove(thongso);
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