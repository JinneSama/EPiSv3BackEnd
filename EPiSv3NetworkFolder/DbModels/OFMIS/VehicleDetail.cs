using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class VehicleDetail
{
    public int Id { get; set; }

    public string? Crno { get; set; }

    public DateTime? Crdate { get; set; }

    public string? Mvfile { get; set; }

    public string? PlateNo { get; set; }

    public string? EngineNo { get; set; }

    public string? ChassisNo { get; set; }

    public string? Denomination { get; set; }

    public string? TransmissionType { get; set; }

    public int? PistonDisplacement { get; set; }

    public int? NoofCylinders { get; set; }

    public string? Fuel { get; set; }

    public decimal? AverageFuelCon { get; set; }

    public string? Make { get; set; }

    public string? Series { get; set; }

    public string? BodyType { get; set; }

    public string? BodyNo { get; set; }

    public int? YearModel { get; set; }

    public int? GrossWt { get; set; }

    public int? NetWt { get; set; }

    public int? ShippingWt { get; set; }

    public int? NetCapacity { get; set; }

    public string? Owner { get; set; }

    public string? OwnersAddress { get; set; }

    public int? Driver { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public int? OfficeId { get; set; }

    public bool? Deleted { get; set; }

    public virtual Employee? DriverNavigation { get; set; }

    public virtual ICollection<GasSlip> GasSlips { get; set; } = new List<GasSlip>();

    public virtual Office? Office { get; set; }

    public virtual ICollection<TripTicket> TripTickets { get; set; } = new List<TripTicket>();
}
