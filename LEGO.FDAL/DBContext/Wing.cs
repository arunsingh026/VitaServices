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
    
    public partial class Wing
    {
        public System.Guid WingId { get; set; }
        public string WingName { get; set; }
        public string NoOfFloors { get; set; }
        public string NoOfFlats { get; set; }
        public string Remark { get; set; }
        public Nullable<System.Guid> SocietyId { get; set; }
        public Nullable<System.Guid> MemberAccountId { get; set; }
    }
}
