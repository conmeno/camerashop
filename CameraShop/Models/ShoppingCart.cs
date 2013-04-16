using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CameraShop.Models
{
    public partial class ShoppingCart
    {
        private CameraShopEntities db = new CameraShopEntities();

        string ShoppingCartID { get; set; }

        public const string CartSessionKey = "CartID";

        public static ShoppingCart GetCart(HttpContextBase context)
        {
            var cart = new ShoppingCart();
            cart.ShoppingCartID = cart.GetCartID(context);
            return cart;
        }
        public static ShoppingCart GetCart(Controller controller)
        {
            return GetCart(controller.HttpContext);
        }

        public void AddToCart(SanPham sanpham, int soluong)
        {
            var cartItem = db.Carts.SingleOrDefault(c => c.CartID == ShoppingCartID
&& c.MaSanPham == sanpham.MaSanPham);

            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists
                cartItem = new Cart
                {
                    MaSanPham = sanpham.MaSanPham,
                    CartID = ShoppingCartID,
                    Count = soluong,
                    DateCreate = DateTime.Now
                };

                db.Carts.Add(cartItem);
            }
            else
            {
                // nếu sản phẩm đả có trong cart thì cộng thêm vào
                cartItem.Count += soluong;
            }

            // Save changes
            db.SaveChanges();
        }

        public int RemoveFromCart(int ID)
        {
            var cartItem = db.Carts.Single(
cart => cart.CartID == ShoppingCartID
&& cart.RecordID == ID);

            int itemCount = 0;

            if (cartItem != null)
            {
                if (cartItem.Count > 1)
                {
                    cartItem.Count--;
                    itemCount = cartItem.Count;
                }
                else
                {
                    db.Carts.Remove(cartItem);
                }
                db.SaveChanges();
            }

            return itemCount;
        }

        public void EmptyCart()
        {
            var cartItems = db.Carts.Where(cart => cart.CartID == ShoppingCartID);

            foreach (var cartItem in cartItems)
            {
                db.Carts.Remove(cartItem);
            }

            db.SaveChanges();
        }

        public List<Cart> GetCartItems()
        {
            return db.Carts.Where(cart => cart.CartID == ShoppingCartID).ToList();
        }

        public int GetCount()
        {
            // Get the count of each item in the cart and sum them up
            int? count = (from cartItems in db.Carts
                          where cartItems.CartID == ShoppingCartID
                          select (int?)cartItems.Count).Sum();
            return count ?? 0;
        }

        public decimal GetTotal()
        {
            decimal? total = (from cartItems in db.Carts
                              where cartItems.CartID == ShoppingCartID
                              select (int?)cartItems.Count * cartItems.SanPham.GiaBan).Sum();
            return total ?? decimal.Zero;
        }

        public int CreateOrder(DonDatHang order)
        {
            decimal orderTotal = 0;

            var cartItems = GetCartItems();
            foreach (var item in cartItems)
            {
                var orderDetail = new ChiTietDonDatHang
                {

                    MaSanPham = item.MaSanPham,
                    MaDonDatHang = order.MaDonDatHang,
                    DonGia = item.SanPham.GiaBan,
                    SoLuong = item.Count,
                    ThanhTien = item.SanPham.GiaBan * item.Count
                };

                // Set the order total of the shopping cart
                orderTotal += (item.Count * item.SanPham.GiaBan);

                db.ChiTietDonDatHangs.Add(orderDetail);

            } 
            order.TongTien = orderTotal; 
            db.SaveChanges(); 
            EmptyCart(); 
            return order.MaDonDatHang;
        }

        // We're using HttpContextBase to allow access to cookies.
        public string GetCartID(HttpContextBase context)
        {
            if (context.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session[CartSessionKey] = context.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.GuID class
                    Guid tempCartID = Guid.NewGuid();

                    // Send tempCartID back to client as a cookie
                    context.Session[CartSessionKey] = tempCartID.ToString();
                }
            }

            return context.Session[CartSessionKey].ToString();
        }

        // When a user has logged in, migrate their shopping cart to
        // be associated with their username
        public void MigrateCart(string userName)
        {
            var shoppingCart = db.Carts.Where(c => c.CartID == ShoppingCartID);

            foreach (Cart item in shoppingCart)
            {
                item.CartID = userName;
            }
            db.SaveChanges();
        }
    }
}