using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class Pgnaccount
{
    public int Id { get; set; }

    public long? HrmisempId { get; set; }

    public string? Username { get; set; }

    public int UserType { get; set; }

    public int Status { get; set; }

    public int? SignInCount { get; set; }

    public int TrafficSpeed { get; set; }

    public int Designation { get; set; }

    public string? Remarks { get; set; }

    public string? Password { get; set; }

    public int? PgngroupOfficesId { get; set; }

    public int? PgnnonEmployeeId { get; set; }

    public int? PgnrequestId { get; set; }

    public virtual PgngroupOffice? PgngroupOffices { get; set; }

    public virtual ICollection<PgnmacAddress> PgnmacAddresses { get; set; } = new List<PgnmacAddress>();

    public virtual PgnnonEmployee? PgnnonEmployee { get; set; }

    public virtual Pgnrequest? Pgnrequest { get; set; }
}
