using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class TechSpecsIctspecsDetail
{
    public int Id { get; set; }

    public int ItemNo { get; set; }

    public string? Specs { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public int TechSpecsIctspecsId { get; set; }

    public virtual TechSpecsIctspec TechSpecsIctspecs { get; set; } = null!;
}
