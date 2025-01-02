using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class PgngroupOffice
{
    public int Id { get; set; }

    public string? OfficeAcr { get; set; }

    public string? Office { get; set; }

    public virtual ICollection<Moaccount> Moaccounts { get; set; } = new List<Moaccount>();

    public virtual ICollection<Pgnaccount> Pgnaccounts { get; set; } = new List<Pgnaccount>();
}
