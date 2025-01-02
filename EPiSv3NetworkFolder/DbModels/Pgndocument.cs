using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class Pgndocument
{
    public int Id { get; set; }

    public int DocOrder { get; set; }

    public string? FilePath { get; set; }

    public string? FileName { get; set; }

    public int PgnrequestId { get; set; }

    public virtual Pgnrequest Pgnrequest { get; set; } = null!;
}
