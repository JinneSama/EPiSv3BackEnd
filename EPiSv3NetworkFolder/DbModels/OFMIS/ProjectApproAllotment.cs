using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class ProjectApproAllotment
{
    public int Id { get; set; }

    public int? ProjectNameAppId { get; set; }

    public DateTime? AllotmentDate { get; set; }

    public decimal? AllotmentAmount { get; set; }

    public string? Remarks { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public virtual ProjectNameApp? ProjectNameApp { get; set; }
}
