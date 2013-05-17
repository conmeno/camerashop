using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using CameraShop.Models;
using System.Data;

namespace CameraShop.Controllers
{
    public class SanPhamController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();
        private List<AnhSanPham> picProduct = new List<AnhSanPham>();
        //
        // GET: /SanPham/

        public ActionResult Index()
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                var sanphams = db.SanPhams.Include(s => s.DongSanPham).Include(s => s.KhuyenMai).Include(s => s.LoaiSanPham);
                return View(sanphams.ToList());
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }

        //
        // GET: /SanPham/Details/5

        public ViewResult Details(int id)
        {
            SanPham sanpham = db.SanPhams.Find(id);
            return View(sanpham);
        }

        //
        // GET: /SanPham/Create

        public ActionResult Create()
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                ViewBag.MaDongSanPham = new SelectList(db.DongSanPhams, "MaDongSanPham", "TenDongSanPham");
                ViewBag.MaKhuyenMai = new SelectList(db.KhuyenMais, "MaKhuyenMai", "TenKhuyenMai");
                ViewBag.MaLoaiSanPham = new SelectList(db.LoaiSanPhams, "MaLoaiSanPham", "TenLoaiSanPham");
                ViewBag.ThongSo = db.ThongSoes.ToList();
                var sanpham = new SanPham();

                return View();
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }

        //
        // POST: /SanPham/Create

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(SanPham sanpham, FormCollection form)
        {
            if (ModelState.IsValid)
            {
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    var file = Request.Files[i];
                }
                sanpham.NgayDang = DateTime.Now;
                sanpham.MaDongSanPham = 1;
                sanpham.MaKhuyenMai = 1;
                if (sanpham.ChiTietThongSoes.Count > 0)
                {
                    foreach (ChiTietThongSo item in sanpham.ChiTietThongSoes)
                    {
                        if (item.GiaTri == null)
                            item.GiaTri = "";
                    }
                }
                db.SanPhams.Add(sanpham);
                db.SaveChanges();

                return RedirectToActionPermanent("Create", "AnhSanPham", new { id = sanpham.MaSanPham });
            }

            ViewBag.MaDongSanPham = new SelectList(db.DongSanPhams, "MaDongSanPham", "TenDongSanPham", sanpham.MaDongSanPham);
            ViewBag.MaKhuyenMai = new SelectList(db.KhuyenMais, "MaKhuyenMai", "TenKhuyenMai", sanpham.MaKhuyenMai);
            ViewBag.MaLoaiSanPham = new SelectList(db.LoaiSanPhams, "MaLoaiSanPham", "TenLoaiSanPham", sanpham.MaLoaiSanPham);
            ViewBag.ThongSo = db.ThongSoes.ToList();
            return View(sanpham);
        }

        //
        // GET: /SanPham/Edit/5

        public ActionResult Edit(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                SanPham sanpham = db.SanPhams.Find(id);
                ViewBag.MaDongSanPham = new SelectList(db.DongSanPhams, "MaDongSanPham", "TenDongSanPham", sanpham.MaDongSanPham);
                ViewBag.MaKhuyenMai = new SelectList(db.KhuyenMais, "MaKhuyenMai", "TenKhuyenMai", sanpham.MaKhuyenMai);
                ViewBag.MaLoaiSanPham = new SelectList(db.LoaiSanPhams, "MaLoaiSanPham", "TenLoaiSanPham", sanpham.MaLoaiSanPham);
                ViewBag.ThongSo = db.ThongSoes.ToList();
                ViewBag.CTThongSo = sanpham.ChiTietThongSoes;
                return View(sanpham);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }

        //
        // POST: /SanPham/Edit/5

        [HttpPost]
        public ActionResult Edit(SanPham sanpham)
        {
            if (ModelState.IsValid)
            {
                sanpham.MaDongSanPham = 1;
                sanpham.MaKhuyenMai = 1;
                sanpham.NgayDang = DateTime.Now;
                ////if (sanpham.ChiTietThongSoes.Count > 0)
                ////{
                ////    foreach (ChiTietThongSo item in sanpham.ChiTietThongSoes)
                ////    {
                ////        if (item.GiaTri == null)
                ////            item.GiaTri = "";
                ////    }
                ////}

                //sanpham.LoaiSanPham = db.LoaiSanPhams.Find(sanpham.MaLoaiSanPham);
                //sanpham.KhuyenMai = db.KhuyenMais.Find(1);
                //sanpham.DongSanPham = db.DongSanPhams.Find(1);
                db.Entry(sanpham).State = EntityState.Modified;
                db.SaveChanges();
                if (sanpham.ChiTietThongSoes.Count > 0)
                {
                    foreach (var item in sanpham.ChiTietThongSoes)
                    {
                        ChiTietThongSo ct = db.ChiTietThongSoes.Where(s => s.MaSanPham == item.MaSanPham & s.MaThongSo == item.MaThongSo).ToList()[0];
                        if (ct != null)
                        {
                            ct.GiaTri = item.GiaTri;
                            db.Entry(ct).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                        
                    }
                   
                    //db.ChiTietThongSoes.Find()
                    //foreach (var item in db.ChiTietThongSoes)
                    //{
                    //}

                    //db.Entry(ChiTietThongSoes).State = EntityState.Modified;
                }
               
                return RedirectToAction("Index");
            }
            ViewBag.MaDongSanPham = new SelectList(db.DongSanPhams, "MaDongSanPham", "TenDongSanPham", sanpham.MaDongSanPham);
            ViewBag.MaKhuyenMai = new SelectList(db.KhuyenMais, "MaKhuyenMai", "TenKhuyenMai", sanpham.MaKhuyenMai);
            ViewBag.MaLoaiSanPham = new SelectList(db.LoaiSanPhams, "MaLoaiSanPham", "TenLoaiSanPham", sanpham.MaLoaiSanPham);
            return View(sanpham);
        }

        //
        // GET: /SanPham/Delete/5

        public ActionResult Delete(int id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                SanPham sanpham = db.SanPhams.Find(id);
                return View(sanpham);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }

        //
        // POST: /SanPham/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                SanPham sanpham = db.SanPhams.Find(id);
                db.SanPhams.Remove(sanpham);
                db.SaveChanges();
            }catch(Exception ex)
            {}
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public void UploadPro(int id)
        {
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];
                file.SaveAs(Server.MapPath("~/upload/" + file.FileName));
                AnhSanPham pic = new AnhSanPham();
                pic.URL = "/upload/" + file.FileName;
                picProduct.Add(pic);
            }
        }
    }
}