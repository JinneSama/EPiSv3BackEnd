using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class EmpId
{
    public int FldIndex { get; set; }

    public int? FldCurrent { get; set; }

    public int? FldYear { get; set; }
}
