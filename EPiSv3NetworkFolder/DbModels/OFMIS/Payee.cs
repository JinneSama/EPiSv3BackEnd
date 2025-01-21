using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Payee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Office { get; set; }

    public string? Address { get; set; }

    public string? Note { get; set; }

    public int? OfficeId { get; set; }

    public virtual ICollection<GasSlip> GasSlips { get; set; } = new List<GasSlip>();

    public virtual ICollection<Liquidation> Liquidations { get; set; } = new List<Liquidation>();

    public virtual ICollection<Obligation> Obligations { get; set; } = new List<Obligation>();

    public virtual Office? OfficeNavigation { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
