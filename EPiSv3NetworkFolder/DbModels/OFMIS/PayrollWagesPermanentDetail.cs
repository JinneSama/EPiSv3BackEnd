using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class PayrollWagesPermanentDetail
{
    public int Id { get; set; }

    public int? ItemNo { get; set; }

    public int? PayrollPermanentId { get; set; }

    public int? EmployeeId { get; set; }

    public decimal? AmountAccrued { get; set; }

    public decimal? WithHoldingTax { get; set; }

    public decimal? Phps { get; set; }

    public decimal? Phgs { get; set; }

    public decimal? Pips { get; set; }

    public decimal? Pigs { get; set; }

    public decimal? Pimp2 { get; set; }

    public decimal? Gsislricps { get; set; }

    public decimal? Gsislricgs { get; set; }

    public decimal? OptInsurance { get; set; }

    public decimal? AddtInsurance { get; set; }

    public decimal? Hip { get; set; }

    public decimal? Ceap { get; set; }

    public decimal? Gfal { get; set; }

    public decimal? Ecard { get; set; }

    public decimal? Rel { get; set; }

    public decimal? Gsiseduc { get; set; }

    public decimal? Nvgempc { get; set; }

    public decimal? Nvpea { get; set; }

    public decimal? InsularLife { get; set; }

    public decimal? Miscellaneous { get; set; }

    public decimal? Lbploan { get; set; }

    public decimal? Gsisarrears { get; set; }

    public decimal? Dbploan { get; set; }

    public decimal? Hrrploan { get; set; }

    public decimal? StateIns { get; set; }

    public decimal? AmountPaid { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual PayrollWagesPermanent? PayrollPermanent { get; set; }
}
