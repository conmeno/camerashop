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
    public class DangKyController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();
        //
        // GET: /DangKy/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TaiKhoan tk)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    
                    tk.NgayTao = DateTime.Now.Date;
                    tk.ThoiGianDangNhap = DateTime.Now.Date;
                    db.NguoiDungs.Add(tk.NguoiDung);
                    db.SaveChanges();
                    tk.MaNguoiDung = tk.NguoiDung.MaNguoiDung;


                    db.TaiKhoans.Add(tk);
                    db.SaveChanges();
                    TempData["myMessage"] = "Đăng ký thành công";
                    return Redirect("~");
                }
                catch
                {
                    TaiKhoan tk1 = db.TaiKhoans.Find(tk.Username);// db.TaiKhoans.Where(a => a.Username == taikhoan.Username).Where(a => a.Password == taikhoan.Password).ToList();
                    if (tk != null)
                    {
                        if (tk.Password.ToString().Trim().Equals(tk.Password.ToString().Trim()))
                        {
                            Session["UserName"] = tk.Username.Trim();
                            Boolean isAddmin = false;
                            foreach (var item in tk1.ChiTietNhomNguoiDungs.ToList())
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
                            Session["MaNguoiDung"] = tk1.MaNguoiDung;
                            Session["TenNguoiDung"] = tk1.Username;
                            //TempData["myMessage"] = "Chào mừng bạn đến web site của chúng tôi (^_^)";
                        }
                        else
                        {
                            Session["isAdmin"] = null;
                            Session["UserName"] = null;
                            Session["TenNguoiDung"] = null;
                            Session["MaNguoiDung"] = null;
                        }
                        return Redirect("~");
                    }
                }
              
            }
            return View(tk);
        }

    }
}
