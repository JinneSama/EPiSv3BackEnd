using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class ReAlignment
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public int? SourceAppropriationId { get; set; }

    public int? TargetAppropriationId { get; set; }

    public decimal? Amount { get; set; }

    public string? Remarks { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public virtual Appropriation? SourceAppropriation { get; set; }

    public virtual Appropriation? TargetAppropriation { get; set; }
}
