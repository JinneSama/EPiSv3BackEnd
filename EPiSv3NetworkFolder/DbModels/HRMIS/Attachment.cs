using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Attachment
{
    public int FldAttachmentId { get; set; }

    public int FldEmpId { get; set; }

    public string? FldDescription { get; set; }

    public string FldFilePath { get; set; } = null!;
}
