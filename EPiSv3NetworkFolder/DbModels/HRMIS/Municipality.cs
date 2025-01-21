using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Municipality
{
    public string? FldMunCode { get; set; }

    public string? FldProvCode { get; set; }

    public string? FldMunicipality { get; set; }

    public string? FldMho { get; set; }

    public string? FldMayor { get; set; }

    public int FldIndex { get; set; }
}
