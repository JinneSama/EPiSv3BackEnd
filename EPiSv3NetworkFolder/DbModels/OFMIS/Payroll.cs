using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Payroll
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public string? ControlNo { get; set; }

    public string? Description { get; set; }

    public string? Title { get; set; }

    public string? ColumnTitle1 { get; set; }

    public string? ColumnTitle2 { get; set; }

    public string? ChiefOfOffice { get; set; }

    public string? Position { get; set; }

    public string? Accountant { get; set; }

    public string? AccountantPos { get; set; }

    public string? Treasurer { get; set; }

    public string? TreasurerPos { get; set; }

    public string? ApprovedBy { get; set; }

    public string? ApprovedByPos { get; set; }

    public int? ApprovedById { get; set; }

    public string? DeptHead { get; set; }

    public string? DeptHeadPos { get; set; }

    public string? ColumnText { get; set; }

    public virtual Obligation IdNavigation { get; set; } = null!;

    public virtual ICollection<PayrollDetail> PayrollDetails { get; set; } = new List<PayrollDetail>();
}
