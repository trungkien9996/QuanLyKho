//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace B4.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detail_PN
    {
        public string Ma_PN { get; set; }
        public string Ma_hh { get; set; }
        public string Ma_kho { get; set; }
        public Nullable<int> So_luong { get; set; }
    
        public virtual Hang Hang { get; set; }
        public virtual PhieuNhap PhieuNhap { get; set; }
    }
}
