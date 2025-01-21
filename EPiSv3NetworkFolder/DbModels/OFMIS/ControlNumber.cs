using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class ControlNumber
{
    public int Id { get; set; }

    public string? ControlNo { get; set; }

    public int? OfficeId { get; set; }

    public string? TableName { get; set; }

    public virtual Office? Office { get; set; }
}
