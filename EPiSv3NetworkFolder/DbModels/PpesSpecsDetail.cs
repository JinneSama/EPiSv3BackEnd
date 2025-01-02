using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class PpesSpecsDetail
{
    public long Id { get; set; }

    public int PpesSpecsId { get; set; }

    public int ItemNo { get; set; }

    public string? Specs { get; set; }

    public string? Description { get; set; }

    public virtual PpesSpec PpesSpecs { get; set; } = null!;
}
