using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class User
{
    public double? Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? UserFirstName { get; set; }

    public string? UserLastName { get; set; }

    public bool Admin { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }
}
