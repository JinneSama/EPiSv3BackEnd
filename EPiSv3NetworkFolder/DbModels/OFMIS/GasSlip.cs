using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class GasSlip
{
    public int Id { get; set; }

    public int? TripTicketId { get; set; }

    public int? OfficeId { get; set; }

    public DateTime? Date { get; set; }

    public int? ToPayees { get; set; }

    public int? Operator { get; set; }

    public int? PlateNo { get; set; }

    public string? Purpose { get; set; }

    public string? Charge { get; set; }

    public string? Regular { get; set; }

    public string? Premium { get; set; }

    public string? Diesel { get; set; }

    public string? Oil { get; set; }

    public string? Others { get; set; }

    public string? InvoiceNo { get; set; }

    public decimal? Amount { get; set; }

    public string? Chief { get; set; }

    public string? ChiefPos { get; set; }

    public string? Inspector { get; set; }

    public string? InspectorPos { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public int? Year { get; set; }

    public string? Ft { get; set; }

    public bool? Deleted { get; set; }

    public string? Status { get; set; }

    public string? OfficeControlNo { get; set; }

    public string? Location { get; set; }

    public string? DateOfOperation { get; set; }

    public string? Equipment { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? PricePerLiterRegular { get; set; }

    public string? TotalPriceRegular { get; set; }

    public string? PricePerLiterPremium { get; set; }

    public string? TotalPricePremium { get; set; }

    public string? PricePerLiterDiesel { get; set; }

    public string? TotalPriceDiesel { get; set; }

    public string? PricePerLiterOil { get; set; }

    public string? TotalPriceOil { get; set; }

    public string? PriceOthers { get; set; }

    public string? TotalPriceOthers { get; set; }

    public string? Discount { get; set; }

    public string? Total { get; set; }

    public virtual VehicleDetail? PlateNoNavigation { get; set; }

    public virtual Payee? ToPayeesNavigation { get; set; }

    public virtual TripTicket? TripTicket { get; set; }
}
