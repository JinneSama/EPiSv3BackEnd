using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class TcpIp
{
    public string? IpList { get; set; }

    public string? Office { get; set; }

    public string? Username { get; set; }

    public DateTime? DteLogin { get; set; }

    public DateTime? DteLogout { get; set; }

    public bool? Done { get; set; }
}
