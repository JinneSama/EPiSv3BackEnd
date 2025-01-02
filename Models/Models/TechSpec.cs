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
    
    public partial class TechSpec
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TechSpec()
        {
            this.Actions = new HashSet<Action>();
            this.PurchaseRequests = new HashSet<PurchaseRequest>();
            this.Repairs = new HashSet<Repair>();
            this.TechSpecsICTSpecs = new HashSet<TechSpecsICTSpec>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> DateRequested { get; set; }
        public Nullable<System.DateTime> DateAccepted { get; set; }
        public long ReqById { get; set; }
        public long ReqByChiefId { get; set; }
        public int ReqByGender { get; set; }
        public string ContactNo { get; set; }
        public Nullable<bool> RequestBasedApprovedPR { get; set; }
        public Nullable<bool> RequestBasedApprovedAPP { get; set; }
        public Nullable<bool> RequestBasedApprovedAIP { get; set; }
        public Nullable<bool> RequestBasedApprovedPPMP { get; set; }
        public Nullable<bool> RequestBasedRequestLetter { get; set; }
        public Nullable<bool> RequestBasedForReplacement { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string PreparedById { get; set; }
        public string ReviewedById { get; set; }
        public string NotedById { get; set; }
        public string Users_Id { get; set; }
        public string Users_Id1 { get; set; }
        public string Users_Id2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Action> Actions { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual AspNetUser AspNetUser2 { get; set; }
        public virtual AspNetUser AspNetUser3 { get; set; }
        public virtual AspNetUser AspNetUser4 { get; set; }
        public virtual AspNetUser AspNetUser5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseRequest> PurchaseRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Repair> Repairs { get; set; }
        public virtual TicketRequest TicketRequest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TechSpecsICTSpec> TechSpecsICTSpecs { get; set; }
    }
}