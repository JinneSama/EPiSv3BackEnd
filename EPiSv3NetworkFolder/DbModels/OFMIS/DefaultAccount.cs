using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class DefaultAccount
{
    public int Id { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountCodeText { get; set; }

    public string? AccountName { get; set; }

    public string? FundType { get; set; }

    public int? FundTypeId { get; set; }

    public string? Ft { get; set; }

    public virtual FundType? FundTypeNavigation { get; set; }
}
