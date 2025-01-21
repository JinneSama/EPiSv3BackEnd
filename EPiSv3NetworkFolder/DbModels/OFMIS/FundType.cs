using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class FundType
{
    public int Id { get; set; }

    public string? FundType1 { get; set; }

    public string? Description { get; set; }

    public int? ItemNumber { get; set; }

    public virtual ICollection<Appropriation> Appropriations { get; set; } = new List<Appropriation>();

    public virtual ICollection<DefaultAccount> DefaultAccounts { get; set; } = new List<DefaultAccount>();

    public virtual ICollection<ProjectNameApp> ProjectNameApps { get; set; } = new List<ProjectNameApp>();
}
