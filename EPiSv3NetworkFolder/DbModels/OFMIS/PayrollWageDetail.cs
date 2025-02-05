﻿using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class PayrollWageDetail
{
    public int Id { get; set; }

    public int? ItemNumber { get; set; }

    public int? PayrollWageId { get; set; }

    public int? EmployeeId { get; set; }

    public decimal? NoOfdays { get; set; }

    public decimal? Ot { get; set; }

    public decimal? RatePerDay { get; set; }

    public decimal? GrossAmount { get; set; }

    public decimal? Pera { get; set; }

    public decimal? Sssps { get; set; }

    public decimal? Phps { get; set; }

    public decimal? Phgs { get; set; }

    public decimal? Pips { get; set; }

    public decimal? Pimp { get; set; }

    public decimal? Pigs { get; set; }

    public decimal? Total { get; set; }

    public decimal? Mpl { get; set; }

    public decimal? PifcalLoan { get; set; }

    public decimal? Nvpea { get; set; }

    public decimal? Sssloan { get; set; }

    public decimal? Lbp { get; set; }

    public decimal? Dbp { get; set; }

    public decimal? Birwh { get; set; }

    public decimal? Gsispolicy { get; set; }

    public decimal? Gsisconsol { get; set; }

    public decimal? HazardPay { get; set; }

    public decimal? Subsistence { get; set; }

    public decimal? Laundry { get; set; }

    public string? SalaryGrade { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual PayrollWage? PayrollWage { get; set; }
}
