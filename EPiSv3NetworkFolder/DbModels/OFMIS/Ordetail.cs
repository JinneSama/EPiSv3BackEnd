using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Ordetail
{
    public int Id { get; set; }

    public int? AppropriationId { get; set; }

    public int? ObligationId { get; set; }

    public string? Particulars { get; set; }

    public decimal? Amount { get; set; }

    public decimal? AdjustedAmount { get; set; }

    public bool? IsCancelled { get; set; }

    public int? ProjectNameId { get; set; }

    public int? ProjectNameAppId { get; set; }

    public string? AccountCodeText { get; set; }

    public virtual Appropriation? Appropriation { get; set; }

    public virtual Obligation? Obligation { get; set; }
}
