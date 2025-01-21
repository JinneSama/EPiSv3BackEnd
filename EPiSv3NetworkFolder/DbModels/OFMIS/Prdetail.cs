using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Prdetail
{
    public int Id { get; set; }

    public int? Prid { get; set; }

    public int? ItemNo { get; set; }

    public decimal? Quantity { get; set; }

    public string? Category { get; set; }

    public string? Item { get; set; }

    public string? Uom { get; set; }

    public decimal? Cost { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? TableName { get; set; }

    public int? ItemId { get; set; }

    public int? SortOrder { get; set; }

    public string? ItemTitle { get; set; }

    public virtual Item? ItemNavigation { get; set; }

    public virtual PurchaseRequest? Pr { get; set; }
}
