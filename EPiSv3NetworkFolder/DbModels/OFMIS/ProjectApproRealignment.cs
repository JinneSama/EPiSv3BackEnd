using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class ProjectApproRealignment
{
    public int Id { get; set; }

    public DateTime? DateRealignment { get; set; }

    public int? SourceProjApproId { get; set; }

    public int? TargetProjApproId { get; set; }

    public decimal? Amount { get; set; }

    public string? Remarks { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public virtual ProjectNameApp? SourceProjAppro { get; set; }

    public virtual ProjectNameApp? TargetProjAppro { get; set; }
}
