using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using CameraShop.Models;
 
namespace CameraShop.Controllers
{
    public class BaoCaoController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();
        //
        // GET: /BaoCao/
         [HttpGet]
        public ActionResult Index()
        {
            
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                
                return View();
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");
            
           
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            if (Session["isAdmin"] != null && Session["isAdmin"].ToString() == "1")
            {
                int ReportType = int.Parse(form["ReportType"].ToString());
                DateTime reportDate = new DateTime();

                try
                {
                    reportDate = DateTime.Parse(form["ReportDate"].ToString());
                    List<HoaDon> listHD = new List<HoaDon>();
                    if (ReportType == 1)
                    {

                        ViewBag.info = "Doanh thu tháng " + reportDate.Month.ToString() + "/" + reportDate.Year.ToString();
                        listHD = db.HoaDons.Where(a => a.NgayLap.Month == reportDate.Month).Where(a => a.NgayLap.Year == reportDate.Year).ToList();
                    }
                    else if (ReportType == 2)
                    {
                        ViewBag.info = "Doanh thu năm " + reportDate.Year.ToString();
                        listHD = db.HoaDons.Where(a => a.NgayLap.Year == reportDate.Year).ToList();

                    }
                    decimal Total = 0;
                    foreach (var item in listHD)
                    {
                        Total += item.DonDatHang.TongTien;
                    }
                    ViewBag.Total = Total;
                    return View(listHD);
                }
                catch
                {
                    TempData["myMessage"] = "Ngày nhập vào không đúng định dạng";
                    return View();
                }
            }
            TempData["myMessage"] = "Bạn cần đăng nhập bằng tài khoản Admin để xe được trang này (^_^)";
            return Redirect("~");

            
           

           
         
        }

     
    }
}
