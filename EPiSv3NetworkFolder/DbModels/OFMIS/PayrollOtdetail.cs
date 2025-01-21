using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class PayrollOtdetail
{
    public int Id { get; set; }

    public int? ItemNo { get; set; }

    public int? PayrollOtid { get; set; }

    public int? EmployeeId { get; set; }

    public decimal? RatePerMonth { get; set; }

    public decimal? RatePerDay { get; set; }

    public decimal? RatePerHr { get; set; }

    public decimal? WeekDayTimes { get; set; }

    public decimal? WeekEndTimes { get; set; }

    public decimal? WeekEndNoHrs { get; set; }

    public decimal? WeekDayNoHrs { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? UnderPay { get; set; }

    public decimal? TotalAmount { get; set; }

    public DateTime? DateCreated { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual PayrollOt? PayrollOt { get; set; }
}
