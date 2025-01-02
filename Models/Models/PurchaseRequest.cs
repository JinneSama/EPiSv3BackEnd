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
    
    public partial class PurchaseRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseRequest()
        {
            this.Actions = new HashSet<Action>();
            this.PRStandardPRSpecs = new HashSet<PRStandardPRSpec>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<long> ChiefId { get; set; }
        public Nullable<long> ReqById { get; set; }
        public string PRNo { get; set; }
        public int Quarter { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> TechSpecsId { get; set; }
        public string CreatedById { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Action> Actions { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRStandardPRSpec> PRStandardPRSpecs { get; set; }
        public virtual TechSpec TechSpec { get; set; }
    }
}
