using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Bacmember
{
    public int Id { get; set; }

    public int? OfficeId { get; set; }

    public int? EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Position { get; set; }

    public string? OfficeName { get; set; }

    public string? OffcAcr { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Office? Office { get; set; }
}
