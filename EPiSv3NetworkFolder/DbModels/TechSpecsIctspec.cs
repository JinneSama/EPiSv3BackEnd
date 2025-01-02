using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class TechSpecsIctspec
{
    public int Id { get; set; }

    public int ItemNo { get; set; }

    public int Quantity { get; set; }

    public int Unit { get; set; }

    public long UnitCost { get; set; }

    public long TotalCost { get; set; }

    public string? Description { get; set; }

    public string? Purpose { get; set; }

    public int TechSpecsId { get; set; }

    public int EquipmentSpecsId { get; set; }

    public int TechSpecsIctspecsDetailsId { get; set; }

    public virtual EquipmentSpec EquipmentSpecs { get; set; } = null!;

    public virtual TechSpec TechSpecs { get; set; } = null!;

    public virtual ICollection<TechSpecsIctspecsDetail> TechSpecsIctspecsDetails { get; set; } = new List<TechSpecsIctspecsDetail>();
}
