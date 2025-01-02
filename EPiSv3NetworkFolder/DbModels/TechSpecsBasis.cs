using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class TechSpecsBasis
{
    public int Id { get; set; }

    public double PriceRange { get; set; }

    public DateTime? PriceDate { get; set; }

    public string? Urlbasis { get; set; }

    public string? Remarks { get; set; }

    public bool? Available { get; set; }

    public int EquipmentSpecsId { get; set; }

    public virtual EquipmentSpec EquipmentSpecs { get; set; } = null!;
}
