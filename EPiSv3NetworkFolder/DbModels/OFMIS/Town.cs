using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Town
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? ProvinceId { get; set; }

    public int? SortOrder { get; set; }

    public virtual Province? Province { get; set; }
}
