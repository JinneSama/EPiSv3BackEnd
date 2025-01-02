using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class CustomerActionSheet
{
    public int Id { get; set; }

    public long? ClientId { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? ClientName { get; set; }

    public string? Office { get; set; }

    public int Gender { get; set; }

    public string? ContactNo { get; set; }

    public string? ClientRequest { get; set; }

    public string? ActionTaken { get; set; }

    public bool? IsDeleted { get; set; }

    public string? AssistedById { get; set; }

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();

    public virtual AspNetUser? AssistedBy { get; set; }
}
