using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class WasteCategory
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public bool? IsActive { get; set; }
}
