using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class ActionsDropdown
{
    public int Id { get; set; }

    public int ActionCategory { get; set; }

    public string? Value { get; set; }

    public int ParentId { get; set; }

    public int Order { get; set; }

    public virtual ICollection<Action> ActionActionsDropdowns { get; set; } = new List<Action>();

    public virtual ICollection<Action> ActionActionsDropdownsId1Navigations { get; set; } = new List<Action>();

    public virtual ICollection<Action> ActionActionsDropdownsId2Navigations { get; set; } = new List<Action>();

    public virtual ICollection<Action> ActionActionsDropdownsId3Navigations { get; set; } = new List<Action>();

    public virtual ICollection<Action> ActionActivities { get; set; } = new List<Action>();

    public virtual ICollection<Action> ActionMainActs { get; set; } = new List<Action>();

    public virtual ICollection<Action> ActionPrograms { get; set; } = new List<Action>();

    public virtual ICollection<Action> ActionSubActivities { get; set; } = new List<Action>();
}
