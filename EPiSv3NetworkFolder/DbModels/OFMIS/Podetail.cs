using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Podetail
{
    public int Id { get; set; }

    public int Poid { get; set; }

    public int ItemNo { get; set; }

    public decimal Quantity { get; set; }

    public string Category { get; set; } = null!;

    public string Item { get; set; } = null!;

    public string Uom { get; set; } = null!;

    public decimal Cost { get; set; }

    public decimal TotalAmount { get; set; }

    public string? ItemTitle { get; set; }

    public virtual PurchaseOrder Po { get; set; } = null!;
}
