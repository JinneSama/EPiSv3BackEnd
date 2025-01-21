using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Aoqdetail
{
    public int Id { get; set; }

    public int? Aoqid { get; set; }

    public int? ItemNo { get; set; }

    public decimal? Quantity { get; set; }

    public string? Category { get; set; }

    public string? Item { get; set; }

    public string? Uom { get; set; }

    public decimal? Cost { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedById { get; set; }

    public string? ItemTitle { get; set; }

    public virtual Aoq? Aoq { get; set; }
}
