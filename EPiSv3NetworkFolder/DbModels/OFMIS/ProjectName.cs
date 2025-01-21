using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class ProjectName
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public string? Project { get; set; }

    public string? Fpp { get; set; }

    public string? Rc { get; set; }

    public string? SourceOfFund { get; set; }

    public string? Ft { get; set; }

    public int? Year { get; set; }

    public int? OfficeId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public bool? Deleted { get; set; }

    public int? ProjectYear { get; set; }

    public virtual ICollection<ProjectNameApp> ProjectNameApps { get; set; } = new List<ProjectNameApp>();
}
