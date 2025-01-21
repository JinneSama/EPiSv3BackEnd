using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class PayrollSpesdetail
{
    public int Id { get; set; }

    public int? ItemNo { get; set; }

    public int? PayrollSpesid { get; set; }

    public int? EmployeeId { get; set; }

    public string? Position { get; set; }

    public decimal? NoOfDays { get; set; }

    public decimal? UnderTime { get; set; }

    public decimal? Total { get; set; }

    public decimal? RatePerDay { get; set; }

    public decimal? Percentage { get; set; }

    public decimal? NetAmtPaid { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual PayrollSpe? PayrollSpes { get; set; }
}
