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
    using System.Web.Mvc;
    
    public partial class Parameter
    {
        public int ID { get; set; }
         [AllowHtml]
        public string LeftAd { get; set; }
         [AllowHtml]
        public string RightAd { get; set; }
         [AllowHtml]
        public string ContactContent { get; set; }
    }
}
