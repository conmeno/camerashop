using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CameraShop.Models;

namespace CameraShop.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        private CameraShopEntities db = new CameraShopEntities();
 
        public ActionResult Index()
        {
            //if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            //{
            //    return View();
            //}
            //TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            //return Redirect("~");
            return View();
        }
        [ChildActionOnly]
        public ActionResult ListActionAdmin()
        {
            return PartialView();
            //return Redirect("~");
        }
        
   
    }
}
