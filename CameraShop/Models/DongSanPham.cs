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
    
    public partial class DongSanPham
    {
        public DongSanPham()
        {
            this.SanPhams = new HashSet<SanPham>();
        }
    
        public int MaDongSanPham { get; set; }
        public Nullable<int> MaNhaSanXuat { get; set; }
        public string TenDongSanPham { get; set; }
    
        public virtual NhaSanXuat NhaSanXuat { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
