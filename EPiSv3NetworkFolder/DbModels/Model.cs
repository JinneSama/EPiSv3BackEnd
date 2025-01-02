using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class Model
{
    public int Id { get; set; }

    public string? ModelName { get; set; }

    public int BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<DeliveriesSpec> DeliveriesSpecs { get; set; } = new List<DeliveriesSpec>();

    public virtual ICollection<PpesSpec> PpesSpecs { get; set; } = new List<PpesSpec>();
}
