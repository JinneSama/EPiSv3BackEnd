using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class TicketRequest
{
    public int Id { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public int TicketStatus { get; set; }

    public int RequestType { get; set; }

    public int? StaffId { get; set; }

    public bool? IsRepairTechSpecs { get; set; }

    public virtual AspNetUser? CreatedByNavigation { get; set; }

    public virtual Delivery? Delivery { get; set; }

    public virtual Repair? Repair { get; set; }

    public virtual Itstaff? Staff { get; set; }

    public virtual TechSpec? TechSpec { get; set; }

    public virtual ICollection<TicketRequestStatus> TicketRequestStatuses { get; set; } = new List<TicketRequestStatus>();
}
