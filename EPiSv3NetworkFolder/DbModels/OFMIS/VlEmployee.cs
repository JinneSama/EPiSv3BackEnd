using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class VlEmployee
{
    public int Id { get; set; }

    public string EmployeeName { get; set; } = null!;
}
