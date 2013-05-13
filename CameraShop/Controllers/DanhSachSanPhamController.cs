using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using CameraShop.Models;

namespace CameraShop.Controllers
{
    public class DanhSachSanPhamController : Controller
    {
        private CameraShopEntities db = new CameraShopEntities();

        //
        // GET: /DanhSachSanPham/
        public ViewResult Index()
        {
            var sanphams = db.SanPhams.Include(s => s.DongSanPham).Include(s => s.KhuyenMai).Include(s => s.LoaiSanPham);
            return View(sanphams.ToList());
        }

        public ViewResult Details(int id)
        {
            SanPham sanpham = db.SanPhams.Find(id);
            return View(sanpham);
        }

        public ViewResult NhaSanXuat(int id)
        {
            var nhasx = db.NhaSanXuats.Find(id);
            return View(nhasx);
        }

        public ViewResult LoaiSanPham(int id)
        {
            var loaiSP = db.LoaiSanPhams.Find(id);
            return View(loaiSP);
        }

        [ChildActionOnly]
        public ActionResult SanPhamMoi()
        {
            return PartialView(db.SanPhams.OrderByDescending(x => x.NgayDang).ToList());
        }

        public ActionResult SanPhamMoiVe()
        {
            return View(db.SanPhams.OrderByDescending(x => x.NgayDang).ToList());
        }
        public ActionResult hot()
        {
            return View(db.SanPhams.Where(x=>x.IsHot==true).ToList());
        }
        public ViewResult Search(FormCollection form)
        {
            string key;
            int type;
            key = form.Get("SearchKey");
            type = int.Parse(form.Get("TypeSearch"));
            List<SanPham> listSp = new System.Collections.Generic.List<SanPham>();
            if (type == 1)
            {
                listSp = db.SanPhams.Where(a => a.TenSanPham.Contains(key)).ToList();
            }
            //else if (type == 2)
            //{
            //    listSp = db.SanPhams.Where(a => a.DongSanPham.NhaSanXuat.TenNhaSanXuat.Contains(key)).ToList();
            //}
            else if (type == 2)
            {
                decimal price = decimal.Parse(key);
                listSp = db.SanPhams.Where(a => a.GiaBan < price).ToList();
            }

            return View(listSp);
        }
    }
}