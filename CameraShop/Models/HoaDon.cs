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
    
    public partial class HoaDon
    {
        public int MaHoaDon { get; set; }
        public int MaDonDatHang { get; set; }
        public int MaNhanVien { get; set; }
        public System.DateTime NgayLap { get; set; }
    
        public virtual DonDatHang DonDatHang { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
    }
}