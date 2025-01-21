using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class SalarySchedule
{
    public int Id { get; set; }

    public string? Sg { get; set; }

    public int? Step { get; set; }

    public decimal? Cost { get; set; }
}
