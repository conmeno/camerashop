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
    public class NhaSanXuatController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        //
        // GET: /NhaSanXuat/

        public ActionResult Index()
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                return View(db.NhaSanXuats.ToList());
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }

        //
        // GET: /NhaSanXuat/Details/5

        public ViewResult Details(int id)
        {
            NhaSanXuat nhasanxuat = db.NhaSanXuats.Find(id);
            return View(nhasanxuat);
        }

        //
        // GET: /NhaSanXuat/Create
 
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
        // POST: /NhaSanXuat/Create

        [HttpPost]
        public ActionResult Create(NhaSanXuat nhasanxuat)
        {
            if (ModelState.IsValid)
            {
                db.NhaSanXuats.Add(nhasanxuat);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(nhasanxuat);
        }
        
        //
        // GET: /NhaSanXuat/Edit/5
 
        //
        // POST: /NhaSanXuat/Edit/5
        public ActionResult Edit(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                NhaSanXuat nhasanxuat = db.NhaSanXuats.Find(id);
                return View(nhasanxuat);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        [HttpPost]
        public ActionResult Edit(NhaSanXuat nhasanxuat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhasanxuat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhasanxuat);
        }

        //
        // GET: /NhaSanXuat/Delete/5
 
        public ActionResult Delete(int id)
        {
            NhaSanXuat nhasanxuat = db.NhaSanXuats.Find(id);
            return View(nhasanxuat);
        }

        //
        // POST: /NhaSanXuat/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            NhaSanXuat nhasanxuat = db.NhaSanXuats.Find(id);
            db.NhaSanXuats.Remove(nhasanxuat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        [ChildActionOnly]
        public ActionResult LoadNhaSanXuat()
        {
            return PartialView(db.NhaSanXuats.ToList());
        }
    }
}