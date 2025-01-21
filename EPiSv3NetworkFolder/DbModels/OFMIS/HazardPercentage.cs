using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class HazardPercentage
{
    public int Id { get; set; }

    public string? HazardFor { get; set; }

    public int? SalaryGrade { get; set; }

    public decimal? HazardPayPercent { get; set; }
}
