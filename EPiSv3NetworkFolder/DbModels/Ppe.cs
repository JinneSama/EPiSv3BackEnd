using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class Ppe
{
    public int Id { get; set; }

    public long? IssuedToId { get; set; }

    public long? ChiefId { get; set; }

    public int? Gender { get; set; }

    public string? ContactNo { get; set; }

    public string? PropertyNo { get; set; }

    public string? SerialNo { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? AquisitionDate { get; set; }

    public int? Status { get; set; }

    public int Quantity { get; set; }

    public int Unit { get; set; }

    public long? UnitValue { get; set; }

    public long? TotalValue { get; set; }

    public string? Remarks { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<MoaccountUser> MoaccountUsers { get; set; } = new List<MoaccountUser>();

    public virtual ICollection<PpesSpec> PpesSpecs { get; set; } = new List<PpesSpec>();

    public virtual ICollection<Repair> Repairs { get; set; } = new List<Repair>();
}
