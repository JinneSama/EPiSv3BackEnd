using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class AspNetRole
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Discriminator { get; set; } = null!;

    public virtual ICollection<RoleDesignation> RoleDesignations { get; set; } = new List<RoleDesignation>();

    public virtual ICollection<AspNetUser> Users { get; set; } = new List<AspNetUser>();
}
