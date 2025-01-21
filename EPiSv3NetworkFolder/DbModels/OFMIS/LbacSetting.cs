using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class LbacSetting
{
    public int Id { get; set; }

    public string? DateYear { get; set; }

    public bool? Q1Status { get; set; }

    public bool? Q2Status { get; set; }

    public bool? Q3Status { get; set; }

    public bool? Q4Status { get; set; }

    public int? OfficeId { get; set; }

    public bool AllowTargetCreation { get; set; }
}
