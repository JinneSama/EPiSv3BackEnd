using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class PriceQuotation
{
    public int Id { get; set; }

    public int? Prid { get; set; }

    public DateTime? Date { get; set; }

    public string? ControlNo { get; set; }

    public string? Description { get; set; }

    public string? Purpose { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? Pgsofficer { get; set; }

    public string? Position { get; set; }

    public string? Office { get; set; }

    public string? CreatedBy { get; set; }

    public virtual ICollection<Pqdetail> Pqdetails { get; set; } = new List<Pqdetail>();

    public virtual PurchaseRequest? Pr { get; set; }
}
