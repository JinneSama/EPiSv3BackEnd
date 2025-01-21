using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class NutObr
{
    public int Id { get; set; }

    public int? AppropriationId { get; set; }

    public string? ControlNo { get; set; }

    public int? ObligationId { get; set; }

    public string? Particulars { get; set; }

    public decimal? Amount { get; set; }

    public decimal? AdjustedAmount { get; set; }

    public string? AccountCode { get; set; }

    public int? Year { get; set; }
}
