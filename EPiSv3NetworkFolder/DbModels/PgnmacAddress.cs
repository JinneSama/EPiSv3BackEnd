using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class PgnmacAddress
{
    public int Id { get; set; }

    public int Connection { get; set; }

    public int Device { get; set; }

    public string? MacAddress { get; set; }

    public int PgnaccountId { get; set; }

    public virtual Pgnaccount Pgnaccount { get; set; } = null!;
}
