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
    
    public partial class PGNDocument
    {
        public int Id { get; set; }
        public int DocOrder { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public int PGNRequestId { get; set; }
    
        public virtual PGNRequest PGNRequest { get; set; }
    }
}