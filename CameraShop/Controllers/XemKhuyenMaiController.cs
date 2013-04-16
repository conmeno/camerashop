using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CameraShop.Models;
namespace CameraShop.Controllers
{
    public class XemKhuyenMaiController : Controller
    {
        //
        // GET: /XemKhuyenMai/

        private CameraShopEntities db = new CameraShopEntities();
        public ActionResult Index()
        {
            KhuyenMai tintuc = db.KhuyenMais.Find(db.KhuyenMais.ToList()[db.KhuyenMais.ToList().Count-1].MaKhuyenMai);
            ViewBag.listKM = db.KhuyenMais.ToList();
            return View(tintuc);
        }
        public ActionResult Detail(int id)
        {
            KhuyenMai tintuc = db.KhuyenMais.Find(id);
            ViewBag.listKM = db.KhuyenMais.ToList();
            return View(tintuc);
        }
    }
}
