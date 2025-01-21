using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Log
{
    public long FldIndex { get; set; }

    public string? FldUsername { get; set; }

    public DateTime? FldDate { get; set; }

    public string? FldParticular { get; set; }
}
