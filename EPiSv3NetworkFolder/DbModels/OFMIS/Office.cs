using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Office
{
    public int Id { get; set; }

    public string? OffcAcr { get; set; }

    public string? OfficeName { get; set; }

    public string? Chief { get; set; }

    public string? ChiefPosition { get; set; }

    public string? ResponsibilityCenter { get; set; }

    public string? ResponsibilityCenterCode { get; set; }

    public bool? IsDivision { get; set; }

    public int? UnderOf { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Address { get; set; }

    public string? TelNo { get; set; }

    public string? Salutation { get; set; }

    public string? InsideAddress { get; set; }

    public int? EmployeeId { get; set; }

    public string? Rctext { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public int? RStatus { get; set; }

    public bool? LbacStatus { get; set; }

    public virtual ICollection<Aoq> Aoqs { get; set; } = new List<Aoq>();

    public virtual ICollection<Bacmember> Bacmembers { get; set; } = new List<Bacmember>();

    public virtual ICollection<ControlNumber> ControlNumbers { get; set; } = new List<ControlNumber>();

    public virtual ICollection<DocumentAction> DocumentActions { get; set; } = new List<DocumentAction>();

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Office> InverseUnderOfNavigation { get; set; } = new List<Office>();

    public virtual ICollection<Letter> Letters { get; set; } = new List<Letter>();

    public virtual ICollection<Obligation> Obligations { get; set; } = new List<Obligation>();

    public virtual ICollection<Payee> Payees { get; set; } = new List<Payee>();

    public virtual ICollection<Risheader> Risheaders { get; set; } = new List<Risheader>();

    public virtual ICollection<TrashBin> TrashBins { get; set; } = new List<TrashBin>();

    public virtual ICollection<TripTicket> TripTickets { get; set; } = new List<TripTicket>();

    public virtual Office? UnderOfNavigation { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<VehicleDetail> VehicleDetails { get; set; } = new List<VehicleDetail>();

    public virtual ICollection<WasteMaterial> WasteMaterials { get; set; } = new List<WasteMaterial>();

    public virtual ICollection<Year> Years { get; set; } = new List<Year>();
}
