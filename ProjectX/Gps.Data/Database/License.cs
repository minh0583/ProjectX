//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gps.Data.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class License
    {
        public System.Guid ID { get; set; }
        public string LicenseNumber { get; set; }
        public string Description { get; set; }
        public Nullable<int> DeviceNumber { get; set; }
        public Nullable<System.DateTime> ExpiredDate { get; set; }
        public Nullable<System.DateTime> LastChanged { get; set; }
        public Nullable<System.Guid> LastChangedBy { get; set; }
    
        public virtual User User { get; set; }
    }
}
