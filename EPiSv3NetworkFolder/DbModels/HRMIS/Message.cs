using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Message
{
    public long FldIndex { get; set; }

    public long? FldEmpId { get; set; }

    public long? FldUpdateNo { get; set; }

    public DateTime? FldDate { get; set; }

    public string? FldSender { get; set; }

    public string? FldMessage { get; set; }

    public bool? FldRead { get; set; }
}
