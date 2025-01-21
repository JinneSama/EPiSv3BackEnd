using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Refcitymun
{
    public string Id { get; set; } = null!;

    public int PsgcCode { get; set; }

    public string CitymunDesc { get; set; } = null!;

    public string RegDesc { get; set; } = null!;

    public int ProvCode { get; set; }

    public int CitymunCode { get; set; }
}
