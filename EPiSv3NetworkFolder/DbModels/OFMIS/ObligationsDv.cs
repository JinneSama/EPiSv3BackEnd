using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class ObligationsDv
{
    public int Id { get; set; }

    public decimal? Goods { get; set; }

    public decimal? Service { get; set; }

    public decimal? Electric { get; set; }

    public decimal? NonVatGoods { get; set; }

    public decimal? NonVatService { get; set; }

    public decimal? Total { get; set; }

    public decimal? OrigContractCost { get; set; }

    public decimal? RevisedContractAmt { get; set; }

    public decimal? TotalValueofWorkToDate { get; set; }

    public decimal? PrevCollection { get; set; }

    public decimal? TotalValueOfWorkThisBil { get; set; }

    public decimal? Retention { get; set; }

    public decimal? WithHoldingTax { get; set; }

    public decimal? ServiceFive { get; set; }

    public decimal? ServiceTwo { get; set; }

    public decimal? Mobilization { get; set; }

    public decimal? Mqcbilling { get; set; }

    public decimal? LiquidatedDamages { get; set; }

    public decimal? TotalAmtDue { get; set; }

    public decimal? WarrantySecurity { get; set; }

    public virtual Obligation IdNavigation { get; set; } = null!;
}
