using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Log
{
    public int Id { get; set; }

    public string? TableName { get; set; }

    public string? OldValues { get; set; }

    public string? NewValues { get; set; }

    public string? Action { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public virtual User? CreatedByNavigation { get; set; }
}
