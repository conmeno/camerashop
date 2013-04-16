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
    public class NhomNguoiDungController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        //
        // GET: /NhomNguoiDung/
 
        public ActionResult Index()
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                return View(db.NhomNguoiDungs.ToList());
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // GET: /NhomNguoiDung/Details/5

        public ViewResult Details(int id)
        {
            NhomNguoiDung nhomnguoidung = db.NhomNguoiDungs.Find(id);
            return View(nhomnguoidung);
        }

        //
        // GET: /NhomNguoiDung/Create
 
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
        // POST: /NhomNguoiDung/Create

        [HttpPost]
        public ActionResult Create(NhomNguoiDung nhomnguoidung)
        {
            if (ModelState.IsValid)
            {
                db.NhomNguoiDungs.Add(nhomnguoidung);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(nhomnguoidung);
        }
        
        //
        // GET: /NhomNguoiDung/Edit/5
 
 
        public ActionResult Edit(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                NhomNguoiDung nhomnguoidung = db.NhomNguoiDungs.Find(id);
                return View(nhomnguoidung);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // POST: /NhomNguoiDung/Edit/5

        [HttpPost]
        public ActionResult Edit(NhomNguoiDung nhomnguoidung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhomnguoidung).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhomnguoidung);
        }

        //
        // GET: /NhomNguoiDung/Delete/5
 
        public ActionResult Delete(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                NhomNguoiDung nhomnguoidung = db.NhomNguoiDungs.Find(id);
                return View(nhomnguoidung);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // POST: /NhomNguoiDung/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            NhomNguoiDung nhomnguoidung = db.NhomNguoiDungs.Find(id);
            db.NhomNguoiDungs.Remove(nhomnguoidung);
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