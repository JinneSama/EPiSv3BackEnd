using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class PrstandardPrspec
{
    public int Id { get; set; }

    public int? ItemNo { get; set; }

    public int? Quantity { get; set; }

    public long? TotalCost { get; set; }

    public int PurchaseRequestId { get; set; }

    public int StandardPrspecsId { get; set; }

    public virtual PurchaseRequest PurchaseRequest { get; set; } = null!;

    public virtual StandardPrspec StandardPrspecs { get; set; } = null!;
}
