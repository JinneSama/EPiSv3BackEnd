using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Role
{
    public int FldIndex { get; set; }

    public string? FldUsername { get; set; }

    public string? FldModule { get; set; }

    public string? FldAction { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }
}
