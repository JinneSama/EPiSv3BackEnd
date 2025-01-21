using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class TblDocPage
{
    public long FldDocPageId { get; set; }

    public long FldDocId { get; set; }

    public int? FldDocPageNo { get; set; }

    public string? FldDocPageImage { get; set; }

    public string? FldDocPageDescription { get; set; }

    public int? FldDocActionId { get; set; }

    public string? FldDocImageExt { get; set; }

    public bool? FldDocDeleted { get; set; }

    public string? FldRespCenter { get; set; }

    public string? FldType { get; set; }

    public long? FldCtrlNo { get; set; }
}
