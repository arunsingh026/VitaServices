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
    
    public partial class Parking
    {
        public System.Guid ParkingId { get; set; }
        public string ParkingNo { get; set; }
        public Nullable<System.Guid> FlatId { get; set; }
        public Nullable<double> Area { get; set; }
        public Nullable<int> Type { get; set; }
    }
}