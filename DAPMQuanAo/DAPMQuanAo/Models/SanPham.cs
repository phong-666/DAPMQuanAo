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
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.MauSacs = new HashSet<MauSac>();
        }
    
        public int SanphamID { get; set; }
        public string Tensanpham { get; set; }
        public int Giatien { get; set; }
        public string size { get; set; }
        public Nullable<int> kieuspID { get; set; }
        public Nullable<int> chatlieuID { get; set; }
    
        public virtual BaoQuanSP BaoQuanSP { get; set; }
        public virtual KieuSP KieuSP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MauSac> MauSacs { get; set; }
    }
}
