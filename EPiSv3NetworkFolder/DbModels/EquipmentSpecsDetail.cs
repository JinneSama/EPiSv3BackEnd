using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class EquipmentSpecsDetail
{
    public int Id { get; set; }

    public int ItemNo { get; set; }

    public string? DetailSpecs { get; set; }

    public string? DetailDescription { get; set; }

    public int EquipmentSpecsId { get; set; }

    public virtual EquipmentSpec EquipmentSpecs { get; set; } = null!;
}
