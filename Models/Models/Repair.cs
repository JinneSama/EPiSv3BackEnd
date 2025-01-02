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
    
    public partial class Repair
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Repair()
        {
            this.Actions = new HashSet<Action>();
        }
    
        public int Id { get; set; }
        public long RequestedById { get; set; }
        public long ReqByChiefId { get; set; }
        public long DeliveredById { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateDelivered { get; set; }
        public string Problems { get; set; }
        public string Findings { get; set; }
        public string Recommendations { get; set; }
        public string PreparedById { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string ReviewedById { get; set; }
        public string NotedById { get; set; }
        public int Gender { get; set; }
        public string ContactNo { get; set; }
        public Nullable<int> PPEsId { get; set; }
        public Nullable<int> PPESpecsId { get; set; }
        public Nullable<int> TechSpecsId { get; set; }
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
        public virtual PPE PPE { get; set; }
        public virtual PPEsSpec PPEsSpec { get; set; }
        public virtual TechSpec TechSpec { get; set; }
        public virtual TicketRequest TicketRequest { get; set; }
    }
}