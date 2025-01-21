using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class TripTicket
{
    public int Id { get; set; }

    public string? ControlNo { get; set; }

    public int? OfficeId { get; set; }

    public DateTime? Date { get; set; }

    public int? Driver { get; set; }

    public int? PlateNo { get; set; }

    public string? PlaceToVisit { get; set; }

    public string? Purpose { get; set; }

    public string? Chief { get; set; }

    public string? ChiefPos { get; set; }

    public string? TimeOfDeparture { get; set; }

    public string? TimeOfArrival { get; set; }

    public string? DateOfDeparture { get; set; }

    public string? DateOfArrival { get; set; }

    public decimal? ApproximateDistance { get; set; }

    public decimal? BalanceInTank { get; set; }

    public decimal? IssuedByOffice { get; set; }

    public decimal? AddPurchase { get; set; }

    public decimal? Total { get; set; }

    public decimal? Deduct { get; set; }

    public decimal? BalanceInTankAtTheEnd { get; set; }

    public decimal? GearOil { get; set; }

    public decimal? LubOil { get; set; }

    public decimal? GreaseIssued { get; set; }

    public string? Others { get; set; }

    public decimal? AtTheBeginning { get; set; }

    public decimal? AtTheEndTrip { get; set; }

    public decimal? DistanceTravelled { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Ft { get; set; }

    public int? Year { get; set; }

    public bool? Deleted { get; set; }

    public string? Status { get; set; }

    public string? TimeOfDepartureFromDestination { get; set; }

    public string? DateOfDepartureFromDestination { get; set; }

    public string? TimeOfArrivalAtGarageOffice { get; set; }

    public string? DateOfArrivalAtGarageOffice { get; set; }

    public bool? IsDefectiveOdo { get; set; }

    public bool? IsCompleted { get; set; }

    public virtual Employee? DriverNavigation { get; set; }

    public virtual ICollection<GasSlip> GasSlips { get; set; } = new List<GasSlip>();

    public virtual Office? Office { get; set; }

    public virtual VehicleDetail? PlateNoNavigation { get; set; }

    public virtual ICollection<TripTicketPassenger> TripTicketPassengers { get; set; } = new List<TripTicketPassenger>();
}
