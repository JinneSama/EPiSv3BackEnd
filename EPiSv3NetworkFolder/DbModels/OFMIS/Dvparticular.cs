using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Dvparticular
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public decimal? Xpercent { get; set; }

    public decimal? Xpercent1 { get; set; }

    public decimal? Xnumber { get; set; }

    public decimal? Dnumber { get; set; }

    public bool? Active { get; set; }

    public string? UserId { get; set; }
}
