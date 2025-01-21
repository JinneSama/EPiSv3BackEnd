using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class ComputerSupply
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public string? Item { get; set; }

    public string? Uom { get; set; }

    public decimal? Cost { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? ItemCode { get; set; }

    public decimal? Qty { get; set; }
}
