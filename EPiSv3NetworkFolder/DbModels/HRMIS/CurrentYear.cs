using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class CurrentYear
{
    public int FldIndex { get; set; }

    public string? FldYear { get; set; }

    public bool? FldCurrent { get; set; }
}
