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
    
    public partial class MemberAccount
    {
        public System.Guid MemberAccountId { get; set; }
        public Nullable<System.Guid> MemberId { get; set; }
        public Nullable<System.Guid> WingId { get; set; }
        public Nullable<System.Guid> FlatId { get; set; }
        public Nullable<int> MonthId { get; set; }
    }
}