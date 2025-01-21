using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class WasteMaterialDetail
{
    public int Id { get; set; }

    public int? WasteMaterialId { get; set; }

    public int? Item { get; set; }

    public decimal? Quantity { get; set; }

    public string? Unit { get; set; }

    public string? Description { get; set; }

    public string? No { get; set; }

    public DateTime? Date { get; set; }

    public decimal? Amount { get; set; }

    public bool? Active { get; set; }

    public string? Category { get; set; }

    public virtual WasteMaterial? WasteMaterial { get; set; }
}
