﻿using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class DocumentAction
{
    public int Id { get; set; }

    public int? RefId { get; set; }

    public int? ProgramId { get; set; }

    public int? MainActivityId { get; set; }

    public int? ActivityId { get; set; }

    public int? SubActivityId { get; set; }

    public string? Status { get; set; }

    public string? ActionTaken { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? ActionDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? TableName { get; set; }

    public string? Remarks { get; set; }

    public string? EndorsedTo { get; set; }

    public bool? IsSend { get; set; }

    public bool? IsSaved { get; set; }

    public string? ControlNo { get; set; }

    public bool? IsDone { get; set; }

    public int? ActionId { get; set; }

    public string? ObRPrNo { get; set; }

    public int? Year { get; set; }

    public int? RoutedToOfficeId { get; set; }

    public string? Description { get; set; }

    public virtual DocumentAction? Action { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<DocumentAction> InverseAction { get; set; } = new List<DocumentAction>();

    public virtual Office? RoutedToOffice { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
