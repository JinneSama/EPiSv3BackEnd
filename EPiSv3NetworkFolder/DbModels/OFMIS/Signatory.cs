using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Signatory
{
    public int Id { get; set; }

    public string? Person { get; set; }

    public string? Position { get; set; }

    public string? Note { get; set; }

    public int? Year { get; set; }

    public string? Office { get; set; }

    public bool? IsBacMember { get; set; }

    public string? BacPosition { get; set; }

    public int? EmployeeId { get; set; }

    public int? Orderby { get; set; }

    public bool Deactivate { get; set; }

    public virtual ICollection<Aoq> Aoqs { get; set; } = new List<Aoq>();

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<Liquidation> LiquidationHeadOfDepNavigations { get; set; } = new List<Liquidation>();

    public virtual ICollection<Liquidation> LiquidationPas { get; set; } = new List<Liquidation>();

    public virtual ICollection<WasteMaterial> WasteMaterials { get; set; } = new List<WasteMaterial>();

    public virtual ICollection<Aoq> AoqsNavigation { get; set; } = new List<Aoq>();
}
