using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class DefaultSetting
{
    public int Id { get; set; }

    public int? Year { get; set; }

    public string? Department { get; set; }

    public string? ChiefOfOffice { get; set; }

    public string? ChiefOfOfficePos { get; set; }

    public string? ResponsibilityCenter { get; set; }

    public string? ResponsibilityCenterCode { get; set; }

    public string? OfficeId { get; set; }

    public bool? IsDepartment { get; set; }

    public string? UnderOf { get; set; }
}
