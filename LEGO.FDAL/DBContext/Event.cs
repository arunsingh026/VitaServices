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
    
    public partial class Event
    {
        public System.Guid EventId { get; set; }
        public string EventTitle { get; set; }
        public string EventDetails { get; set; }
        public Nullable<int> EventType { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Remark { get; set; }
        public Nullable<System.Guid> MemberId { get; set; }
    }
}