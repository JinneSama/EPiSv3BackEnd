using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class PpesSpec
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

    public int? PpesId { get; set; }

    public virtual Model Model { get; set; } = null!;

    public virtual Ppe? Ppes { get; set; }

    public virtual ICollection<PpesSpecsDetail> PpesSpecsDetails { get; set; } = new List<PpesSpecsDetail>();

    public virtual ICollection<Repair> Repairs { get; set; } = new List<Repair>();
}
