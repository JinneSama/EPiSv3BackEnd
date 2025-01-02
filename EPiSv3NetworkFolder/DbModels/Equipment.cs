using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class Equipment
{
    public int Id { get; set; }

    public string? EquipmentName { get; set; }

    public virtual ICollection<EquipmentSpec> EquipmentSpecs { get; set; } = new List<EquipmentSpec>();
}
