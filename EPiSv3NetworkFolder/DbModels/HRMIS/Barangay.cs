using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Barangay
{
    public string FldBrgyCode { get; set; } = null!;

    public string FldMunCode { get; set; } = null!;

    public string? FldBarangay { get; set; }

    public int FldIndex { get; set; }
}
