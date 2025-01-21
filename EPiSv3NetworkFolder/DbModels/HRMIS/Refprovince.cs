using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Refprovince
{
    public string Id { get; set; } = null!;

    public int PsgcCode { get; set; }

    public string ProvDesc { get; set; } = null!;

    public string RegCode { get; set; } = null!;

    public int ProvCode { get; set; }
}
