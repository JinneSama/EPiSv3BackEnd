using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Obligation
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

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

    public string? ObrapprovedByNote { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string? ModifiedData { get; set; }

    public decimal? TotalAdjustedAmount { get; set; }

    public int? Poid { get; set; }

    public decimal? Dvamount { get; set; }

    public string? Ft { get; set; }

    public bool? IsCancelled { get; set; }

    public string? CancelReason { get; set; }

    public string? Rctext { get; set; }

    public bool? Deleted { get; set; }

    public decimal? LessDiscount { get; set; }

    public int? ProjectNameId { get; set; }

    public decimal? WarrantySecurityAmount { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<ItenaryofTravel> ItenaryofTravels { get; set; } = new List<ItenaryofTravel>();

    public virtual ICollection<Liquidation> Liquidations { get; set; } = new List<Liquidation>();

    public virtual ObligationsDv? ObligationsDv { get; set; }

    public virtual ICollection<ObligationsDvadditional> ObligationsDvadditionals { get; set; } = new List<ObligationsDvadditional>();

    public virtual Office? Office { get; set; }

    public virtual ICollection<Ordetail> Ordetails { get; set; } = new List<Ordetail>();

    public virtual Payee? Payee { get; set; }

    public virtual Payroll? Payroll { get; set; }

    public virtual ICollection<PayrollDifferential> PayrollDifferentials { get; set; } = new List<PayrollDifferential>();

    public virtual ICollection<PayrollHazard> PayrollHazards { get; set; } = new List<PayrollHazard>();

    public virtual ICollection<PayrollOt> PayrollOts { get; set; } = new List<PayrollOt>();

    public virtual ICollection<PayrollSpe> PayrollSpes { get; set; } = new List<PayrollSpe>();

    public virtual PayrollWage? PayrollWage { get; set; }

    public virtual PayrollWagesPermanent? PayrollWagesPermanent { get; set; }

    public virtual PayrollWagesPermanentEnd? PayrollWagesPermanentEnd { get; set; }

    public virtual PurchaseOrder? Po { get; set; }

    public virtual ICollection<Letter> Letters { get; set; } = new List<Letter>();
}
