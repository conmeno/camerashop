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
    public class HoaDonController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        //
        // GET: /HoaDon/

 

        public ActionResult TaoHoaDon(int MaDonDatHang)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                HoaDon hoadon = new HoaDon();

                if (db.HoaDons.Where(a => a.MaDonDatHang == MaDonDatHang).ToList().Count > 0)
                {
                    TempData["myMessage"] = "Đơn đặt hàng này đã được tạo hóa đơn";
                    return Redirect("~/QLDonDatHang");
                }
                else
                {

                    TaiKhoan tk = db.TaiKhoans.Find(Session["UserName"].ToString());
                    hoadon.MaNhanVien = tk.MaNguoiDung;
                    hoadon.MaDonDatHang = MaDonDatHang;
                    hoadon.NgayLap = DateTime.Now.Date;
                    db.HoaDons.Add(hoadon);
                    db.SaveChanges();
                    var chitietdondathangs = db.ChiTietDonDatHangs.Include(c => c.DonDatHang).Include(c => c.SanPham).Where(c => c.MaDonDatHang == MaDonDatHang);
                    ViewBag.hoadon = hoadon;
                    return View(chitietdondathangs.ToList());
                }
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");

        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}