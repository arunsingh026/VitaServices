//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LEGO.FDAL.DBContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class Maintanance
    {
        public System.Guid MaintananceId { get; set; }
        public System.DateTime PeriodStartFrom { get; set; }
        public System.DateTime PeriodEndTo { get; set; }
        public double ChargePaid { get; set; }
        public Nullable<System.Guid> FlatId { get; set; }
    }
}
