using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CameraShop.Models
{
    public partial class SanPhamThongSo
    {
        public SanPham sanpham { get; set; }
        
        public ICollection<ChiTietThongSo> chitietthongso{ get; set; }
      

    }
}