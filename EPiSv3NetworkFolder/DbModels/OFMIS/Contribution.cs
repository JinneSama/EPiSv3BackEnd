using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Contribution
{
    public int Id { get; set; }

    public string? ContributionTo { get; set; }

    public int? Year { get; set; }

    public string? Status { get; set; }

    public decimal? SalBasic { get; set; }

    public decimal? SalBasic1 { get; set; }

    public decimal? SalBasic2 { get; set; }

    public decimal? SalBasic3 { get; set; }

    public decimal? Xdays { get; set; }

    public decimal? XPercent { get; set; }

    public int? DPsgs { get; set; }

    public decimal? MontlyPremiumMin { get; set; }

    public decimal? MonthlyPremiumMax { get; set; }

    public bool Active { get; set; }
}
