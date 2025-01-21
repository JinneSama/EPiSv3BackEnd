using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class UserWithRole
{
    public string Id { get; set; } = null!;

    public string? UserName { get; set; }

    public int? OfficeId { get; set; }

    public string? ResponsibilityCenter { get; set; }

    public string? OfficeName { get; set; }

    public int? UnderOf { get; set; }

    public bool? LbacUser { get; set; }

    public int? LbacRole { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Position { get; set; }

    public int? Expr1 { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }
}
