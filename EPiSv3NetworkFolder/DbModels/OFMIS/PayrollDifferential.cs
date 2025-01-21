using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class PayrollDifferential
{
    public int Id { get; set; }

    public int? ObId { get; set; }

    public DateTime? Date { get; set; }

    public string? ControlNo { get; set; }

    public string? Description { get; set; }

    public string? Title { get; set; }

    public string? ChiefOfOffice { get; set; }

    public string? Position { get; set; }

    public string? Accountant { get; set; }

    public string? AccountantPos { get; set; }

    public string? Treasurer { get; set; }

    public string? TreasurerPos { get; set; }

    public string? DeptHead { get; set; }

    public string? DeptHeadPos { get; set; }

    public int? DeptHeadId { get; set; }

    public string? ApprovedBy { get; set; }

    public string? ApprovedByPos { get; set; }

    public int? ApprovedById { get; set; }

    public bool? WithHazard { get; set; }

    public virtual Obligation? Ob { get; set; }

    public virtual ICollection<PayrollDifferentialDetail> PayrollDifferentialDetails { get; set; } = new List<PayrollDifferentialDetail>();
}
