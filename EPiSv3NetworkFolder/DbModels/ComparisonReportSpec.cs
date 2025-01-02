using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class ComparisonReportSpec
{
    public int Id { get; set; }

    public int? ItemNo { get; set; }

    public int? Quantity { get; set; }

    public int Unit { get; set; }

    public string? Type { get; set; }

    public string? Pr { get; set; }

    public string? Quotation { get; set; }

    public string? Po { get; set; }

    public string? ActualDelivery { get; set; }

    public string? Remarks { get; set; }

    public bool? IsDiscrepancy { get; set; }

    public int? ComparisonReportId { get; set; }

    public virtual ComparisonReport? ComparisonReport { get; set; }

    public virtual ICollection<ComparisonReportSpecsDetail> ComparisonReportSpecsDetails { get; set; } = new List<ComparisonReportSpecsDetail>();
}
