using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class PayrollHazardDetail
{
    public int Id { get; set; }

    public int? ItemNo { get; set; }

    public int? PayrollHazardId { get; set; }

    public int? EmployeeId { get; set; }

    public string? Position { get; set; }

    public string? SalaryGrade { get; set; }

    public decimal? SalaryBasis { get; set; }

    public decimal? NoOfDays { get; set; }

    public decimal? Percentage { get; set; }

    public decimal? HazardPay { get; set; }

    public decimal? Subsistence { get; set; }

    public decimal? Laundry { get; set; }

    public decimal? Amount { get; set; }

    public string? Remarks { get; set; }

    public string? RiskAssessment { get; set; }

    public decimal? HazardWt { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual PayrollHazard? PayrollHazard { get; set; }
}
