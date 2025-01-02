using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class PgnnonEmployee
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Position { get; set; }

    public string? Username { get; set; }

    public virtual ICollection<Pgnaccount> Pgnaccounts { get; set; } = new List<Pgnaccount>();
}
