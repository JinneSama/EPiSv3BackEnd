using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class OnlineUser
{
    public int OnlineId { get; set; }

    public string? Ip { get; set; }

    public string? Officename { get; set; }

    public string? Employeename { get; set; }
}
