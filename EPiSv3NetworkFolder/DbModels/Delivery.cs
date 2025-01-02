using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class Delivery
{
    public int Id { get; set; }

    public DateTime? DeliveredDate { get; set; }

    public DateTime? DateRequested { get; set; }

    public long RequestedById { get; set; }

    public long ReqByChiefId { get; set; }

    public long DeliveredById { get; set; }

    public int Gender { get; set; }

    public string? ContactNo { get; set; }

    public string? Pono { get; set; }

    public string? ReceiptNo { get; set; }

    public int? SupplierId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();

    public virtual ICollection<ComparisonReport> ComparisonReports { get; set; } = new List<ComparisonReport>();

    public virtual ICollection<DeliveriesSpec> DeliveriesSpecs { get; set; } = new List<DeliveriesSpec>();

    public virtual TicketRequest IdNavigation { get; set; } = null!;

    public virtual Supplier? Supplier { get; set; }
}
