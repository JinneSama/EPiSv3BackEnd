using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Division
{
    public string? FldOfficeId { get; set; }

    public string? FldDivision { get; set; }

    public string? FldTelNo { get; set; }

    public int FldIndex { get; set; }

    public string? FldOfcAcr { get; set; }

    public long? FldEmpId { get; set; }

    public long? FldAoempId { get; set; }
}
