using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class EquipmentSpec
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public int EquipmentId { get; set; }

    public virtual ICollection<Brand> Brands { get; set; } = new List<Brand>();

    public virtual Equipment Equipment { get; set; } = null!;

    public virtual ICollection<EquipmentSpecsDetail> EquipmentSpecsDetails { get; set; } = new List<EquipmentSpecsDetail>();

    public virtual ICollection<StandardPrspec> StandardPrspecs { get; set; } = new List<StandardPrspec>();

    public virtual ICollection<TechSpecsBasis> TechSpecsBases { get; set; } = new List<TechSpecsBasis>();

    public virtual ICollection<TechSpecsIctspec> TechSpecsIctspecs { get; set; } = new List<TechSpecsIctspec>();
}
