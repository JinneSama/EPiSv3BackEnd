using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Aireport
{
    public int Id { get; set; }

    public int? Poid { get; set; }

    public int? Prid { get; set; }

    public string? ControlNo { get; set; }

    public int? Risno { get; set; }

    public DateTime? Risdate { get; set; }

    public DateTime? Date { get; set; }

    public string? PropertyInspector { get; set; }

    public string? PropertyInspectorPosition { get; set; }

    public string? PropertyInspector2 { get; set; }

    public string? PropertyInspector2Position { get; set; }

    public string? Pgsofficer { get; set; }

    public string? PgsofficerPosition { get; set; }

    public string? Head { get; set; }

    public string? HeadPosition { get; set; }

    public string? PreparedBy { get; set; }

    public string? PropertyOfficer2 { get; set; }

    public string? PropertyOfficerPosition2 { get; set; }

    public string? NotedBy { get; set; }

    public string? NotedByPosition { get; set; }

    public string? PropertyOfficer { get; set; }

    public string? PropertyOfficerPosition { get; set; }

    public string? Airno { get; set; }

    public DateTime? Airdate { get; set; }

    public string? InvoiceNo { get; set; }

    public string? InvoiceDate { get; set; }

    public string? Supplier { get; set; }

    public string? Pono { get; set; }

    public string? Podate { get; set; }

    public bool? Deleted { get; set; }

    public string? InvoiceDateStr { get; set; }

    public string? PodateStr { get; set; }

    public string? CreatedBy { get; set; }

    public virtual ICollection<Airdetail> Airdetails { get; set; } = new List<Airdetail>();

    public virtual PurchaseRequest? Pr { get; set; }

    public virtual User? PreparedByNavigation { get; set; }
}
