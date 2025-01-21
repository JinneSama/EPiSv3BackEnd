using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Function
{
    public int Id { get; set; }

    public string? Action { get; set; }

    public virtual ICollection<UserRole> Roles { get; set; } = new List<UserRole>();
}
