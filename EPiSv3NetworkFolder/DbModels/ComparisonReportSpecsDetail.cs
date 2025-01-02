using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class ComparisonReportSpecsDetail
{
    public int Id { get; set; }

    public int ItemOrder { get; set; }

    public string? Type { get; set; }

    public string? Pr { get; set; }

    public string? Quotation { get; set; }

    public string? Po { get; set; }

    public string? ActualDelivery { get; set; }

    public bool? IsDiscrepancy { get; set; }

    public int? ComparisonReportSpecsId { get; set; }

    public virtual ComparisonReportSpec? ComparisonReportSpecs { get; set; }
}
