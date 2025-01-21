using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class ColumnTitle
{
    public int Id { get; set; }

    public string? ColumTitle { get; set; }

    public string? AccountType { get; set; }
}
