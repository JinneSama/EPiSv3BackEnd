using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class LbacOffice
{
    public int Id { get; set; }

    public string? OffcAcr { get; set; }

    public string? OfficeName { get; set; }

    public string? Chief { get; set; }

    public string? ChiefPosition { get; set; }

    public string? ResponsibilityCenter { get; set; }

    public string? ResponsibilityCenterCode { get; set; }

    public bool? IsDivision { get; set; }

    public int? UnderOf { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Address { get; set; }

    public string? TelNo { get; set; }

    public string? Salutation { get; set; }

    public string? InsideAddress { get; set; }

    public int? EmployeeId { get; set; }

    public string? Email { get; set; }

    public int? RStatus { get; set; }

    public string? Rctext { get; set; }

    public string NewName { get; set; } = null!;
}
