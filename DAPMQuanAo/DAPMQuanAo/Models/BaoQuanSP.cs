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
    
    public partial class BaoQuanSP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaoQuanSP()
        {
            this.SanPhams = new HashSet<SanPham>();
        }
    
        public int ChatLieuID { get; set; }
        public string ChatLieu { get; set; }
        public string GiatBang { get; set; }
        public string CachNgam { get; set; }
        public string CachGiat { get; set; }
        public string VatQA { get; set; }
        public string UDo { get; set; }
        public string KieuGiat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
