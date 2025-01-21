using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class PurchaseOrder
{
    public int Id { get; set; }

    public int? Prid { get; set; }

    public DateTime? Date { get; set; }

    public string? ControlNo { get; set; }

    public string? Description { get; set; }

    public string? Purpose { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? Pgsofficer { get; set; }

    public string? Position { get; set; }

    public string? Supplier { get; set; }

    public string? SupplierAddress { get; set; }

    public string? Pono { get; set; }

    public DateTime? Podate { get; set; }

    public string? ModeOfProcurement { get; set; }

    public string? Prno { get; set; }

    public string? PlaceOfDelivery { get; set; }

    public string? DateOfDelivery { get; set; }

    public string? DeliveryTerm { get; set; }

    public string? PaymentTerm { get; set; }

    public string? TinSupplier { get; set; }

    public string? PodateText { get; set; }

    public decimal? LessDiscount { get; set; }

    public string? CreatedBy { get; set; }

    public virtual ICollection<Obligation> Obligations { get; set; } = new List<Obligation>();

    public virtual ICollection<Podetail> Podetails { get; set; } = new List<Podetail>();

    public virtual PurchaseRequest? Pr { get; set; }
}
