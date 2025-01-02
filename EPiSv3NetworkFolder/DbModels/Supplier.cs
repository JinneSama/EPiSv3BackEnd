using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class Supplier
{
    public int Id { get; set; }

    public string? SupplierName { get; set; }

    public string? Address { get; set; }

    public string? ContactPerson { get; set; }

    public string? TelNumber { get; set; }

    public string? FaxNumber { get; set; }

    public string? PhoneNumber { get; set; }

    public bool? Status { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();
}
