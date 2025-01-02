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
    
    public partial class CustomerActionSheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerActionSheet()
        {
            this.Actions = new HashSet<Action>();
        }
    
        public int Id { get; set; }
        public Nullable<long> ClientId { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string ClientName { get; set; }
        public string Office { get; set; }
        public int Gender { get; set; }
        public string ContactNo { get; set; }
        public string ClientRequest { get; set; }
        public string ActionTaken { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string AssistedById { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Action> Actions { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}