using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class RoleDesignation
{
    public int Id { get; set; }

    public int Designation { get; set; }

    public string? RoleId { get; set; }

    public virtual AspNetRole? Role { get; set; }
}
