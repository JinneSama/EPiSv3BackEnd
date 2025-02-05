﻿using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class ItenaryofTravel
{
    public int Id { get; set; }

    public int? Obrid { get; set; }

    public int? EmployeeId { get; set; }

    public string? Position { get; set; }

    public string? OfficialAddress { get; set; }

    public string? Purpose { get; set; }

    public int? GovernorId { get; set; }

    public int? Paid { get; set; }

    public int? PreparedBy { get; set; }

    public string? PreparedByPos { get; set; }

    public int? ApprovedBy { get; set; }

    public string? ApprovedByPos { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? Supervisor { get; set; }

    public string? SupervisorPos { get; set; }

    public virtual Employee? ApprovedByNavigation { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<ItenaryDetail> ItenaryDetails { get; set; } = new List<ItenaryDetail>();

    public virtual Obligation? Obr { get; set; }
}
