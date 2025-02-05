﻿using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class PayrollWage
{
    public int Id { get; set; }

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

    public string? ApprovedBy { get; set; }

    public string? ApprovedByPos { get; set; }

    public int? ApprovedById { get; set; }

    public string? ApprovedByPa { get; set; }

    public string? ApprovedByPapos { get; set; }

    public int? ApprovedByPaid { get; set; }

    public string? ColumnTitles { get; set; }

    public virtual Obligation IdNavigation { get; set; } = null!;

    public virtual ICollection<PayrollWageDetail> PayrollWageDetails { get; set; } = new List<PayrollWageDetail>();
}
