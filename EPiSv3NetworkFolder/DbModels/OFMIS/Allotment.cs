using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Allotment
{
    public int Id { get; set; }

    public int? AppropriationId { get; set; }

    public DateTime? AllotmentDate { get; set; }

    public decimal? AllotmentAmount { get; set; }

    public string? Remarks { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? CreatedB { get; set; }

    public virtual Appropriation? Appropriation { get; set; }
}
