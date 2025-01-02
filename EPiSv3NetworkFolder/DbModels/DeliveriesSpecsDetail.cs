using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class DeliveriesSpecsDetail
{
    public long Id { get; set; }

    public int DeliveriesSpecsId { get; set; }

    public int ItemNo { get; set; }

    public string? Specs { get; set; }

    public string? Description { get; set; }

    public virtual DeliveriesSpec DeliveriesSpecs { get; set; } = null!;
}
