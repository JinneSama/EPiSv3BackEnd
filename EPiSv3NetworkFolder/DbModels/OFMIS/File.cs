using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class File
{
    public int Id { get; set; }

    public int? RefId { get; set; }

    public string? TableName { get; set; }

    public string? Path { get; set; }

    public string? RootFolder { get; set; }

    public string? OriginalFileName { get; set; }

    public string? CreatedBy { get; set; }

    public virtual User? CreatedByNavigation { get; set; }
}
