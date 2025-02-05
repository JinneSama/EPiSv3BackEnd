﻿using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class PayrollDifferentialDetail
{
    public int Id { get; set; }

    public int? PayrollDiffentialId { get; set; }

    public int? ItemNumber { get; set; }

    public int? EmployeeId { get; set; }

    public string? Designation { get; set; }

    public string? EmployeeName { get; set; }

    public string? SalaryGrade { get; set; }

    public decimal? NewRate { get; set; }

    public decimal? OldRate { get; set; }

    public decimal? Amount { get; set; }

    public decimal? DiffMidYearBonus { get; set; }

    public decimal? Month { get; set; }

    public decimal? Hazard { get; set; }

    public decimal? DiffBonus { get; set; }

    public decimal? Phps { get; set; }

    public decimal? Phgs { get; set; }

    public decimal? Pips { get; set; }

    public decimal? Pigs { get; set; }

    public decimal? Gsisps { get; set; }

    public decimal? Gsisgs { get; set; }

    public decimal? TotalAmount { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual PayrollDifferential? PayrollDiffential { get; set; }
}
