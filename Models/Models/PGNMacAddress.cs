//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PGNMacAddress
    {
        public int Id { get; set; }
        public int Connection { get; set; }
        public int Device { get; set; }
        public string MacAddress { get; set; }
        public int PGNAccountId { get; set; }
    
        public virtual PGNAccount PGNAccount { get; set; }
    }
}