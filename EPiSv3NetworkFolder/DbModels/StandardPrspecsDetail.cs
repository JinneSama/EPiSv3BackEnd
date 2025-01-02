using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class StandardPrspecsDetail
{
    public int Id { get; set; }

    public int ItemNo { get; set; }

    public string? Specs { get; set; }

    public string? Description { get; set; }

    public int StandardPrspecsId { get; set; }

    public virtual StandardPrspec StandardPrspecs { get; set; } = null!;
}
