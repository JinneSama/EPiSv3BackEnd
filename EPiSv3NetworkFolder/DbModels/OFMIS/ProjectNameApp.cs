using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class ProjectNameApp
{
    public int Id { get; set; }

    public int? ProjectNameId { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountCodeText { get; set; }

    public string? AccountName { get; set; }

    public string? FundType { get; set; }

    public int? FundTypeId { get; set; }

    public string? Ft { get; set; }

    public decimal? Appropriation { get; set; }

    public int? Year { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Createdby { get; set; }

    public int? OfficeId { get; set; }

    public int? ObligationsId { get; set; }

    public virtual FundType? FundTypeNavigation { get; set; }

    public virtual ICollection<ProjectApproAllotment> ProjectApproAllotments { get; set; } = new List<ProjectApproAllotment>();

    public virtual ICollection<ProjectApproRealignment> ProjectApproRealignmentSourceProjAppros { get; set; } = new List<ProjectApproRealignment>();

    public virtual ICollection<ProjectApproRealignment> ProjectApproRealignmentTargetProjAppros { get; set; } = new List<ProjectApproRealignment>();

    public virtual ProjectName? ProjectName { get; set; }
}
