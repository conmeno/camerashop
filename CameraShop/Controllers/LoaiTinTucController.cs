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
    public class LoaiTinTucController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        //
        // GET: /LoaiTinTuc/

        public ViewResult Index()
        {
            return View(db.LoaiTinTucs.ToList());
        }

        //
        // GET: /LoaiTinTuc/Details/5

        public ViewResult Details(int id)
        {
            LoaiTinTuc loaitintuc = db.LoaiTinTucs.Find(id);
            return View(loaitintuc);
        }

        //
        // GET: /LoaiTinTuc/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /LoaiTinTuc/Create

        [HttpPost]
        public ActionResult Create(LoaiTinTuc loaitintuc)
        {
            if (ModelState.IsValid)
            {
                db.LoaiTinTucs.Add(loaitintuc);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(loaitintuc);
        }
        
        //
        // GET: /LoaiTinTuc/Edit/5
 
        public ActionResult Edit(int id)
        {
            LoaiTinTuc loaitintuc = db.LoaiTinTucs.Find(id);
            return View(loaitintuc);
        }

        //
        // POST: /LoaiTinTuc/Edit/5

        [HttpPost]
        public ActionResult Edit(LoaiTinTuc loaitintuc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaitintuc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaitintuc);
        }

        //
        // GET: /LoaiTinTuc/Delete/5
 
        public ActionResult Delete(int id)
        {
            LoaiTinTuc loaitintuc = db.LoaiTinTucs.Find(id);
            return View(loaitintuc);
        }

        //
        // POST: /LoaiTinTuc/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            LoaiTinTuc loaitintuc = db.LoaiTinTucs.Find(id);
            db.LoaiTinTucs.Remove(loaitintuc);
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