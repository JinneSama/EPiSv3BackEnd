using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class ChangeLog
{
    public int Id { get; set; }

    public string? Version { get; set; }

    public string? Changelogs { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? UserId { get; set; }

    public virtual AspNetUser? User { get; set; }
}
