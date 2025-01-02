using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class PurchaseRequest
{
    public int Id { get; set; }

    public DateTime? DateCreated { get; set; }

    public long? ChiefId { get; set; }

    public long? ReqById { get; set; }

    public string? Prno { get; set; }

    public int Quarter { get; set; }

    public bool? IsDeleted { get; set; }

    public int? TechSpecsId { get; set; }

    public string? CreatedById { get; set; }

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();

    public virtual AspNetUser? CreatedBy { get; set; }

    public virtual ICollection<PrstandardPrspec> PrstandardPrspecs { get; set; } = new List<PrstandardPrspec>();

    public virtual TechSpec? TechSpecs { get; set; }
}
