using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class SalarySchedule
{
    public int? FldSg { get; set; }

    public double? Fld1st { get; set; }

    public double? Fld2nd { get; set; }

    public double? Fld3rd { get; set; }

    public double? Fld4th { get; set; }

    public double? Fld5th { get; set; }

    public double? Fld6th { get; set; }

    public double? Fld7th { get; set; }

    public double? Fld8th { get; set; }

    public string? FldCurrentYear { get; set; }

    public int FldIndex { get; set; }
}
