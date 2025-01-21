using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class TrashBin
{
    public int Id { get; set; }

    public string? TableName { get; set; }

    public string? OldValues { get; set; }

    public int? ParentId { get; set; }

    public string? Description { get; set; }

    public string? DeletedBy { get; set; }

    public int? OfficeId { get; set; }

    public virtual ICollection<TrashBin> InverseParent { get; set; } = new List<TrashBin>();

    public virtual Office? Office { get; set; }

    public virtual TrashBin? Parent { get; set; }
}
