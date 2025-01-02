using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class MoaccountUser
{
    public int Id { get; set; }

    public int DeviceNo { get; set; }

    public DateTime? DateCreated { get; set; }

    public long IssuedTo { get; set; }

    public long AccountUser { get; set; }

    public DateTime? DateOfInstallation { get; set; }

    public DateTime? ProcuredDate { get; set; }

    public string? Remarks { get; set; }

    public int Ppeid { get; set; }

    public int MoaccountId { get; set; }

    public string? CreatedById { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();

    public virtual AspNetUser? CreatedBy { get; set; }

    public virtual Moaccount Moaccount { get; set; } = null!;

    public virtual Ppe Ppe { get; set; } = null!;
}
