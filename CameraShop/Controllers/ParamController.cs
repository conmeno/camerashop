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
    public class ParamController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        //
        // GET: /Param/

        public ViewResult Index()
        {
            return View(db.Parameters.ToList());
        }

        //
        // GET: /Param/Details/5

        public ViewResult Details(int id)
        {
            Parameter parameter = db.Parameters.Find(id);
            return View(parameter);
        }

        //
        // GET: /Param/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Param/Create

        [HttpPost]
        public ActionResult Create(Parameter parameter)
        {
            if (ModelState.IsValid)
            {
                db.Parameters.Add(parameter);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(parameter);
        }
        
        //
        // GET: /Param/Edit/5
 
        public ActionResult Edit(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                Parameter parameter = db.Parameters.Find(id);
                return View(parameter);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        [ChildActionOnly]
        public ActionResult ShowLeft()
        {

            Parameter parameter = db.Parameters.Find(1);
            return PartialView(parameter);
        }
        [ChildActionOnly]
        public ActionResult ShowRight()
        {

            Parameter parameter = db.Parameters.Find(1);
            return PartialView(parameter);
        }
        //
        // POST: /Param/Edit/5

        [HttpPost]
        public ActionResult Edit(Parameter parameter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parameter).State = EntityState.Modified;
                db.SaveChanges();
                //return RedirectToAction("Index");
            }
            return View(parameter);
        }

        //
        // GET: /Param/Delete/5
 
        public ActionResult Delete(int id)
        {
            Parameter parameter = db.Parameters.Find(id);
            return View(parameter);
        }

        //
        // POST: /Param/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Parameter parameter = db.Parameters.Find(id);
            db.Parameters.Remove(parameter);
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