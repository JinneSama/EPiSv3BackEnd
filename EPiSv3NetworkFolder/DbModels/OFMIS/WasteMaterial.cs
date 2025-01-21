using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class WasteMaterial
{
    public int Id { get; set; }

    public string? ControlNo { get; set; }

    public int? OfficeId { get; set; }

    public string? Fund { get; set; }

    public string? PlaceOfStorage { get; set; }

    public DateTime? Date { get; set; }

    public int? CertifiedId { get; set; }

    public int? ApprovedId { get; set; }

    public int? PgsocertifiedId { get; set; }

    public int? Year { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Ft { get; set; }

    public bool Deleted { get; set; }

    public string? Status { get; set; }

    public virtual Signatory? Approved { get; set; }

    public virtual Employee? Certified { get; set; }

    public virtual Office? Office { get; set; }

    public virtual Employee? Pgsocertified { get; set; }

    public virtual ICollection<WasteMaterialDetail> WasteMaterialDetails { get; set; } = new List<WasteMaterialDetail>();
}
