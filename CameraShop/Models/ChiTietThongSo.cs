//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CameraShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietThongSo
    {
        public int MaThongSo { get; set; }
        public int MaSanPham { get; set; }
        public string GiaTri { get; set; }
    
        public virtual SanPham SanPham { get; set; }
        public virtual ThongSo ThongSo { get; set; }
    }
}
