using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class ComparisonReport
{
    public int Id { get; set; }

    public int? DeliveryId { get; set; }

    public string? PreparedById { get; set; }

    public string? ReviewedById { get; set; }

    public string? NotedById { get; set; }

    public string? UsersId { get; set; }

    public string? UsersId1 { get; set; }

    public string? UsersId2 { get; set; }

    public virtual ICollection<ComparisonReportSpec> ComparisonReportSpecs { get; set; } = new List<ComparisonReportSpec>();

    public virtual Delivery? Delivery { get; set; }

    public virtual AspNetUser? NotedBy { get; set; }

    public virtual AspNetUser? PreparedBy { get; set; }

    public virtual AspNetUser? ReviewedBy { get; set; }

    public virtual AspNetUser? Users { get; set; }

    public virtual AspNetUser? UsersId1Navigation { get; set; }

    public virtual AspNetUser? UsersId2Navigation { get; set; }
}
