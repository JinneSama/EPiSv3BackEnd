using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class Moaccount
{
    public int Id { get; set; }

    public string? PrincipalName { get; set; }

    public string? Password { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? CreatedById { get; set; }

    public int? OfficeId { get; set; }

    public virtual AspNetUser? CreatedBy { get; set; }

    public virtual ICollection<MoaccountUser> MoaccountUsers { get; set; } = new List<MoaccountUser>();

    public virtual PgngroupOffice? Office { get; set; }
}
