using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class AspNetUser
{
    public string Id { get; set; } = null!;

    public string? FullName { get; set; }

    public string? Position { get; set; }

    public string? Email { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string UserName { get; set; } = null!;

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();

    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; } = new List<AspNetUserClaim>();

    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; } = new List<AspNetUserLogin>();

    public virtual ICollection<ChangeLog> ChangeLogs { get; set; } = new List<ChangeLog>();

    public virtual ICollection<ComparisonReport> ComparisonReportNotedBies { get; set; } = new List<ComparisonReport>();

    public virtual ICollection<ComparisonReport> ComparisonReportPreparedBies { get; set; } = new List<ComparisonReport>();

    public virtual ICollection<ComparisonReport> ComparisonReportReviewedBies { get; set; } = new List<ComparisonReport>();

    public virtual ICollection<ComparisonReport> ComparisonReportUsers { get; set; } = new List<ComparisonReport>();

    public virtual ICollection<ComparisonReport> ComparisonReportUsersId1Navigations { get; set; } = new List<ComparisonReport>();

    public virtual ICollection<ComparisonReport> ComparisonReportUsersId2Navigations { get; set; } = new List<ComparisonReport>();

    public virtual ICollection<CustomerActionSheet> CustomerActionSheets { get; set; } = new List<CustomerActionSheet>();

    public virtual ICollection<Itstaff> Itstaffs { get; set; } = new List<Itstaff>();

    public virtual ICollection<MoaccountUser> MoaccountUsers { get; set; } = new List<MoaccountUser>();

    public virtual ICollection<Moaccount> Moaccounts { get; set; } = new List<Moaccount>();

    public virtual ICollection<Pgnrequest> Pgnrequests { get; set; } = new List<Pgnrequest>();

    public virtual ICollection<PurchaseRequest> PurchaseRequests { get; set; } = new List<PurchaseRequest>();

    public virtual ICollection<Repair> RepairNotedBies { get; set; } = new List<Repair>();

    public virtual ICollection<Repair> RepairPreparedBies { get; set; } = new List<Repair>();

    public virtual ICollection<Repair> RepairReviewedBies { get; set; } = new List<Repair>();

    public virtual ICollection<Repair> RepairUsers { get; set; } = new List<Repair>();

    public virtual ICollection<Repair> RepairUsersId1Navigations { get; set; } = new List<Repair>();

    public virtual ICollection<Repair> RepairUsersId2Navigations { get; set; } = new List<Repair>();

    public virtual ICollection<TechSpec> TechSpecNotedBies { get; set; } = new List<TechSpec>();

    public virtual ICollection<TechSpec> TechSpecPreparedBies { get; set; } = new List<TechSpec>();

    public virtual ICollection<TechSpec> TechSpecReviewedBies { get; set; } = new List<TechSpec>();

    public virtual ICollection<TechSpec> TechSpecUsers { get; set; } = new List<TechSpec>();

    public virtual ICollection<TechSpec> TechSpecUsersId1Navigations { get; set; } = new List<TechSpec>();

    public virtual ICollection<TechSpec> TechSpecUsersId2Navigations { get; set; } = new List<TechSpec>();

    public virtual ICollection<TicketRequestStatus> TicketRequestStatuses { get; set; } = new List<TicketRequestStatus>();

    public virtual ICollection<TicketRequest> TicketRequests { get; set; } = new List<TicketRequest>();

    public virtual ICollection<Action> ActionsNavigation { get; set; } = new List<Action>();

    public virtual ICollection<AspNetRole> Roles { get; set; } = new List<AspNetRole>();
}
