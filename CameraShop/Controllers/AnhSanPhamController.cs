using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using CameraShop.Models;

namespace CameraShop.Controllers
{
    public class AnhSanPhamController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        //
        // GET: /AnhSanPham/

        public ActionResult Index(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                var anhsanphams = db.AnhSanPhams.Include(a => a.SanPham).Where(a => a.MaSanPham == id);

                return View(anhsanphams.ToList());
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }

        //
        // GET: /AnhSanPham/Create

        public ActionResult Create(int id)
        {
            var anhsanphams = db.AnhSanPhams.Include(a => a.SanPham).Where(a => a.MaSanPham == id);

            ViewBag.MaSanPham = id;
            ViewBag.SanPham = db.SanPhams.Find(id);
            return View(anhsanphams.ToList());
        }

        //
        // POST: /AnhSanPham/Create

        [HttpPost]
        public ActionResult Create(AnhSanPham anhsanpham)
        {
            if (ModelState.IsValid)
            {
                db.AnhSanPhams.Add(anhsanpham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaSanPham = new SelectList(db.SanPhams, "MaSanPham", "TenSanPham", anhsanpham.MaSanPham);
            return View(anhsanpham);
        }

        //
        // GET: /AnhSanPham/Edit/5

        public ActionResult Edit(int id)
        {
            AnhSanPham anhsanpham = db.AnhSanPhams.Find(id);
            ViewBag.MaSanPham = new SelectList(db.SanPhams, "MaSanPham", "TenSanPham", anhsanpham.MaSanPham);
            return View(anhsanpham);
        }

        //
        // GET: /AnhSanPham/Delete/5

        public ActionResult DeleteImg(int id, int masp)
        {
            AnhSanPham anhsanpham = db.AnhSanPhams.Find(id);
            db.AnhSanPhams.Remove(anhsanpham);
            db.SaveChanges();
            return RedirectToAction("Create", "AnhSanPham", new { id = masp });
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public JsonResult UploadPro(int id)
        {
            List<ViewDataUploadFilesResult> statuses = new List<ViewDataUploadFilesResult>();
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];
                file.SaveAs(Server.MapPath("~/upload/" + file.FileName));
                AnhSanPham picSP = new AnhSanPham();
                picSP.MaSanPham = id;
                picSP.URL = "/upload/" + file.FileName;
                db.AnhSanPhams.Add(picSP);

                statuses.Add(new ViewDataUploadFilesResult()
              {
                  name = file.FileName,
                  size = file.ContentLength,
                  type = file.ContentType,
                  url = "/Home/Download/" + file.FileName,
                  delete_url = "/Home/Delete/" + file.FileName,
                  thumbnail_url = "/content/images/uploaded.jpg",//@"data:image/png;base64," + EncodeFile(fullPath),
                  delete_type = "GET",
              });
            }
            db.SaveChanges();
            return Json(statuses);
            // HttpContext.Response.ContentType = "application/json";
            // HttpContext.Response.Write("{'files':[{'url':'','thumbnail_url':'','name':'xxx','type':'image/jpeg','size':143477,'delete_url':'?delete=true','delete_type':'DELETE'}]}");
        }

        public class ViewDataUploadFilesResult
        {
            public string name { get; set; }

            public int size { get; set; }

            public string type { get; set; }

            public string url { get; set; }

            public string delete_url { get; set; }

            public string thumbnail_url { get; set; }

            public string delete_type { get; set; }
        }
    }
}