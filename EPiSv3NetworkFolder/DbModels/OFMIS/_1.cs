using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class _1
{
    public int Id { get; set; }

    public int? ItemOrder { get; set; }

    public string? Category { get; set; }

    public string? Value { get; set; }

    public int? ParentId { get; set; }

    public int? OfficeId { get; set; }
}
