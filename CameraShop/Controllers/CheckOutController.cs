using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CameraShop.Models;

namespace CameraShop.Controllers
{
     
    public class CheckOutController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();
        //
        // GET: /CheckOut/

        public ActionResult AddressAndPayment()
        {
            
            return View();
        }

        //
        // POST: /Checkout/AddressAndPayment

        [HttpPost]
        public ActionResult AddressAndPayment(NguoiDung nguoidung, FormCollection values)
        {
            var order = new DonDatHang();
            TryUpdateModel(order);

            try
            {
              
                if (Session["UserName"] != null)
                {
                    order.MaNguoiDung = int.Parse(Session["MaNguoiDung"].ToString());
                }
                else
                {
                    db.NguoiDungs.Add(nguoidung);
                    db.SaveChanges();
                    order.MaNguoiDung = nguoidung.MaNguoiDung;
                }
                    order.NgayLap = DateTime.Now;
                    order.TinhTrang = false;
                    order.NgayLap = DateTime.Now.Date;
                    order.ThueSuat = 10;
                    var cart = ShoppingCart.GetCart(this.HttpContext);
                    order.TongTien = cart.GetTotal();
                    //Save Order

                    db.DonDatHangs.Add(order);
                    db.SaveChanges();

                    //Process the order
                     
                    cart.CreateOrder(order);

                    return RedirectToAction("Complete",
                        new { id = order.MaDonDatHang,manguoidung=order.MaNguoiDung });
                //}

            }
            catch
            {
                //Invalid - redisplay with errors
                return View(order);
            }
            return View(order);
        }

        //
        // GET: /Checkout/Complete

        public ActionResult Complete(int id,int manguoidung)
        {
            // Validate customer owns this order
            bool isValid = db.DonDatHangs.Any(
                o => o.MaDonDatHang == id &&
                o.MaNguoiDung ==manguoidung);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }

    }
}
