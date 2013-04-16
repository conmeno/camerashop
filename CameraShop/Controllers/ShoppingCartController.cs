using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CameraShop.Models;

namespace CameraShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();
        //
        // GET: /ShoppingCart/

        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext); 
            var viewModel = new ShoppingCartViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            }; 
            return View(viewModel);
        }
 
        public ActionResult AddToCart(int id,FormCollection form)
        {
            int soluong;
            if (form[0] != null)
            {
                soluong = int.Parse(form[0].ToString());
            }
            else
            {
                soluong = 1;
            } 
            var sp = db.SanPhams.Single(a=>a.MaSanPham == id); 
            var cart = ShoppingCart.GetCart(this.HttpContext); 
            cart.AddToCart(sp,soluong); 
            return RedirectToAction("Index");
        }

        //
        // AJAX: /ShoppingCart/RemoveFromCart/5

        [HttpPost]
        public  ActionResult RemoveFromCart(int id)
        { 
            var cart = ShoppingCart.GetCart(this.HttpContext); 
            string albumName = db.Carts
                .Single(item => item.RecordID == id).SanPham.TenSanPham; 
            int itemCount = cart.RemoveFromCart(id); 
            var results = new ShoppingCartRemoveViewModel
            {
                Message ="Sản phẩm "+ Server.HtmlEncode(albumName) +
                    " đã xóa khỏi giỏ hàng của bạn.",
                CartTotal = cart.GetTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };

            return Json(results);
        }

        //
        // GET: /ShoppingCart/CartSummary

        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            ViewData["CartCount"] = cart.GetCount();

            return PartialView("CartSummary");
        }

    }
}
