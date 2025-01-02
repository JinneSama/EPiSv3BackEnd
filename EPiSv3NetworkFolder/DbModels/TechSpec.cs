using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class TechSpec
{
    public int Id { get; set; }

    public DateTime? DateRequested { get; set; }

    public DateTime? DateAccepted { get; set; }

    public long ReqById { get; set; }

    public long ReqByChiefId { get; set; }

    public int ReqByGender { get; set; }

    public string? ContactNo { get; set; }

    public bool? RequestBasedApprovedPr { get; set; }

    public bool? RequestBasedApprovedApp { get; set; }

    public bool? RequestBasedApprovedAip { get; set; }

    public bool? RequestBasedApprovedPpmp { get; set; }

    public bool? RequestBasedRequestLetter { get; set; }

    public bool? RequestBasedForReplacement { get; set; }

    public bool? IsDeleted { get; set; }

    public string? PreparedById { get; set; }

    public string? ReviewedById { get; set; }

    public string? NotedById { get; set; }

    public string? UsersId { get; set; }

    public string? UsersId1 { get; set; }

    public string? UsersId2 { get; set; }

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();

    public virtual TicketRequest IdNavigation { get; set; } = null!;

    public virtual AspNetUser? NotedBy { get; set; }

    public virtual AspNetUser? PreparedBy { get; set; }

    public virtual ICollection<PurchaseRequest> PurchaseRequests { get; set; } = new List<PurchaseRequest>();

    public virtual ICollection<Repair> Repairs { get; set; } = new List<Repair>();

    public virtual AspNetUser? ReviewedBy { get; set; }

    public virtual ICollection<TechSpecsIctspec> TechSpecsIctspecs { get; set; } = new List<TechSpecsIctspec>();

    public virtual AspNetUser? Users { get; set; }

    public virtual AspNetUser? UsersId1Navigation { get; set; }

    public virtual AspNetUser? UsersId2Navigation { get; set; }
}
