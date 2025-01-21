using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Module
{
    public int FldIndex { get; set; }

    public string? FldModule { get; set; }

    public string? FldAction { get; set; }

    public bool? FldEndUser { get; set; }

    public bool? FldHrstaff { get; set; }
}
