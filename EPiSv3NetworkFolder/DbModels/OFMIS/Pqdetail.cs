using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Pqdetail
{
    public int Id { get; set; }

    public int? Pqid { get; set; }

    public int? ItemNo { get; set; }

    public decimal? Quantity { get; set; }

    public string? Category { get; set; }

    public string? Item { get; set; }

    public string? Uom { get; set; }

    public decimal? Cost { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? ItemTitle { get; set; }

    public virtual PriceQuotation? Pq { get; set; }
}
