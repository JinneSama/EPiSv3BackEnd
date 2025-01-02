using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class StandardPrspec
{
    public int Id { get; set; }

    public int ItemNo { get; set; }

    public int Quarter { get; set; }

    public string? Description { get; set; }

    public string? Purpose { get; set; }

    public int Unit { get; set; }

    public long? UnitCost { get; set; }

    public int EquipmentSpecsId { get; set; }

    public virtual EquipmentSpec EquipmentSpecs { get; set; } = null!;

    public virtual ICollection<PrstandardPrspec> PrstandardPrspecs { get; set; } = new List<PrstandardPrspec>();

    public virtual ICollection<StandardPrspecsDetail> StandardPrspecsDetails { get; set; } = new List<StandardPrspecsDetail>();
}
