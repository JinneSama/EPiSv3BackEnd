using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Supplier
{
    public int Id { get; set; }

    public string? SupplierName { get; set; }

    public string? Address { get; set; }

    public string? ContactNumber { get; set; }

    public string? PhoneNumber { get; set; }

    public string? FaxNumber { get; set; }

    public string? CellNumber { get; set; }

    public bool? Status { get; set; }
}
