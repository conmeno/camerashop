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
    public class KhuyenMaiController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        //
        // GET: /KhuyenMai/

 
        public ActionResult Index()
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                return View(db.KhuyenMais.ToList());
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // GET: /KhuyenMai/Details/5

        public ViewResult Details(int id)
        {
            KhuyenMai khuyenmai = db.KhuyenMais.Find(id);
            ViewBag.listKM = db.KhuyenMais.ToList();
            return View(khuyenmai);
        }

        //
        // GET: /KhuyenMai/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /KhuyenMai/Create

        [HttpPost]
        public ActionResult Create(KhuyenMai khuyenmai)
        {
            if (ModelState.IsValid)
            {
                db.KhuyenMais.Add(khuyenmai);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(khuyenmai);
        }
        
        //
        // GET: /KhuyenMai/Edit/5
 
        public ActionResult Edit(int id)
        {
            KhuyenMai khuyenmai = db.KhuyenMais.Find(id);
            return View(khuyenmai);
        }

        //
        // POST: /KhuyenMai/Edit/5

        [HttpPost]
        public ActionResult Edit(KhuyenMai khuyenmai)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khuyenmai).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(khuyenmai);
        }

        //
        // GET: /KhuyenMai/Delete/5
 
        public ActionResult Delete(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                KhuyenMai khuyenmai = db.KhuyenMais.Find(id);
                return View(khuyenmai);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // POST: /KhuyenMai/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            KhuyenMai khuyenmai = db.KhuyenMais.Find(id);
            db.KhuyenMais.Remove(khuyenmai);
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