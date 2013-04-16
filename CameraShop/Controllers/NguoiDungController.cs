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
        
    
    public class NguoiDungController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();
        //
        // GET: /NguoiDung/

 
        public ActionResult Index()
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                return View(db.NguoiDungs.ToList());
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // GET: /NguoiDung/Details/5

        public ViewResult Details(int id)
        {
            NguoiDung nguoidung = db.NguoiDungs.Find(id);
            return View(nguoidung);
        }

        //
        // GET: /NguoiDung/Create

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
        // POST: /NguoiDung/Create

        [HttpPost]
        public ActionResult Create(NguoiDung nguoidung)
        {
            if (ModelState.IsValid)
            {
                db.NguoiDungs.Add(nguoidung);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(nguoidung);
        }
        
        //
        // GET: /NguoiDung/Edit/5

        public ActionResult Edit(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                NguoiDung nguoidung = db.NguoiDungs.Find(id);
                return View(nguoidung);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // POST: /NguoiDung/Edit/5

        [HttpPost]
        public ActionResult Edit(NguoiDung nguoidung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nguoidung).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nguoidung);
        }

        //
        // GET: /NguoiDung/Delete/5

        public ActionResult Delete(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                NguoiDung nguoidung = db.NguoiDungs.Find(id);
                return View(nguoidung);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // POST: /NguoiDung/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            NguoiDung nguoidung = db.NguoiDungs.Find(id);
            db.NguoiDungs.Remove(nguoidung);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult ThongTinNguoiDung(int id)
        { 
                NguoiDung nguoidung = db.NguoiDungs.Find(id);
                return View(nguoidung);
             
        }
    }
}