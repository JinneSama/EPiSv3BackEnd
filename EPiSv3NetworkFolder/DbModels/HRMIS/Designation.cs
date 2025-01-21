using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Designation
{
    public string? FldDesignation { get; set; }

    public int FldIndex { get; set; }

    public string? FldLevel { get; set; }

    public string? FldType { get; set; }

    public string? FldSequence { get; set; }
}
