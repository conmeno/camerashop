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
    
    public partial class Cart
    {
        public int RecordID { get; set; }
        public string CartID { get; set; }
        public int MaSanPham { get; set; }
        public int Count { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
    
        public virtual SanPham SanPham { get; set; }
    }
}
