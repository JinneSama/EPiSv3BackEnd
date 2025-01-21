using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class RecordUpdate
{
    public long FldIndex { get; set; }

    public long? FldEmpId { get; set; }

    public DateTime? FldDateTime { get; set; }

    public string? FldParticular { get; set; }

    public long? FldCtrlNo { get; set; }

    public bool? FldApproved { get; set; }

    public string? FldApprovedBy { get; set; }

    public DateTime? FldApprovedDateTime { get; set; }

    public string? FldCreatedBy { get; set; }

    public bool? FldApprovedAo { get; set; }

    public DateTime? FldApprovedDateTimeAo { get; set; }

    public DateTime? FldDateSubmitted { get; set; }

    public bool? FldCompleteDocs { get; set; }

    public string? FldRemarks { get; set; }

    public string? FldValidatedBy { get; set; }
}
