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
    
    public partial class MOAccountUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MOAccountUser()
        {
            this.Actions = new HashSet<Action>();
        }
    
        public int Id { get; set; }
        public int DeviceNo { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public long IssuedTo { get; set; }
        public long AccountUser { get; set; }
        public Nullable<System.DateTime> DateOfInstallation { get; set; }
        public Nullable<System.DateTime> ProcuredDate { get; set; }
        public string Remarks { get; set; }
        public int PPEId { get; set; }
        public int MOAccountId { get; set; }
        public string CreatedById { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Action> Actions { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual MOAccount MOAccount { get; set; }
        public virtual PPE PPE { get; set; }
    }
}