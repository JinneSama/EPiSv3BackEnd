using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class UserRole
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Function> Functions { get; set; } = new List<Function>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
