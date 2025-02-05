﻿using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class PayrollDetail
{
    public int Id { get; set; }

    public int? PayrollId { get; set; }

    public int? ItemNumber { get; set; }

    public int? EmployeeId { get; set; }

    public string? Name { get; set; }

    public string? Designation { get; set; }

    public string? Lbpaccount { get; set; }

    public decimal? ColumnTitle1 { get; set; }

    public decimal? ColumnTitle2 { get; set; }

    public decimal? Total { get; set; }

    public string? ColumnTitle { get; set; }

    public string? ColumnText { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Payroll? Payroll { get; set; }
}
