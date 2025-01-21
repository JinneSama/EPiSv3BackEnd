using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Lrdetail
{
    public int Id { get; set; }

    public int? Lrid { get; set; }

    public string? Particulars { get; set; }

    public decimal? Amount { get; set; }

    public virtual Liquidation? Lr { get; set; }
}
