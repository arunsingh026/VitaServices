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
    
    public partial class CoreSupport
    {
        public System.Guid SupportId { get; set; }
        public string Title { get; set; }
        public System.DateTime ReportDate { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> ComplaintById { get; set; }
    }
}
