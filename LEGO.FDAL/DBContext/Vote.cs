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
    
    public partial class Vote
    {
        public System.Guid VoteId { get; set; }
        public Nullable<System.DateTime> VoteAt { get; set; }
        public Nullable<System.Guid> PollId { get; set; }
        public Nullable<int> Voted { get; set; }
        public Nullable<System.Guid> VoteById { get; set; }
        public string VoteFor { get; set; }
    }
}
