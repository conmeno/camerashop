﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel;
    
    public partial class LoaiSanPham
    {
        public LoaiSanPham()
        {
            this.SanPhams = new HashSet<SanPham>();
        }
    [DisplayName("Mả loại sp")]
        public int MaLoaiSanPham { get; set; }

        [DisplayName("Tên loại sản phẩm")]
        public string TenLoaiSanPham { get; set; }
    
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
