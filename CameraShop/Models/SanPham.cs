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
    using System.Web.Mvc;
    public partial class SanPham
    {
        public SanPham()
        {
            this.AnhSanPhams = new HashSet<AnhSanPham>();
            this.Carts = new HashSet<Cart>();
            this.ChiTietDonDatHangs = new HashSet<ChiTietDonDatHang>();
            this.ChiTietThongSoes = new HashSet<ChiTietThongSo>();
        }
    
        public int MaSanPham { get; set; }
        public int MaDongSanPham { get; set; }
        public int MaLoaiSanPham { get; set; }
        public int MaKhuyenMai { get; set; }
        public string TenSanPham { get; set; }

        [DisplayName("Giá bán")]
        public decimal GiaBan { get; set; }
        public System.DateTime NgayDang { get; set; }
        public int SoLuong { get; set; }
        public Nullable<bool> TinhTrang { get; set; }
 [AllowHtml]
        public string Description { get; set; }
          [DisplayName("Sản phẩm mới")]
        public bool IsNew { get; set; }
        [DisplayName("Sản phẩm hot")]
        public bool IsHot { get; set; }
        [DisplayName("Phần trăm giảm giá")]
        public Nullable<int> Percent { get; set; }
        [DisplayName("Giá chưa giảm")]
        public Nullable<decimal> Gia2 { get; set; }
    
        public virtual ICollection<AnhSanPham> AnhSanPhams { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
        public virtual ICollection<ChiTietThongSo> ChiTietThongSoes { get; set; }
        public virtual DongSanPham DongSanPham { get; set; }
        public virtual KhuyenMai KhuyenMai { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
    }
}
