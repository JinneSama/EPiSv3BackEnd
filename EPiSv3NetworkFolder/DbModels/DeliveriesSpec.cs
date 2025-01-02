using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class DeliveriesSpec
{
    public int Id { get; set; }

    public int ItemNo { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public int Quantity { get; set; }

    public int Unit { get; set; }

    public long UnitCost { get; set; }

    public long TotalCost { get; set; }

    public long ProposedBudget { get; set; }

    public string? Purpose { get; set; }

    public bool IsActive { get; set; }

    public string? SerialNo { get; set; }

    public int ModelId { get; set; }

    public int? DeliveriesId { get; set; }

    public virtual Delivery? Deliveries { get; set; }

    public virtual ICollection<DeliveriesSpecsDetail> DeliveriesSpecsDetails { get; set; } = new List<DeliveriesSpecsDetail>();

    public virtual Model Model { get; set; } = null!;
}
