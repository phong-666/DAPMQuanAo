//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAPMQuanAo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuNhapHang
    {
        public int NhaphangID { get; set; }
        public int Kichco { get; set; }
        public int mausac { get; set; }
        public int sanpham { get; set; }
        public Nullable<int> Soluong { get; set; }
    
        public virtual NhapHang NhapHang { get; set; }
        public virtual SoLuong SoLuong1 { get; set; }
    }
}
