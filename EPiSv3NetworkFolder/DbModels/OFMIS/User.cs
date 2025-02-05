﻿using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class User
{
    public string Id { get; set; } = null!;

    public string? Email { get; set; }

    public bool? EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool? PhoneNumberConfirmed { get; set; }

    public bool? TwoFactorEnabled { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public bool? LockoutEnabled { get; set; }

    public int? AccessFailedCount { get; set; }

    public string? UserName { get; set; }

    public string? LastUpdatedBy { get; set; }

    public DateTime? LastUpdated { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string? CivilStatus { get; set; }

    public string? Gender { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine1 { get; set; }

    public int? TownCity { get; set; }

    public string? Cellular { get; set; }

    public decimal? Height { get; set; }

    public decimal? Weight { get; set; }

    public string? Religion { get; set; }

    public string? Citizenship { get; set; }

    public string? Languages { get; set; }

    public string? Position { get; set; }

    public int? OfficeId { get; set; }

    public bool IsActive { get; set; }

    public bool? Dmsadmin { get; set; }

    public bool? DmsviewPaps { get; set; }

    public bool? IsHead { get; set; }

    public bool? LbacUser { get; set; }

    public int? LbacRole { get; set; }

    public string? LbacFullName { get; set; }

    public bool? NewUserFromHrmis { get; set; }

    public bool? FldDms { get; set; }

    public virtual ICollection<Aireport> Aireports { get; set; } = new List<Aireport>();

    public virtual ICollection<DocumentAction> DocumentActions { get; set; } = new List<DocumentAction>();

    public virtual ICollection<File> Files { get; set; } = new List<File>();

    public virtual ICollection<Letter> Letters { get; set; } = new List<Letter>();

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    public virtual ICollection<Obligation> Obligations { get; set; } = new List<Obligation>();

    public virtual Office? Office { get; set; }

    public virtual ICollection<Pi> Pis { get; set; } = new List<Pi>();

    public virtual ICollection<UserClaim> UserClaims { get; set; } = new List<UserClaim>();

    public virtual ICollection<UserLogin> UserLogins { get; set; } = new List<UserLogin>();

    public virtual ICollection<DocumentAction> DocActs { get; set; } = new List<DocumentAction>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
