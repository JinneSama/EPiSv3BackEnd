using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class Pgnrequest
{
    public int Id { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? RequestDate { get; set; }

    public int CommunicationType { get; set; }

    public long? SignatoryId { get; set; }

    public string? Subject { get; set; }

    public string? CreatedById { get; set; }

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();

    public virtual AspNetUser? CreatedBy { get; set; }

    public virtual ICollection<Pgnaccount> Pgnaccounts { get; set; } = new List<Pgnaccount>();

    public virtual ICollection<Pgndocument> Pgndocuments { get; set; } = new List<Pgndocument>();
}
