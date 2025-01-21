using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Office
{
    public string? FldOfficeId { get; set; }

    public string? FldOfficeName { get; set; }

    public string? FldChief { get; set; }

    public string? FldTelNo { get; set; }

    public int FldIndex { get; set; }

    public string? FldSequence { get; set; }

    public string? FldMainOffice { get; set; }

    public bool? FldOldNew { get; set; }

    public long? FldEmpId { get; set; }

    public long? FldAoempId { get; set; }
}
