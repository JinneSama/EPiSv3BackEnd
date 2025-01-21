using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class TempReference
{
    public long? FldEmpId { get; set; }

    public string? FldRefName { get; set; }

    public string? FldRefAddress { get; set; }

    public string? FldTelNo { get; set; }

    public int? FldIndex { get; set; }

    public string? FldOffice { get; set; }

    public bool? FldApproved { get; set; }

    public int FldCtrlNo { get; set; }
}
