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
    public class TaiKhoanController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        //
        // GET: /TaiKhoan/

        public ActionResult Index()
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                var taikhoans = db.TaiKhoans.Include(t => t.NguoiDung);
                return View(taikhoans.ToList());
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // GET: /TaiKhoan/Details/5

        public ActionResult Details(string id)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                TaiKhoan taikhoan = db.TaiKhoans.Find(id);
                return View(taikhoan);
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // GET: /TaiKhoan/Create

        public ActionResult Create()
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                ViewBag.MaNguoiDung = new SelectList(db.NguoiDungs, "MaNguoiDung", "TenNguoiDung");
                return View();
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
        }
        //
        // POST: /TaiKhoan/Create

        [HttpPost]
        public ActionResult Create(TaiKhoan taikhoan)
        {
            if (ModelState.IsValid)
            {
                db.TaiKhoans.Add(taikhoan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNguoiDung = new SelectList(db.NguoiDungs, "MaNguoiDung", "TenNguoiDung", taikhoan.MaNguoiDung);
            return View(taikhoan);
        }

        //
        // GET: /TaiKhoan/Edit/5

        public ActionResult Edit(string id)
        {
            TaiKhoan taikhoan = db.TaiKhoans.Find(id);
            ViewBag.MaNguoiDung = new SelectList(db.NguoiDungs, "MaNguoiDung", "TenNguoiDung", taikhoan.MaNguoiDung);
            return View(taikhoan);
        }

        //
        // POST: /TaiKhoan/Edit/5

        [HttpPost]
        public ActionResult Edit(TaiKhoan taikhoan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taikhoan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNguoiDung = new SelectList(db.NguoiDungs, "MaNguoiDung", "TenNguoiDung", taikhoan.MaNguoiDung);
            return View(taikhoan);
        }

        //
        // GET: /TaiKhoan/Delete/5

        public ActionResult Delete(string id)
        {
            TaiKhoan taikhoan = db.TaiKhoans.Find(id);
            return View(taikhoan);
        }

        //
        // POST: /TaiKhoan/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            TaiKhoan taikhoan = db.TaiKhoans.Find(id);
            db.TaiKhoans.Remove(taikhoan);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Login(TaiKhoan taikhoan)
        {

            TaiKhoan tk = db.TaiKhoans.Find(taikhoan.Username);// db.TaiKhoans.Where(a => a.Username == taikhoan.Username).Where(a => a.Password == taikhoan.Password).ToList();
            if (tk != null)
            {
                if (tk.Password.ToString().Trim().Equals(taikhoan.Password.ToString().Trim()))
                {
                    Session["UserName"] = tk.Username.Trim();
                    Boolean isAddmin = false;
                    foreach (var item in tk.ChiTietNhomNguoiDungs.ToList())
                    {
                        if (item.NhomNguoiDung.TenNhomNguoiDung == "Admin")
                        {
                            isAddmin = true;
                        }
                    }
                    if (isAddmin)
                    {
                        Session["isAdmin"] = 1;
                    }
                    else
                    {
                        Session["isAdmin"] = 0;
                    }
                    Session["MaNguoiDung"] = tk.MaNguoiDung;
                    Session["TenNguoiDung"] = tk.Username;
                    //TempData["myMessage"] = "Chào mừng bạn đến web site của chúng tôi (^_^)";
                }
                else
                {
                    Session["isAdmin"] = null;
                    Session["UserName"] = null;
                    Session["TenNguoiDung"] = null;
                    Session["MaNguoiDung"] = null;
                }

            }
            return PartialView(taikhoan);

        }
        public ActionResult Logout()
        {
            Session["isAdmin"] = null;
            Session["UserName"] = null;
            Session["TenNguoiDung"] = null;
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ViewResult NhomNguoiDung(string id)
        {
            TaiKhoan taikhoan = db.TaiKhoans.Find(id);
            ViewBag.NhomNguoiDung = db.NhomNguoiDungs.ToList();
            return View(taikhoan);
        }

        [HttpPost]
        public ViewResult NhomNguoiDung(string id, FormCollection forms)
        {
            int MaNhomNguoiDung = int.Parse(forms.GetValue("ListNhomNguoiDung").AttemptedValue.ToString());
            ChiTietNhomNguoiDung nhomND = new ChiTietNhomNguoiDung();
            nhomND.MaNhomNguoiDung = MaNhomNguoiDung;
            nhomND.Username = id;
            nhomND.MoTa = "ko co j";
            List<ChiTietNhomNguoiDung> listNhom = db.ChiTietNhomNguoiDungs.Where(a => a.Username.Trim() == id.Trim()).Where(a => a.MaNhomNguoiDung == MaNhomNguoiDung).ToList();
            if (listNhom != null && listNhom.Count == 0)
            {
                db.ChiTietNhomNguoiDungs.Add(nhomND);
                db.SaveChanges();
            }
            TaiKhoan taikhoan = db.TaiKhoans.Find(id);
            ViewBag.NhomNguoiDung = db.NhomNguoiDungs.ToList();
            return View(taikhoan);
        }
        public ActionResult DeleteRole(int id, string username)
        {
            List<ChiTietNhomNguoiDung> ctNhomND = db.ChiTietNhomNguoiDungs.Where(a => a.Username == username).Where(a => a.MaNhomNguoiDung == id).ToList();
            if (ctNhomND.Count > 0)
            {
                db.ChiTietNhomNguoiDungs.Remove(ctNhomND[0]);
                db.SaveChanges();
            }
            ViewBag.username = username;


            return RedirectToAction("NhomNguoiDung", "TaiKhoan", new { id = username.Trim() });
        }

        //danh cho user xem thong tin ca nhan cua ho
        [HttpGet]
        public ActionResult AccountInfo(string id)
        {
            if (Session["Username"] != null && Session["Username"].ToString() == id)
            {
                TaiKhoan taikhoan = db.TaiKhoans.Find(id);
                return View(taikhoan);
            }
            TempData["myMessage"] = "Không có quyền xem thông tin cá nhân của người khác (^_^)";
            return Redirect("~");
        }
        [HttpPost]
        public ActionResult AccountInfo(TaiKhoan tk)
        {
            int a = 3;
            if (ModelState.IsValid)
            {
                db.Entry(tk.NguoiDung).State = EntityState.Modified;
                db.SaveChanges();
                TempData["myMessage"] = "Bạn đả thay đổi thông tin thành công (^_^)";
                return Redirect("~");
            }

            return View("Error");
        }

    }
}