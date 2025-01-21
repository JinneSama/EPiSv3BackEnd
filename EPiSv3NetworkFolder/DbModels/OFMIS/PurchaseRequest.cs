using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class PurchaseRequest
{
    public int Id { get; set; }

    public int? AppropriationId { get; set; }

    public DateTime? Date { get; set; }

    public string? ControlNo { get; set; }

    public string? Description { get; set; }

    public string? Purpose { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? TableName { get; set; }

    public int? OfficeId { get; set; }

    public string? Pa { get; set; }

    public string? Papos { get; set; }

    public string? ApprovedNote { get; set; }

    public string? DeptHead { get; set; }

    public string? DeptHeadPos { get; set; }

    public int? DeptHeadId { get; set; }

    public string? DivisionHead { get; set; }

    public string? DivisionHeadPos { get; set; }

    public string? CreatedBy { get; set; }

    public bool? IsEarmark { get; set; }

    public string? BudgetControlNo { get; set; }

    public bool IsClosed { get; set; }

    public int? Year { get; set; }

    public bool? IsCancelled { get; set; }

    public string? CancellationReason { get; set; }

    public string? Ft { get; set; }

    public string? Sai { get; set; }

    public DateTime? Saidate { get; set; }

    public bool? Deleted { get; set; }

    public int? ProjectId { get; set; }

    public virtual ICollection<Aireport> Aireports { get; set; } = new List<Aireport>();

    public virtual ICollection<AllotmentLetter> AllotmentLetters { get; set; } = new List<AllotmentLetter>();

    public virtual ICollection<Aoq> Aoqs { get; set; } = new List<Aoq>();

    public virtual ICollection<Apr> Aprs { get; set; } = new List<Apr>();

    public virtual ICollection<Ic> Ics { get; set; } = new List<Ic>();

    public virtual ICollection<Par> Pars { get; set; } = new List<Par>();

    public virtual ICollection<Pi> Pis { get; set; } = new List<Pi>();

    public virtual ICollection<Prdetail> Prdetails { get; set; } = new List<Prdetail>();

    public virtual ICollection<PriceQuotation> PriceQuotations { get; set; } = new List<PriceQuotation>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<Risheader> Risheaders { get; set; } = new List<Risheader>();
}
