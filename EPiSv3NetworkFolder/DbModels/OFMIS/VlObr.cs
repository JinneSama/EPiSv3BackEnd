using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class VlObr
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

    public string? DeptHead { get; set; }

    public string? DeptHeadPos { get; set; }

    public string? DivisionHead { get; set; }

    public string? DivisionHeadPos { get; set; }

    public string? CreatedBy { get; set; }

    public bool? IsEarmark { get; set; }

    public string? BudgetControlNo { get; set; }
}
