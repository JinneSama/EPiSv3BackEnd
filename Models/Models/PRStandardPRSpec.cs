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
    
    public partial class PRStandardPRSpec
    {
        public int Id { get; set; }
        public Nullable<int> ItemNo { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<long> TotalCost { get; set; }
        public int PurchaseRequestId { get; set; }
        public int StandardPRSpecsId { get; set; }
    
        public virtual PurchaseRequest PurchaseRequest { get; set; }
        public virtual StandardPRSpec StandardPRSpec { get; set; }
    }
}