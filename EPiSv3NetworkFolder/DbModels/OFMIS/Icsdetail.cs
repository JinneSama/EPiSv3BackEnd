using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Icsdetail
{
    public int Id { get; set; }

    public int? Icsid { get; set; }

    public int? ItemNo { get; set; }

    public decimal? Quantity { get; set; }

    public string? Category { get; set; }

    public string? Item { get; set; }

    public string? Uom { get; set; }

    public decimal? Cost { get; set; }

    public decimal? TotalAmount { get; set; }

    public DateTime? DatePurchase { get; set; }

    public string? PropertyNumber { get; set; }

    public string? EstimatedUsefulLife { get; set; }

    public virtual Ic? Ics { get; set; }
}
