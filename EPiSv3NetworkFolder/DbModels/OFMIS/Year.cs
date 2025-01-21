using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Year
{
    public int Id { get; set; }

    public int? Year1 { get; set; }

    public bool? IsActive { get; set; }

    public int? OfficeId { get; set; }

    public virtual Office? Office { get; set; }
}
