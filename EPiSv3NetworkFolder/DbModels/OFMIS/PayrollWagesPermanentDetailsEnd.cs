using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class PayrollWagesPermanentDetailsEnd
{
    public int Id { get; set; }

    public int? ItemNo { get; set; }

    public int? PayrollPermanentId { get; set; }

    public int? EmployeeId { get; set; }

    public decimal? AmountAccrued { get; set; }

    public decimal? Pera { get; set; }

    public decimal? Gsisrel { get; set; }

    public decimal? GsisoptionalLoan { get; set; }

    public decimal? GsisemergencyLoan { get; set; }

    public decimal? GsispolicyLoan { get; set; }

    public decimal? GsisconsolLoan { get; set; }

    public decimal? Gsisgfal { get; set; }

    public decimal? Pimpl { get; set; }

    public decimal? PihousingLoan { get; set; }

    public decimal? Picalamity { get; set; }

    public decimal? Nvgempci { get; set; }

    public decimal? CashAdv { get; set; }

    public decimal? Dbp { get; set; }

    public decimal? Lbp { get; set; }

    public decimal? Disallowance { get; set; }

    public decimal? Gsismpl { get; set; }

    public decimal? InsularLife { get; set; }

    public decimal? PrepaidTax { get; set; }

    public decimal? Nvpealoan { get; set; }

    public decimal? Gsisarrearages { get; set; }

    public decimal? Philam { get; set; }

    public decimal? Gsiscpl { get; set; }

    public decimal? AmountPaid { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual PayrollWagesPermanentEnd? PayrollPermanent { get; set; }
}
