using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class VlYear
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public string? ControlNo { get; set; }

    public string? BudgetControlNo { get; set; }

    public string? Dmsno { get; set; }

    public int? PayeeId { get; set; }

    public string? PayeeOffice { get; set; }

    public string? PayeeAddress { get; set; }

    public string? Chief { get; set; }

    public string? ChiefPosition { get; set; }

    public string? Pbopos { get; set; }

    public string? Pbo { get; set; }

    public bool? Closed { get; set; }

    public string? Description { get; set; }

    public string? Dvparticular { get; set; }

    public string? DvapprovedBy { get; set; }

    public string? DvapprovedByPosition { get; set; }

    public string? Dvnote { get; set; }

    public string? Status { get; set; }

    public DateTime? DateClosed { get; set; }

    public bool? Earmarked { get; set; }

    public int? Prno { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public decimal Amount { get; set; }

    public int? Year { get; set; }

    public string? ResponsibilityCenter { get; set; }

    public string? ResponsibilityCenterCode { get; set; }

    public int? OfficeId { get; set; }

    public string? Treasurer { get; set; }

    public string? TreasurerPos { get; set; }

    public string? Accountant { get; set; }

    public string? AccountantPos { get; set; }

    public string? ObrapprovedBy { get; set; }

    public string? ObrapprovedByPos { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string? ModifiedData { get; set; }

    public decimal? TotalAdjustedAmount { get; set; }

    public int? Poid { get; set; }

    public decimal? Dvamount { get; set; }
}
