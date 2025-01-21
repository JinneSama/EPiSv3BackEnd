using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class OtherEducation
{
    public long FldIndex { get; set; }

    public long FldEmpId { get; set; }

    public int? FldLevel { get; set; }

    public string? FldSchool { get; set; }

    public string? FldDegree { get; set; }

    public double? FldStartYear { get; set; }

    public double? FldEndYear { get; set; }

    public string? FldUnits { get; set; }

    public double? FldYearGrad { get; set; }

    public string? FldHonors { get; set; }

    public bool? FldGraduated { get; set; }

    public bool? FldApproved { get; set; }
}
