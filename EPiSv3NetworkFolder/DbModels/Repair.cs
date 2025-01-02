using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class Repair
{
    public int Id { get; set; }

    public long RequestedById { get; set; }

    public long ReqByChiefId { get; set; }

    public long DeliveredById { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateDelivered { get; set; }

    public string? Problems { get; set; }

    public string? Findings { get; set; }

    public string? Recommendations { get; set; }

    public string? PreparedById { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ReviewedById { get; set; }

    public string? NotedById { get; set; }

    public int Gender { get; set; }

    public string? ContactNo { get; set; }

    public int? PpesId { get; set; }

    public int? PpespecsId { get; set; }

    public int? TechSpecsId { get; set; }

    public string? UsersId { get; set; }

    public string? UsersId1 { get; set; }

    public string? UsersId2 { get; set; }

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();

    public virtual TicketRequest IdNavigation { get; set; } = null!;

    public virtual AspNetUser? NotedBy { get; set; }

    public virtual Ppe? Ppes { get; set; }

    public virtual PpesSpec? Ppespecs { get; set; }

    public virtual AspNetUser? PreparedBy { get; set; }

    public virtual AspNetUser? ReviewedBy { get; set; }

    public virtual TechSpec? TechSpecs { get; set; }

    public virtual AspNetUser? Users { get; set; }

    public virtual AspNetUser? UsersId1Navigation { get; set; }

    public virtual AspNetUser? UsersId2Navigation { get; set; }
}
