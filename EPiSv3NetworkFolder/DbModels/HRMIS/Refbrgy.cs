using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Refbrgy
{
    public string Id { get; set; } = null!;

    public int BrgyCode { get; set; }

    public string? BrgyDesc { get; set; }

    public int CitymunCode { get; set; }
}
