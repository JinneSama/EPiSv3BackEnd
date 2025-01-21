using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class NewUserFromHrmi
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? UserName { get; set; }

    public string? Position { get; set; }

    public string? Password { get; set; }

    public string? UserRole { get; set; }

    public int? OfficeId { get; set; }

    public bool? IsNew { get; set; }

    public bool? IsInserted { get; set; }
}
