using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class Action
{
    public int Id { get; set; }

    public string? ActionTaken { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? ActionDate { get; set; }

    public string? Remarks { get; set; }

    public bool? IsSend { get; set; }

    public int RequestType { get; set; }

    public int? ProgramId { get; set; }

    public int? MainActId { get; set; }

    public int? ActivityId { get; set; }

    public int? SubActivityId { get; set; }

    public int? DeliveriesId { get; set; }

    public int? TechSpecsId { get; set; }

    public int? RepairId { get; set; }

    public int? PurchaseRequestId { get; set; }

    public int? CustomerActionSheetId { get; set; }

    public int? PgnrequestId { get; set; }

    public string? CreatedById { get; set; }

    public int? ActionsDropdownsId { get; set; }

    public int? ActionsDropdownsId1 { get; set; }

    public int? ActionsDropdownsId2 { get; set; }

    public int? ActionsDropdownsId3 { get; set; }

    public int? MoaccountUserId { get; set; }

    public virtual ActionsDropdown? ActionsDropdowns { get; set; }

    public virtual ActionsDropdown? ActionsDropdownsId1Navigation { get; set; }

    public virtual ActionsDropdown? ActionsDropdownsId2Navigation { get; set; }

    public virtual ActionsDropdown? ActionsDropdownsId3Navigation { get; set; }

    public virtual ActionsDropdown? Activity { get; set; }

    public virtual AspNetUser? CreatedBy { get; set; }

    public virtual CustomerActionSheet? CustomerActionSheet { get; set; }

    public virtual Delivery? Deliveries { get; set; }

    public virtual ActionsDropdown? MainAct { get; set; }

    public virtual MoaccountUser? MoaccountUser { get; set; }

    public virtual Pgnrequest? Pgnrequest { get; set; }

    public virtual ActionsDropdown? Program { get; set; }

    public virtual PurchaseRequest? PurchaseRequest { get; set; }

    public virtual Repair? Repair { get; set; }

    public virtual ActionsDropdown? SubActivity { get; set; }

    public virtual TechSpec? TechSpecs { get; set; }

    public virtual ICollection<AspNetUser> Users { get; set; } = new List<AspNetUser>();
}
