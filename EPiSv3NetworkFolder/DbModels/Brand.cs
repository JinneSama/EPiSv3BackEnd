using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class Brand
{
    public int Id { get; set; }

    public string? BrandName { get; set; }

    public int EquipmenSpecsId { get; set; }

    public virtual EquipmentSpec EquipmenSpecs { get; set; } = null!;

    public virtual ICollection<Model> Models { get; set; } = new List<Model>();
}
