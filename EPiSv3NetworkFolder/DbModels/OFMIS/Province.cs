using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Province
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? SortOrder { get; set; }

    public virtual ICollection<Town> Towns { get; set; } = new List<Town>();
}
