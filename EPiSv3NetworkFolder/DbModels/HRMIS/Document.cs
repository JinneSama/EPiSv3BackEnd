using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Document
{
    public int FldIndex { get; set; }

    public int? FldEmpId { get; set; }

    public string? FldDescription { get; set; }

    public string? FldFilename { get; set; }

    public bool? FldApproved { get; set; }

    public long? FldCtrlNo { get; set; }
}
