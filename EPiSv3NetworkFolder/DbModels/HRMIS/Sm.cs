using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Sm
{
    public long SmsIdx { get; set; }

    public long? SmsEmpId { get; set; }

    public string? SmsMsg { get; set; }

    public DateTime? SmsDte { get; set; }

    public bool? SmsSent { get; set; }

    public string? SmsCpno { get; set; }
}
