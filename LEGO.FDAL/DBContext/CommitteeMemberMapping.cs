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
    
    public partial class CommitteeMemberMapping
    {
        public System.Guid CommitteeMemberMappingId { get; set; }
        public string Member { get; set; }
        public string Date { get; set; }
        public Nullable<System.Guid> FlatId { get; set; }
        public Nullable<System.Guid> CommitteeId { get; set; }
        public Nullable<System.Guid> DesignationId { get; set; }
    }
}
