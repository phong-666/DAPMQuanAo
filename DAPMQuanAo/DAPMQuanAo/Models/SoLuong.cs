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
    
    public partial class SoLuong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SoLuong()
        {
            this.HoaDonCTs = new HashSet<HoaDonCT>();
            this.PhieuNhapHangs = new HashSet<PhieuNhapHang>();
        }
    
        public int KichcoID { get; set; }
        public int MauSacID { get; set; }
        public int SanphamID { get; set; }
        public Nullable<int> Soluong1 { get; set; }
        public Nullable<int> SanPhamCho { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonCT> HoaDonCTs { get; set; }
        public virtual KichCo KichCo { get; set; }
        public virtual MauSac MauSac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhapHang> PhieuNhapHangs { get; set; }
    }
}